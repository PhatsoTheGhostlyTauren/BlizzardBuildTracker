using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BuildTrackerLib {

    public class CDNConfig
    {
        public string checksum { get; set; }
        public string config_key { get; set; }
        public string config_url { get; set; }
        public bool loadSuccess { get; set; }

        public string[] archives { get; set; }
        public string archive_group { get; set; }
        public string[] patch_archives { get; set; }
        public string patch_archive_group { get; set; }
        public string[] build_keys { get; set; }

        public CDNConfig(string _url, string _key) {

            //Prepare URL for CDNConfig-Download
            this.config_key = _key;
            this.config_url = Utility.getHashUrl(_url, this.config_key);

            //load Build Config and store the Success of that Routine
            this.loadSuccess = this.fetchCDNConfig();
        }

        //Set Properties
        public void SetCDNConfigProperties(Dictionary<string, string> _CDNconfdata) {
            this.archives = Regex.Split(Utility.ifKeyExists(_CDNconfdata, "archives"), " ");
            this.archive_group = Utility.ifKeyExists(_CDNconfdata, "archive-group");
            this.patch_archives = Regex.Split(Utility.ifKeyExists(_CDNconfdata, "patch-archives"), " ");
            this.patch_archive_group = Utility.ifKeyExists(_CDNconfdata, "patch-archive-group");
            this.build_keys = Regex.Split(Utility.ifKeyExists(_CDNconfdata, "builds"), " ");
        }

        //Download CDNConfig to String and Convert it to Dictionary<string,string>
        public bool fetchCDNConfig()
        {
            //Download Version String from BNet
            string CDNConfig_string = Utility.getString(this.config_url);

            if (CDNConfig_string != null) {

                //Generate Line By Line Dictionary
                Dictionary<string, string> _data = Utility.convertBlizzData(CDNConfig_string);

                //update Properties
                this.SetCDNConfigProperties(_data);            

                //update Checksum
                this.checksum = Utility.CreateMD5(CDNConfig_string);

                return true;
            } else {
                return false;
            }
        }



    }


}
