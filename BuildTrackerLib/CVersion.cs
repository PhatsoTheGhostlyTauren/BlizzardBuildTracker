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
        public string checksum,version_url;
        public string region;
        public string cdnConfigHash;
        public string buildConfigHash;
        public string buildName;
        public string buildID;
        public Dictionary<string, string> version_data;
        private Log log;

        public ClientVersion(string _url, Log _log)
        {
            log = _log;
            version_url = _url;
            version_data = loadVersion(version_url);
            region = version_data["Region"];
            cdnConfigHash = version_data["CDNConfig"];
            buildConfigHash = version_data["BuildConfig"];
            buildName = version_data["VersionsName"];
            buildID = version_data["BuildId"];
        }

        private Dictionary<string, string> loadVersion(string _url)
        {
            //Download Version String from BNet
            string versions_string = Utility.getString(_url);
            this.checksum = Utility.CreateMD5(versions_string);
            //Generate Line By Line Associated Array
            List<Dictionary<string, string>> Version_Data = Utility.deserializeBlizzTable(versions_string);
            log.WriteMessage("Version-Data succesfully gathered and deserialized!","CVersion:loadVersion");


            //Find appropriate Region
            string[] priorities = { "us", "xx", "eu", "kr", "tw", "cn", "sg" };
            Dictionary<string, string> vdata = Utility.priorityFind(priorities, Version_Data, "Region"); // returns a single row of the source data as an associative array



            return vdata;
        }


        public void updateClientVersion(string _datastr) {
            this.checksum = Utility.CreateMD5(_datastr);
            List<Dictionary<string, string>> Version_Data = Utility.deserializeBlizzTable(_datastr);


            string[] priorities = { "us", "xx", "eu", "kr", "tw", "cn", "sg" };
            this.version_data = Utility.priorityFind(priorities, Version_Data, "Region");

            this.region = version_data["Region"];
            this.cdnConfigHash = version_data["CDNConfig"];
            this.buildConfigHash = version_data["BuildConfig"];
            this.buildName = version_data["VersionsName"];
            this.buildID = version_data["BuildId"];
        }





        public bool checkForUpdates() {
            string data = Utility.getString(this.version_url);
            string new_CheckSum = Utility.CreateMD5(data);
            if (new_CheckSum == this.checksum) {
                return false;
            } else {
                this.checksum = new_CheckSum;
                updateClientVersion(data);
                return true;
            }
        }


    }
}
