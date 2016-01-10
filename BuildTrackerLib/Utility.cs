using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace BuildTrackerLib {
    public class Utility
    {


        public static bool CheckForInternetConnection() {
            try {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            } catch (Exception) {
                return false;
            }
        }

        public static string getString(string _url)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string no_cached_url = _url + "?fuckcache=" + unixTimestamp;

            string myString = null;
           
            try {
                using (WebClient wc = new WebClient()) {
                    return myString = wc.DownloadString(no_cached_url);
                }

            } catch (Exception) {
                Log.WriteWarning("Error downloading Data from URL: " + _url, "Utility:getString()");
                return null;
            }          
        }




        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static List<Dictionary<string, string>> deserializeBlizzTable(string _data)
        {
            _data = _data.TrimEnd(); //Remove Trailing Spaces and Lines//
            string[] rows = Regex.Split(_data, "\n");
            string[] headrow = rows[0].Split('|');
            int colcount = 0;
            string[] header = new string[headrow.Length];
            string[] temparr;
            foreach (string head in headrow)
            {
                temparr = Regex.Split(head, "!");
                header[colcount] = temparr[0];
                colcount++;
            }
            List <Dictionary<string, string>> BlizzData = new List<Dictionary<string, string>>();
            string[] crow;
            bool isEmpty;
            for (int i = 1; i < rows.Length; i++)
            {
                isEmpty = (rows[i] == "");
                if (!isEmpty)
                {
                    crow = rows[i].Split('|');
                    Dictionary<string, string> tmpdict = new Dictionary<string, string>();
                    for (int j = 0; j < header.Length; j++)
                    {
                        tmpdict.Add(header[j],crow[j]);
                    }
                    BlizzData.Add(tmpdict);
                }
            }
            return BlizzData;
        }



        public static string getHashUrl(string _url, string _hash) {

            string result = _url + string.Format("/{0}/{1}/{2}", _hash.Substring(0, 2), _hash.Substring(2, 2), _hash);
            return result;
        }

        public static string ifKeyExists(Dictionary<string, string> _dict, string _key) {
            return (_dict.ContainsKey(_key)) ? _dict[_key] : "Not found!";
        }

        //Convert "dataname = a b c d ...." Results into a Dictionary
        public static Dictionary<string, string> convertBlizzData(string _data) {
            _data = _data.Trim();
            string[] raw = Regex.Split(_data, "\n");

            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] tmp = new string[2];
            foreach (string line in raw) {
                if (!(line.Length == 0) && !(line[0] == '#')) { //if Line is not empty or Commented out 
                    tmp = Regex.Split(line, "=");
                    result.Add(tmp[0].Trim(), tmp[1].Trim());
                }

            }

            return result;
        }

        //Outputs the differing Elements of two String Arrays
        public static string[] getDifference(string[] _a, string[] _b) {
            IEnumerable<string> diffa = _a.Except(_b);
            IEnumerable<string> diffb = _b.Except(_a);
            string[] diff = diffa.Concat(diffb).ToArray();

            Console.WriteLine(diff.ToString());
            return diff;
        }





    }
}
