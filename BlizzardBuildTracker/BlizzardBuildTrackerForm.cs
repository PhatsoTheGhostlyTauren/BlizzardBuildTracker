using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace BlizzardBuildTracker
{
    public partial class BlizzardBuildTrackerForm : Form
    {
        public BuildTrackerLib.Games.Game currentGame;
        public BuildTrackerLib.Log log;
        public int TrackerDelay = 30000;
        public bool isTracking = false;
        public SoundPlayer FelReaver;

        public BlizzardBuildTrackerForm()
        {
            InitializeComponent();
            this.Icon = BlizzardBuildTracker.Properties.Resources.phatso;
            this.cbGameCode.Items.AddRange(new object[] { "wow", "wow_beta", "wowt" });
            this.cbGameCode.SelectedIndex = 0;
            this.numUDTrackerDelay.Value = TrackerDelay / 1000;
            this.FelReaver = new SoundPlayer(BlizzardBuildTracker.Properties.Resources.FelReaver);
            FelReaver.Play();
        }




        //Control-Update Functions
        public void updateClientVersion(BuildTrackerLib.ClientVersion _v) {
            this.tbCVBuildID.Text = _v.buildID;
            this.tbCVRegion.Text = _v.region;
            this.tbCVBuildName.Text = _v.buildName;
            this.tbCVBuildConfig.Text = _v.buildConfigHash;
            this.tbLog.Text = _v.cdnConfigHash;
        }

        public void updateBuildConfig(BuildTrackerLib.BuildConfig _bc)
        {
            if (_bc != null)
            {
                this.tbCDNBuildName.Text = _bc.build_name;
                this.tbCDNBuildHash.Text = _bc.config_hash;
                this.tbCDNBuildUID.Text = _bc.build_uid;
                this.tbCDNBuildRoot.Text = _bc.root;
                this.tbCDNBuildInstall.Text = _bc.install;
                this.tbCDNBuildDownload.Text = _bc.download;
                this.tbCDNBuildEncoding.Text = string.Join(" | ", _bc.encoding);
                this.tbCDNBuildEncodingSize.Text = string.Join(" | ", _bc.encoding_size);
                this.tbCDNBuildPatch.Text = _bc.patch;
                this.tbCDNBuildPatchConfig.Text = _bc.patch_config;
                this.tbCDNBuildPatchSize.Text = _bc.patch_size;
            }
        }

        public class BuildItem {
            public string Name { get; set; }
            public BuildTrackerLib.BuildConfig Value { get; set; }
        }

        public void loadCDNBuilds(Dictionary<string, BuildTrackerLib.BuildConfig> _builds) {
            List<BuildItem> items = new List<BuildItem>(); 

            foreach(KeyValuePair<string, BuildTrackerLib.BuildConfig> entry in _builds) {
                items.Add(new BuildItem() { Name = entry.Value.build_name, Value = entry.Value });
            }

            this.listBoxCDNBuilds.DisplayMember = "Name";
            this.listBoxCDNBuilds.ValueMember = "Value";
            this.listBoxCDNBuilds.DataSource = items;

            this.listBoxCDNBuilds.SelectedIndex = 0;
            this.listBoxCDNBuilds_SelectedIndexChanged(listBoxCDNBuilds, new EventArgs());
        }


        //Event-Functions
        private void buttonLoadVersionsData_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Gamecode from Dropdown
                string selectedGameCode = this.cbGameCode.Text;
                loadGame(selectedGameCode);

            }
            catch (Exception E)
            {
                Console.WriteLine("{0} Exception caught.", E);
            }
        }

        private void listBoxCDNBuilds_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildTrackerLib.BuildConfig cConfig = listBoxCDNBuilds.SelectedValue as BuildTrackerLib.BuildConfig;
            updateBuildConfig(cConfig);
        }


        //Functionality Functions
        public void loadGame(string _gamecode) {
            rtbLog.Clear();
                       
            //Load Game Object
            log = new BuildTrackerLib.Log();
            log.NewMessage += OnNewMessage;
            currentGame = BuildTrackerLib.Games.loadGame(_gamecode, log);

            //Update the Client Version Display
            updateClientVersion(currentGame.client_version);
            loadCDNBuilds(currentGame.cdn_config.builds);

            //Enable Tracking Buttons
            this.numUDTrackerDelay.Enabled = true;          
        }

        //call CheckForUpdate-Routines
        public void track(object sender, EventArgs e) {
            //Store old Builds to math exact differences afterwards
            string[] old_buildhashes = this.currentGame.cdn_config.build_hashes;


            //Check for Updates in CDNConfig; If the Checksum changes, reload the Object and return true
            bool cdnconf_changed = this.currentGame.cdn_config.checkForUpdates();


            if (cdnconf_changed == true) 
            {
                log.WriteMessage("CDNConfig has changed.", "BlizzardBuildTrackerForm:track()");

                //Calculate difference between old and new build_hashes string[]
                string[] cdnconf_diff = BuildTrackerLib.Utility.getDifference(old_buildhashes, this.currentGame.cdn_config.build_hashes);

                //if diff isnt empty sort in added and removed list
                if (cdnconf_diff.Any())
                {                    
                    List<string> added = new List<string>();
                    List<string> removed = new List<string>();

                    foreach (string _hash in cdnconf_diff)
                    {
                        if (old_buildhashes.Contains(_hash))
                        {
                            removed.Add(_hash);
                        } else {
                            added.Add(this.currentGame.cdn_config.builds[_hash].build_name);
                        }
                    }

                    //Log all added Builds by BuildName
                    if (added.Any())
                    {
                        string addedBuilds = string.Join(", ", added.ToArray());
                        log.WriteSuccess("New Builds: "+addedBuilds, "BlizzardBuildTrackerForm:track()");

                        FelReaver.Play();
                    }
                    //Log all removed Builds by BuildHash
                    if (removed.Any())
                    {
                        string removedBuilds = string.Join(", ", removed.ToArray());
                        log.WriteMessage("Removed Builds: " + removedBuilds, "BlizzardBuildTrackerForm:track()");
                    }

                    //Reload ListBox Datasource
                    loadCDNBuilds(this.currentGame.cdn_config.builds);

                } else {
                    log.WriteMessage("Build-Section hasn't changed", "BlizzardBuildTrackerForm:track()");
                }

            } else {
                log.WriteMessage("CDNConfig hasn't changed", "BlizzardBuildTrackerForm:track()");
            }


            //Store ClientVersion-ID for later Checkage
            string old_clientversion = this.currentGame.client_version.buildID;

            bool ClientVersionChanged = this.currentGame.client_version.checkForUpdates();

            //If the Version-File has a new Checksum, do:
            if (ClientVersionChanged) {
                //if the ClientVersion-ID has changed do:
                if(old_clientversion != this.currentGame.client_version.buildID) {
                    log.WriteSuccess("New Build has been pushed to the '"+this.currentGame.gamecode+"'-Client: "+this.currentGame.client_version.buildName, "BlizzardBuildTrackerForm:track()");
                    FelReaver.Play();
                } else {
                    log.WriteMessage("Version-ID hasnt changed!", "BlizzardBuildTrackerForm:track()");
                }
                //update the ClientVersion-Display anyways for potential secondary changes
                updateClientVersion(this.currentGame.client_version);
            } else {
                log.WriteMessage("ClientVersion hasn't changed!", "BlizzardBuildTrackerForm:track()");
            }


        }


        //log-"NewMessage"-Subscriber Routine
        public void OnNewMessage(object source, EventArgs args)
        {
            this.rtbLog.AppendText("[" + log.Messages.Last().Date_Send + "] ");
            this.rtbLog.AppendText(log.Messages.Last().Msg + Environment.NewLine);

            Color color = ColorTranslator.FromHtml(this.log.Messages.Last().color);
            this.rtbLog.Find(log.Messages.Last().Msg);
            this.rtbLog.SelectionColor = color;
        }

        private void numUDTrackerDelay_ValueChanged(object sender, EventArgs e)
        {
            this.TrackerDelay = (int)numUDTrackerDelay.Value * 1000;
        }

        private void btnTrackerToggle_Click(object sender, EventArgs e)
        {
            if (isTracking)
            {
                //Stop the Timer 
                this.TrackerTimer.Enabled = false;

                //Enable Timer-Delay Numerical Control
                this.numUDTrackerDelay.Enabled = true;

                //Change Button Text
                this.btnTrackerToggle.Text = "Start Tracking";
            }
            else {
                //Set Timer Interval from int TrackerDelay
                this.TrackerTimer.Interval = this.TrackerDelay;
                //Enable Timer
                this.TrackerTimer.Enabled = true;
                //Disable Interval NumControl
                this.numUDTrackerDelay.Enabled = false;
                //Edit Button Text
                this.btnTrackerToggle.Text = "Stop Tracking";
            }

            this.isTracking = !this.isTracking;
        }
    }
}
