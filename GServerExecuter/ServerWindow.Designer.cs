
namespace GServerExecuter
{
    partial class ServerWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.infoDetail = new System.Windows.Forms.TextBox();
            this.useConfigButton = new System.Windows.Forms.Button();
            this.infoName = new System.Windows.Forms.TextBox();
            this.ConfigList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.consoleInputBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.folderPathBrowseButton = new System.Windows.Forms.Button();
            this.folderPathInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mapNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playerCountNum = new System.Windows.Forms.NumericUpDown();
            this.serverNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gamemodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serverHostButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.setting_dontredirect = new System.Windows.Forms.CheckBox();
            this.srcdsPathButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.srcdsPathInput = new System.Windows.Forms.TextBox();
            this.folderPathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.srcdsDialog = new System.Windows.Forms.OpenFileDialog();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCountNum)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigToolStripMenuItem,
            this.duplicateConfigToolStripMenuItem,
            this.editConfigToolStripMenuItem,
            this.removeConfigToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadConfigToolStripMenuItem
            // 
            this.loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            this.loadConfigToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.loadConfigToolStripMenuItem.Text = "Load Config";
            // 
            // duplicateConfigToolStripMenuItem
            // 
            this.duplicateConfigToolStripMenuItem.Name = "duplicateConfigToolStripMenuItem";
            this.duplicateConfigToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.duplicateConfigToolStripMenuItem.Text = "Duplicate Config";
            // 
            // editConfigToolStripMenuItem
            // 
            this.editConfigToolStripMenuItem.Name = "editConfigToolStripMenuItem";
            this.editConfigToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editConfigToolStripMenuItem.Text = "Edit Config";
            // 
            // removeConfigToolStripMenuItem
            // 
            this.removeConfigToolStripMenuItem.Name = "removeConfigToolStripMenuItem";
            this.removeConfigToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removeConfigToolStripMenuItem.Text = "Remove Config";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startHostToolStripMenuItem,
            this.stopHostToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // startHostToolStripMenuItem
            // 
            this.startHostToolStripMenuItem.Name = "startHostToolStripMenuItem";
            this.startHostToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.startHostToolStripMenuItem.Text = "Start Host";
            // 
            // stopHostToolStripMenuItem
            // 
            this.stopHostToolStripMenuItem.Enabled = false;
            this.stopHostToolStripMenuItem.Name = "stopHostToolStripMenuItem";
            this.stopHostToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.stopHostToolStripMenuItem.Text = "Stop Host";
            this.stopHostToolStripMenuItem.Click += new System.EventHandler(this.stopHostToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.infoDetail);
            this.tabPage1.Controls.Add(this.useConfigButton);
            this.tabPage1.Controls.Add(this.infoName);
            this.tabPage1.Controls.Add(this.ConfigList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // infoDetail
            // 
            this.infoDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoDetail.Location = new System.Drawing.Point(330, 31);
            this.infoDetail.Multiline = true;
            this.infoDetail.Name = "infoDetail";
            this.infoDetail.ReadOnly = true;
            this.infoDetail.Size = new System.Drawing.Size(432, 319);
            this.infoDetail.TabIndex = 3;
            // 
            // useConfigButton
            // 
            this.useConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.useConfigButton.Location = new System.Drawing.Point(687, 356);
            this.useConfigButton.Name = "useConfigButton";
            this.useConfigButton.Size = new System.Drawing.Size(75, 23);
            this.useConfigButton.TabIndex = 2;
            this.useConfigButton.Text = "Use";
            this.useConfigButton.UseVisualStyleBackColor = true;
            this.useConfigButton.Click += new System.EventHandler(this.useConfigButton_Click);
            // 
            // infoName
            // 
            this.infoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoName.Location = new System.Drawing.Point(330, 6);
            this.infoName.Name = "infoName";
            this.infoName.ReadOnly = true;
            this.infoName.Size = new System.Drawing.Size(432, 19);
            this.infoName.TabIndex = 1;
            // 
            // ConfigList
            // 
            this.ConfigList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigList.FormattingEnabled = true;
            this.ConfigList.ItemHeight = 12;
            this.ConfigList.Location = new System.Drawing.Point(6, 6);
            this.ConfigList.Name = "ConfigList";
            this.ConfigList.Size = new System.Drawing.Size(318, 376);
            this.ConfigList.TabIndex = 0;
            this.ConfigList.SelectedIndexChanged += new System.EventHandler(this.ConfigList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.consoleOutput);
            this.tabPage2.Controls.Add(this.consoleInputBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Console";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // consoleOutput
            // 
            this.consoleOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.consoleOutput.ForeColor = System.Drawing.Color.White;
            this.consoleOutput.Location = new System.Drawing.Point(6, 6);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.Size = new System.Drawing.Size(756, 348);
            this.consoleOutput.TabIndex = 2;
            this.consoleOutput.Text = "";
            // 
            // consoleInputBox
            // 
            this.consoleInputBox.Location = new System.Drawing.Point(6, 360);
            this.consoleInputBox.Name = "consoleInputBox";
            this.consoleInputBox.Size = new System.Drawing.Size(756, 19);
            this.consoleInputBox.TabIndex = 1;
            this.consoleInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consoleInputBox_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tokenBox);
            this.tabPage3.Controls.Add(this.folderPathBrowseButton);
            this.tabPage3.Controls.Add(this.folderPathInput);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.saveConfigButton);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.outputBox);
            this.tabPage3.Controls.Add(this.commandBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.mapNameBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.playerCountNum);
            this.tabPage3.Controls.Add(this.serverNameBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.gamemodeBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.serverHostButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Server Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // folderPathBrowseButton
            // 
            this.folderPathBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderPathBrowseButton.Location = new System.Drawing.Point(641, 214);
            this.folderPathBrowseButton.Name = "folderPathBrowseButton";
            this.folderPathBrowseButton.Size = new System.Drawing.Size(124, 23);
            this.folderPathBrowseButton.TabIndex = 16;
            this.folderPathBrowseButton.Text = "Browse...";
            this.folderPathBrowseButton.UseVisualStyleBackColor = true;
            this.folderPathBrowseButton.Click += new System.EventHandler(this.folderPathBrowseButton_Click);
            // 
            // folderPathInput
            // 
            this.folderPathInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderPathInput.Location = new System.Drawing.Point(5, 216);
            this.folderPathInput.Name = "folderPathInput";
            this.folderPathInput.ReadOnly = true;
            this.folderPathInput.Size = new System.Drawing.Size(630, 19);
            this.folderPathInput.TabIndex = 15;
            this.folderPathInput.Text = "C:\\";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Folder Path";
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveConfigButton.Location = new System.Drawing.Point(609, 359);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(75, 23);
            this.saveConfigButton.TabIndex = 13;
            this.saveConfigButton.Text = "Save Config";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Command Output";
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Location = new System.Drawing.Point(5, 253);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(760, 100);
            this.outputBox.TabIndex = 11;
            // 
            // commandBox
            // 
            this.commandBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandBox.Location = new System.Drawing.Point(5, 128);
            this.commandBox.Multiline = true;
            this.commandBox.Name = "commandBox";
            this.commandBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandBox.Size = new System.Drawing.Size(760, 72);
            this.commandBox.TabIndex = 10;
            this.commandBox.TextChanged += new System.EventHandler(this.commandBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Additional Command";
            // 
            // mapNameBox
            // 
            this.mapNameBox.Location = new System.Drawing.Point(5, 91);
            this.mapNameBox.Name = "mapNameBox";
            this.mapNameBox.Size = new System.Drawing.Size(215, 19);
            this.mapNameBox.TabIndex = 8;
            this.mapNameBox.Text = "gm_construct";
            this.mapNameBox.TextChanged += new System.EventHandler(this.mapNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Map Name";
            // 
            // playerCountNum
            // 
            this.playerCountNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerCountNum.Location = new System.Drawing.Point(645, 17);
            this.playerCountNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerCountNum.Name = "playerCountNum";
            this.playerCountNum.Size = new System.Drawing.Size(120, 19);
            this.playerCountNum.TabIndex = 6;
            this.playerCountNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playerCountNum.ValueChanged += new System.EventHandler(this.playerCountNum_ValueChanged);
            // 
            // serverNameBox
            // 
            this.serverNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverNameBox.Location = new System.Drawing.Point(5, 54);
            this.serverNameBox.Name = "serverNameBox";
            this.serverNameBox.Size = new System.Drawing.Size(760, 19);
            this.serverNameBox.TabIndex = 5;
            this.serverNameBox.Text = "Garry\'s mod server";
            this.serverNameBox.TextChanged += new System.EventHandler(this.serverNameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Name";
            // 
            // gamemodeBox
            // 
            this.gamemodeBox.Location = new System.Drawing.Point(5, 17);
            this.gamemodeBox.Name = "gamemodeBox";
            this.gamemodeBox.Size = new System.Drawing.Size(215, 19);
            this.gamemodeBox.TabIndex = 3;
            this.gamemodeBox.Text = "sandbox";
            this.gamemodeBox.TextChanged += new System.EventHandler(this.gamemodeBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gamemode";
            // 
            // serverHostButton
            // 
            this.serverHostButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.serverHostButton.Location = new System.Drawing.Point(690, 359);
            this.serverHostButton.Name = "serverHostButton";
            this.serverHostButton.Size = new System.Drawing.Size(75, 23);
            this.serverHostButton.TabIndex = 0;
            this.serverHostButton.Text = "Host Server";
            this.serverHostButton.UseVisualStyleBackColor = true;
            this.serverHostButton.Click += new System.EventHandler(this.serverHostButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.setting_dontredirect);
            this.tabPage4.Controls.Add(this.srcdsPathButton);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.srcdsPathInput);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tool Config";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // setting_dontredirect
            // 
            this.setting_dontredirect.AutoSize = true;
            this.setting_dontredirect.Location = new System.Drawing.Point(5, 42);
            this.setting_dontredirect.Name = "setting_dontredirect";
            this.setting_dontredirect.Size = new System.Drawing.Size(136, 16);
            this.setting_dontredirect.TabIndex = 18;
            this.setting_dontredirect.Text = "Don\'t redirect console";
            this.setting_dontredirect.UseVisualStyleBackColor = true;
            this.setting_dontredirect.CheckedChanged += new System.EventHandler(this.setting_dontredirect_CheckedChanged);
            // 
            // srcdsPathButton
            // 
            this.srcdsPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.srcdsPathButton.Location = new System.Drawing.Point(641, 15);
            this.srcdsPathButton.Name = "srcdsPathButton";
            this.srcdsPathButton.Size = new System.Drawing.Size(124, 23);
            this.srcdsPathButton.TabIndex = 17;
            this.srcdsPathButton.Text = "Browse...";
            this.srcdsPathButton.UseVisualStyleBackColor = true;
            this.srcdsPathButton.Click += new System.EventHandler(this.srcdsPathButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "srcds Path";
            // 
            // srcdsPathInput
            // 
            this.srcdsPathInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srcdsPathInput.Location = new System.Drawing.Point(3, 17);
            this.srcdsPathInput.Name = "srcdsPathInput";
            this.srcdsPathInput.ReadOnly = true;
            this.srcdsPathInput.Size = new System.Drawing.Size(632, 19);
            this.srcdsPathInput.TabIndex = 0;
            // 
            // folderPathDialog
            // 
            this.folderPathDialog.Description = "Select the gmod data path.";
            this.folderPathDialog.ShowNewFolderButton = false;
            // 
            // srcdsDialog
            // 
            this.srcdsDialog.Filter = "srcds|srcds.exe";
            this.srcdsDialog.Title = "Select exe...";
            // 
            // tokenBox
            // 
            this.tokenBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenBox.Location = new System.Drawing.Point(226, 91);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(539, 19);
            this.tokenBox.TabIndex = 17;
            this.tokenBox.TextChanged += new System.EventHandler(this.tokenBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "Token";
            // 
            // ServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ServerWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GServerExecuter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCountNum)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button serverHostButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gamemodeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverNameBox;
        private System.Windows.Forms.NumericUpDown playerCountNum;
        private System.Windows.Forms.TextBox mapNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.ListBox ConfigList;
        private System.Windows.Forms.TextBox consoleInputBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox folderPathInput;
        private System.Windows.Forms.Button folderPathBrowseButton;
        private System.Windows.Forms.RichTextBox consoleOutput;
        private System.Windows.Forms.FolderBrowserDialog folderPathDialog;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox srcdsPathInput;
        private System.Windows.Forms.Button srcdsPathButton;
        private System.Windows.Forms.OpenFileDialog srcdsDialog;
        private System.Windows.Forms.TextBox infoName;
        private System.Windows.Forms.Button useConfigButton;
        private System.Windows.Forms.TextBox infoDetail;
        private System.Windows.Forms.CheckBox setting_dontredirect;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Label label8;
    }
}

