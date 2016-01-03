using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BlizzardBuildTracker
{
    public partial class BlizzardBuildTrackerForm : Form
    {
        public BuildTrackerLib.Games.Game currentGame;
        BuildTrackerLib.Log log;

        public BlizzardBuildTrackerForm()
        {
            InitializeComponent();
            this.Icon = BlizzardBuildTracker.Properties.Resources.phatso;
            this.cbGameCode.Items.AddRange(new object[] { "wow", "wow_beta", "wowt" });
            this.cbGameCode.SelectedIndex = 0;


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

        public void loadCDNBuilds(Dictionary<string,BuildTrackerLib.BuildConfig> _builds) {
            this.listBoxCDNBuilds.DataSource = null;
            this.listBoxCDNBuilds.DataSource = new BindingSource(_builds,null);
            this.listBoxCDNBuilds.DisplayMember = "Key";
            this.listBoxCDNBuilds.ValueMember = "Value";
            this.listBoxCDNBuilds.SelectedIndex = 0;
            this.listBoxCDNBuilds_SelectedIndexChanged(listBoxCDNBuilds,new EventArgs());       
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
            //Load Game Object
            log = new BuildTrackerLib.Log();
            log.NewMessage += OnNewMessage;
            log.MessageUpdate += OnMessageUpdate;
            currentGame = BuildTrackerLib.Games.loadGame(_gamecode,log);
            //Update the Client Version Display
            updateClientVersion(currentGame.client_version);
            loadCDNBuilds(currentGame.cdn_config.builds);
        }


        public void OnNewMessage(object source, EventArgs args) { 
            this.rtbLog.AppendText("["+log.Messages.Last().Date_Send+"] ");
            this.rtbLog.AppendText(log.Messages.Last().Msg + Environment.NewLine);            
        }

        public void OnMessageUpdate(object source, EventArgs args) {
            string[] lines = this.rtbLog.Lines;
            lines[lines.Length -2] = "[" + log.Messages.Last().Date_Send + "] " + log.Messages.Last().Msg;
            rtbLog.Lines = lines;
        }
    }
}
