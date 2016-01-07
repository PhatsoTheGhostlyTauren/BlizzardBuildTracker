using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BuildTrackerLib
{
    public class ClientVersion
    {
        private string checksum,version_url;
        private string region;
        private string cdnConfigKey;
        private string buildConfigKey;
        private string buildName;
        private string buildID;
        private Dictionary<string, string> version_data;
        private Log log;

        public ClientVersion(string _url,ref Log _log)
        {
            this.log = _log;
            this.version_url = _url;
            this.version_data = loadVersion(version_url);
            this.region = version_data["Region"];
            this.cdnConfigKey = version_data["CDNConfig"];
            this.buildConfigKey = version_data["BuildConfig"];
            this.buildName = version_data["VersionsName"];
            this.buildID = version_data["BuildId"];
        }

        // Getter's 'n' Setter's

        public string getCDNConfigKey() {
            return this.cdnConfigKey;
        }


        //Secondarys Getters for Output
        public string getRegion() { return this.region; }
        public string getBuildID() { return this.buildID; }
        public string getBuildName() { return this.buildName; }
        public string getBuildConfigKey() { return this.buildConfigKey; }





        private Dictionary<string, string> loadVersion(string _url)
        {
            //Download Version String from BNet
            string versions_string = Utility.getString(_url, ref this.log);
            this.checksum = Utility.CreateMD5(versions_string);
            //Generate Line By Line Associated Array
            List<Dictionary<string, string>> Version_Data = Utility.deserializeBlizzTable(versions_string);


            //Find appropriate Region
            string[] priorities = { "us", "xx", "eu", "kr", "tw", "cn", "sg" };
            Dictionary<string, string> vdata = Utility.priorityFind(priorities, Version_Data, "Region",false); // returns a single row of the source data as an associative array

            return vdata;
        }


        private void updateClientVersion(string _datastr) {
            this.checksum = Utility.CreateMD5(_datastr);
            List<Dictionary<string, string>> Version_Data = Utility.deserializeBlizzTable(_datastr);


            string[] priorities = { "us", "xx", "eu", "kr", "tw", "cn", "sg" };
            this.version_data = Utility.priorityFind(priorities, Version_Data, "Region",false);

            this.region = version_data["Region"];
            this.cdnConfigKey = version_data["CDNConfig"];
            this.buildConfigKey = version_data["BuildConfig"];
            this.buildName = version_data["VersionsName"];
            this.buildID = version_data["BuildId"];
        }





        public bool checkForUpdates() {
            string data = Utility.getString(this.version_url,ref this.log);
            string new_CheckSum = Utility.CreateMD5(data);
            if (new_CheckSum == this.checksum) {
                return false;
            } else {
                this.checksum = new_CheckSum;
                this.updateClientVersion(data);
                return true;
            }
        }


    }
}
