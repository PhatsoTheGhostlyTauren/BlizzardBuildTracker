using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using BuildTrackerLib;

namespace BlizzardBuildTracker {
    public partial class BlizzardBuildTrackerForm : Form
    {
        public SplashScreen splash;
        public Tracker tracker;
        private SoundPlayer FelReaver;
        public string[] gamecodes;
        public int TrackerDelay;
        public bool isTracking;

        public BlizzardBuildTrackerForm() {
            InitializeComponent();
            this.Icon = Properties.Resources.phatso;
            this.FelReaver = new SoundPlayer(Properties.Resources.FelReaver);
            this.TrackerDelay = 30000;
            this.isTracking = false;
        }




        #region "Loading"
        //Before loading the MainForm show SplashScreen
        private void BlizzardBuildTrackerForm_Load(object sender, EventArgs e) {

            this.gamecodes = new string[] { "wow_beta", "wowt", "wow", "s2", "s2b", "d3", "d3cn", "d3t", "hero", "herot", "hsb", "pro", "agent" };

            //Subscribe to Events
            BuildTrackerLib.Log.NewMessage += OnNewMessage;



            if (BuildTrackerLib.Utility.CheckForInternetConnection()) {

                //Create the Tracker-Object
                this.tracker = new Tracker(this.gamecodes);

                //Subscribe to Tracker-Events
                this.tracker.VersionsUpdate += OnVersionsUpdated;
                this.tracker.CDNConfigUpdate += OnCDNConfigUpdated;

                // Create a new thread from which to start the splash screen form
                Thread splashThread = new Thread(new ThreadStart(startSplash));
                splashThread.Start();

                //Give Splash-Screen a Second to load the Form and subscribe to the LoadingGame event
                Thread.Sleep(1000);
                //start loading games into the tracker object
                this.tracker.loadGames();
                updateGamesListbox(this.tracker.listGames());


                // Close the splash screen
                this.closeSplash();

                this.FelReaver.Play();
            } else {
                Log.WriteWarning("No Internet Connectivity!", "BlizzardBuildTrackerForm:BlizzardBuildTrackerForm_Load()");
            }
        }


        //Splash-Loading-Screen Control
        private void startSplash() {
            // Instance a splash form given the image names
            this.splash = new SplashScreen(ref this.tracker);

            // Run the form
            Application.Run(this.splash);

        }
        private void closeSplash() {
            if (this.splash == null)
                return;

            // Shut down the splash screen
            this.splash.Invoke(new EventHandler(splash.KillMe));
            this.splash.Dispose();
            this.splash = null;
        }
        #endregion






        #region "DisplayUpdates"
        //Main Form Controls Update Methods
        public void updateClientVersion(Game _g, string _region) {
            Game.Version _CV = _g.Versions[_region];

            this.tbCVBuildID.Text = _CV.buildID;
            this.tbCVBuildName.Text = _CV.buildName;
            this.tbCVBuildConfigKey.Text = _CV.buildConfigKey;
            this.tbCVCDNConfigKey.Text = _CV.cdnConfigKey;
        }

        public void updateBuildConfig(string _ConfigKey)
        {

            if (this.tracker.Builds.ContainsKey(_ConfigKey)) {
                BuildConfig _bc = this.tracker.Builds[_ConfigKey];

                if (_bc.loadSuccess == true) {
                    this.tbCDNBuildName.Text = _bc.build_name;
                    this.tbCDNBuildKey.Text = _bc.config_key;
                    this.tbCDNBuildUID.Text = _bc.build_uid;
                    this.tbCDNBuildRootKey.Text = _bc.rootKey;
                    this.tbCDNBuildInstallKey.Text = _bc.installKey;
                    this.tbCDNBuildDownloadKey.Text = _bc.downloadKey;
                    this.tbCDNBuildEncodingKeys.Text = string.Join(" | ", _bc.encodingKeys);
                    this.tbCDNBuildEncodingSize.Text = string.Join(" | ", _bc.encoding_size);
                    this.tbCDNBuildPatchKey.Text = _bc.patchKey;
                    this.tbCDNBuildPatchConfigKey.Text = _bc.patch_config_Key;
                    this.tbCDNBuildPatchSize.Text = _bc.patch_size;
                }
            }
        }

        public void updateGamesListbox(List<Tracker.GameItem> _items) {
            this.lbGames.DataSource = _items;
            this.lbGames.DisplayMember = "Name";
            this.lbGames.ValueMember = "Value";
        }

        public void updateCDNBuildsListBox(List<Tracker.BuildItem> _items) {
            this.lbCDNBuilds.DataSource = _items;
            this.lbCDNBuilds.DisplayMember = "Name";
            this.lbCDNBuilds.ValueMember = "Value";
        }

        public void updateRegionsComboBox(List<Tracker.RegionItem> _items) {
            this.cbClientRegion.DataSource = _items;
            this.cbClientRegion.DisplayMember = "Name";
            this.cbClientRegion.ValueMember = "Value";
        }
        #endregion



        #region "ControlEvents"
        private void lbGames_SelectedIndexChanged(object sender, EventArgs e) {
            //Get ClientVersion by GameCode and send to the update function
            string _code = ((Tracker.GameItem)this.lbGames.SelectedItem).Value;
            this.updateRegionsComboBox(this.tracker.listRegions(_code));

            //Get all Builds in the CDN for the GameCode X and send it to the update function
            updateCDNBuildsListBox(this.tracker.listCDNBuilds(_code));

        }
        private void cbClientRegion_SelectedValueChanged(object sender, EventArgs e) {
            string _code = ((Tracker.GameItem)this.lbGames.SelectedItem).Value;
            string _region = ((Tracker.RegionItem) this.cbClientRegion.SelectedItem).Value;
            this.updateClientVersion(this.tracker.Games[_code], _region);
        }

        private void lbCDNBuilds_SelectedIndexChanged(object sender, EventArgs e) {
            string key = ((Tracker.BuildItem)this.lbCDNBuilds.SelectedItem).Value;
            updateBuildConfig(key);
        }


        private void btnOpenTrackerChooser_Click(object sender, EventArgs e) {
            TrackingChooser TC = new TrackingChooser(ref this.tracker);
            TC.StartPosition = FormStartPosition.CenterParent;
            TC.ShowDialog();
        }

        private void numUDTrackerDelay_ValueChanged(object sender, EventArgs e) {
            this.TrackerDelay = (int)numUDTrackerDelay.Value * 1000;
        }

        private void btnTrackerToggle_Click(object sender, EventArgs e) {
            toggleTracking();
        }

        private void TrackerTimer_Tick(object sender, EventArgs e) {
            this.tracker.track();
        }
        #endregion



        #region "CustomEvents"
        public void OnNewMessage()
        {
            string line = "[" + Log.Messages.Last().Date_Send + "] " + Log.Messages.Last().Msg + Environment.NewLine;
            this.rtbLog.AppendText(line);

            Color color = ColorTranslator.FromHtml(Log.Messages.Last().color);
            this.rtbLog.Find(Log.Messages.Last().Msg,RichTextBoxFinds.Reverse);
            this.rtbLog.SelectionColor = color;

            //Scroll to bottom
            this.rtbLog.SelectionStart = this.rtbLog.TextLength;
            this.rtbLog.ScrollToCaret();
        }


        public void OnVersionsUpdated(string _code) {
            this.updateRegionsComboBox(this.tracker.listRegions(_code));
        }

        public void OnCDNConfigUpdated(string _code) {
            this.updateCDNBuildsListBox(this.tracker.listCDNBuilds(_code));
        }
        #endregion        


        //toggle Tracking 
        public void toggleTracking() {
            if (isTracking) {
                //Stop the Timer 
                this.TrackerTimer.Enabled = false;

                //Re-Enable Controls
                this.numUDTrackerDelay.Enabled = true;
                this.btnOpenTrackerChooser.Enabled = true;

                //Change Button Text
                this.btnTrackerToggle.Text = "Start Tracking";

                Log.WriteMessage("Stopped Tracking!", "BlizzardBuildTrackerForm:btnTrackerToggle_Click()");

            } else {
                //Set Timer Interval from int TrackerDelay
                this.TrackerTimer.Interval = this.TrackerDelay;
                //Enable Timer
                this.TrackerTimer.Enabled = true;
                //Disable Interval NumControl
                this.numUDTrackerDelay.Enabled = false;
                this.btnOpenTrackerChooser.Enabled = false;
                //Edit Button Text
                this.btnTrackerToggle.Text = "Stop Tracking";

                Log.WriteMessage("Started Tracking!", "BlizzardBuildTrackerForm:btnTrackerToggle_Click()");

                //For logging purposes list all games being tracked
                List<string> gamesBeingTracked = new List<string>();
                foreach (var currentG in this.tracker.Games) {
                    if (currentG.Value.isTracked) {
                        gamesBeingTracked.Add(currentG.Key);
                    }
                }
                if (gamesBeingTracked.Any()) {
                    Log.WriteMessage("Tracking the following Codes: " + String.Join(", ", gamesBeingTracked.ToArray()), "Tracker:track()");
                } else {
                    Log.WriteWarning("No Code has been enabled for tracking.", "Tracker:track()");
                }

            }

            this.isTracking = !this.isTracking;
        }


    }
}
