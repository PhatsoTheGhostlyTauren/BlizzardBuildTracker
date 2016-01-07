using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildTrackerLib
{
    public class CDN
    {
        public Log log;
        public Dictionary<string, string> _cdndata;
        public string region;
        public string path;
        public string hosts;

        public CDN(string _url, ref Log _log)
        {
            this.log = _log;
            this._cdndata = loadCDN(_url);
            this.region = _cdndata["Name"];
            this.path = _cdndata["Path"];
            this.hosts = _cdndata["Hosts"];
        }

        private Dictionary<string,string> loadCDN(string _url)
        {
            //Download Version String from BNet
            string cdns_string = Utility.getString(_url, ref this.log);
            //Generate Line By Line Associated Array
            List<Dictionary<string, string>> CDNS_Data = Utility.deserializeBlizzTable(cdns_string);

            //Find appropriate Region
            string[] priorities = { "us", "xx", "eu", "kr", "tw", "cn", "sg" };
            Dictionary<string, string> cdndata = Utility.priorityFind(priorities, CDNS_Data, "Name",false); // returns a single row of the source data as an associative array

            return cdndata;
        }
    }
}
