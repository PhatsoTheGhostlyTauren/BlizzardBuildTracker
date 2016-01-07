namespace BlizzardBuildTracker {
    partial class SplashScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pBGamesLoaded = new System.Windows.Forms.ProgressBar();
            this.lbLoading = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBGamesLoaded
            // 
            this.pBGamesLoaded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBGamesLoaded.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBGamesLoaded.ForeColor = System.Drawing.Color.Transparent;
            this.pBGamesLoaded.Location = new System.Drawing.Point(140, 200);
            this.pBGamesLoaded.Name = "pBGamesLoaded";
            this.pBGamesLoaded.Size = new System.Drawing.Size(450, 40);
            this.pBGamesLoaded.TabIndex = 0;
            // 
            // lbLoading
            // 
            this.lbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoading.BackColor = System.Drawing.Color.Transparent;
            this.lbLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLoading.Location = new System.Drawing.Point(140, 147);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(450, 40);
            this.lbLoading.TabIndex = 1;
            this.lbLoading.Text = "Loading...";
            this.lbLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(-205, -5);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(604, 257);
            this.Background.TabIndex = 2;
            this.Background.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlizzardBuildTracker.Properties.Resources.PhatsosBBT;
            this.pictureBox1.Location = new System.Drawing.Point(277, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 102);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.pBGamesLoaded);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "Loading Games";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBGamesLoaded;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}