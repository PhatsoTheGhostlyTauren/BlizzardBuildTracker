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
        private Log log;
        private Dictionary<string, string> _Buildconfdata;
        private string checksum;
        private string config_key;
        private string rootKey, downloadKey, installKey;
        private string[] encodingKeys, encoding_size;
        private string build_name, build_playbuild_installer, build_product, build_uid;
        private string patchKey, patch_size, patch_config_Key;

        public BuildConfig(string _url, string _key, ref Log _log)
        {
            this.log = _log;
            this.config_key = _key;
            this._Buildconfdata = loadBuildConfig(_url, this.config_key);
            this.rootKey = _Buildconfdata["root"];
            this.downloadKey = _Buildconfdata["download"];
            this.installKey = _Buildconfdata["install"];
            this.encodingKeys = Regex.Split(_Buildconfdata["encoding"], " ");
            this.encoding_size = Regex.Split(ifKeyExists("encoding-size"), " ");
            this.build_name = _Buildconfdata["build-name"];
            this.build_playbuild_installer = ifKeyExists("build-playbuild-installer");
            this.build_product = _Buildconfdata["build-product"];
            this.build_uid = _Buildconfdata["build-uid"];
            this.patchKey = ifKeyExists("patch");
            this.patch_size = ifKeyExists("patch-size");
            this.patch_config_Key = ifKeyExists("patch-config");
        }

        public string getBuildName() {
            return this.build_name;
        }
        public string getConfigKey() {
            return this.config_key;
        }

        
        //Secondary Display-Getters
        public string getRootKey(){ return this.rootKey; }
        public string getDownloadKey() { return this.downloadKey; }
        public string getInstallKey() { return this.installKey; }
        public string getBuild_Playbuild_Installer() { return this.build_playbuild_installer; }
        public string getBuild_Product() { return this.build_product; }
        public string getBuild_UID() { return this.build_uid; }
        public string getPatchKey() { return this.patchKey; }
        public string getPatchSize() { return this.patch_size; }
        public string getPatchConfigKey() { return this.patch_config_Key; }
        public string[] getEncodingKeys() { return this.encodingKeys; }
        public string[] getEncodingSize() { return this.encoding_size; }








        private string ifKeyExists(string _key) {
            return (_Buildconfdata.ContainsKey(_key)) ? _Buildconfdata[_key] : "Not found!";
        }

        private Dictionary<string, string> loadBuildConfig(string _url, string _hash)
        {
            //Download BuildConfig String from BNet
            string constructed_url = Utility.getHashUrl(_url, _hash);
            string BuildConfig_string = Utility.getString(constructed_url,ref this.log);
            this.checksum = Utility.CreateMD5(BuildConfig_string);
            //Generate Line By Line Dictionary
            Dictionary<string, string> BuildConfig_Data = Utility.convertBlizzData(BuildConfig_string);

            return BuildConfig_Data;
        }
        
        

    }

}
