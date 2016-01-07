using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlizzardBuildTracker {
    public partial class SplashScreen : Form {
        private Tracker tracker;
        delegate void UpdateProgressCallback(Prog _p);

        public SplashScreen(ref Tracker _t) {
            this.Icon = BlizzardBuildTracker.Properties.Resources.phatso;
            InitializeComponent();
            this.tracker = _t;

            this.tracker.LoadingGame += OnLoadingGame;
        }


        private void OnLoadingGame(int _c, int _max,string _code) {
            int progress;
            string text;
            if ((_c - 1) == _max) {
                text = "Finished loading!";
                progress = 100;
            } else {
                double progressD = ((double)(_c - 1) / _max) * 100.0;
                progress = (int)progressD;
                text = "Loading: '" + _code + "' (" + _c + "/" + _max + ")";
            }

            updateProgress(new Prog() {Text = text, Value = progress});
            if((_c - 1) == _max) {
                Thread.Sleep(1000);
            }
        }

        class Prog {
            public string Text { get; set; }
            public int Value { get; set; }
        }


        private void updateProgress(Prog _p) {

            if (this.pBGamesLoaded.InvokeRequired | this.lbLoading.InvokeRequired) {
                UpdateProgressCallback pr = new UpdateProgressCallback(updateProgress);
                this.Invoke(pr, new object[] { _p });
            } else {
                this.lbLoading.Text = _p.Text;
                this.pBGamesLoaded.Value = _p.Value;
                this.lbLoading.Refresh();
                this.pBGamesLoaded.Refresh();
            }
        }

        public void KillMe(object o, EventArgs e) {
            this.Close();
        }


    }
}
