namespace MoodPicker
{
    partial class SettingsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsBox));
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openFileAPI = new System.Windows.Forms.OpenFileDialog();
            this.apiSettingsNavbar = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpPictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpPictureBox2 = new System.Windows.Forms.PictureBox();
            this.helpPictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.apiSettingsNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Location = new System.Drawing.Point(13, 147);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(258, 20);
            this.tokenTextBox.TabIndex = 31;
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(12, 131);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(58, 13);
            this.tokenLabel.TabIndex = 30;
            this.tokenLabel.Text = "API Token";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(13, 105);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(258, 20);
            this.keyTextBox.TabIndex = 21;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(12, 89);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(45, 13);
            this.keyLabel.TabIndex = 20;
            this.keyLabel.Text = "API Key";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(12, 50);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(258, 20);
            this.serverTextBox.TabIndex = 11;
            this.serverTextBox.WordWrap = false;
            this.serverTextBox.TextChanged += new System.EventHandler(this.serverTextBox_TextChanged);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(12, 34);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(63, 13);
            this.serverLabel.TabIndex = 10;
            this.serverLabel.Text = "Server URL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 35);
            this.panel1.TabIndex = 28;
            // 
            // saveButton
            // 
            this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveButton.Location = new System.Drawing.Point(64, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 50;
            this.saveButton.Text = "OK";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(145, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 60;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openFileAPI
            // 
            this.openFileAPI.Filter = "XML files|*.xml";
            this.openFileAPI.Title = "Import API settings file";
            // 
            // apiSettingsNavbar
            // 
            this.apiSettingsNavbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem1,
            this.importFileToolStripMenuItem1});
            this.apiSettingsNavbar.Location = new System.Drawing.Point(0, 0);
            this.apiSettingsNavbar.Name = "apiSettingsNavbar";
            this.apiSettingsNavbar.Size = new System.Drawing.Size(284, 24);
            this.apiSettingsNavbar.TabIndex = 1;
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFileToolStripMenuItem,
            this.testconnectionToolStripMenuItem});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.importFileToolStripMenuItem.Text = "&Import file";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // testconnectionToolStripMenuItem
            // 
            this.testconnectionToolStripMenuItem.Name = "testconnectionToolStripMenuItem";
            this.testconnectionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.testconnectionToolStripMenuItem.Text = "Test &connection";
            this.testconnectionToolStripMenuItem.Click += new System.EventHandler(this.testConnectionToolStripMenuItem_Click);
            // 
            // importFileToolStripMenuItem1
            // 
            this.importFileToolStripMenuItem1.Name = "importFileToolStripMenuItem1";
            this.importFileToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.importFileToolStripMenuItem1.Text = "&Import file";
            this.importFileToolStripMenuItem1.Visible = false;
            this.importFileToolStripMenuItem1.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testConnectionButton.Location = new System.Drawing.Point(87, 186);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(111, 23);
            this.testConnectionButton.TabIndex = 40;
            this.testConnectionButton.Text = "Test connection";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionToolStripMenuItem_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // helpPictureBox1
            // 
            this.helpPictureBox1.Location = new System.Drawing.Point(254, 31);
            this.helpPictureBox1.Name = "helpPictureBox1";
            this.helpPictureBox1.Size = new System.Drawing.Size(16, 16);
            this.helpPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpPictureBox1.TabIndex = 31;
            this.helpPictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.helpPictureBox1, "The full URL where the MoodPicker webapp is hosted, such as http://domain.tld/moo" +
        "ds/.");
            // 
            // helpPictureBox2
            // 
            this.helpPictureBox2.Location = new System.Drawing.Point(254, 86);
            this.helpPictureBox2.Name = "helpPictureBox2";
            this.helpPictureBox2.Size = new System.Drawing.Size(16, 16);
            this.helpPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpPictureBox2.TabIndex = 32;
            this.helpPictureBox2.TabStop = false;
            this.toolTip.SetToolTip(this.helpPictureBox2, "The API key used to connect to the API server");
            // 
            // helpPictureBox3
            // 
            this.helpPictureBox3.Location = new System.Drawing.Point(254, 128);
            this.helpPictureBox3.Name = "helpPictureBox3";
            this.helpPictureBox3.Size = new System.Drawing.Size(16, 16);
            this.helpPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpPictureBox3.TabIndex = 33;
            this.helpPictureBox3.TabStop = false;
            this.toolTip.SetToolTip(this.helpPictureBox3, "The API token used to connect to the API server");
            // 
            // SettingsBox
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.helpPictureBox3);
            this.Controls.Add(this.helpPictureBox2);
            this.Controls.Add(this.helpPictureBox1);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(this.tokenLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.apiSettingsNavbar);
            this.Controls.Add(this.serverTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.apiSettingsNavbar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.apiSettingsNavbar.ResumeLayout(false);
            this.apiSettingsNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog openFileAPI;
        private System.Windows.Forms.MenuStrip apiSettingsNavbar;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testconnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem1;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox helpPictureBox1;
        private System.Windows.Forms.PictureBox helpPictureBox2;
        private System.Windows.Forms.PictureBox helpPictureBox3;



    }
}