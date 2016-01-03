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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlizzardBuildTrackerForm));
            this.sCCDNConfig = new System.Windows.Forms.SplitContainer();
            this.listBoxCDNBuilds = new System.Windows.Forms.ListBox();
            this.lbCDNBuildHash = new System.Windows.Forms.Label();
            this.tbCDNBuildHash = new System.Windows.Forms.TextBox();
            this.lbCDNBuildUID = new System.Windows.Forms.Label();
            this.tbCDNBuildUID = new System.Windows.Forms.TextBox();
            this.lbCDNBuildName = new System.Windows.Forms.Label();
            this.tbCDNBuildName = new System.Windows.Forms.TextBox();
            this.lbCDNBuildRoot = new System.Windows.Forms.Label();
            this.tbCDNBuildRoot = new System.Windows.Forms.TextBox();
            this.lbCDNBuildInstall = new System.Windows.Forms.Label();
            this.tbCDNBuildInstall = new System.Windows.Forms.TextBox();
            this.lbCDNBuildDownload = new System.Windows.Forms.Label();
            this.tbCDNBuildDownload = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatchSize = new System.Windows.Forms.Label();
            this.tbCDNBuildPatchSize = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatch = new System.Windows.Forms.Label();
            this.tbCDNBuildPatch = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatchConfig = new System.Windows.Forms.Label();
            this.tbCDNBuildPatchConfig = new System.Windows.Forms.TextBox();
            this.lbCDNBuildEncoding = new System.Windows.Forms.Label();
            this.tbCDNBuildEncoding = new System.Windows.Forms.TextBox();
            this.lbCDNBuildEncodingSize = new System.Windows.Forms.Label();
            this.tbCDNBuildEncodingSize = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.scGameVersion = new System.Windows.Forms.SplitContainer();
            this.lbCVBuildID = new System.Windows.Forms.Label();
            this.tbCVBuildID = new System.Windows.Forms.TextBox();
            this.lbCVRegion = new System.Windows.Forms.Label();
            this.tbCVRegion = new System.Windows.Forms.TextBox();
            this.lbCVBuildName = new System.Windows.Forms.Label();
            this.tbCVBuildName = new System.Windows.Forms.TextBox();
            this.lbCVBuildConfig = new System.Windows.Forms.Label();
            this.tbCVBuildConfig = new System.Windows.Forms.TextBox();
            this.lbCVCDNConfig = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.buttonLoadVersionsData = new System.Windows.Forms.Button();
            this.cbGameCode = new System.Windows.Forms.ComboBox();
            this.panelTracker = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sCCDNConfig)).BeginInit();
            this.sCCDNConfig.Panel1.SuspendLayout();
            this.sCCDNConfig.Panel2.SuspendLayout();
            this.sCCDNConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGameVersion)).BeginInit();
            this.scGameVersion.Panel1.SuspendLayout();
            this.scGameVersion.Panel2.SuspendLayout();
            this.scGameVersion.SuspendLayout();
            this.panelTracker.SuspendLayout();
            this.SuspendLayout();
            // 
            // sCCDNConfig
            // 
            this.sCCDNConfig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sCCDNConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sCCDNConfig.Location = new System.Drawing.Point(5, 137);
            this.sCCDNConfig.Margin = new System.Windows.Forms.Padding(0);
            this.sCCDNConfig.Name = "sCCDNConfig";
            // 
            // sCCDNConfig.Panel1
            // 
            this.sCCDNConfig.Panel1.BackColor = System.Drawing.Color.Silver;
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildEncodingSize);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildEncodingSize);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildEncoding);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildEncoding);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildPatchConfig);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildPatchConfig);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildPatch);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildPatch);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildPatchSize);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildPatchSize);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildDownload);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildDownload);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildInstall);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildInstall);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildRoot);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildRoot);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildName);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildName);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildUID);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildUID);
            this.sCCDNConfig.Panel1.Controls.Add(this.tbCDNBuildHash);
            this.sCCDNConfig.Panel1.Controls.Add(this.lbCDNBuildHash);
            // 
            // sCCDNConfig.Panel2
            // 
            this.sCCDNConfig.Panel2.Controls.Add(this.listBoxCDNBuilds);
            this.sCCDNConfig.Size = new System.Drawing.Size(1090, 270);
            this.sCCDNConfig.SplitterDistance = 620;
            this.sCCDNConfig.TabIndex = 2;
            // 
            // listBoxCDNBuilds
            // 
            this.listBoxCDNBuilds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCDNBuilds.FormattingEnabled = true;
            this.listBoxCDNBuilds.IntegralHeight = false;
            this.listBoxCDNBuilds.Location = new System.Drawing.Point(0, 0);
            this.listBoxCDNBuilds.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxCDNBuilds.Name = "listBoxCDNBuilds";
            this.listBoxCDNBuilds.Size = new System.Drawing.Size(464, 268);
            this.listBoxCDNBuilds.TabIndex = 5;
            this.listBoxCDNBuilds.SelectedIndexChanged += new System.EventHandler(this.listBoxCDNBuilds_SelectedIndexChanged);
            // 
            // lbCDNBuildHash
            // 
            this.lbCDNBuildHash.AutoSize = true;
            this.lbCDNBuildHash.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildHash.Location = new System.Drawing.Point(8, 6);
            this.lbCDNBuildHash.Name = "lbCDNBuildHash";
            this.lbCDNBuildHash.Size = new System.Drawing.Size(90, 22);
            this.lbCDNBuildHash.TabIndex = 26;
            this.lbCDNBuildHash.Text = "Build-Hash:";
            // 
            // tbCDNBuildHash
            // 
            this.tbCDNBuildHash.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildHash.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildHash.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildHash.Location = new System.Drawing.Point(128, 7);
            this.tbCDNBuildHash.Name = "tbCDNBuildHash";
            this.tbCDNBuildHash.ReadOnly = true;
            this.tbCDNBuildHash.Size = new System.Drawing.Size(238, 20);
            this.tbCDNBuildHash.TabIndex = 27;
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
            // lbCDNBuildRoot
            // 
            this.lbCDNBuildRoot.AutoSize = true;
            this.lbCDNBuildRoot.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildRoot.Location = new System.Drawing.Point(8, 58);
            this.lbCDNBuildRoot.Name = "lbCDNBuildRoot";
            this.lbCDNBuildRoot.Size = new System.Drawing.Size(48, 22);
            this.lbCDNBuildRoot.TabIndex = 32;
            this.lbCDNBuildRoot.Text = "Root:";
            // 
            // tbCDNBuildRoot
            // 
            this.tbCDNBuildRoot.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildRoot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildRoot.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildRoot.Location = new System.Drawing.Point(128, 59);
            this.tbCDNBuildRoot.Name = "tbCDNBuildRoot";
            this.tbCDNBuildRoot.ReadOnly = true;
            this.tbCDNBuildRoot.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildRoot.TabIndex = 33;
            // 
            // lbCDNBuildInstall
            // 
            this.lbCDNBuildInstall.AutoSize = true;
            this.lbCDNBuildInstall.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildInstall.Location = new System.Drawing.Point(8, 84);
            this.lbCDNBuildInstall.Name = "lbCDNBuildInstall";
            this.lbCDNBuildInstall.Size = new System.Drawing.Size(56, 22);
            this.lbCDNBuildInstall.TabIndex = 34;
            this.lbCDNBuildInstall.Text = "Install:";
            // 
            // tbCDNBuildInstall
            // 
            this.tbCDNBuildInstall.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildInstall.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildInstall.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildInstall.Location = new System.Drawing.Point(128, 85);
            this.tbCDNBuildInstall.Name = "tbCDNBuildInstall";
            this.tbCDNBuildInstall.ReadOnly = true;
            this.tbCDNBuildInstall.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildInstall.TabIndex = 35;
            // 
            // lbCDNBuildDownload
            // 
            this.lbCDNBuildDownload.AutoSize = true;
            this.lbCDNBuildDownload.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildDownload.Location = new System.Drawing.Point(8, 110);
            this.lbCDNBuildDownload.Name = "lbCDNBuildDownload";
            this.lbCDNBuildDownload.Size = new System.Drawing.Size(86, 22);
            this.lbCDNBuildDownload.TabIndex = 36;
            this.lbCDNBuildDownload.Text = "Download:";
            // 
            // tbCDNBuildDownload
            // 
            this.tbCDNBuildDownload.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildDownload.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildDownload.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildDownload.Location = new System.Drawing.Point(128, 111);
            this.tbCDNBuildDownload.Name = "tbCDNBuildDownload";
            this.tbCDNBuildDownload.ReadOnly = true;
            this.tbCDNBuildDownload.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildDownload.TabIndex = 37;
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
            // lbCDNBuildPatch
            // 
            this.lbCDNBuildPatch.AutoSize = true;
            this.lbCDNBuildPatch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildPatch.Location = new System.Drawing.Point(8, 136);
            this.lbCDNBuildPatch.Name = "lbCDNBuildPatch";
            this.lbCDNBuildPatch.Size = new System.Drawing.Size(55, 22);
            this.lbCDNBuildPatch.TabIndex = 40;
            this.lbCDNBuildPatch.Text = "Patch:";
            // 
            // tbCDNBuildPatch
            // 
            this.tbCDNBuildPatch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildPatch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildPatch.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildPatch.Location = new System.Drawing.Point(128, 137);
            this.tbCDNBuildPatch.Name = "tbCDNBuildPatch";
            this.tbCDNBuildPatch.ReadOnly = true;
            this.tbCDNBuildPatch.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildPatch.TabIndex = 41;
            // 
            // lbCDNBuildPatchConfig
            // 
            this.lbCDNBuildPatchConfig.AutoSize = true;
            this.lbCDNBuildPatchConfig.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildPatchConfig.Location = new System.Drawing.Point(8, 188);
            this.lbCDNBuildPatchConfig.Name = "lbCDNBuildPatchConfig";
            this.lbCDNBuildPatchConfig.Size = new System.Drawing.Size(107, 22);
            this.lbCDNBuildPatchConfig.TabIndex = 42;
            this.lbCDNBuildPatchConfig.Text = "Patch-Config:";
            // 
            // tbCDNBuildPatchConfig
            // 
            this.tbCDNBuildPatchConfig.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildPatchConfig.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildPatchConfig.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildPatchConfig.Location = new System.Drawing.Point(128, 189);
            this.tbCDNBuildPatchConfig.Name = "tbCDNBuildPatchConfig";
            this.tbCDNBuildPatchConfig.ReadOnly = true;
            this.tbCDNBuildPatchConfig.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildPatchConfig.TabIndex = 43;
            // 
            // lbCDNBuildEncoding
            // 
            this.lbCDNBuildEncoding.AutoSize = true;
            this.lbCDNBuildEncoding.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCDNBuildEncoding.Location = new System.Drawing.Point(8, 214);
            this.lbCDNBuildEncoding.Name = "lbCDNBuildEncoding";
            this.lbCDNBuildEncoding.Size = new System.Drawing.Size(80, 22);
            this.lbCDNBuildEncoding.TabIndex = 44;
            this.lbCDNBuildEncoding.Text = "Encoding:";
            // 
            // tbCDNBuildEncoding
            // 
            this.tbCDNBuildEncoding.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildEncoding.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildEncoding.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildEncoding.Location = new System.Drawing.Point(128, 215);
            this.tbCDNBuildEncoding.Name = "tbCDNBuildEncoding";
            this.tbCDNBuildEncoding.ReadOnly = true;
            this.tbCDNBuildEncoding.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildEncoding.TabIndex = 45;
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
            // rtbLog
            // 
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbLog.Location = new System.Drawing.Point(5, 425);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(1090, 270);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // scGameVersion
            // 
            this.scGameVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scGameVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.scGameVersion.Location = new System.Drawing.Point(5, 5);
            this.scGameVersion.Name = "scGameVersion";
            // 
            // scGameVersion.Panel1
            // 
            this.scGameVersion.Panel1.Controls.Add(this.cbGameCode);
            this.scGameVersion.Panel1.Controls.Add(this.buttonLoadVersionsData);
            // 
            // scGameVersion.Panel2
            // 
            this.scGameVersion.Panel2.BackColor = System.Drawing.Color.Silver;
            this.scGameVersion.Panel2.Controls.Add(this.tbLog);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVCDNConfig);
            this.scGameVersion.Panel2.Controls.Add(this.tbCVBuildConfig);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVBuildConfig);
            this.scGameVersion.Panel2.Controls.Add(this.tbCVBuildName);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVBuildName);
            this.scGameVersion.Panel2.Controls.Add(this.tbCVRegion);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVRegion);
            this.scGameVersion.Panel2.Controls.Add(this.tbCVBuildID);
            this.scGameVersion.Panel2.Controls.Add(this.lbCVBuildID);
            this.scGameVersion.Size = new System.Drawing.Size(1090, 129);
            this.scGameVersion.SplitterDistance = 482;
            this.scGameVersion.TabIndex = 4;
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
            this.lbCVRegion.Location = new System.Drawing.Point(296, 3);
            this.lbCVRegion.Name = "lbCVRegion";
            this.lbCVRegion.Size = new System.Drawing.Size(97, 22);
            this.lbCVRegion.TabIndex = 16;
            this.lbCVRegion.Text = "Build-Name:";
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
            // lbCVBuildConfig
            // 
            this.lbCVBuildConfig.AutoSize = true;
            this.lbCVBuildConfig.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVBuildConfig.Location = new System.Drawing.Point(3, 68);
            this.lbCVBuildConfig.Name = "lbCVBuildConfig";
            this.lbCVBuildConfig.Size = new System.Drawing.Size(97, 22);
            this.lbCVBuildConfig.TabIndex = 20;
            this.lbCVBuildConfig.Text = "BuildConfig:";
            // 
            // tbCVBuildConfig
            // 
            this.tbCVBuildConfig.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVBuildConfig.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVBuildConfig.ForeColor = System.Drawing.Color.Black;
            this.tbCVBuildConfig.Location = new System.Drawing.Point(100, 69);
            this.tbCVBuildConfig.Name = "tbCVBuildConfig";
            this.tbCVBuildConfig.ReadOnly = true;
            this.tbCVBuildConfig.Size = new System.Drawing.Size(484, 20);
            this.tbCVBuildConfig.TabIndex = 21;
            // 
            // lbCVCDNConfig
            // 
            this.lbCVCDNConfig.AutoSize = true;
            this.lbCVCDNConfig.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVCDNConfig.Location = new System.Drawing.Point(3, 101);
            this.lbCVCDNConfig.Name = "lbCVCDNConfig";
            this.lbCVCDNConfig.Size = new System.Drawing.Size(92, 22);
            this.lbCVCDNConfig.TabIndex = 22;
            this.lbCVCDNConfig.Text = "CDNConfig:";
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLog.ForeColor = System.Drawing.Color.Black;
            this.tbLog.Location = new System.Drawing.Point(100, 102);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(484, 20);
            this.tbLog.TabIndex = 23;
            // 
            // buttonLoadVersionsData
            // 
            this.buttonLoadVersionsData.AutoEllipsis = true;
            this.buttonLoadVersionsData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLoadVersionsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadVersionsData.Location = new System.Drawing.Point(0, 21);
            this.buttonLoadVersionsData.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadVersionsData.Name = "buttonLoadVersionsData";
            this.buttonLoadVersionsData.Size = new System.Drawing.Size(480, 106);
            this.buttonLoadVersionsData.TabIndex = 10;
            this.buttonLoadVersionsData.Text = "Load Game";
            this.buttonLoadVersionsData.UseCompatibleTextRendering = true;
            this.buttonLoadVersionsData.UseVisualStyleBackColor = true;
            this.buttonLoadVersionsData.Click += new System.EventHandler(this.buttonLoadVersionsData_Click);
            // 
            // cbGameCode
            // 
            this.cbGameCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbGameCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameCode.FormattingEnabled = true;
            this.cbGameCode.Location = new System.Drawing.Point(0, 0);
            this.cbGameCode.Name = "cbGameCode";
            this.cbGameCode.Size = new System.Drawing.Size(480, 21);
            this.cbGameCode.Sorted = true;
            this.cbGameCode.TabIndex = 9;
            // 
            // panelTracker
            // 
            this.panelTracker.Controls.Add(this.scGameVersion);
            this.panelTracker.Controls.Add(this.rtbLog);
            this.panelTracker.Controls.Add(this.sCCDNConfig);
            this.panelTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTracker.Location = new System.Drawing.Point(0, 0);
            this.panelTracker.Margin = new System.Windows.Forms.Padding(0);
            this.panelTracker.Name = "panelTracker";
            this.panelTracker.Padding = new System.Windows.Forms.Padding(5);
            this.panelTracker.Size = new System.Drawing.Size(1100, 700);
            this.panelTracker.TabIndex = 0;
            // 
            // BlizzardBuildTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelTracker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlizzardBuildTrackerForm";
            this.Text = "Blizzard Build Tracker";
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
            this.panelTracker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTracker;
        private System.Windows.Forms.Label lbCVBuildID;
        private System.Windows.Forms.TextBox tbCVBuildID;
        private System.Windows.Forms.Label lbCVRegion;
        private System.Windows.Forms.TextBox tbCVRegion;
        private System.Windows.Forms.Label lbCVBuildName;
        private System.Windows.Forms.TextBox tbCVBuildName;
        private System.Windows.Forms.Label lbCVBuildConfig;
        private System.Windows.Forms.TextBox tbCVBuildConfig;
        private System.Windows.Forms.Label lbCVCDNConfig;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button buttonLoadVersionsData;
        private System.Windows.Forms.ComboBox cbGameCode;
        private System.Windows.Forms.SplitContainer scGameVersion;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ListBox listBoxCDNBuilds;
        private System.Windows.Forms.Label lbCDNBuildHash;
        private System.Windows.Forms.TextBox tbCDNBuildHash;
        private System.Windows.Forms.Label lbCDNBuildUID;
        private System.Windows.Forms.TextBox tbCDNBuildUID;
        private System.Windows.Forms.Label lbCDNBuildName;
        private System.Windows.Forms.TextBox tbCDNBuildName;
        private System.Windows.Forms.Label lbCDNBuildRoot;
        private System.Windows.Forms.TextBox tbCDNBuildRoot;
        private System.Windows.Forms.Label lbCDNBuildInstall;
        private System.Windows.Forms.TextBox tbCDNBuildInstall;
        private System.Windows.Forms.Label lbCDNBuildDownload;
        private System.Windows.Forms.TextBox tbCDNBuildDownload;
        private System.Windows.Forms.Label lbCDNBuildPatchSize;
        private System.Windows.Forms.TextBox tbCDNBuildPatchSize;
        private System.Windows.Forms.Label lbCDNBuildPatch;
        private System.Windows.Forms.TextBox tbCDNBuildPatch;
        private System.Windows.Forms.Label lbCDNBuildPatchConfig;
        private System.Windows.Forms.TextBox tbCDNBuildPatchConfig;
        private System.Windows.Forms.Label lbCDNBuildEncoding;
        private System.Windows.Forms.TextBox tbCDNBuildEncoding;
        private System.Windows.Forms.Label lbCDNBuildEncodingSize;
        private System.Windows.Forms.TextBox tbCDNBuildEncodingSize;
        private System.Windows.Forms.SplitContainer sCCDNConfig;
    }
}

