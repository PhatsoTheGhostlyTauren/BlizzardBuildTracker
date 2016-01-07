using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace BuildTrackerLib
{
    public class Utility
    {

        public static string getString(string _url,ref Log _log)
        {
            using (WebClient client = new WebClient())
            {
                Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                string no_cached_url = _url + "?fuckcache=" + unixTimestamp;
                string data = null;
                try {
                    data = client.DownloadString(no_cached_url);
                } catch(Exception E) {

                    _log.WriteWarning("Error downloading data!", "Utility:getString()");
                    _log.WriteWarning(E.Message, "Utility:getString()");
                    //Console.WriteLine(_url + Environment.NewLine + client.ResponseHeaders);
                }

                return data;
            }
        }

        public static string getSize(string _url) {
            Dictionary<string, string> Headers = GetHTTPResponseHeaders(_url);

            return Headers["age"];
        }

        private static Dictionary<string, string> GetHTTPResponseHeaders(string _url)
        {
            throw new NotImplementedException();
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

        public static Dictionary<string, string> priorityFind(string[] _prios, List<Dictionary<string, string>> _data, string _key, bool _caseSens)
        {
            string value, priority;
            foreach (string prio in _prios)
            {
                foreach (Dictionary<string, string> entry in _data)
                {
                    //if not Case Sensitive transform to lowercase
                    if (!_caseSens) {
                        value = entry[_key].ToLower();
                        priority = prio.ToLower();
                    } else {
                        value = entry[_key];
                        priority = prio;
                    }

                    if (value == priority)
                    {
                        return entry;
                    }

                }

            }
            return null;
        }

        public static string getHashUrl(string _url, string _hash) {

            string result = _url + string.Format("/{0}/{1}/{2}", _hash.Substring(0, 2), _hash.Substring(2, 2), _hash);
            return result;
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
