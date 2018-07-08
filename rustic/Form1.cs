using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace rustic
{
    public partial class Form1 : Form
    {
        String rustExe = String.Empty;
        String customMap = String.Empty;
        private Process proc1;
        public Form1()
        {
            InitializeComponent();
            this.ServerWorldSizeField.SelectedIndex = 0;
            this.ServerLevelType.SelectedIndex = 0;
            this.ServerRconWebField.SelectedIndex = 0;
            this.ServerMaxPlayers.SelectedIndex = 3;
            this.buttonLaunch.Enabled = false;
        }

        private void buttonExecuatable_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rustExe = openFileDialog1.FileName;
                    this.labelExecuatable.Text = rustExe;
                    this.buttonLaunch.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "map files (*.map)|*.map|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    customMap = "file:\\\\\\" + $"{openFileDialog1.FileName}";
                    this.ServerMapUrl.Text = customMap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            // All the magic happens here
            var launchArgs = new StringBuilder();
            if (this.ServerBatchMode.Checked)
            {
                launchArgs.Append("-batchmode ");
            }
            try
            {
                Convert.ToInt32(this.ServerPort.Text);
                launchArgs.Append($"+server.port {ServerPort.Text} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Malformed or Blank server port");
                return;
            }
            if (this.ServerLevelType.SelectedIndex == 0)
            {
                if (this.ServerMapUrl.Text.Equals(String.Empty))
                {
                    MessageBox.Show("There is no level url set");
                    return;
                }
                launchArgs.Append($"-levelurl \"{this.ServerMapUrl.Text}\" ");
            }
            else
            {
                try
                {
                    Convert.ToInt32(this.ServerSeedField.Text);
                    launchArgs.Append($"+server.level \"Procedural Map\" +server.seed {this.ServerSeedField.Text} +server.worldsize {this.ServerWorldSizeField.Text} ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Malformed or Blank world seed");
                    return;
                }
                
            }
            launchArgs.Append($"+server.maxplayers {this.ServerMaxPlayers.Text} ");
            if (this.ServerHostname.Checked)
            {
                launchArgs.Append($"+server.hostname \"{this.ServerHostnameField.Text}\" ");
            }
            if (this.ServerDesc.Checked)
            {
                launchArgs.Append($"+server.description \"{this.ServerDescField.Text}\" ");
            }
            if (this.ServerUrl.Checked)
            {
                launchArgs.Append($"+server.url \"{this.ServerUrlField.Text}\" ");
            }
            if (this.ServerImage.Checked)
            {
                launchArgs.Append($"+server.headerimage \"{this.ServerImageField.Text}\" ");
            }
            if (this.ServerIdentity.Checked)
            {
                launchArgs.Append($"+server.identity \"{this.ServerIdentityField.Text}\" ");
            }
            if (this.ServerRconPort.Checked)
            {
                try
                {
                    Convert.ToInt32(this.ServerRconPortField.Text);
                    launchArgs.Append($"+rcon.port {this.ServerRconPortField.Text} ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Malformed or Blank RCON port");
                    return;
                }
            }
            if (this.ServerRconPassword.Checked)
            {
                launchArgs.Append($"+rcon.password {this.ServerRconPasswordField.Text} ");
            }
            if (this.ServerRconWeb.Checked)
            {
                launchArgs.Append($"+rcon.web {this.ServerRconWebField.Text} ");
            }
            if (this.Args.Checked)
            {
                MessageBox.Show(launchArgs.ToString());
                Clipboard.SetText(launchArgs.ToString());
            }
            proc1 = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = rustExe,
                    WorkingDirectory = Path.GetDirectoryName(rustExe),
                    Arguments = $"{launchArgs.ToString()}",
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    CreateNoWindow = false
                }
            };
            proc1.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
