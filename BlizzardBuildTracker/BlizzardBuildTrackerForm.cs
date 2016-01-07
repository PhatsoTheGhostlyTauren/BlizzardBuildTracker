using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using System.Threading;

namespace BlizzardBuildTracker
{
    public partial class BlizzardBuildTrackerForm : Form
    {

        //Before loading the MainForm show SplashScreen
        private void BlizzardBuildTrackerForm_Load(object sender, EventArgs e) {

            this.gamecodes = new string[] {"wow_beta", "wowt", "wow", "s2", "s2b", "d3", "d3cn", "d3t", "hero", "herot", "hsb", "pro", "agent" };
            this.log = new BuildTrackerLib.Log();

            //Subscribe to Events
            this.log.NewMessage += OnNewMessage;

            //Create the Tracker-Object
            this.tracker = new Tracker(this.gamecodes, this.log);

            //Subscribe to Tracker-Events
            this.tracker.ClientUpdate += OnClientUpdated;
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





        /// Start Main Form


        public SplashScreen splash;
        public Tracker tracker;
        private SoundPlayer FelReaver;
        public BuildTrackerLib.Log log;
        public string[] gamecodes;
        public int TrackerDelay;
        public bool isTracking;

        public BlizzardBuildTrackerForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.phatso;
            this.FelReaver = new SoundPlayer(Properties.Resources.FelReaver);
            this.TrackerDelay = 30000;
            this.isTracking = false;
        }



        //Main Form Controls Update Methods
        public void updateClientVersion(BuildTrackerLib.ClientVersion _CV) {
            this.tbCVBuildID.Text = _CV.getBuildID();
            this.tbCVRegion.Text = _CV.getRegion();
            this.tbCVBuildName.Text = _CV.getBuildName();
            this.tbCVBuildConfigKey.Text = _CV.getBuildConfigKey();
            this.tbCVCDNConfigKey.Text = _CV.getCDNConfigKey();
        }

        public void updateBuildConfig(BuildTrackerLib.BuildConfig _bc)
        {
            if (_bc != null)
            {
                this.tbCDNBuildName.Text = _bc.getBuildName();
                this.tbCDNBuildKey.Text = _bc.getConfigKey();
                this.tbCDNBuildUID.Text = _bc.getBuild_UID();
                this.tbCDNBuildRootKey.Text = _bc.getRootKey();
                this.tbCDNBuildInstallKey.Text = _bc.getRootKey();
                this.tbCDNBuildDownloadKey.Text = _bc.getDownloadKey();
                this.tbCDNBuildEncodingKeys.Text = string.Join(" | ", _bc.getEncodingKeys());
                this.tbCDNBuildEncodingSize.Text = string.Join(" | ", _bc.getEncodingSize());
                this.tbCDNBuildPatchKey.Text = _bc.getPatchKey();
                this.tbCDNBuildPatchConfigKey.Text = _bc.getPatchConfigKey();
                this.tbCDNBuildPatchSize.Text = _bc.getPatchSize();
            }
        }

        public void updateGamesListbox(List<Tracker.GameItem> _items) {
            this.lbGames.DisplayMember = "Name";
            this.lbGames.ValueMember = "Value";
            this.lbGames.DataSource = _items;
        }

        public void updateCDNBuildsListBox(List<Tracker.BuildItem> _items) {
            this.lbCDNBuilds.DisplayMember = "Name";
            this.lbCDNBuilds.ValueMember = "Value";
            this.lbCDNBuilds.DataSource = _items;
        }




        //Control-Event-Functions
        private void lbGames_SelectedIndexChanged(object sender, EventArgs e) {
            //Get ClientVersion by GameCode and send to the update function
            string CVkey = ((Tracker.GameItem)this.lbGames.SelectedItem).Value;
            updateClientVersion(this.tracker.getClientVersionByKey(CVkey));

            //Get all Builds in the CDN for the GameCode X and send it to the update function
            updateCDNBuildsListBox(this.tracker.listCDNBuilds(CVkey));

        }

        private void lbCDNBuilds_SelectedIndexChanged(object sender, EventArgs e) {
            string key = ((Tracker.BuildItem)this.lbCDNBuilds.SelectedItem).Value;
            BuildTrackerLib.BuildConfig cConfig = this.tracker.getBuildConfigByKey(key);
            updateBuildConfig(cConfig);
        }


        private void btnOpenTrackerChooser_Click(object sender, EventArgs e) {
            TrackingChooser TC = new TrackingChooser(ref this.tracker);
            TC.StartPosition = FormStartPosition.CenterParent;
            TC.ShowDialog();
        }




        //log-"NewMessage"-Subscriber Routine
        public void OnNewMessage(object source, EventArgs args)
        {
            string line = "[" + this.log.Messages.Last().Date_Send + "] " + this.log.Messages.Last().Msg + Environment.NewLine;
            this.rtbLog.AppendText(line);

            Color color = ColorTranslator.FromHtml(this.log.Messages.Last().color);
            this.rtbLog.Find(this.log.Messages.Last().Msg);
            this.rtbLog.SelectionColor = color;

            //Scroll to bottom
            this.rtbLog.SelectionStart = this.rtbLog.TextLength;
            this.rtbLog.ScrollToCaret();
        }





        //Tracker-Event Subscriber Routines

        public void OnClientUpdated(string _code) {
            this.updateClientVersion(this.tracker.Games[_code].getClientVersion());
        }

        public void OnCDNConfigUpdated(string _code) {
            this.updateCDNBuildsListBox(this.tracker.listCDNBuilds(_code));
        }



        //Timer Related WinForm.Control Events
        private void numUDTrackerDelay_ValueChanged(object sender, EventArgs e)
        {
            this.TrackerDelay = (int)numUDTrackerDelay.Value * 1000;
        }

        private void btnTrackerToggle_Click(object sender, EventArgs e) {
            toggleTracking();
        }

        private void TrackerTimer_Tick(object sender, EventArgs e) {
            this.tracker.track();
        }


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

                this.log.WriteMessage("Stopped Tracking!", "BlizzardBuildTrackerForm:btnTrackerToggle_Click()");

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

                this.log.WriteMessage("Started Tracking!", "BlizzardBuildTrackerForm:btnTrackerToggle_Click()");

                //For logging purposes list all games being tracked
                List<string> gamesBeingTracked = new List<string>();
                foreach (var currentG in this.tracker.Games) {
                    if (currentG.Value.getTrackingStatus()) {
                        gamesBeingTracked.Add(currentG.Key);
                    }
                }
                if (gamesBeingTracked.Any()) {
                    this.log.WriteMessage("Tracking the following Codes: " + String.Join(", ", gamesBeingTracked.ToArray()), "Tracker:track()");
                } else {
                    this.log.WriteWarning("No Code has been enabled for tracking.", "Tracker:track()");
                }

            }

            this.isTracking = !this.isTracking;
        }


    }
}
