using System;
using System.Collections.Generic;

namespace BuildTrackerLib
{
    public class Games
    {
        private enum GameCodes { agent, bnt, d3, d3cn, d3t, demo, hero, herot, hsb, pro, prodev, sc2, s2, s2t, s2b, test, storm, war3, wow, wowt, wow_beta };

        public static Game loadGame(string _GameCode) {
            if (System.Enum.IsDefined(typeof(GameCodes), _GameCode))
            {
                Console.WriteLine("Game {0} loaded!",_GameCode);
                Game game = new Game(_GameCode);
                return game;
            }
            else {
                throw new Exception("Not a legal GameCode!");
            }
        }


        public class Game {
            public string bnet_url,versions_url, cdns_url,dist_url;
            public ClientVersion client_version;
            public CDN cdn;
            public CDNConfig cdn_config;

            public Game(string _GameCode) {
                bnet_url = string.Format("http://us.patch.battle.net:1119/{0}",_GameCode);
                versions_url = string.Format("{0}/versions", bnet_url);
                cdns_url = string.Format("{0}/cdns", bnet_url);

                client_version = new ClientVersion(versions_url);
                cdn = new CDN(cdns_url);

                dist_url = string.Format("http://dist.blizzard.com.edgesuite.net/{0}/config", cdn.path);
                cdn_config = new CDNConfig(dist_url, client_version.cdnConfigHash);
            }



        }



    }
}
