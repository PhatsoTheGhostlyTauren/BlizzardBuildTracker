using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BuildTrackerLib
{
    public class Utility
    {

        public static string getString(string _url)
        {

            using (WebClient client = new WebClient())
            {
                return client.DownloadString(_url);
            }

        }

        public static List<Dictionary<string, string>> disentangleBlizzTable(string _data)
        {
            _data = _data.TrimEnd(); //Remove Trailing Spaces and Lines
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

        public static Dictionary<string, string> priorityFind(string[] _prios, List<Dictionary<string, string>> _data, string _key)
        {
            foreach (string prio in _prios)
            {
                foreach (Dictionary<string, string> entry in _data)
                {
                    if (entry[_key] == prio)
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





    }
}
