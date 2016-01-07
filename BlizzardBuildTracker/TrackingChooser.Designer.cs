namespace BlizzardBuildTracker {
    partial class TrackingChooser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnUpdateTrackingsStatuses = new System.Windows.Forms.Button();
            this.cLBGames = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnUpdateTrackingsStatuses
            // 
            this.btnUpdateTrackingsStatuses.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdateTrackingsStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateTrackingsStatuses.Location = new System.Drawing.Point(10, 149);
            this.btnUpdateTrackingsStatuses.MinimumSize = new System.Drawing.Size(150, 30);
            this.btnUpdateTrackingsStatuses.Name = "btnUpdateTrackingsStatuses";
            this.btnUpdateTrackingsStatuses.Size = new System.Drawing.Size(180, 41);
            this.btnUpdateTrackingsStatuses.TabIndex = 1;
            this.btnUpdateTrackingsStatuses.Text = "Update Settings";
            this.btnUpdateTrackingsStatuses.UseVisualStyleBackColor = true;
            this.btnUpdateTrackingsStatuses.Click += new System.EventHandler(this.btnUpdateTrackingsStatuses_Click);
            // 
            // cLBGames
            // 
            this.cLBGames.CheckOnClick = true;
            this.cLBGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.cLBGames.FormattingEnabled = true;
            this.cLBGames.Location = new System.Drawing.Point(10, 10);
            this.cLBGames.Name = "cLBGames";
            this.cLBGames.Size = new System.Drawing.Size(180, 139);
            this.cLBGames.TabIndex = 0;
            this.cLBGames.ThreeDCheckBoxes = true;
            // 
            // TrackingChooser
            // 
            this.AcceptButton = this.btnUpdateTrackingsStatuses;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.btnUpdateTrackingsStatuses);
            this.Controls.Add(this.cLBGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "TrackingChooser";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "TrackingChooser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateTrackingsStatuses;
        private System.Windows.Forms.CheckedListBox cLBGames;
    }
}