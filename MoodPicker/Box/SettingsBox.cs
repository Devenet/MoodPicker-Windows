using MoodPicker.Box;
using MoodPicker.ApiHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MoodPicker
{
    public partial class SettingsBox : Form
    {
        public SettingsBox()
        {
            InitializeComponent();
            
            serverTextBox.Text = Properties.Settings.Default.API_Server;
            keyTextBox.Text = Properties.Settings.Default.API_Key;
            tokenTextBox.Text = Properties.Settings.Default.API_Token;
            helpPictureBox1.Image = System.Drawing.SystemIcons.Question.ToBitmap();
            helpPictureBox2.Image = System.Drawing.SystemIcons.Question.ToBitmap();
            helpPictureBox3.Image = System.Drawing.SystemIcons.Question.ToBitmap();

            serverTextBox.SelectionStart = 0;

            testConnectionButton.Enabled = serverTextBox.Text.Length > 0 && Api.CheckUri(serverTextBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Api api = new Api(serverTextBox.Text, keyTextBox.Text, tokenTextBox.Text);   

            Properties.Settings.Default.API_Server = api.Server;
            Properties.Settings.Default.API_Key = api.Key;
            Properties.Settings.Default.API_Token = api.Token;
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            base.OnClosing(e);
        }

        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileAPI.ShowDialog() == DialogResult.OK)
            {
                this.UseWaitCursor = true;

                XmlDocument settings = new XmlDocument();
                XmlNode api_key, api_token, api_server;

                try {
                    settings.Load(openFileAPI.FileName);

                    api_server = settings.DocumentElement.SelectSingleNode("/configuration/api/server");
                    serverTextBox.Text = api_server.InnerText;

                    api_key = settings.DocumentElement.SelectSingleNode("/configuration/api/key");
                    keyTextBox.Text = api_key.InnerText;

                    api_token = settings.DocumentElement.SelectSingleNode("/configuration/api/token");
                    tokenTextBox.Text = api_token.InnerText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to load the given XML settings file." + Environment.NewLine + "Details: " + ex.Message,
                        "Holy crap!", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                        );
                }

                this.UseWaitCursor = false;
            }
        }

        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ConnectionTestBox tcb = new ConnectionTestBox(serverTextBox.Text, keyTextBox.Text, tokenTextBox.Text);
            if (tcb.ContainsFocus) { tcb.FormClosed += tcb_FormClosed; }
            else { this.Enabled = true; }
            
        }

        void tcb_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void serverTextBox_TextChanged(object sender, EventArgs e)
        {
            testConnectionButton.Enabled = serverTextBox.Text.Length > 0 && Api.CheckUri(serverTextBox.Text);            
        }

    }
}
