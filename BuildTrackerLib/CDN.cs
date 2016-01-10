using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BuildTrackerLib {
    public partial class Game  {


        public Dictionary<string, CDN> CDNS;
        public string CDNS_CheckSum;



        public class CDN {

            public CDN(string _region, string _path, string _hosts) {
                this.region = _region;
                this.path = _path;
                this.hosts = Regex.Split(_hosts, " ");
            }

            public string region { get; set; }
            public string path { get; set; }
            public string[] hosts { get; set; }
        }

        public bool loadCDNSFile() {

            //Download CDNS-File String from BNet
            string cdns_string = Utility.getString(this.cdns_url);

            if (cdns_string != null) {
                //Update CDNS-File-CheckSum for this Game
                this.CDNS_CheckSum = Utility.CreateMD5(cdns_string);


                Dictionary<string, CDN> cdn_list = new Dictionary<string, CDN>();

                //Generate Line By Line Associated Array
                List<Dictionary<string, string>> CDNS_Data = Utility.deserializeBlizzTable(cdns_string);

                foreach (Dictionary<string, string> _cdn in CDNS_Data) {
                    cdn_list.Add(_cdn["Name"], new CDN(_cdn["Name"], _cdn["Path"], _cdn["Hosts"]));
                }

                this.CDNS = cdn_list;

                return true;

            } else {
                return false;
            }
        }
    }
}
