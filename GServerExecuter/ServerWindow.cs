using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GServerExecuter
{
    public partial class ServerWindow : Form
    {
        public ServerWindow()
        {
            InitializeComponent();
            WriteConsole(PREFIX + "Initialized!", Color.Aqua);
            WriteConsole(PREFIX + "GServerExecuter " + VERSION);
            LoadAllConfig();
            UpdateOutCommand();
            this.srcdsPathInput.Text = Properties.Settings.Default.srcdsPath;
            this.setting_dontredirect.Checked = Properties.Settings.Default.dontRedirectConsole;
        }

        public void LoadAllConfig()
        {
            var path = Path.Combine(Application.StartupPath, "ServerConfigs");
            WriteConsole(PREFIX + "Loading " + path);
            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    var config = ServerConfig.LoadConfig(Path.GetFileName(file));
                    configs.Add(config);
                    this.ConfigList.Items.Add(config.serverName);
                    WriteConsole("[gse] Loading " + Path.GetFileName(file), Color.Yellow);
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }
        }

        public List<ServerConfig> configs = new List<ServerConfig>();

        private void versionToolStripMenuItem_Click(object sender, EventArgs e) //バージョン表示
        {
            MessageBox.Show("GServerExecuter " + VERSION, "Version Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private const string VERSION = "v0.1.0";
        private const string PREFIX = "[GServerExecuter] ";

        private void folderPathBrowseButton_Click(object sender, EventArgs e)
        {
            var res = folderPathDialog.ShowDialog();
            switch (res)
            {
                case DialogResult.OK:
                    folderPathInput.Text = folderPathDialog.SelectedPath;
                    UpdateOutCommand();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }

        }

        public void WriteConsole(string text, Color color, Color backcolor)
        {
            if (consoleOutput.InvokeRequired)
            {
                consoleOutput.Invoke(new Action(() => {
                    var sp = consoleOutput.SelectionStart;
                    var sl = consoleOutput.SelectionLength;
                    var pos = consoleOutput.TextLength;
                    consoleOutput.AppendText(text + "\n");
                    var length = consoleOutput.TextLength - pos;
                    consoleOutput.Select(pos, length);
                    consoleOutput.SelectionColor = color;
                    if (backcolor != Color.Transparent)
                    {
                        consoleOutput.SelectionBackColor = backcolor;
                    }

                    consoleOutput.Select(sp,sl);
                }));
            }
            else
            {
                var sp = consoleOutput.SelectionStart;
                var sl = consoleOutput.SelectionLength;
                var pos = consoleOutput.TextLength;
                consoleOutput.AppendText(text + "\n");
                var length = consoleOutput.TextLength - pos;
                consoleOutput.Select(pos, length);
                consoleOutput.SelectionColor = color;
                if (backcolor != Color.Transparent)
                {
                    consoleOutput.SelectionBackColor = backcolor;
                }

                consoleOutput.Select(sp, sl);
            }
        }

        public void WriteConsole(string text)
        {
            
            WriteConsole(text, Color.White, Color.Transparent);
        }

        public void WriteConsole(string text, Color color)
        {
            WriteConsole(text, color, Color.Transparent);
        }

        private void serverHostButton_Click(object sender, EventArgs e)
        {
            UpdateOutCommand();

            Process p = new Process();

            ProcessStartInfo processStartInfo = new ProcessStartInfo(this.srcdsPathInput.Text, this.ExecuteCommand);

            processStartInfo.CreateNoWindow = false;
            processStartInfo.UseShellExecute = false;

            var redirect = !this.setting_dontredirect.Checked;

            processStartInfo.RedirectStandardOutput = redirect;
            processStartInfo.RedirectStandardError = redirect;

            p.StartInfo = processStartInfo;

            if (redirect)
            {
                p.OutputDataReceived += P_OutputDataReceived;
                p.ErrorDataReceived += P_ErrorDataReceived;
            }
            p.Exited += P_Exited;

            tabControl1.SelectedTab = tabPage2;
            WriteConsole(PREFIX + "Server opening...", Color.Aqua);
            try
            {
                p.Start();
                stopHostToolStripMenuItem.Enabled = true;
                currentP = p;
                if (redirect)
                {
                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();
                }
            }
            catch (Exception ex)
            {
                WriteConsole(PREFIX + ex.Message, Color.Red);
                WriteConsole(PREFIX + "Server Opening Failed", Color.Red);
                currentP = null;
            }
        }

        private Process currentP;

        private void P_Exited(object sender, EventArgs e)
        {
            WriteConsole(PREFIX + "Server closed!", Color.Aqua);
        }

        private void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            WriteConsole(e.Data, Color.Red);
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            WriteConsole(e.Data);
        }

        private void UpdateOutCommand()
        {
            this.ExecuteCommand = "-console +hostname \"" + this.serverNameBox.Text + "\" +maxplayers " + this.playerCountNum.Value + " +gamemode " + this.gamemodeBox.Text + " +map " + this.mapNameBox.Text + (this.tokenBox.Text != "" ? " +sv_setsteamaccount " + this.tokenBox.Text : "") + " " + this.commandBox.Text + " +console";
            this.outputBox.Text = this.ExecuteCommand;
        }

        public string ExecuteCommand { get; private set; }

        private void gamemodeBox_TextChanged(object sender, EventArgs e) => UpdateOutCommand();

        private void playerCountNum_ValueChanged(object sender, EventArgs e) => UpdateOutCommand();

        private void serverNameBox_TextChanged(object sender, EventArgs e) => UpdateOutCommand();

        private void mapNameBox_TextChanged(object sender, EventArgs e) => UpdateOutCommand();

        private void commandBox_TextChanged(object sender, EventArgs e) => UpdateOutCommand();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void srcdsPathButton_Click(object sender, EventArgs e)
        {
            var res = srcdsDialog.ShowDialog();
            switch (res)
            {
                case DialogResult.OK:
                    this.srcdsPathInput.Text = srcdsDialog.FileName;
                    Properties.Settings.Default.srcdsPath = this.srcdsPathInput.Text;
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        private void ServerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void stopHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentP != null && !currentP.HasExited)
            {
                currentP.Kill();
                WriteConsole(PREFIX + "Server closed!", Color.Aqua);
                stopHostToolStripMenuItem.Enabled = false;
            }
        }

        private void consoleInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (e.KeyChar == '\r')
            {
                if (currentP != null)
                {
                    //currentP.StandardInput.WriteLine(consoleInputBox.Text);
                    consoleInputBox.Text = "";
                }
            }
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            var savewin = new SaveConfigWindow();
            savewin.mainwindow = this;
            savewin.ShowDialog();
        }

        public void SaveConfig(string name)
        {
            var config = new ServerConfig()
            {
                gamemode = this.gamemodeBox.Text,
                serverName = this.serverNameBox.Text,
                playercount = (int)this.playerCountNum.Value,
                map = this.mapNameBox.Text,
                token = this.tokenBox.Text
            };
            config.SaveConfig(name);
            configs.Add(config);
            this.ConfigList.Items.Add(config.serverName);
        }

        private void ConfigList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(configs.Count + ", " + ConfigList.SelectedIndex);
            var config = configs[ConfigList.SelectedIndex];
            this.infoName.Text = config.serverName;
            this.infoDetail.Text = "Gamemode: " + config.gamemode + "\nPlayerCount: " + config.playercount + "\nMap: " + config.map;
        }

        private void useConfigButton_Click(object sender, EventArgs e)
        {
            var config = configs[ConfigList.SelectedIndex];
            this.gamemodeBox.Text = config.gamemode;
            this.playerCountNum.Value = config.playercount;
            this.mapNameBox.Text = config.map;
            this.serverNameBox.Text = config.serverName;
            this.tokenBox.Text = config.token;

            UpdateOutCommand();
            tabControl1.SelectedTab = tabPage3;
        }

        private void setting_dontredirect_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dontRedirectConsole = this.setting_dontredirect.Checked;
        }

        private void tokenBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOutCommand();
        }
    }
}
