using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTrackerLib
{
    public class ClientVersion
    {
        public string region;
        public string cdnConfigHash;
        public string buildConfigHash;
        public string buildName;
        public string buildID;
        public Dictionary<string, string> _vdata;


        public ClientVersion(string _url)
        {
            _vdata = loadVersion(_url);
            region = _vdata["Region"];
            cdnConfigHash = _vdata["CDNConfig"];
            buildConfigHash = _vdata["BuildConfig"];
            buildName = _vdata["VersionsName"];
            buildID = _vdata["BuildId"];
        }

        private Dictionary<string, string> loadVersion(string _url)
        {
            //Download Version String from BNet
            string versions_string = Utility.getString(_url);
            //Generate Line By Line Associated Array
            List<Dictionary<string, string>> Version_Data = Utility.disentangleBlizzTable(versions_string);

            //Find appropriate Region
            string[] priorities = { "us", "xx", "eu", "kr", "tw", "cn", "sg" };
            Dictionary<string, string> vdata = Utility.priorityFind(priorities, Version_Data, "Region"); // returns a single row of the source data as an associative array

            return vdata;
        }

    }
}
