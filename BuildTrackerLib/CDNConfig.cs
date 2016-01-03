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
        public string[] archives;
        public string archive_group;
        public string[] patch_archives;
        public string patch_archive_group;
        public string[] build_hashes;
        public Dictionary<string,string> _CDNconfdata;
        public Dictionary<string,BuildConfig> builds;
        public Log log;

        public CDNConfig(string _url, string _hash,Log _log) {
            log = _log;
            _CDNconfdata = loadCDNConfig(_url, _hash);
            archives = Regex.Split(_CDNconfdata["archives"]," ");
            archive_group = _CDNconfdata["archive-group"];
            patch_archives = Regex.Split(_CDNconfdata["patch-archives"], " ");
            patch_archive_group = _CDNconfdata["patch-archive-group"];
            build_hashes = Regex.Split(_CDNconfdata["builds"], " ");
            builds = loadBuilds(_url, build_hashes);
        }

        private Dictionary<string, string> loadCDNConfig(string _url, string _hash)
        {
            //Download Version String from BNet
            string constructed_url = Utility.getHashUrl(_url, _hash);
            string CDNConfig_string = Utility.getString(constructed_url);
            //Generate Line By Line Dictionary
            Dictionary<string, string> CDNConfig_Data = Utility.convertBlizzData(CDNConfig_string);
            log.WriteMessage("Succesfully loaded CDN-Config!", "CDNConfig:loadCDNConfig");                                                  //Logging
            return CDNConfig_Data;
        }

        private Dictionary<string,BuildConfig> loadBuilds(string _url, string[] _BuildConfigHashes) {
            Dictionary<string, BuildConfig> result = new Dictionary<string,BuildConfig>();
            BuildConfig tmp;
            int msgindex = log.WriteProgress(String.Format("Loading Build-Config (0/{0})", _BuildConfigHashes.Length), "CDNConfig:loadBuilds");
            int counter = 0;
            foreach (string hash in _BuildConfigHashes) {
                tmp = new BuildConfig(_url, hash);
                result[tmp.build_uid+"."+tmp.build_name] = tmp;
                counter++;
                log.updateProgress(String.Format("Loading Build-Config ({0}/{1})", counter, _BuildConfigHashes.Length),msgindex);
            }
            //this.log.WriteMessage("Succesfully gathered BuildConfigs for this CDN");
            return result;
        }



    }


}
