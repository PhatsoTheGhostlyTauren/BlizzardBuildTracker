namespace BuildTrackerLib {
    public partial class Game {

        public string gamecode { get; set; }
        public string bnet_url { get; set; }
        public string versions_url { get; set; }
        public string cdns_url { get; set; }
        public string dist_url { get; set; }
        public string CDNConfig_Key { get; set; }

        public Version ClientVersion { get; set; }

        public bool loadSuccess { get; set; } = false;
        public bool isTracked { get; set; } = false;

        public Game(string _GameCode) {
            this.gamecode = _GameCode;

            //Generate bnet-url specifying the Folder for _GameCode
            this.bnet_url = string.Format("http://us.patch.battle.net:1119/{0}", _GameCode);

            //use bnet-url to target relevant Files
            this.versions_url = string.Format("{0}/versions", bnet_url);
            this.cdns_url = string.Format("{0}/cdns", bnet_url);

            //Load Versions and CDNS
            bool cdnSuc = this.loadCDNSFile();
            bool verSuc = this.loadVersionFile();

            //set Dist URL for Build and CDN Configs
            if (cdnSuc && verSuc) {
                this.setDistURL();
                this.setCDNConfigKey();
            }  

            if(this.dist_url != null && this.CDNS != null && this.Versions != null) {
                this.loadSuccess = true;
            }
        }



        //Hacky Method to select the cdn path on the dist with Priority: US>XX>CN (US is always going to be the most uptodate CDN except for when only XX is enabled for betas or CN for gamecodes like d3CN
        public void setDistURL() {
            if (this.CDNS.ContainsKey("us")) {
                this.dist_url = string.Format("http://dist.blizzard.com.edgesuite.net/{0}/config", CDNS["us"].path);
            } else {
                if (this.CDNS.ContainsKey("xx")) {
                    this.dist_url = string.Format("http://dist.blizzard.com.edgesuite.net/{0}/config", CDNS["xx"].path);
                } else {
                    if (this.CDNS.ContainsKey("cn")) {
                        this.dist_url = string.Format("http://dist.blizzard.com.edgesuite.net/{0}/config", CDNS["cn"].path);
                    } else {
                        Log.WriteWarning("Couldn't find a CDN!", "Game:setDistURL()");
                    }
                }
            }
        }

        //Same for the CDNConfig-Key
        public void setCDNConfigKey() {
            if (this.Versions.ContainsKey("us")) {
                this.CDNConfig_Key = this.Versions["us"].cdnConfigKey;
            } else {
                if (this.Versions.ContainsKey("xx")) {
                    this.CDNConfig_Key = this.Versions["xx"].cdnConfigKey;
                } else {
                    if (this.Versions.ContainsKey("cn")) {
                        this.CDNConfig_Key = this.Versions["cn"].cdnConfigKey;
                    } else {
                        Log.WriteWarning("Couldn't find a CDNConfigKey!", "Game:setCDNConfigKey()");
                    }
                }
            }
        }






    }

    
}
