using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;

namespace BlizzardBuildTracker {
    public class Tracker {

        private string[] GameCodes;
        public Dictionary<string, BuildTrackerLib.Game> Games;
        private Dictionary<string, BuildTrackerLib.CDNConfig> CDNConfigs;
        private Dictionary<string, BuildTrackerLib.BuildConfig> Builds;

        private SoundPlayer FelReaver;


        public BuildTrackerLib.Log log;

        public Tracker(string[] _codes, BuildTrackerLib.Log _l) {
            this.GameCodes = _codes;            
            this.log = _l;
            this.Games = new Dictionary<string, BuildTrackerLib.Game>();
            this.Builds = new Dictionary<string, BuildTrackerLib.BuildConfig>();
            this.CDNConfigs = new Dictionary<string, BuildTrackerLib.CDNConfig>();

            this.FelReaver = new SoundPlayer(Properties.Resources.FelReaver);
        }

        public BuildTrackerLib.CDNConfig getCDNConfigByKey(string _key) {
            return this.CDNConfigs[_key];
        }
        public BuildTrackerLib.BuildConfig getBuildConfigByKey(string _key) {
            return this.Builds[_key];
        }
        public BuildTrackerLib.ClientVersion getClientVersionByKey(string _key) {
            return this.Games[_key].getClientVersion();
        }
        

        //Initiate EventHandlesr
        public delegate void LoadingEventHandler(int _current, int _max, string _code);
        public delegate void TrackerEventHandler(string _code);

        //Register Events
        public event LoadingEventHandler LoadingGame;
        public event TrackerEventHandler ClientUpdate;
        public event TrackerEventHandler CDNConfigUpdate;


        //Alert Event-Subscribers
        protected virtual void OnLoadingGame(int _current, int _max, string _code) {
            if (LoadingGame != null)
                LoadingGame(_current, _max, _code);
        }

        protected virtual void OnClientUpdate(string _code) {
            if (ClientUpdate != null)
                ClientUpdate(_code);
        }
        protected virtual void OnCDNConfigUpdate(string _code) {
            if (CDNConfigUpdate != null)
                CDNConfigUpdate(_code);
        }


        //Iterate over GameCodes
        public void loadGames() {
            this.Games = new Dictionary<string, BuildTrackerLib.Game>();
            int c = 1;
            foreach(string code in GameCodes) {
                OnLoadingGame(c, GameCodes.Length, code);
                this.loadGame(code);
                c++;
            }

            OnLoadingGame(c, GameCodes.Length, "all");
        }

        //Create GameObject and expand the list of builds and cdnconfigs
        private void loadGame(string _code) {
            BuildTrackerLib.Game currentg = new BuildTrackerLib.Game(_code, ref this.log);
            this.Games.Add(_code,currentg);
            this.addCDNConfig(currentg.getCDNConfig());
            this.addBuilds(currentg);
        }

        //Add CDNConfigs to Dictionary when not already in
        private void addCDNConfig(BuildTrackerLib.CDNConfig _cdnc) {
            if (this.CDNConfigs.ContainsKey(_cdnc.getConfigKey())) {
                //Console.WriteLine("CDNConfig already added!");
            } else {
                this.CDNConfigs.Add(_cdnc.getConfigKey(), _cdnc);
            }
        }
        //Add BuildConfigs to Dictionary when not already in
        private void addBuilds(BuildTrackerLib.Game _g) {
            string[] keys = this.CDNConfigs[_g.getClientVersion().getCDNConfigKey()].getBuildKeys();
            foreach (string buildkey in keys) {
                if (this.Builds.ContainsKey(buildkey)) {
                    //Console.WriteLine("Build '"+ buildkey +"' already added.");
                } else {
                    this.Builds.Add(buildkey, new BuildTrackerLib.BuildConfig(_g.getDistUrl(), buildkey, ref this.log));
                }
            }

        }



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
            BuildTrackerLib.Game selectedGame = this.Games[_code];
            BuildTrackerLib.CDNConfig cdnC = this.CDNConfigs[selectedGame.getClientVersion().getCDNConfigKey()];

            List<BuildItem> items = new List<BuildItem>();

            foreach (string buildkey in cdnC.getBuildKeys()) {
                items.Add(new BuildItem() { Name = this.Builds[buildkey].getBuildName(), Value = buildkey });
            }

            return items;
        }

        //call CheckForUpdate-Routines

        public void track() {
            //Console.WriteLine(DateTime.Now.ToString("hh:mm:ss") + ": track()");
            Dictionary<string, BuildTrackerLib.Game> allGames = this.Games;
            bool cvUpdated = false;
            bool cdnConfUpdated = false;
            string[] old_buildkeys, new_buildkeys, diff;



            foreach (var currentG in allGames) {
                if (currentG.Value.getTrackingStatus()) {
                    old_buildkeys = currentG.Value.getCDNConfig().getBuildKeys();
                    cvUpdated = currentG.Value.CheckClientVersion();
                    cdnConfUpdated = this.CDNConfigs[currentG.Value.getClientVersion().getCDNConfigKey()].checkForUpdates();

                    //Do when ClientVersion has been updated
                    if (cvUpdated) {
                        OnClientUpdate(currentG.Key); // Fire Events
                        this.log.WriteSuccess("A new Build has been pushed to the '"+currentG.Key+"' Client: "+currentG.Value.getClientVersion().getBuildName(), "Tracker:track()");
                    }

                    //DO when CDNConfig has been updated
                    if (cdnConfUpdated) {
                        new_buildkeys = currentG.Value.getCDNConfig().getBuildKeys();
                        diff = BuildTrackerLib.Utility.getDifference(old_buildkeys, new_buildkeys);
                        this.addBuilds(currentG.Value);

                        //if diff isnt empty sort in added and removed list
                        if (diff.Any()) {
                            this.log.WriteSuccess("CDNConfig for Code '" + currentG.Key + "' has changed!", "Tracker:track()");
                            List<string> added = new List<string>();
                            List<string> removed = new List<string>();

                            //Sort into added and removed List
                            foreach (string _key in diff) {
                                if (old_buildkeys.Contains(_key)) {
                                    removed.Add(_key);
                                } else {
                                    added.Add(this.getBuildConfigByKey(_key).getBuildName());
                                }
                            }

                            //Log all added Builds by BuildName
                            if (added.Any()) {
                                string addedBuilds = string.Join(", ", added.ToArray());
                                log.WriteSuccess("New Builds: " + addedBuilds, "BlizzardBuildTrackerForm:track()");

                                FelReaver.Play();
                            }

                            //Log all removed Builds by BuildHash
                            if (removed.Any()) {
                                string removedBuilds = string.Join(", ", removed.ToArray());
                                log.WriteMessage("Removed Builds: " + removedBuilds, "BlizzardBuildTrackerForm:track()");
                            }                            

                        }

                        //Clear CDNConf-Update related helper arrays
                        Array.Clear(new_buildkeys, 0, new_buildkeys.Length);
                        Array.Clear(diff, 0, diff.Length);
                    }

                    //reset for Iteration
                    cvUpdated = false;
                    cdnConfUpdated = false;
                    Array.Clear(old_buildkeys,0,old_buildkeys.Length);
                    
                } 
            }

        }




    }

}
