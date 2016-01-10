using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlizzardBuildTracker {
    public partial class TrackingChooser : Form {
        Tracker tr;
        public TrackingChooser(ref Tracker _tracker) {
            this.tr = _tracker;
            InitializeComponent();
            InitiateCheckedListBox();
        }
        private void InitiateCheckedListBox() {
            foreach(var game in this.tr.Games) {
                this.cLBGames.Items.Add(game.Key, game.Value.isTracked);
            }
        }

        private void btnUpdateTrackingsStatuses_Click(object sender, EventArgs e) {
            bool Checked;
            string name;
            for (int i = 0; i < this.cLBGames.Items.Count; i++) {
                Checked = this.cLBGames.GetItemChecked(i);
                name = this.cLBGames.Items[i].ToString();
                this.tr.Games[name].isTracked = Checked;
            }
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
