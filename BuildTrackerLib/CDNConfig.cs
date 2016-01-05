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
        public string checksum, config_hash, config_url, base_url;

        public string[] archives;
        public string archive_group;
        public string[] patch_archives;
        public string patch_archive_group;
        public string[] build_hashes;
        public Dictionary<string, BuildConfig> builds;
        public Log log;

        public CDNConfig(string _url, string _hash, Log _log) {
            this.base_url = _url;
            this.config_hash = _hash;
            this.config_url = Utility.getHashUrl(_url, _hash);
            this.log = _log;


            parseCDNConfigDictionary(loadCDNConfig());
            this.builds = loadBuilds(base_url, build_hashes);
        }
        
        
        public void parseCDNConfigDictionary(Dictionary<string,string> _CDNconfdata) {
            this.archives = Regex.Split(_CDNconfdata["archives"], " ");
            this.archive_group = _CDNconfdata["archive-group"];
            this.patch_archives = Regex.Split(_CDNconfdata["patch-archives"], " ");
            this.patch_archive_group = _CDNconfdata["patch-archive-group"];
            this.build_hashes = Regex.Split(_CDNconfdata["builds"], " ");
        }


        //Download CDNConfig to String and Convert it to Dictionary<string,string>
        private Dictionary<string, string> loadCDNConfig()
        {
            //Download Version String from BNet
            string CDNConfig_string = Utility.getString(this.config_url);
            this.checksum = Utility.CreateMD5(CDNConfig_string);
            //Generate Line By Line Dictionary
            Dictionary<string, string> CDNConfig_Data = Utility.convertBlizzData(CDNConfig_string);
            log.WriteMessage("Succesfully loaded CDN-Config!", "CDNConfig:loadCDNConfig");
            return CDNConfig_Data;
        }

        //Iterate through BuildHashes to generate BuildConfig-Objects
        private Dictionary<string, BuildConfig> loadBuilds(string _url, string[] _BuildConfigHashes) {
            Dictionary<string, BuildConfig> result = new Dictionary<string, BuildConfig>();
            BuildConfig tmp;
            foreach (string hash in _BuildConfigHashes) {
                tmp = new BuildConfig(_url, hash);
                result[hash] = tmp;
            }
            this.log.WriteMessage(String.Format("Loading Build-Config ({0}/{1})", result.Count, _BuildConfigHashes.Length), "CDNConfig:loadBuilds");
            return result;
        }


        //Update the CDNConfig-Object after finding that the 
        private void updateCDNConfig(string _datastr) {
            //Generate Line By Line Dictionary
            Dictionary<string, string> CDNConfig_Data = Utility.convertBlizzData(_datastr);

            //Continue to parse the updated Config
            parseCDNConfigDictionary(CDNConfig_Data);
            this.builds = loadBuilds(this.base_url, this.build_hashes);
        }




        public bool checkForUpdates() {
            string data = Utility.getString(this.config_url);
            string new_CheckSum = Utility.CreateMD5(data);
            if (new_CheckSum == this.checksum)
            {
                return false;
            }
            else {
                this.checksum = new_CheckSum;
                updateCDNConfig(data);
                return true;
            }
        }


    }


}
