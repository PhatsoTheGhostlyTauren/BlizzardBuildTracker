namespace BlizzardBuildTracker
{
    partial class BlizzardBuildTrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlizzardBuildTrackerForm));
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lbCDNBuilds = new System.Windows.Forms.ListBox();
            this.lbCDNBuildKey = new System.Windows.Forms.Label();
            this.tbCDNBuildKey = new System.Windows.Forms.TextBox();
            this.lbCDNBuildUID = new System.Windows.Forms.Label();
            this.tbCDNBuildUID = new System.Windows.Forms.TextBox();
            this.lbCDNBuildName = new System.Windows.Forms.Label();
            this.tbCDNBuildName = new System.Windows.Forms.TextBox();
            this.lbCDNBuildRootKey = new System.Windows.Forms.Label();
            this.tbCDNBuildRootKey = new System.Windows.Forms.TextBox();
            this.lbCDNBuildInstallKey = new System.Windows.Forms.Label();
            this.tbCDNBuildInstallKey = new System.Windows.Forms.TextBox();
            this.lbCDNBuildDownloadKey = new System.Windows.Forms.Label();
            this.tbCDNBuildDownloadKey = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatchSize = new System.Windows.Forms.Label();
            this.tbCDNBuildPatchSize = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatchKey = new System.Windows.Forms.Label();
            this.tbCDNBuildPatchKey = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatchConfigKey = new System.Windows.Forms.Label();
            this.tbCDNBuildPatchConfigKey = new System.Windows.Forms.TextBox();
            this.lbCDNBuildEncodingKeys = new System.Windows.Forms.Label();
            this.tbCDNBuildEncodingKeys = new System.Windows.Forms.TextBox();
            this.lbCDNBuildEncodingSize = new System.Windows.Forms.Label();
            this.tbCDNBuildEncodingSize = new System.Windows.Forms.TextBox();
            this.sCCDNConfig = new System.Windows.Forms.SplitContainer();
            this.lbCVBuildID = new System.Windows.Forms.Label();
            this.tbCVBuildID = new System.Windows.Forms.TextBox();
            this.lbCVRegion = new System.Windows.Forms.Label();
            this.tbCVRegion = new System.Windows.Forms.TextBox();
            this.lbCVBuildName = new System.Windows.Forms.Label();
            this.tbCVBuildName = new System.Windows.Forms.TextBox();
            this.lbCVBuildConfigKey = new System.Windows.Forms.Label();
            this.tbCVBuildConfigKey = new System.Windows.Forms.TextBox();
            this.lbCVCDNConfigKey = new System.Windows.Forms.Label();
            this.tbCVCDNConfigKey = new System.Windows.Forms.TextBox();
            this.scGameVersion = new System.Windows.Forms.SplitContainer();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.panelSpacer1 = new System.Windows.Forms.Panel();
            this.pnLogControl = new System.Windows.Forms.Panel();
            this.btnOpenTrackerChooser = new System.Windows.Forms.Button();
            this.btnTrackerToggle = new System.Windows.Forms.Button();
            this.numUDTrackerDelay = new System.Windows.Forms.NumericUpDown();
            this.lbTrackerDelay = new System.Windows.Forms.Label();
            this.TrackerTimer = new System.Windows.Forms.Timer(this.components);
            this.panelSpacer2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sCCDNConfig)).BeginInit();
            this.sCCDNConfig.Panel1.SuspendLayout();
            this.sCCDNConfig.Panel2.SuspendLayout();
            this.sCCDNConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGameVersion)).BeginInit();
            this.scGameVersion.Panel1.SuspendLayout();
            this.scGameVersion.Panel2.SuspendLayout();
            this.scGameVersion.SuspendLayout();
            this.pnLogControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTrackerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(5, 494);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(1090, 201);
            this.rtbLog.TabIndex = 6;
            this.rtbLog.Text = "";
            // 
            // lbCDNBuilds
            // 
            this.lbCDNBuilds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCDNBuilds.FormattingEnabled = true;
            this.lbCDNBuilds.IntegralHeight = false;
            this.lbCDNBuilds.Location = new System.Drawing.Point(0, 0);
            this.lbCDNBuilds.Margin = new System.Windows.Forms.Padding(0);
            this.lbCDNBuilds.Name = "lbCDNBuilds";
            this.lbCDNBuilds.Size = new System.Drawing.Size(476, 272);
            this.lbCDNBuilds.TabIndex = 5;
            this.lbCDNBuilds.SelectedIndexChanged += new System.EventHandler(this.lbCDNBuilds_SelectedIndexChanged);
            // 
            // lbCDNBuildKey
            // 
            this.lbCDNBuildKey.AutoSize = true;
            this.lbCDNBuildKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildKey.Location = new System.Drawing.Point(8, 6);
            this.lbCDNBuildKey.Name = "lbCDNBuildKey";
            this.lbCDNBuildKey.Size = new System.Drawing.Size(83, 22);
            this.lbCDNBuildKey.TabIndex = 26;
            this.lbCDNBuildKey.Text = "Build-Key:";
            // 
            // tbCDNBuildKey
            // 
            this.tbCDNBuildKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildKey.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildKey.Location = new System.Drawing.Point(128, 7);
            this.tbCDNBuildKey.Name = "tbCDNBuildKey";
            this.tbCDNBuildKey.ReadOnly = true;
            this.tbCDNBuildKey.Size = new System.Drawing.Size(238, 20);
            this.tbCDNBuildKey.TabIndex = 27;
            // 
            // lbCDNBuildUID
            // 
            this.lbCDNBuildUID.AutoSize = true;
            this.lbCDNBuildUID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildUID.Location = new System.Drawing.Point(372, 6);
            this.lbCDNBuildUID.Name = "lbCDNBuildUID";
            this.lbCDNBuildUID.Size = new System.Drawing.Size(81, 22);
            this.lbCDNBuildUID.TabIndex = 28;
            this.lbCDNBuildUID.Text = "Build-UID:";
            // 
            // tbCDNBuildUID
            // 
            this.tbCDNBuildUID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildUID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildUID.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildUID.Location = new System.Drawing.Point(469, 7);
            this.tbCDNBuildUID.Name = "tbCDNBuildUID";
            this.tbCDNBuildUID.ReadOnly = true;
            this.tbCDNBuildUID.Size = new System.Drawing.Size(120, 20);
            this.tbCDNBuildUID.TabIndex = 29;
            // 
            // lbCDNBuildName
            // 
            this.lbCDNBuildName.AutoSize = true;
            this.lbCDNBuildName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildName.Location = new System.Drawing.Point(8, 32);
            this.lbCDNBuildName.Name = "lbCDNBuildName";
            this.lbCDNBuildName.Size = new System.Drawing.Size(97, 22);
            this.lbCDNBuildName.TabIndex = 30;
            this.lbCDNBuildName.Text = "Build-Name:";
            // 
            // tbCDNBuildName
            // 
            this.tbCDNBuildName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildName.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildName.Location = new System.Drawing.Point(128, 33);
            this.tbCDNBuildName.Name = "tbCDNBuildName";
            this.tbCDNBuildName.ReadOnly = true;
            this.tbCDNBuildName.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildName.TabIndex = 31;
            // 
            // lbCDNBuildRootKey
            // 
            this.lbCDNBuildRootKey.AutoSize = true;
            this.lbCDNBuildRootKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildRootKey.Location = new System.Drawing.Point(8, 58);
            this.lbCDNBuildRootKey.Name = "lbCDNBuildRootKey";
            this.lbCDNBuildRootKey.Size = new System.Drawing.Size(48, 22);
            this.lbCDNBuildRootKey.TabIndex = 32;
            this.lbCDNBuildRootKey.Text = "Root:";
            // 
            // tbCDNBuildRootKey
            // 
            this.tbCDNBuildRootKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildRootKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildRootKey.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildRootKey.Location = new System.Drawing.Point(128, 59);
            this.tbCDNBuildRootKey.Name = "tbCDNBuildRootKey";
            this.tbCDNBuildRootKey.ReadOnly = true;
            this.tbCDNBuildRootKey.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildRootKey.TabIndex = 33;
            // 
            // lbCDNBuildInstallKey
            // 
            this.lbCDNBuildInstallKey.AutoSize = true;
            this.lbCDNBuildInstallKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildInstallKey.Location = new System.Drawing.Point(8, 84);
            this.lbCDNBuildInstallKey.Name = "lbCDNBuildInstallKey";
            this.lbCDNBuildInstallKey.Size = new System.Drawing.Size(56, 22);
            this.lbCDNBuildInstallKey.TabIndex = 34;
            this.lbCDNBuildInstallKey.Text = "Install:";
            // 
            // tbCDNBuildInstallKey
            // 
            this.tbCDNBuildInstallKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildInstallKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildInstallKey.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildInstallKey.Location = new System.Drawing.Point(128, 85);
            this.tbCDNBuildInstallKey.Name = "tbCDNBuildInstallKey";
            this.tbCDNBuildInstallKey.ReadOnly = true;
            this.tbCDNBuildInstallKey.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildInstallKey.TabIndex = 35;
            // 
            // lbCDNBuildDownloadKey
            // 
            this.lbCDNBuildDownloadKey.AutoSize = true;
            this.lbCDNBuildDownloadKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildDownloadKey.Location = new System.Drawing.Point(8, 110);
            this.lbCDNBuildDownloadKey.Name = "lbCDNBuildDownloadKey";
            this.lbCDNBuildDownloadKey.Size = new System.Drawing.Size(86, 22);
            this.lbCDNBuildDownloadKey.TabIndex = 36;
            this.lbCDNBuildDownloadKey.Text = "Download:";
            // 
            // tbCDNBuildDownloadKey
            // 
            this.tbCDNBuildDownloadKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildDownloadKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildDownloadKey.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildDownloadKey.Location = new System.Drawing.Point(128, 111);
            this.tbCDNBuildDownloadKey.Name = "tbCDNBuildDownloadKey";
            this.tbCDNBuildDownloadKey.ReadOnly = true;
            this.tbCDNBuildDownloadKey.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildDownloadKey.TabIndex = 37;
            // 
            // lbCDNBuildPatchSize
            // 
            this.lbCDNBuildPatchSize.AutoSize = true;
            this.lbCDNBuildPatchSize.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildPatchSize.Location = new System.Drawing.Point(8, 162);
            this.lbCDNBuildPatchSize.Name = "lbCDNBuildPatchSize";
            this.lbCDNBuildPatchSize.Size = new System.Drawing.Size(91, 22);
            this.lbCDNBuildPatchSize.TabIndex = 38;
            this.lbCDNBuildPatchSize.Text = "Patch-Size:";
            // 
            // tbCDNBuildPatchSize
            // 
            this.tbCDNBuildPatchSize.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildPatchSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildPatchSize.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildPatchSize.Location = new System.Drawing.Point(128, 163);
            this.tbCDNBuildPatchSize.Name = "tbCDNBuildPatchSize";
            this.tbCDNBuildPatchSize.ReadOnly = true;
            this.tbCDNBuildPatchSize.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildPatchSize.TabIndex = 39;
            // 
            // lbCDNBuildPatchKey
            // 
            this.lbCDNBuildPatchKey.AutoSize = true;
            this.lbCDNBuildPatchKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildPatchKey.Location = new System.Drawing.Point(8, 136);
            this.lbCDNBuildPatchKey.Name = "lbCDNBuildPatchKey";
            this.lbCDNBuildPatchKey.Size = new System.Drawing.Size(55, 22);
            this.lbCDNBuildPatchKey.TabIndex = 40;
            this.lbCDNBuildPatchKey.Text = "Patch:";
            // 
            // tbCDNBuildPatchKey
            // 
            this.tbCDNBuildPatchKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildPatchKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildPatchKey.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildPatchKey.Location = new System.Drawing.Point(128, 137);
            this.tbCDNBuildPatchKey.Name = "tbCDNBuildPatchKey";
            this.tbCDNBuildPatchKey.ReadOnly = true;
            this.tbCDNBuildPatchKey.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildPatchKey.TabIndex = 41;
            // 
            // lbCDNBuildPatchConfigKey
            // 
            this.lbCDNBuildPatchConfigKey.AutoSize = true;
            this.lbCDNBuildPatchConfigKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildPatchConfigKey.Location = new System.Drawing.Point(8, 188);
            this.lbCDNBuildPatchConfigKey.Name = "lbCDNBuildPatchConfigKey";
            this.lbCDNBuildPatchConfigKey.Size = new System.Drawing.Size(107, 22);
            this.lbCDNBuildPatchConfigKey.TabIndex = 42;
            this.lbCDNBuildPatchConfigKey.Text = "Patch-Config:";
            // 
            // tbCDNBuildPatchConfigKey
            // 
            this.tbCDNBuildPatchConfigKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildPatchConfigKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildPatchConfigKey.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildPatchConfigKey.Location = new System.Drawing.Point(128, 189);
            this.tbCDNBuildPatchConfigKey.Name = "tbCDNBuildPatchConfigKey";
            this.tbCDNBuildPatchConfigKey.ReadOnly = true;
            this.tbCDNBuildPatchConfigKey.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildPatchConfigKey.TabIndex = 43;
            // 
            // lbCDNBuildEncodingKeys
            // 
            this.lbCDNBuildEncodingKeys.AutoSize = true;
            this.lbCDNBuildEncodingKeys.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildEncodingKeys.Location = new System.Drawing.Point(8, 214);
            this.lbCDNBuildEncodingKeys.Name = "lbCDNBuildEncodingKeys";
            this.lbCDNBuildEncodingKeys.Size = new System.Drawing.Size(80, 22);
            this.lbCDNBuildEncodingKeys.TabIndex = 44;
            this.lbCDNBuildEncodingKeys.Text = "Encoding:";
            // 
            // tbCDNBuildEncodingKeys
            // 
            this.tbCDNBuildEncodingKeys.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildEncodingKeys.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildEncodingKeys.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildEncodingKeys.Location = new System.Drawing.Point(128, 215);
            this.tbCDNBuildEncodingKeys.Name = "tbCDNBuildEncodingKeys";
            this.tbCDNBuildEncodingKeys.ReadOnly = true;
            this.tbCDNBuildEncodingKeys.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildEncodingKeys.TabIndex = 45;
            // 
            // lbCDNBuildEncodingSize
            // 
            this.lbCDNBuildEncodingSize.AutoSize = true;
            this.lbCDNBuildEncodingSize.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildEncodingSize.Location = new System.Drawing.Point(8, 240);
            this.lbCDNBuildEncodingSize.Name = "lbCDNBuildEncodingSize";
            this.lbCDNBuildEncodingSize.Size = new System.Drawing.Size(116, 22);
            this.lbCDNBuildEncodingSize.TabIndex = 46;
            this.lbCDNBuildEncodingSize.Text = "Encoding-Size:";
            // 
            // tbCDNBuildEncodingSize
            // 
            this.tbCDNBuildEncodingSize.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildEncodingSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildEncodingSize.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildEncodingSize.Location = new System.Drawing.Point(128, 241);
            this.tbCDNBuildEncodingSize.Name = "tbCDNBuildEncodingSize";
            this.tbCDNBuildEncodingSize.ReadOnly = true;
            this.tbCDNBuildEncodingSize.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildEncodingSize.TabIndex = 47;
            // 
            // sCCDNConfig
            // 
            this.sCCDNConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.sCCDNConfig.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sCCDNConfig.IsSplitterFixed = true;
            this.sCCDNConfig.Location = new System.Drawing.Point(5, 161);
            this.sCCDNConfig.Margin = new System.Windows.Forms.Padding(0);
            this.sCCDNConfig.Name = "sCCDNConfig";
            // 
            // sCCDNConfig.Panel1
            // 
            this.sCCDNConfig.Panel1.BackColor = System.Drawing.Color.Silver;
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildEncodingSize);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildEncodingSize);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildEncodingKeys);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildEncodingKeys);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildPatchConfigKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildPatchConfigKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildPatchKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildPatchKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildPatchSize);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildPatchSize);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildDownloadKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildDownloadKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildInstallKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildInstallKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildRootKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildRootKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildName);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildName);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildUID);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildUID);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildKey);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildKey);
            // 
            // sCCDNConfig.Panel2
            // 
            this.sCCDNConfig.Panel2.Controls.Add(this.lbCDNBuilds);
            this.sCCDNConfig.Size = new System.Drawing.Size(1090, 272);
            this.sCCDNConfig.SplitterDistance = 604;
            this.sCCDNConfig.SplitterWidth = 10;
            this.sCCDNConfig.TabIndex = 9;
            // 
            // lbCVBuildID
            // 
            this.lbCVBuildID.AutoSize = true;
            this.lbCVBuildID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVBuildID.Location = new System.Drawing.Point(3, 4);
            this.lbCVBuildID.Name = "lbCVBuildID";
            this.lbCVBuildID.Size = new System.Drawing.Size(71, 22);
            this.lbCVBuildID.TabIndex = 14;
            this.lbCVBuildID.Text = "Build-ID:";
            // 
            // tbCVBuildID
            // 
            this.tbCVBuildID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVBuildID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVBuildID.ForeColor = System.Drawing.Color.Black;
            this.tbCVBuildID.Location = new System.Drawing.Point(100, 5);
            this.tbCVBuildID.Name = "tbCVBuildID";
            this.tbCVBuildID.ReadOnly = true;
            this.tbCVBuildID.Size = new System.Drawing.Size(171, 20);
            this.tbCVBuildID.TabIndex = 15;
            // 
            // lbCVRegion
            // 
            this.lbCVRegion.AutoSize = true;
            this.lbCVRegion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVRegion.Location = new System.Drawing.Point(319, 3);
            this.lbCVRegion.Name = "lbCVRegion";
            this.lbCVRegion.Size = new System.Drawing.Size(63, 22);
            this.lbCVRegion.TabIndex = 16;
            this.lbCVRegion.Text = "Region:";
            // 
            // tbCVRegion
            // 
            this.tbCVRegion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVRegion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVRegion.ForeColor = System.Drawing.Color.Black;
            this.tbCVRegion.Location = new System.Drawing.Point(413, 5);
            this.tbCVRegion.Name = "tbCVRegion";
            this.tbCVRegion.ReadOnly = true;
            this.tbCVRegion.Size = new System.Drawing.Size(171, 20);
            this.tbCVRegion.TabIndex = 17;
            // 
            // lbCVBuildName
            // 
            this.lbCVBuildName.AutoSize = true;
            this.lbCVBuildName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVBuildName.Location = new System.Drawing.Point(3, 35);
            this.lbCVBuildName.Name = "lbCVBuildName";
            this.lbCVBuildName.Size = new System.Drawing.Size(97, 22);
            this.lbCVBuildName.TabIndex = 18;
            this.lbCVBuildName.Text = "Build-Name:";
            // 
            // tbCVBuildName
            // 
            this.tbCVBuildName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVBuildName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVBuildName.ForeColor = System.Drawing.Color.Black;
            this.tbCVBuildName.Location = new System.Drawing.Point(100, 36);
            this.tbCVBuildName.Name = "tbCVBuildName";
            this.tbCVBuildName.ReadOnly = true;
            this.tbCVBuildName.Size = new System.Drawing.Size(484, 20);
            this.tbCVBuildName.TabIndex = 19;
            // 
            // lbCVBuildConfigKey
            // 
            this.lbCVBuildConfigKey.AutoSize = true;
            this.lbCVBuildConfigKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVBuildConfigKey.Location = new System.Drawing.Point(3, 68);
            this.lbCVBuildConfigKey.Name = "lbCVBuildConfigKey";
            this.lbCVBuildConfigKey.Size = new System.Drawing.Size(97, 22);
            this.lbCVBuildConfigKey.TabIndex = 20;
            this.lbCVBuildConfigKey.Text = "BuildConfig:";
            // 
            // tbCVBuildConfigKey
            // 
            this.tbCVBuildConfigKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVBuildConfigKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVBuildConfigKey.ForeColor = System.Drawing.Color.Black;
            this.tbCVBuildConfigKey.Location = new System.Drawing.Point(100, 69);
            this.tbCVBuildConfigKey.Name = "tbCVBuildConfigKey";
            this.tbCVBuildConfigKey.ReadOnly = true;
            this.tbCVBuildConfigKey.Size = new System.Drawing.Size(484, 20);
            this.tbCVBuildConfigKey.TabIndex = 21;
            // 
            // lbCVCDNConfigKey
            // 
            this.lbCVCDNConfigKey.AutoSize = true;
            this.lbCVCDNConfigKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVCDNConfigKey.Location = new System.Drawing.Point(3, 101);
            this.lbCVCDNConfigKey.Name = "lbCVCDNConfigKey";
            this.lbCVCDNConfigKey.Size = new System.Drawing.Size(92, 22);
            this.lbCVCDNConfigKey.TabIndex = 22;
            this.lbCVCDNConfigKey.Text = "CDNConfig:";
            // 
            // tbCVCDNConfigKey
            // 
            this.tbCVCDNConfigKey.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVCDNConfigKey.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVCDNConfigKey.ForeColor = System.Drawing.Color.Black;
            this.tbCVCDNConfigKey.Location = new System.Drawing.Point(100, 102);
            this.tbCVCDNConfigKey.Name = "tbCVCDNConfigKey";
            this.tbCVCDNConfigKey.ReadOnly = true;
            this.tbCVCDNConfigKey.Size = new System.Drawing.Size(484, 20);
            this.tbCVCDNConfigKey.TabIndex = 23;
            // 
            // scGameVersion
            // 
            this.scGameVersion.BackColor = System.Drawing.Color.Silver;
            this.scGameVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.scGameVersion.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scGameVersion.IsSplitterFixed = true;
            this.scGameVersion.Location = new System.Drawing.Point(5, 5);
            this.scGameVersion.Margin = new System.Windows.Forms.Padding(10);
            this.scGameVersion.Name = "scGameVersion";
            // 
            // scGameVersion.Panel1
            // 
            this.scGameVersion.Panel1.Controls.Add(this.lbGames);
            // 
            // scGameVersion.Panel2
            // 
            this.scGameVersion.Panel2.BackColor = System.Drawing.Color.Silver;
            this.scGameVersion.Panel2.Controls.Add(this.tbCVCDNConfigKey);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVCDNConfigKey);
            this.scGameVersion.Panel2.Controls.Add(this.tbCVBuildConfigKey);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVBuildConfigKey);
            this.scGameVersion.Panel2.Controls.Add(this.tbCVBuildName);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVBuildName);
            this.scGameVersion.Panel2.Controls.Add(this.tbCVRegion);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVRegion);
            this.scGameVersion.Panel2.Controls.Add(this.tbCVBuildID);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVBuildID);
            this.scGameVersion.Size = new System.Drawing.Size(1090, 129);
            this.scGameVersion.SplitterDistance = 482;
            this.scGameVersion.TabIndex = 7;
            // 
            // lbGames
            // 
            this.lbGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGames.FormattingEnabled = true;
            this.lbGames.IntegralHeight = false;
            this.lbGames.Location = new System.Drawing.Point(0, 0);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(482, 129);
            this.lbGames.TabIndex = 0;
            this.lbGames.SelectedIndexChanged += new System.EventHandler(this.lbGames_SelectedIndexChanged);
            // 
            // panelSpacer1
            // 
            this.panelSpacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpacer1.Location = new System.Drawing.Point(5, 134);
            this.panelSpacer1.Name = "panelSpacer1";
            this.panelSpacer1.Size = new System.Drawing.Size(1090, 27);
            this.panelSpacer1.TabIndex = 8;
            // 
            // pnLogControl
            // 
            this.pnLogControl.BackColor = System.Drawing.Color.Silver;
            this.pnLogControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogControl.Controls.Add(this.btnOpenTrackerChooser);
            this.pnLogControl.Controls.Add(this.btnTrackerToggle);
            this.pnLogControl.Controls.Add(this.numUDTrackerDelay);
            this.pnLogControl.Controls.Add(this.lbTrackerDelay);
            this.pnLogControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogControl.Location = new System.Drawing.Point(5, 469);
            this.pnLogControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnLogControl.Name = "pnLogControl";
            this.pnLogControl.Size = new System.Drawing.Size(1090, 25);
            this.pnLogControl.TabIndex = 10;
            // 
            // btnOpenTrackerChooser
            // 
            this.btnOpenTrackerChooser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenTrackerChooser.Location = new System.Drawing.Point(968, 0);
            this.btnOpenTrackerChooser.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenTrackerChooser.Name = "btnOpenTrackerChooser";
            this.btnOpenTrackerChooser.Size = new System.Drawing.Size(120, 23);
            this.btnOpenTrackerChooser.TabIndex = 9;
            this.btnOpenTrackerChooser.Text = "Choose Trackers";
            this.btnOpenTrackerChooser.UseVisualStyleBackColor = true;
            this.btnOpenTrackerChooser.Click += new System.EventHandler(this.btnOpenTrackerChooser_Click);
            // 
            // btnTrackerToggle
            // 
            this.btnTrackerToggle.Location = new System.Drawing.Point(256, 0);
            this.btnTrackerToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrackerToggle.Name = "btnTrackerToggle";
            this.btnTrackerToggle.Size = new System.Drawing.Size(120, 23);
            this.btnTrackerToggle.TabIndex = 8;
            this.btnTrackerToggle.Text = "Start Tracking";
            this.btnTrackerToggle.UseVisualStyleBackColor = true;
            this.btnTrackerToggle.Click += new System.EventHandler(this.btnTrackerToggle_Click);
            // 
            // numUDTrackerDelay
            // 
            this.numUDTrackerDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDTrackerDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDTrackerDelay.Location = new System.Drawing.Point(127, 1);
            this.numUDTrackerDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDTrackerDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDTrackerDelay.Name = "numUDTrackerDelay";
            this.numUDTrackerDelay.Size = new System.Drawing.Size(120, 21);
            this.numUDTrackerDelay.TabIndex = 7;
            this.numUDTrackerDelay.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numUDTrackerDelay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUDTrackerDelay.ValueChanged += new System.EventHandler(this.numUDTrackerDelay_ValueChanged);
            // 
            // lbTrackerDelay
            // 
            this.lbTrackerDelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTrackerDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackerDelay.Location = new System.Drawing.Point(3, 1);
            this.lbTrackerDelay.Name = "lbTrackerDelay";
            this.lbTrackerDelay.Size = new System.Drawing.Size(139, 21);
            this.lbTrackerDelay.TabIndex = 6;
            this.lbTrackerDelay.Text = "Tracker-Interval:";
            // 
            // TrackerTimer
            // 
            this.TrackerTimer.Interval = 99999;
            this.TrackerTimer.Tick += new System.EventHandler(this.TrackerTimer_Tick);
            // 
            // panelSpacer2
            // 
            this.panelSpacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpacer2.Location = new System.Drawing.Point(5, 433);
            this.panelSpacer2.Name = "panelSpacer2";
            this.panelSpacer2.Size = new System.Drawing.Size(1090, 36);
            this.panelSpacer2.TabIndex = 11;
            // 
            // BlizzardBuildTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.pnLogControl);
            this.Controls.Add(this.panelSpacer2);
            this.Controls.Add(this.sCCDNConfig);
            this.Controls.Add(this.panelSpacer1);
            this.Controls.Add(this.scGameVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlizzardBuildTrackerForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Blizzard Build Tracker";
            this.Load += new System.EventHandler(this.BlizzardBuildTrackerForm_Load);
            this.sCCDNConfig.Panel1.ResumeLayout(false);
            this.sCCDNConfig.Panel1.PerformLayout();
            this.sCCDNConfig.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCCDNConfig)).EndInit();
            this.sCCDNConfig.ResumeLayout(false);
            this.scGameVersion.Panel1.ResumeLayout(false);
            this.scGameVersion.Panel2.ResumeLayout(false);
            this.scGameVersion.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGameVersion)).EndInit();
            this.scGameVersion.ResumeLayout(false);
            this.pnLogControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDTrackerDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scGameVersion;
        private System.Windows.Forms.TextBox tbCVCDNConfigKey;
        private System.Windows.Forms.Label lbCVCDNConfigKey;
        private System.Windows.Forms.TextBox tbCVBuildConfigKey;
        private System.Windows.Forms.Label lbCVBuildConfigKey;
        private System.Windows.Forms.TextBox tbCVBuildName;
        private System.Windows.Forms.Label lbCVBuildName;
        private System.Windows.Forms.TextBox tbCVRegion;
        private System.Windows.Forms.Label lbCVRegion;
        private System.Windows.Forms.TextBox tbCVBuildID;
        private System.Windows.Forms.Label lbCVBuildID;
        private System.Windows.Forms.SplitContainer sCCDNConfig;
        private System.Windows.Forms.TextBox tbCDNBuildEncodingSize;
        private System.Windows.Forms.Label lbCDNBuildEncodingSize;
        private System.Windows.Forms.TextBox tbCDNBuildEncodingKeys;
        private System.Windows.Forms.Label lbCDNBuildEncodingKeys;
        private System.Windows.Forms.TextBox tbCDNBuildPatchConfigKey;
        private System.Windows.Forms.Label lbCDNBuildPatchConfigKey;
        private System.Windows.Forms.TextBox tbCDNBuildPatchKey;
        private System.Windows.Forms.Label lbCDNBuildPatchKey;
        private System.Windows.Forms.TextBox tbCDNBuildPatchSize;
        private System.Windows.Forms.Label lbCDNBuildPatchSize;
        private System.Windows.Forms.TextBox tbCDNBuildDownloadKey;
        private System.Windows.Forms.Label lbCDNBuildDownloadKey;
        private System.Windows.Forms.TextBox tbCDNBuildInstallKey;
        private System.Windows.Forms.Label lbCDNBuildInstallKey;
        private System.Windows.Forms.TextBox tbCDNBuildRootKey;
        private System.Windows.Forms.Label lbCDNBuildRootKey;
        private System.Windows.Forms.TextBox tbCDNBuildName;
        private System.Windows.Forms.Label lbCDNBuildName;
        private System.Windows.Forms.TextBox tbCDNBuildUID;
        private System.Windows.Forms.Label lbCDNBuildUID;
        private System.Windows.Forms.TextBox tbCDNBuildKey;
        private System.Windows.Forms.Label lbCDNBuildKey;
        private System.Windows.Forms.ListBox lbCDNBuilds;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Panel panelSpacer1;
        private System.Windows.Forms.Panel pnLogControl;
        private System.Windows.Forms.Timer TrackerTimer;
        private System.Windows.Forms.Label lbTrackerDelay;
        private System.Windows.Forms.NumericUpDown numUDTrackerDelay;
        private System.Windows.Forms.Button btnTrackerToggle;
        private System.Windows.Forms.Panel panelSpacer2;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.Button btnOpenTrackerChooser;
    }
}

