using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BuildTrackerLib {
    public class BuildConfig
    {
        public string checksum { get; set; }
        public string config_key { get; set; }
        public bool loadSuccess { get; set; }


        public string rootKey { get; set; }
        public string downloadKey { get; set; }
        public string installKey { get; set; }
        public string[] encodingKeys { get; set; }
        public string[] encoding_size { get; set; }
        public string build_name { get; set; }
        public string build_playbuild_installer { get; set; }
        public string build_product { get; set; }
        public string build_uid { get; set; }
        public string patchKey { get; set; }
        public string patch_size { get; set; }
        public string patch_config_Key { get; set; }

        public BuildConfig(string _url, string _key)
        {
            this.config_key = _key;

            //load Build Config and store the Success of that Routine
            this.loadSuccess = loadBuildConfig(_url, this.config_key);
        }


        private bool loadBuildConfig(string _url, string _hash)
        {
            //Download BuildConfig String from BNet
            string constructed_url = Utility.getHashUrl(_url, _hash);
            string BuildConfig_string = Utility.getString(constructed_url);

            //Exit if Download failed
            if (BuildConfig_string != null) { 
                this.checksum = Utility.CreateMD5(BuildConfig_string);
                //Generate Line By Line Dictionary
                Dictionary<string, string> _Buildconfdata = Utility.convertBlizzData(BuildConfig_string);

                //Assign Properties
                this.rootKey = _Buildconfdata["root"];
                this.downloadKey = _Buildconfdata["download"];
                this.installKey = _Buildconfdata["install"];
                this.encodingKeys = Regex.Split(_Buildconfdata["encoding"], " ");
                this.encoding_size = Regex.Split(Utility.ifKeyExists(_Buildconfdata,"encoding-size"), " ");
                this.build_name = _Buildconfdata["build-name"];
                this.build_playbuild_installer = Utility.ifKeyExists(_Buildconfdata, "build-playbuild-installer");
                this.build_product = _Buildconfdata["build-product"];
                this.build_uid = _Buildconfdata["build-uid"];
                this.patchKey = Utility.ifKeyExists(_Buildconfdata, "patch");
                this.patch_size = Utility.ifKeyExists(_Buildconfdata, "patch-size");
                this.patch_config_Key = Utility.ifKeyExists(_Buildconfdata, "patch-config");


                //Report that the BuildConfig was succesfully loaded
                return true;
            } else {
                return false;
            }


        }



    }

}
