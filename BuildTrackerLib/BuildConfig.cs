using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BuildTrackerLib
{
    public class BuildConfig
    {
        public Dictionary<string, string> _Buildconfdata;
        public string config_hash;
        public string root, download, install;
        public string[] encoding, encoding_size;
        public string build_name, build_playbuild_installer, build_product, build_uid;
        public string patch, patch_size, patch_config;

        public BuildConfig(string _url, string _hash)
        {
            config_hash = _hash;
            _Buildconfdata = loadBuildConfig(_url, _hash);            
            root = _Buildconfdata["root"];
            download = _Buildconfdata["download"];
            install = _Buildconfdata["install"];
            encoding = Regex.Split(_Buildconfdata["encoding"], " ");
            encoding_size = Regex.Split(_Buildconfdata["encoding-size"], " ");
            build_name = _Buildconfdata["build-name"];
            build_playbuild_installer = _Buildconfdata["build-playbuild-installer"];
            build_product = _Buildconfdata["build-product"];
            build_uid = _Buildconfdata["build-uid"];
            patch = (_Buildconfdata.ContainsKey("patch")) ? _Buildconfdata["patch"] : "Not found!";
            patch_size = (_Buildconfdata.ContainsKey("patch-size")) ? _Buildconfdata["patch-size"] : "Not found!";
            patch_config = (_Buildconfdata.ContainsKey("patch-config")) ? _Buildconfdata["patch-config"] : "Not found!";
        }

        private Dictionary<string, string> loadBuildConfig(string _url, string _hash)
        {
            //Download BuildConfig String from BNet
            string constructed_url = Utility.getHashUrl(_url, _hash);
            string BuildConfig_string = Utility.getString(constructed_url);
            //Generate Line By Line Dictionary
            Dictionary<string, string> BuildConfig_Data = Utility.convertBlizzData(BuildConfig_string);

            return BuildConfig_Data;
        }
        
        public string getDisplayName
        {
            get {
                return build_name;
            }
        }
        

    }

}
