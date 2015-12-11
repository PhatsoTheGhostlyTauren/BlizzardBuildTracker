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

        public CDNConfig(string _url, string _hash ) {
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

            return CDNConfig_Data;
        }

        private Dictionary<string,BuildConfig> loadBuilds(string _url, string[] _BuildConfigHashes) {
            Dictionary<string, BuildConfig> result = new Dictionary<string,BuildConfig>();
            foreach (string hash in _BuildConfigHashes) {
                result[hash] = new BuildConfig(_url, hash);
            }
            return result;
        }



    }


}
