using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace rustic
{
    public partial class Form1 : Form
    {
        private string _rustExe = string.Empty;
        private Process _proc1;

        public Form1()
        {
            InitializeComponent();
            ServerWorldSizeField.SelectedIndex = 0;
            ServerLevelType.SelectedIndex = 0;
            ServerRconWebField.SelectedIndex = 0;
            ServerMaxPlayers.SelectedIndex = 3;
            buttonLaunch.Enabled = false;
        }

        private void buttonExecuatable_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                _rustExe = openFileDialog1.FileName;
                labelExecuatable.Text = _rustExe;
                buttonLaunch.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "map files (*.map)|*.map|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.ServerMapUrl.Text = $"file:\\\\\\{openFileDialog1.FileName}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Could not read file from disk. Original error: {ex.Message}");
                }
            }
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            // All the magic happens here
            var launchArgs = new StringBuilder();
            if (ServerBatchMode.Checked)
            {
                launchArgs.Append("-batchmode ");
            }

            try
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                // checks if the input is a valid interger
                Convert.ToInt32(ServerPort.Text);
                launchArgs.Append($"+server.port {ServerPort.Text} ");
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Malformed or Blank server port");
                return;
            }

            if (ServerLevelType.SelectedIndex == 0)
            {
                if (ServerMapUrl.Text.Equals(String.Empty))
                {
                    MessageBox.Show("There is no level url set");
                    return;
                }

                launchArgs.Append($"-levelurl \"{ServerMapUrl.Text}\" ");
            }
            else
            {
                try
                {
                    // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                    Convert.ToInt32(ServerSeedField.Text);
                    launchArgs.Append(
                        $"+server.level \"Procedural Map\" +server.seed {ServerSeedField.Text} +server.worldsize {ServerWorldSizeField.Text} ");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Malformed or Blank world seed");
                    return;
                }
            }

            launchArgs.Append($"+server.maxplayers {ServerMaxPlayers.Text} ");
            if (ServerHostname.Checked)
            {
                launchArgs.Append($"+server.hostname \"{ServerHostnameField.Text}\" ");
            }

            if (ServerDesc.Checked)
            {
                launchArgs.Append($"+server.description \"{ServerDescField.Text}\" ");
            }

            if (ServerUrl.Checked)
            {
                launchArgs.Append($"+server.url \"{ServerUrlField.Text}\" ");
            }

            if (ServerImage.Checked)
            {
                launchArgs.Append($"+server.headerimage \"{ServerImageField.Text}\" ");
            }

            if (ServerIdentity.Checked)
            {
                launchArgs.Append($"+server.identity \"{ServerIdentityField.Text}\" ");
            }

            if (ServerRconPort.Checked)
            {
                try
                {
                    // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                    // checks if the input is a valid interger
                    Convert.ToInt32(ServerRconPortField.Text);
                    launchArgs.Append($"+rcon.port {ServerRconPortField.Text} ");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Malformed or Blank RCON port");
                    return;
                }
            }

            if (ServerRconPassword.Checked)
            {
                launchArgs.Append($"+rcon.password {ServerRconPasswordField.Text} ");
            }

            if (ServerRconWeb.Checked)
            {
                launchArgs.Append($"+rcon.web {ServerRconWebField.Text} ");
            }

            if (Args.Checked)
            {
                MessageBox.Show(launchArgs.ToString());
                Clipboard.SetText(launchArgs.ToString());
            }

            _proc1 = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = _rustExe,
                    // ReSharper disable once AssignNullToNotNullAttribute
                    // launch button is disabled until _rustExe is set
                    WorkingDirectory = Path.GetDirectoryName(_rustExe),
                    Arguments = $"{launchArgs}",
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    CreateNoWindow = false
                }
            };
            _proc1.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}