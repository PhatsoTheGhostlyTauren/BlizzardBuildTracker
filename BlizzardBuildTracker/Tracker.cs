using BuildTrackerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace BlizzardBuildTracker {
    public partial class Tracker {

        public string[] GameCodes;
        public Dictionary<string, Game> Games;
        public Dictionary<string, CDNConfig> CDNConfigs;
        public Dictionary<string, BuildConfig> Builds;

        public SoundPlayer FelReaver;

        public Tracker(string[] _codes) {

            this.GameCodes = _codes;            
            
            this.Games = new Dictionary<string, Game>();
            this.Builds = new Dictionary<string, BuildConfig>();
            this.CDNConfigs = new Dictionary<string, CDNConfig>();

            this.FelReaver = new SoundPlayer(Properties.Resources.FelReaver);
        }

        #region "Initiation"
        //Iterate over GameCodes
        public void loadGames() {
            if (BuildTrackerLib.Utility.CheckForInternetConnection()) {
                this.Games = new Dictionary<string, BuildTrackerLib.Game>();
                int c = 1;
                foreach (string code in GameCodes) {
                    OnLoadingGame(c, GameCodes.Length, "Loading Game: " + code + " (" + c + "/" + GameCodes.Length + ")");
                    this.loadGame(code);
                    c++;
                }

                OnLoadingGame(c, GameCodes.Length, "Finished Loading!");
            } else {
                OnLoadingGame(2, 1, "No Internet-Connection!");
            }
        }

        //Create GameObject and expand the list of builds and cdnconfigs
        private void loadGame(string _code) {
            BuildTrackerLib.Game currentg = new BuildTrackerLib.Game(_code);
            this.Games.Add(_code, currentg);
            if (currentg.loadSuccess) {
                this.addCDNConfig(currentg.CDNConfig_Key, currentg.dist_url);
                if (CDNConfigs.ContainsKey(currentg.CDNConfig_Key)) {
                    this.addBuilds(CDNConfigs[currentg.CDNConfig_Key].build_keys, currentg.dist_url);
                }
            }
        }

        //Add CDNConfigs to Dictionary when not already in
        private bool addCDNConfig(string _cdnc_key, string _disturl) {
            if (this.CDNConfigs.ContainsKey(_cdnc_key)) {
                //Console.WriteLine("CDNConfig already added!");
                return false;
            } else {
                BuildTrackerLib.CDNConfig newCDNC = new BuildTrackerLib.CDNConfig(_disturl, _cdnc_key);
                if (newCDNC.loadSuccess) {
                    this.CDNConfigs.Add(_cdnc_key, newCDNC);
                    return true;
                } else {
                    return false;
                }
            }
        }
        //Add BuildConfigs to Dictionary when not already in
        private void addBuilds(string[] _buildKeys, string _disturl) {

            foreach (string _key in _buildKeys) {
                if (this.Builds.ContainsKey(_key)) {
                    //Console.WriteLine("Build '"+ buildkey +"' already added.");
                } else {
                    BuildTrackerLib.BuildConfig newBC = new BuildTrackerLib.BuildConfig(_disturl, _key);
                    if (newBC.loadSuccess) {
                        this.Builds.Add(_key, newBC);
                    }
                }
            }

        }
        #endregion

        #region "Display"
        //Games List
        public class GameItem {
            public string Name { get; set; }
            public string Value { get; set; }
        }


        public List<GameItem> listGames() {
            List<GameItem> items = new List<GameItem>();

            string[] codes = this.Games.Keys.ToArray();

            foreach (string code in codes) {
                items.Add(new GameItem() { Name = code, Value = code });
            }
            return items;
        }

        //CDNConfig Builds-List
        public class BuildItem {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public List<BuildItem> listCDNBuilds(string _code) {
            List<BuildItem> items = new List<BuildItem>();

            //If Game didnt succesfully load
            if (this.Games[_code].loadSuccess == false) {
                return items;
            }


            Game selectedGame = this.Games[_code];
            CDNConfig cdnC = this.CDNConfigs[selectedGame.CDNConfig_Key];

            foreach (string _key in cdnC.build_keys) {
                if (this.Builds.ContainsKey(_key)) {
                    items.Add(new BuildItem() { Name = this.Builds[_key].build_name, Value = _key });
                } else {
                    items.Add(new BuildItem() { Name = _key, Value = _key });
                }
            }

            return items;
        }

        //Regions List
        public class RegionItem {
            public string Name { get; set; }
            public string Value { get; set; }
        }


        public List<RegionItem> listRegions(string _code) {
            List<RegionItem> items = new List<RegionItem>();

            //If Game didnt succesfully load
            if (this.Games[_code].loadSuccess == false) {
                return items;
            }

            foreach (var version in this.Games[_code].Versions) {
                items.Add(new RegionItem() { Name = version.Value.region, Value = version.Value.region });
            }

            return items;
        }
        #endregion

        #region "Events"
        //Initiate EventHandler-Delegates
        public delegate void LoadingEventHandler(int _current, int _max, string _text);
        public delegate void TrackerEventHandler(string _code);

        //Register Events
        public event LoadingEventHandler LoadingGame;
        public event TrackerEventHandler VersionsUpdate;
        public event TrackerEventHandler CDNConfigUpdate;


        //Alert Event-Subscribers
        protected virtual void OnLoadingGame(int _current, int _max, string _text) {
            if (LoadingGame != null)
                LoadingGame(_current, _max, _text);
        }

        protected virtual void OnVersionsUpdate(string _code) {
            if (VersionsUpdate != null)
                VersionsUpdate(_code);
        }
        protected virtual void OnCDNConfigUpdate(string _code) {
            if (CDNConfigUpdate != null)
                CDNConfigUpdate(_code);
        }
        #endregion

        #region "Track-Routines"
        public void track() {
            //Console.WriteLine(DateTime.Now.ToString("hh:mm:ss") + ": track()");
            if (Utility.CheckForInternetConnection()) {
                List<string> disabledCodes = new List<string>();

                foreach (var _g in this.Games) {
                    Application.DoEvents();
                    if (_g.Value.isTracked) {
                        //Only Track if the Game was initiated Successful
                        if(_g.Value.loadSuccess == false) {
                            Log.WriteWarning("Gamecode '"+_g.Value.gamecode+"' wasnt successfully initiated! ", "Tracker:track()");
                            _g.Value.isTracked = false;
                            disabledCodes.Add(_g.Value.gamecode);
                        } else {
                            trackCDNConfig(_g.Value);
                            trackGame(_g.Value);
                        }
                    }
                }

                if (disabledCodes.Any()) {
                    Log.WriteMessage("The following Gamecodes have been disabled for Tracking: "+String.Join(", ",disabledCodes.ToArray()), "Tracker:track()");
                    Log.WriteMessage("Please restart the Tracker with a stable Connection to be able to be able to track any Gamecode.", "Tracker:track()");

                }


            } else {
                Log.WriteWarning("No Internet-Connection!", "Tracker:track()");
            }
        }


        public void trackCDNConfig(Game _g) {
            CDNConfig _cdnc = this.CDNConfigs[_g.CDNConfig_Key];

            //Store old Information Diff-Calculation
            string[] old_buildkeys = _cdnc.build_keys;

            Update.UpdateStatus cdnConfig_update = _cdnc.updateCDNConfig();

            if (cdnConfig_update == Update.UpdateStatus.Changed) {
                OnCDNConfigUpdate(_g.gamecode);
                Log.WriteSuccess(_g.gamecode + " CDNConfig-File has changed!", "Tracker:track()");

                string[] new_buildkeys = _cdnc.build_keys;

                string[] diff = Utility.getDifference(old_buildkeys, new_buildkeys);

                if (diff.Any()) {
                    List<string> added = new List<string>();
                    List<string> removed = new List<string>();

                    //Sort into added and removed List
                    foreach (string _key in diff) {
                        if (old_buildkeys.Contains(_key)) {
                            removed.Add(_key);
                        } else {
                            added.Add(_key);
                        }
                    }

                    //Log all added Builds by BuildName
                    if (added.Any()) {

                        this.addBuilds(added.ToArray(), _g.dist_url);


                        List<string> addedBuildNames = new List<string>();
                        foreach(string _key in added) {
                            addedBuildNames.Add(this.Builds[_key].build_name);
                        }
                        Log.WriteSuccess("New Builds: " + String.Join(", ",addedBuildNames.ToArray()), "BlizzardBuildTrackerForm:track()");

                        FelReaver.Play();
                    }

                    //Log all removed Builds by BuildHash
                    if (removed.Any()) {
                        string removedBuilds = string.Join(", ", removed.ToArray());
                        Log.WriteMessage("Removed Builds: " + removedBuilds, "BlizzardBuildTrackerForm:track()");
                    }

                }
            } else if (cdnConfig_update == Update.UpdateStatus.DLError) {
                Log.WriteWarning("Couldn't download CDNConfig-File for :" + _g.gamecode, "Tracker:track()");
            }

        }


        public void trackGame(Game _g) {
            // Version and CDN File

            Update.UpdateStatus cdns_update = _g.updateCDNS();
            Update.UpdateStatus versions_update = _g.updateVersions();

            //If the CDNS-File changed
            if (cdns_update == Update.UpdateStatus.Changed) {
                Log.WriteSuccess(_g.gamecode + " CDNS-File has changed!", "Tracker:track()");
            } else if (cdns_update == Update.UpdateStatus.DLError) {
                Log.WriteWarning("Couldn't download CDNS-File for Game:" + _g.gamecode, "Tracker:track()");
            }
            
            //If the VersionFile changed check if the CDNConfigKey is new and add to CDNConfigs if so
            if (versions_update == Update.UpdateStatus.Changed) {
                OnVersionsUpdate(_g.gamecode);
                Log.WriteSuccess(_g.gamecode + " Versions-File has changed!", "Tracker:track()");

                bool new_CDNConfig = this.addCDNConfig(_g.CDNConfig_Key, _g.dist_url);
                if (new_CDNConfig) {
                    Log.WriteSuccess(_g.gamecode + " has been assigned to a new CDNConfig.", "Tracker:track()");
                    this.addBuilds(this.CDNConfigs[_g.CDNConfig_Key].build_keys, _g.dist_url);
                }
            } else if (versions_update == Update.UpdateStatus.DLError) {
                Log.WriteWarning("Couldn't download Version-File for Game:" + _g.gamecode, "Tracker:track()");
            }          

        }
        #endregion







    }

}
