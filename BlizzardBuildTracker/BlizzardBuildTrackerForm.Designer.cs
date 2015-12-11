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
            this.gbCVersionData = new System.Windows.Forms.GroupBox();
            this.cbGameCode = new System.Windows.Forms.ComboBox();
            this.gbCVData = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.lbCVCDNConfig = new System.Windows.Forms.Label();
            this.tbCVBuildConfig = new System.Windows.Forms.TextBox();
            this.lbCVBuildConfig = new System.Windows.Forms.Label();
            this.tbCVBuildName = new System.Windows.Forms.TextBox();
            this.lbCVBuildName = new System.Windows.Forms.Label();
            this.tbCVRegion = new System.Windows.Forms.TextBox();
            this.lbCVRegion = new System.Windows.Forms.Label();
            this.tbCVBuildID = new System.Windows.Forms.TextBox();
            this.lbCVBuildID = new System.Windows.Forms.Label();
            this.buttonLoadVersionsData = new System.Windows.Forms.Button();
            this.panelTracker = new System.Windows.Forms.Panel();
            this.scLog = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sCCDNConfig = new System.Windows.Forms.SplitContainer();
            this.tbCDNBuildEncodingSize = new System.Windows.Forms.TextBox();
            this.lbCDNBuildEncodingSize = new System.Windows.Forms.Label();
            this.tbCDNBuildEncoding = new System.Windows.Forms.TextBox();
            this.lbCDNBuildEncoding = new System.Windows.Forms.Label();
            this.tbCDNBuildPatchConfig = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatchConfig = new System.Windows.Forms.Label();
            this.tbCDNBuildPatch = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatch = new System.Windows.Forms.Label();
            this.tbCDNBuildPatchSize = new System.Windows.Forms.TextBox();
            this.lbCDNBuildPatchSize = new System.Windows.Forms.Label();
            this.tbCDNBuildDownload = new System.Windows.Forms.TextBox();
            this.lbCDNBuildDownload = new System.Windows.Forms.Label();
            this.tbCDNBuildInstall = new System.Windows.Forms.TextBox();
            this.lbCDNBuildInstall = new System.Windows.Forms.Label();
            this.tbCDNBuildRoot = new System.Windows.Forms.TextBox();
            this.lbCDNBuildRoot = new System.Windows.Forms.Label();
            this.tbCDNBuildName = new System.Windows.Forms.TextBox();
            this.lbCDNBuildName = new System.Windows.Forms.Label();
            this.tbCDNBuildUID = new System.Windows.Forms.TextBox();
            this.lbCDNBuildUID = new System.Windows.Forms.Label();
            this.tbCDNBuildHash = new System.Windows.Forms.TextBox();
            this.lbCDNBuildHash = new System.Windows.Forms.Label();
            this.listBoxCDNBuilds = new System.Windows.Forms.ListBox();
            this.gbCVersionData.SuspendLayout();
            this.gbCVData.SuspendLayout();
            this.panelTracker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLog)).BeginInit();
            this.scLog.Panel1.SuspendLayout();
            this.scLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCCDNConfig)).BeginInit();
            this.sCCDNConfig.Panel1.SuspendLayout();
            this.sCCDNConfig.Panel2.SuspendLayout();
            this.sCCDNConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCVersionData
            // 
            this.gbCVersionData.Controls.Add(this.cbGameCode);
            this.gbCVersionData.Controls.Add(this.gbCVData);
            this.gbCVersionData.Controls.Add(this.buttonLoadVersionsData);
            this.gbCVersionData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCVersionData.Location = new System.Drawing.Point(5, 5);
            this.gbCVersionData.Margin = new System.Windows.Forms.Padding(0);
            this.gbCVersionData.Name = "gbCVersionData";
            this.gbCVersionData.Padding = new System.Windows.Forms.Padding(5);
            this.gbCVersionData.Size = new System.Drawing.Size(1074, 169);
            this.gbCVersionData.TabIndex = 0;
            this.gbCVersionData.TabStop = false;
            // 
            // cbGameCode
            // 
            this.cbGameCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameCode.FormattingEnabled = true;
            this.cbGameCode.Location = new System.Drawing.Point(9, 21);
            this.cbGameCode.Name = "cbGameCode";
            this.cbGameCode.Size = new System.Drawing.Size(402, 21);
            this.cbGameCode.Sorted = true;
            this.cbGameCode.TabIndex = 0;
            // 
            // gbCVData
            // 
            this.gbCVData.Controls.Add(this.tbLog);
            this.gbCVData.Controls.Add(this.lbCVCDNConfig);
            this.gbCVData.Controls.Add(this.tbCVBuildConfig);
            this.gbCVData.Controls.Add(this.lbCVBuildConfig);
            this.gbCVData.Controls.Add(this.tbCVBuildName);
            this.gbCVData.Controls.Add(this.lbCVBuildName);
            this.gbCVData.Controls.Add(this.tbCVRegion);
            this.gbCVData.Controls.Add(this.lbCVRegion);
            this.gbCVData.Controls.Add(this.tbCVBuildID);
            this.gbCVData.Controls.Add(this.lbCVBuildID);
            this.gbCVData.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbCVData.Location = new System.Drawing.Point(469, 18);
            this.gbCVData.Name = "gbCVData";
            this.gbCVData.Size = new System.Drawing.Size(600, 146);
            this.gbCVData.TabIndex = 2;
            this.gbCVData.TabStop = false;
            this.gbCVData.Text = "Versions-Data:";
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbLog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLog.ForeColor = System.Drawing.Color.Black;
            this.tbLog.Location = new System.Drawing.Point(111, 115);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(484, 20);
            this.tbLog.TabIndex = 13;
            // 
            // lbCVCDNConfig
            // 
            this.lbCVCDNConfig.AutoSize = true;
            this.lbCVCDNConfig.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVCDNConfig.Location = new System.Drawing.Point(14, 114);
            this.lbCVCDNConfig.Name = "lbCVCDNConfig";
            this.lbCVCDNConfig.Size = new System.Drawing.Size(92, 22);
            this.lbCVCDNConfig.TabIndex = 12;
            this.lbCVCDNConfig.Text = "CDNConfig:";
            // 
            // tbCVBuildConfig
            // 
            this.tbCVBuildConfig.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVBuildConfig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCVBuildConfig.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVBuildConfig.ForeColor = System.Drawing.Color.Black;
            this.tbCVBuildConfig.Location = new System.Drawing.Point(111, 82);
            this.tbCVBuildConfig.Name = "tbCVBuildConfig";
            this.tbCVBuildConfig.ReadOnly = true;
            this.tbCVBuildConfig.Size = new System.Drawing.Size(484, 20);
            this.tbCVBuildConfig.TabIndex = 11;
            // 
            // lbCVBuildConfig
            // 
            this.lbCVBuildConfig.AutoSize = true;
            this.lbCVBuildConfig.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVBuildConfig.Location = new System.Drawing.Point(14, 81);
            this.lbCVBuildConfig.Name = "lbCVBuildConfig";
            this.lbCVBuildConfig.Size = new System.Drawing.Size(97, 22);
            this.lbCVBuildConfig.TabIndex = 10;
            this.lbCVBuildConfig.Text = "BuildConfig:";
            // 
            // tbCVBuildName
            // 
            this.tbCVBuildName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVBuildName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCVBuildName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVBuildName.ForeColor = System.Drawing.Color.Black;
            this.tbCVBuildName.Location = new System.Drawing.Point(111, 49);
            this.tbCVBuildName.Name = "tbCVBuildName";
            this.tbCVBuildName.ReadOnly = true;
            this.tbCVBuildName.Size = new System.Drawing.Size(484, 20);
            this.tbCVBuildName.TabIndex = 9;
            // 
            // lbCVBuildName
            // 
            this.lbCVBuildName.AutoSize = true;
            this.lbCVBuildName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVBuildName.Location = new System.Drawing.Point(14, 48);
            this.lbCVBuildName.Name = "lbCVBuildName";
            this.lbCVBuildName.Size = new System.Drawing.Size(97, 22);
            this.lbCVBuildName.TabIndex = 8;
            this.lbCVBuildName.Text = "Build-Name:";
            // 
            // tbCVRegion
            // 
            this.tbCVRegion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVRegion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCVRegion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVRegion.ForeColor = System.Drawing.Color.Black;
            this.tbCVRegion.Location = new System.Drawing.Point(424, 18);
            this.tbCVRegion.Name = "tbCVRegion";
            this.tbCVRegion.ReadOnly = true;
            this.tbCVRegion.Size = new System.Drawing.Size(171, 20);
            this.tbCVRegion.TabIndex = 7;
            // 
            // lbCVRegion
            // 
            this.lbCVRegion.AutoSize = true;
            this.lbCVRegion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVRegion.Location = new System.Drawing.Point(307, 16);
            this.lbCVRegion.Name = "lbCVRegion";
            this.lbCVRegion.Size = new System.Drawing.Size(97, 22);
            this.lbCVRegion.TabIndex = 6;
            this.lbCVRegion.Text = "Build-Name:";
            // 
            // tbCVBuildID
            // 
            this.tbCVBuildID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCVBuildID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCVBuildID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCVBuildID.ForeColor = System.Drawing.Color.Black;
            this.tbCVBuildID.Location = new System.Drawing.Point(111, 18);
            this.tbCVBuildID.Name = "tbCVBuildID";
            this.tbCVBuildID.ReadOnly = true;
            this.tbCVBuildID.Size = new System.Drawing.Size(171, 20);
            this.tbCVBuildID.TabIndex = 5;
            // 
            // lbCVBuildID
            // 
            this.lbCVBuildID.AutoSize = true;
            this.lbCVBuildID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVBuildID.Location = new System.Drawing.Point(14, 17);
            this.lbCVBuildID.Name = "lbCVBuildID";
            this.lbCVBuildID.Size = new System.Drawing.Size(71, 22);
            this.lbCVBuildID.TabIndex = 4;
            this.lbCVBuildID.Text = "Build-ID:";
            // 
            // buttonLoadVersionsData
            // 
            this.buttonLoadVersionsData.AutoEllipsis = true;
            this.buttonLoadVersionsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadVersionsData.Location = new System.Drawing.Point(8, 45);
            this.buttonLoadVersionsData.Name = "buttonLoadVersionsData";
            this.buttonLoadVersionsData.Size = new System.Drawing.Size(403, 119);
            this.buttonLoadVersionsData.TabIndex = 1;
            this.buttonLoadVersionsData.Text = "Load Versions Data";
            this.buttonLoadVersionsData.UseCompatibleTextRendering = true;
            this.buttonLoadVersionsData.UseVisualStyleBackColor = true;
            this.buttonLoadVersionsData.Click += new System.EventHandler(this.buttonLoadVersionsData_Click);
            // 
            // panelTracker
            // 
            this.panelTracker.Controls.Add(this.scLog);
            this.panelTracker.Controls.Add(this.sCCDNConfig);
            this.panelTracker.Controls.Add(this.gbCVersionData);
            this.panelTracker.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTracker.Location = new System.Drawing.Point(0, 0);
            this.panelTracker.Margin = new System.Windows.Forms.Padding(0);
            this.panelTracker.Name = "panelTracker";
            this.panelTracker.Padding = new System.Windows.Forms.Padding(5);
            this.panelTracker.Size = new System.Drawing.Size(1084, 677);
            this.panelTracker.TabIndex = 0;
            // 
            // scLog
            // 
            this.scLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.scLog.Location = new System.Drawing.Point(5, 464);
            this.scLog.Name = "scLog";
            // 
            // scLog.Panel1
            // 
            this.scLog.Panel1.Controls.Add(this.textBox1);
            this.scLog.Size = new System.Drawing.Size(1074, 144);
            this.scLog.SplitterDistance = 882;
            this.scLog.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(882, 144);
            this.textBox1.TabIndex = 0;
            // 
            // sCCDNConfig
            // 
            this.sCCDNConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.sCCDNConfig.Location = new System.Drawing.Point(5, 174);
            this.sCCDNConfig.Name = "sCCDNConfig";
            // 
            // sCCDNConfig.Panel1
            // 
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
            this.sCCDNConfig.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.sCCDNConfig.Size = new System.Drawing.Size(1074, 290);
            this.sCCDNConfig.SplitterDistance = 675;
            this.sCCDNConfig.TabIndex = 2;
            // 
            // tbCDNBuildEncodingSize
            // 
            this.tbCDNBuildEncodingSize.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildEncodingSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildEncodingSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildEncodingSize.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildEncodingSize.Location = new System.Drawing.Point(128, 241);
            this.tbCDNBuildEncodingSize.Name = "tbCDNBuildEncodingSize";
            this.tbCDNBuildEncodingSize.ReadOnly = true;
            this.tbCDNBuildEncodingSize.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildEncodingSize.TabIndex = 47;
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
            // tbCDNBuildEncoding
            // 
            this.tbCDNBuildEncoding.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildEncoding.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildEncoding.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildEncoding.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildEncoding.Location = new System.Drawing.Point(128, 215);
            this.tbCDNBuildEncoding.Name = "tbCDNBuildEncoding";
            this.tbCDNBuildEncoding.ReadOnly = true;
            this.tbCDNBuildEncoding.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildEncoding.TabIndex = 45;
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
            // tbCDNBuildPatchConfig
            // 
            this.tbCDNBuildPatchConfig.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildPatchConfig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildPatchConfig.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildPatchConfig.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildPatchConfig.Location = new System.Drawing.Point(128, 189);
            this.tbCDNBuildPatchConfig.Name = "tbCDNBuildPatchConfig";
            this.tbCDNBuildPatchConfig.ReadOnly = true;
            this.tbCDNBuildPatchConfig.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildPatchConfig.TabIndex = 43;
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
            // tbCDNBuildPatch
            // 
            this.tbCDNBuildPatch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildPatch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildPatch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildPatch.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildPatch.Location = new System.Drawing.Point(128, 137);
            this.tbCDNBuildPatch.Name = "tbCDNBuildPatch";
            this.tbCDNBuildPatch.ReadOnly = true;
            this.tbCDNBuildPatch.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildPatch.TabIndex = 41;
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
            // tbCDNBuildPatchSize
            // 
            this.tbCDNBuildPatchSize.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildPatchSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildPatchSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildPatchSize.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildPatchSize.Location = new System.Drawing.Point(128, 163);
            this.tbCDNBuildPatchSize.Name = "tbCDNBuildPatchSize";
            this.tbCDNBuildPatchSize.ReadOnly = true;
            this.tbCDNBuildPatchSize.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildPatchSize.TabIndex = 39;
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
            // tbCDNBuildDownload
            // 
            this.tbCDNBuildDownload.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildDownload.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildDownload.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildDownload.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildDownload.Location = new System.Drawing.Point(128, 111);
            this.tbCDNBuildDownload.Name = "tbCDNBuildDownload";
            this.tbCDNBuildDownload.ReadOnly = true;
            this.tbCDNBuildDownload.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildDownload.TabIndex = 37;
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
            // tbCDNBuildInstall
            // 
            this.tbCDNBuildInstall.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildInstall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildInstall.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildInstall.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildInstall.Location = new System.Drawing.Point(128, 85);
            this.tbCDNBuildInstall.Name = "tbCDNBuildInstall";
            this.tbCDNBuildInstall.ReadOnly = true;
            this.tbCDNBuildInstall.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildInstall.TabIndex = 35;
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
            // tbCDNBuildRoot
            // 
            this.tbCDNBuildRoot.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildRoot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildRoot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildRoot.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildRoot.Location = new System.Drawing.Point(128, 59);
            this.tbCDNBuildRoot.Name = "tbCDNBuildRoot";
            this.tbCDNBuildRoot.ReadOnly = true;
            this.tbCDNBuildRoot.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildRoot.TabIndex = 33;
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
            // tbCDNBuildName
            // 
            this.tbCDNBuildName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildName.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildName.Location = new System.Drawing.Point(128, 33);
            this.tbCDNBuildName.Name = "tbCDNBuildName";
            this.tbCDNBuildName.ReadOnly = true;
            this.tbCDNBuildName.Size = new System.Drawing.Size(461, 20);
            this.tbCDNBuildName.TabIndex = 31;
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
            // tbCDNBuildUID
            // 
            this.tbCDNBuildUID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildUID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildUID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildUID.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildUID.Location = new System.Drawing.Point(469, 7);
            this.tbCDNBuildUID.Name = "tbCDNBuildUID";
            this.tbCDNBuildUID.ReadOnly = true;
            this.tbCDNBuildUID.Size = new System.Drawing.Size(120, 20);
            this.tbCDNBuildUID.TabIndex = 29;
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
            // tbCDNBuildHash
            // 
            this.tbCDNBuildHash.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbCDNBuildHash.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCDNBuildHash.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCDNBuildHash.ForeColor = System.Drawing.Color.Black;
            this.tbCDNBuildHash.Location = new System.Drawing.Point(128, 7);
            this.tbCDNBuildHash.Name = "tbCDNBuildHash";
            this.tbCDNBuildHash.ReadOnly = true;
            this.tbCDNBuildHash.Size = new System.Drawing.Size(238, 20);
            this.tbCDNBuildHash.TabIndex = 27;
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
            // listBoxCDNBuilds
            // 
            this.listBoxCDNBuilds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCDNBuilds.FormattingEnabled = true;
            this.listBoxCDNBuilds.Location = new System.Drawing.Point(5, 5);
            this.listBoxCDNBuilds.Name = "listBoxCDNBuilds";
            this.listBoxCDNBuilds.Size = new System.Drawing.Size(385, 280);
            this.listBoxCDNBuilds.TabIndex = 5;
            this.listBoxCDNBuilds.SelectedIndexChanged += new System.EventHandler(this.listBoxCDNBuilds_SelectedIndexChanged);
            // 
            // BlizzardBuildTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1084, 615);
            this.Controls.Add(this.panelTracker);
            this.Name = "BlizzardBuildTrackerForm";
            this.Text = "Blizzard Build Tracker";
            this.gbCVersionData.ResumeLayout(false);
            this.gbCVData.ResumeLayout(false);
            this.gbCVData.PerformLayout();
            this.panelTracker.ResumeLayout(false);
            this.scLog.Panel1.ResumeLayout(false);
            this.scLog.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLog)).EndInit();
            this.scLog.ResumeLayout(false);
            this.sCCDNConfig.Panel1.ResumeLayout(false);
            this.sCCDNConfig.Panel1.PerformLayout();
            this.sCCDNConfig.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCCDNConfig)).EndInit();
            this.sCCDNConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTracker;
        private System.Windows.Forms.Button buttonLoadVersionsData;
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
        private System.Windows.Forms.GroupBox gbCVData;
        private System.Windows.Forms.ComboBox cbGameCode;
        private System.Windows.Forms.GroupBox gbCVersionData;
        private System.Windows.Forms.SplitContainer scLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer sCCDNConfig;
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
    }
}

