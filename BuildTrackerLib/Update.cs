using System;

namespace BuildTrackerLib {
    public static class Update {

        [Flags]
        public enum UpdateStatus : int {
            Unchanged = 0,
            Changed = 1,
            DLError = 2
        }


        //Update CDN Config
        /// <summary>
        /// Attempts to fetch the CDNConfig-File of CDNConfig _cdnc and updates CDNConfig _cdnc's Property if the Checksum has changed
        /// </summary>
        /// <param name="_cdnc">Reference to an instance of CDNConfig _cdnc</param>
        /// <returns>UpdateStatus (Changed,Unchanged,DLError)</returns>
        public static UpdateStatus updateCDNConfig(this CDNConfig _cdnc) {
            string current_Checksum = _cdnc.checksum;

            bool fetchSuccess = _cdnc.fetchCDNConfig();
            if (fetchSuccess) {
                string new_Checksum = _cdnc.checksum;
                if(current_Checksum == new_Checksum) {
                    return UpdateStatus.Unchanged;
                } else {

                    return UpdateStatus.Changed;
                }
            } else {
                return UpdateStatus.DLError;
            }
        }

        //Update CDNS-Property
        /// <summary>
        /// Attempts to fetch the CDNS-File of Game _G and updates the CDNS-Property of the Game
        /// </summary>
        /// <param name="_G">Reference to an instance of Game _G</param>
        /// <returns>UpdateStatus (Changed,Unchanged,DLError)</returns>
        public static UpdateStatus updateCDNS(this Game _G) {
            string current_Checksum = _G.CDNS_CheckSum;

            bool loadSuccess = _G.loadCDNSFile();
            if (loadSuccess) {
                string new_Checksum = _G.CDNS_CheckSum;
                if (current_Checksum == new_Checksum) {
                    return UpdateStatus.Unchanged;
                } else {
                    return UpdateStatus.Changed;
                }
            } else {
                return UpdateStatus.DLError;
            }
        }

        //Update CDNS-Property
        /// <summary>
        /// Attempts to fetch the Version-File of Game _G and updates the Versions-Property of the Game
        /// </summary>
        /// <param name="_G">Reference to an instance of Game _G</param>
        /// <returns>UpdateStatus (Changed,Unchanged,DLError)</returns>
        public static UpdateStatus updateVersions(this Game _G) {
            string current_CheckSum, new_CheckSum;
            current_CheckSum = _G.Versions_CheckSum;

            bool loadSuccess = _G.loadVersionFile();
            if (loadSuccess) {
                new_CheckSum = _G.Versions_CheckSum;
                if (current_CheckSum == new_CheckSum) {
                    return UpdateStatus.Unchanged;
                } else {
                    return UpdateStatus.Changed;
                }
            } else {
                return UpdateStatus.DLError;
            }
        }

    }
}
