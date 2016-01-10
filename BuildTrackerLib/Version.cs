using System.Collections.Generic;

namespace BuildTrackerLib {

    public partial class Game {
        /// <summary>
        /// List of Versions with its Region-Specification as Key
        /// </summary>
        public Dictionary<string, Version> Versions;
        public string Versions_CheckSum;

        /// <summary>
        /// Object to Store the Client-Version-Properties for a Games specific region.
        /// </summary>
        public class Version {
            /// <summary>
            /// Casts
            /// </summary>
            /// <param name="_version_string">Associated array deserialized from the Version-File</param>
            public Version(Dictionary<string, string> _version_string) {
                this.region = _version_string["Region"];
                this.cdnConfigKey = _version_string["CDNConfig"];
                this.buildConfigKey = _version_string["BuildConfig"];
                this.buildName = _version_string["VersionsName"];
                this.buildID = _version_string["BuildId"];
            }

            public string region { get; set; }
            public string cdnConfigKey { get; set; }
            public string buildConfigKey { get; set; }
            public string buildName { get; set; }
            public string buildID { get; set; }
        }

        /// <summary>
        /// Attempts to download the Version-File, updates the CheckSum and the Versions-Property if succesful
        /// </summary>
        /// <returns>bool: Download-Success</returns>
        public bool loadVersionFile() {

            //Download Versions-File String from BNet
            string versions_string = Utility.getString(this.versions_url);

            if (versions_string != null) {
                //Update Versions-File-CheckSum for this Game
                this.Versions_CheckSum = Utility.CreateMD5(versions_string);

                Dictionary<string, Version> vers = new Dictionary<string, Version>();

                //Generate Line By Line Associated Array
                List<Dictionary<string, string>> versions_data = Utility.deserializeBlizzTable(versions_string);

                foreach (Dictionary<string, string> _version in versions_data) {
                    vers.Add(_version["Region"], new Version(_version));
                }
                
                //Update Game.Versions Property
                this.Versions = vers;

                return true;

            } else {
                return false;
            }
        }
    }

}
