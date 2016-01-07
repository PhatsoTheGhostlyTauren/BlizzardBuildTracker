using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BuildTrackerLib
{

    public class CDNConfig
    {
        public string checksum, config_key, config_url, dist_url;

        private string[] archives;
        private string archive_group;
        private string[] patch_archives;
        private string patch_archive_group;
        private string[] build_keys;
        private Dictionary<string, string> CDNConfData;
        private Log log;

        public CDNConfig(string _url, string _key, ref Log _log) {
            this.dist_url = _url;
            this.config_key = _key;
            this.config_url = Utility.getHashUrl(this.dist_url, this.config_key);
            this.log = _log;

            this.CDNConfData = loadCDNConfig();
            parseCDNConfigDictionary(this.CDNConfData);
        }
        
        //Getters 'n' Setters

        public string[] getBuildKeys() {
            return this.build_keys;
        }

        public string getConfigKey() {
            return this.config_key;
        }

        
        private void parseCDNConfigDictionary(Dictionary<string,string> _CDNconfdata) {
            this.archives = Regex.Split(ifKeyExists("archives"), " ");
            this.archive_group = ifKeyExists("archive-group");
            this.patch_archives = Regex.Split(ifKeyExists("patch-archives"), " ");
            this.patch_archive_group = ifKeyExists("patch-archive-group");
            this.build_keys = Regex.Split(ifKeyExists("builds"), " ");
        }

        private string ifKeyExists(string _key) {
            return (CDNConfData.ContainsKey(_key)) ? CDNConfData[_key] : "Not found!";
        }

        //Download CDNConfig to String and Convert it to Dictionary<string,string>
        private Dictionary<string, string> loadCDNConfig()
        {
            //Download Version String from BNet
            string CDNConfig_string = Utility.getString(this.config_url,ref this.log);
            this.checksum = Utility.CreateMD5(CDNConfig_string);

            //Generate Line By Line Dictionary
            Dictionary<string, string> CDNConfig_Data = Utility.convertBlizzData(CDNConfig_string);

            return CDNConfig_Data;
        }

        //Update the CDNConfig-Object after finding that the 
        private void updateCDNConfig(string _datastr) {
            //Generate Line By Line Dictionary
            Dictionary<string, string> CDNConfig_Data = Utility.convertBlizzData(_datastr);

            //Continue to parse the updated Config
            this.parseCDNConfigDictionary(CDNConfig_Data);
        }




        public bool checkForUpdates() {
            string data = Utility.getString(this.config_url,ref this.log);
            string new_CheckSum = Utility.CreateMD5(data);
            if (new_CheckSum == this.checksum)
            {
                return false;
            }
            else {
                this.checksum = new_CheckSum;
                this.updateCDNConfig(data);
                return true;
            }
        }


    }


}
