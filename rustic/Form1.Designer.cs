namespace rustic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.ServerSeed = new System.Windows.Forms.CheckBox();
            this.ServerSeedField = new System.Windows.Forms.TextBox();
            this.ServerWorldSize = new System.Windows.Forms.CheckBox();
            this.ServerRconPortField = new System.Windows.Forms.TextBox();
            this.ServerRconPort = new System.Windows.Forms.CheckBox();
            this.ServerRconPasswordField = new System.Windows.Forms.TextBox();
            this.ServerRconPassword = new System.Windows.Forms.CheckBox();
            this.ServerRconWeb = new System.Windows.Forms.CheckBox();
            this.ServerHostnameField = new System.Windows.Forms.TextBox();
            this.ServerHostname = new System.Windows.Forms.CheckBox();
            this.ServerDescField = new System.Windows.Forms.TextBox();
            this.ServerDesc = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerLevelType = new System.Windows.Forms.ComboBox();
            this.ServerBatchMode = new System.Windows.Forms.CheckBox();
            this.ServerWorldSizeField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerMaxPlayers = new System.Windows.Forms.ComboBox();
            this.ServerUrlField = new System.Windows.Forms.TextBox();
            this.ServerUrl = new System.Windows.Forms.CheckBox();
            this.ServerRconWebField = new System.Windows.Forms.ComboBox();
            this.ServerImageField = new System.Windows.Forms.TextBox();
            this.ServerImage = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerMapUrl = new System.Windows.Forms.TextBox();
            this.buttonMap = new System.Windows.Forms.Button();
            this.labelExecuatable = new System.Windows.Forms.Label();
            this.buttonExecuatable = new System.Windows.Forms.Button();
            this.ServerWipe = new System.Windows.Forms.CheckBox();
            this.ServerIdentityField = new System.Windows.Forms.TextBox();
            this.ServerIdentity = new System.Windows.Forms.CheckBox();
            this.Args = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(203, 446);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(75, 23);
            this.buttonLaunch.TabIndex = 28;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(122, 446);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ServerSeed
            // 
            this.ServerSeed.AutoSize = true;
            this.ServerSeed.Location = new System.Drawing.Point(12, 188);
            this.ServerSeed.Name = "ServerSeed";
            this.ServerSeed.Size = new System.Drawing.Size(87, 17);
            this.ServerSeed.TabIndex = 9;
            this.ServerSeed.Text = "+server.seed";
            this.ServerSeed.UseVisualStyleBackColor = true;
            // 
            // ServerSeedField
            // 
            this.ServerSeedField.Location = new System.Drawing.Point(136, 186);
            this.ServerSeedField.Name = "ServerSeedField";
            this.ServerSeedField.Size = new System.Drawing.Size(141, 20);
            this.ServerSeedField.TabIndex = 10;
            this.ServerSeedField.Text = "1234";
            // 
            // ServerWorldSize
            // 
            this.ServerWorldSize.AutoSize = true;
            this.ServerWorldSize.Location = new System.Drawing.Point(12, 213);
            this.ServerWorldSize.Name = "ServerWorldSize";
            this.ServerWorldSize.Size = new System.Drawing.Size(107, 17);
            this.ServerWorldSize.TabIndex = 11;
            this.ServerWorldSize.Text = "+server.worldsize";
            this.ServerWorldSize.UseVisualStyleBackColor = true;
            // 
            // ServerRconPortField
            // 
            this.ServerRconPortField.Location = new System.Drawing.Point(136, 237);
            this.ServerRconPortField.Name = "ServerRconPortField";
            this.ServerRconPortField.Size = new System.Drawing.Size(141, 20);
            this.ServerRconPortField.TabIndex = 14;
            this.ServerRconPortField.Text = "28016";
            // 
            // ServerRconPort
            // 
            this.ServerRconPort.AutoSize = true;
            this.ServerRconPort.Checked = true;
            this.ServerRconPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServerRconPort.Location = new System.Drawing.Point(12, 238);
            this.ServerRconPort.Name = "ServerRconPort";
            this.ServerRconPort.Size = new System.Drawing.Size(74, 17);
            this.ServerRconPort.TabIndex = 13;
            this.ServerRconPort.Text = "+rcon.port";
            this.ServerRconPort.UseVisualStyleBackColor = true;
            // 
            // ServerRconPasswordField
            // 
            this.ServerRconPasswordField.Location = new System.Drawing.Point(136, 262);
            this.ServerRconPasswordField.Name = "ServerRconPasswordField";
            this.ServerRconPasswordField.Size = new System.Drawing.Size(141, 20);
            this.ServerRconPasswordField.TabIndex = 16;
            this.ServerRconPasswordField.Text = "ChangeMe1";
            // 
            // ServerRconPassword
            // 
            this.ServerRconPassword.AutoSize = true;
            this.ServerRconPassword.Checked = true;
            this.ServerRconPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServerRconPassword.Location = new System.Drawing.Point(12, 263);
            this.ServerRconPassword.Name = "ServerRconPassword";
            this.ServerRconPassword.Size = new System.Drawing.Size(101, 17);
            this.ServerRconPassword.TabIndex = 15;
            this.ServerRconPassword.Text = "+rcon.password";
            this.ServerRconPassword.UseVisualStyleBackColor = true;
            // 
            // ServerRconWeb
            // 
            this.ServerRconWeb.AutoSize = true;
            this.ServerRconWeb.Checked = true;
            this.ServerRconWeb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServerRconWeb.Location = new System.Drawing.Point(12, 288);
            this.ServerRconWeb.Name = "ServerRconWeb";
            this.ServerRconWeb.Size = new System.Drawing.Size(76, 17);
            this.ServerRconWeb.TabIndex = 17;
            this.ServerRconWeb.Text = "+rcon.web";
            this.ServerRconWeb.UseVisualStyleBackColor = true;
            // 
            // ServerHostnameField
            // 
            this.ServerHostnameField.Location = new System.Drawing.Point(136, 313);
            this.ServerHostnameField.Name = "ServerHostnameField";
            this.ServerHostnameField.Size = new System.Drawing.Size(141, 20);
            this.ServerHostnameField.TabIndex = 20;
            this.ServerHostnameField.Text = "Rusty rust server";
            // 
            // ServerHostname
            // 
            this.ServerHostname.AutoSize = true;
            this.ServerHostname.Location = new System.Drawing.Point(12, 313);
            this.ServerHostname.Name = "ServerHostname";
            this.ServerHostname.Size = new System.Drawing.Size(110, 17);
            this.ServerHostname.TabIndex = 19;
            this.ServerHostname.Text = "+server.hostname";
            this.ServerHostname.UseVisualStyleBackColor = true;
            // 
            // ServerDescField
            // 
            this.ServerDescField.Location = new System.Drawing.Point(136, 338);
            this.ServerDescField.Name = "ServerDescField";
            this.ServerDescField.Size = new System.Drawing.Size(141, 20);
            this.ServerDescField.TabIndex = 22;
            this.ServerDescField.Text = "sooper rust server";
            // 
            // ServerDesc
            // 
            this.ServerDesc.AutoSize = true;
            this.ServerDesc.Location = new System.Drawing.Point(12, 338);
            this.ServerDesc.Name = "ServerDesc";
            this.ServerDesc.Size = new System.Drawing.Size(115, 17);
            this.ServerDesc.TabIndex = 21;
            this.ServerDesc.Text = "+server.description";
            this.ServerDesc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "+server.port";
            // 
            // ServerPort
            // 
            this.ServerPort.Location = new System.Drawing.Point(78, 6);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(100, 20);
            this.ServerPort.TabIndex = 1;
            this.ServerPort.Text = "28015";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "+server.level";
            // 
            // ServerLevelType
            // 
            this.ServerLevelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerLevelType.FormattingEnabled = true;
            this.ServerLevelType.Items.AddRange(new object[] {
            "Custom Map",
            "Procedural Map"});
            this.ServerLevelType.Location = new System.Drawing.Point(78, 30);
            this.ServerLevelType.Name = "ServerLevelType";
            this.ServerLevelType.Size = new System.Drawing.Size(100, 21);
            this.ServerLevelType.TabIndex = 3;
            // 
            // ServerBatchMode
            // 
            this.ServerBatchMode.AutoSize = true;
            this.ServerBatchMode.Checked = true;
            this.ServerBatchMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ServerBatchMode.Location = new System.Drawing.Point(184, 8);
            this.ServerBatchMode.Name = "ServerBatchMode";
            this.ServerBatchMode.Size = new System.Drawing.Size(82, 17);
            this.ServerBatchMode.TabIndex = 2;
            this.ServerBatchMode.Text = "-batchmode";
            this.ServerBatchMode.UseVisualStyleBackColor = true;
            // 
            // ServerWorldSizeField
            // 
            this.ServerWorldSizeField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerWorldSizeField.FormattingEnabled = true;
            this.ServerWorldSizeField.ItemHeight = 13;
            this.ServerWorldSizeField.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000"});
            this.ServerWorldSizeField.Location = new System.Drawing.Point(136, 211);
            this.ServerWorldSizeField.Name = "ServerWorldSizeField";
            this.ServerWorldSizeField.Size = new System.Drawing.Size(141, 21);
            this.ServerWorldSizeField.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "+server.maxplayers";
            // 
            // ServerMaxPlayers
            // 
            this.ServerMaxPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerMaxPlayers.FormattingEnabled = true;
            this.ServerMaxPlayers.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "25",
            "50",
            "100",
            "200",
            "300",
            "500"});
            this.ServerMaxPlayers.Location = new System.Drawing.Point(113, 55);
            this.ServerMaxPlayers.Name = "ServerMaxPlayers";
            this.ServerMaxPlayers.Size = new System.Drawing.Size(65, 21);
            this.ServerMaxPlayers.TabIndex = 4;
            // 
            // ServerUrlField
            // 
            this.ServerUrlField.Location = new System.Drawing.Point(136, 363);
            this.ServerUrlField.Name = "ServerUrlField";
            this.ServerUrlField.Size = new System.Drawing.Size(141, 20);
            this.ServerUrlField.TabIndex = 24;
            this.ServerUrlField.Text = "http://www.myserver.com";
            // 
            // ServerUrl
            // 
            this.ServerUrl.AutoSize = true;
            this.ServerUrl.Location = new System.Drawing.Point(12, 363);
            this.ServerUrl.Name = "ServerUrl";
            this.ServerUrl.Size = new System.Drawing.Size(75, 17);
            this.ServerUrl.TabIndex = 23;
            this.ServerUrl.Text = "+server.url";
            this.ServerUrl.UseVisualStyleBackColor = true;
            // 
            // ServerRconWebField
            // 
            this.ServerRconWebField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerRconWebField.FormattingEnabled = true;
            this.ServerRconWebField.Items.AddRange(new object[] {
            "1",
            "0"});
            this.ServerRconWebField.Location = new System.Drawing.Point(136, 287);
            this.ServerRconWebField.Name = "ServerRconWebField";
            this.ServerRconWebField.Size = new System.Drawing.Size(141, 21);
            this.ServerRconWebField.TabIndex = 18;
            // 
            // ServerImageField
            // 
            this.ServerImageField.Location = new System.Drawing.Point(136, 388);
            this.ServerImageField.Name = "ServerImageField";
            this.ServerImageField.Size = new System.Drawing.Size(141, 20);
            this.ServerImageField.TabIndex = 26;
            this.ServerImageField.Text = "http://www.myserver.com/server.jpg";
            // 
            // ServerImage
            // 
            this.ServerImage.AutoSize = true;
            this.ServerImage.Location = new System.Drawing.Point(12, 388);
            this.ServerImage.Name = "ServerImage";
            this.ServerImage.Size = new System.Drawing.Size(125, 17);
            this.ServerImage.TabIndex = 25;
            this.ServerImage.Text = "+server.headerimage";
            this.ServerImage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Map Url";
            // 
            // ServerMapUrl
            // 
            this.ServerMapUrl.Location = new System.Drawing.Point(12, 160);
            this.ServerMapUrl.Name = "ServerMapUrl";
            this.ServerMapUrl.Size = new System.Drawing.Size(265, 20);
            this.ServerMapUrl.TabIndex = 8;
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(202, 131);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(75, 23);
            this.buttonMap.TabIndex = 7;
            this.buttonMap.Text = "Browse";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // labelExecuatable
            // 
            this.labelExecuatable.AutoSize = true;
            this.labelExecuatable.Location = new System.Drawing.Point(92, 88);
            this.labelExecuatable.Name = "labelExecuatable";
            this.labelExecuatable.Size = new System.Drawing.Size(189, 13);
            this.labelExecuatable.TabIndex = 32;
            this.labelExecuatable.Text = "Please Select your RustDedicated.exe";
            // 
            // buttonExecuatable
            // 
            this.buttonExecuatable.Location = new System.Drawing.Point(11, 83);
            this.buttonExecuatable.Name = "buttonExecuatable";
            this.buttonExecuatable.Size = new System.Drawing.Size(75, 23);
            this.buttonExecuatable.TabIndex = 5;
            this.buttonExecuatable.Text = "Browse";
            this.buttonExecuatable.UseVisualStyleBackColor = true;
            this.buttonExecuatable.Click += new System.EventHandler(this.buttonExecuatable_Click);
            // 
            // ServerWipe
            // 
            this.ServerWipe.AutoSize = true;
            this.ServerWipe.Location = new System.Drawing.Point(13, 113);
            this.ServerWipe.Name = "ServerWipe";
            this.ServerWipe.Size = new System.Drawing.Size(137, 17);
            this.ServerWipe.TabIndex = 6;
            this.ServerWipe.Text = "Wipe On Launch (WIP)";
            this.ServerWipe.UseVisualStyleBackColor = true;
            // 
            // ServerIdentityField
            // 
            this.ServerIdentityField.Location = new System.Drawing.Point(136, 414);
            this.ServerIdentityField.Name = "ServerIdentityField";
            this.ServerIdentityField.Size = new System.Drawing.Size(141, 20);
            this.ServerIdentityField.TabIndex = 34;
            this.ServerIdentityField.Text = "server1";
            // 
            // ServerIdentity
            // 
            this.ServerIdentity.AutoSize = true;
            this.ServerIdentity.Location = new System.Drawing.Point(12, 414);
            this.ServerIdentity.Name = "ServerIdentity";
            this.ServerIdentity.Size = new System.Drawing.Size(97, 17);
            this.ServerIdentity.TabIndex = 33;
            this.ServerIdentity.Text = "+server.identity";
            this.ServerIdentity.UseVisualStyleBackColor = true;
            // 
            // Args
            // 
            this.Args.AutoSize = true;
            this.Args.Location = new System.Drawing.Point(12, 449);
            this.Args.Name = "Args";
            this.Args.Size = new System.Drawing.Size(108, 17);
            this.Args.TabIndex = 35;
            this.Args.Text = "Copy to clipboard";
            this.Args.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 478);
            this.Controls.Add(this.Args);
            this.Controls.Add(this.ServerIdentityField);
            this.Controls.Add(this.ServerIdentity);
            this.Controls.Add(this.ServerWipe);
            this.Controls.Add(this.buttonExecuatable);
            this.Controls.Add(this.labelExecuatable);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.ServerMapUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ServerImageField);
            this.Controls.Add(this.ServerImage);
            this.Controls.Add(this.ServerRconWebField);
            this.Controls.Add(this.ServerUrlField);
            this.Controls.Add(this.ServerUrl);
            this.Controls.Add(this.ServerMaxPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerWorldSizeField);
            this.Controls.Add(this.ServerBatchMode);
            this.Controls.Add(this.ServerLevelType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerDescField);
            this.Controls.Add(this.ServerDesc);
            this.Controls.Add(this.ServerHostnameField);
            this.Controls.Add(this.ServerHostname);
            this.Controls.Add(this.ServerRconWeb);
            this.Controls.Add(this.ServerRconPasswordField);
            this.Controls.Add(this.ServerRconPassword);
            this.Controls.Add(this.ServerRconPortField);
            this.Controls.Add(this.ServerRconPort);
            this.Controls.Add(this.ServerWorldSize);
            this.Controls.Add(this.ServerSeedField);
            this.Controls.Add(this.ServerSeed);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLaunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rustic Server Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox ServerSeed;
        private System.Windows.Forms.TextBox ServerSeedField;
        private System.Windows.Forms.CheckBox ServerWorldSize;
        private System.Windows.Forms.TextBox ServerRconPortField;
        private System.Windows.Forms.CheckBox ServerRconPort;
        private System.Windows.Forms.TextBox ServerRconPasswordField;
        private System.Windows.Forms.CheckBox ServerRconPassword;
        private System.Windows.Forms.CheckBox ServerRconWeb;
        private System.Windows.Forms.TextBox ServerHostnameField;
        private System.Windows.Forms.CheckBox ServerHostname;
        private System.Windows.Forms.TextBox ServerDescField;
        private System.Windows.Forms.CheckBox ServerDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServerLevelType;
        private System.Windows.Forms.CheckBox ServerBatchMode;
        private System.Windows.Forms.ComboBox ServerWorldSizeField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ServerMaxPlayers;
        private System.Windows.Forms.TextBox ServerUrlField;
        private System.Windows.Forms.CheckBox ServerUrl;
        private System.Windows.Forms.ComboBox ServerRconWebField;
        private System.Windows.Forms.TextBox ServerImageField;
        private System.Windows.Forms.CheckBox ServerImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ServerMapUrl;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Label labelExecuatable;
        private System.Windows.Forms.Button buttonExecuatable;
        private System.Windows.Forms.CheckBox ServerWipe;
        private System.Windows.Forms.TextBox ServerIdentityField;
        private System.Windows.Forms.CheckBox ServerIdentity;
        private System.Windows.Forms.CheckBox Args;
    }
}

