using MoodPicker.ApiHelper;
using MoodPicker.Box;
using MoodPicker.Tools;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MoodPicker
{
    public partial class MoodPicker : Form
    {

        const string BALLON_TITLE = "Mood Picker";
        const int BALLON_SHORT_TIMEOUT = 2000;
        const int BALLON_TIMEOUT = 6000;
        const int BALLON_LONG_TIMEOUT = 10000;

        const int TICK_INTERVAL = 15000;            // 15 secondes
        const int TICK_INTERVAL_HIDDEN = 1800000;   // 30 minutes

        const string STATUS_DISCONNECTED = "Not connected";
        const string STATUS_CONNECTED = "Partially connected";
        const string STATUS_AUTHENTIFICATED = "Connected";

        private bool exit = false;
        private bool authentificated = false;

        public MoodPicker(string[] args)
        {
            Logger.Log("Running with arguments: " + string.Join(", ", args));

            InitializeComponent();
            #if DEBUG
            debugToolStripMenuItem.Visible = true;
            quitToolStripMenuItem.Visible = true;
            #endif
            dayLabel.Text = DateTime.Now.ToString("dd MMM yyyy");
            this.DisableMoodChart();

            if (args.Length > 0 && args[0] == Program.ARGS_INTRAY)
                timer.Interval = TICK_INTERVAL_HIDDEN;
            else
                timer.Interval = TICK_INTERVAL;
            
            timer.Start();
            this.UpdateStatus();
        }

        /*
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Minimized) {
                this.MinimizeToTray();
            }
        }
        */

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (! this.exit)
            {
                e.Cancel = true;
                this.MinimizeToTray();
            }
            base.OnFormClosing(e);
        }

        private void MinimizeToTray()
        {
            if (Properties.Settings.Default.NotificationHelper)
            {
                this.notification.ShowBalloonTip(
                    BALLON_LONG_TIMEOUT,
                    BALLON_TITLE,
                    "I'm running on background if you need me! \nDouble click the icon to open Mood Picker.",
                    ToolTipIcon.Info);
                Properties.Settings.Default.NotificationHelper = false;
                Properties.Settings.Default.Save();
            }
            
            this.timer.Interval = TICK_INTERVAL_HIDDEN;
            this.Hide();
        }

        private void ShowOutOfTray()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.timer.Interval = TICK_INTERVAL;
            this.UpdateStatus();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exit = true;
            Application.Exit();
        }

        private void closeStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MinimizeToTray();
        }

        private void notification_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowOutOfTray();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowOutOfTray();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // update buttons state
            this.UpdateSubmitButtons();
            // update moods
            this.UpdateMoods();
        }

        private void settingsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
            SettingsBox box = new SettingsBox();
            box.FormClosed += new FormClosedEventHandler(settingsBox_Closed);
            box.ShowDialog();
        }

        private void settingsBox_Closed(object sender, FormClosedEventArgs e)
        {
            Logger.Log("SettingsBox closed");
            this.UpdateStatus();
            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Logger.Log("Tic");

            if (this.Visible)
            {
                this.UpdateStatus();
            }
            else if (Helper.CanSubmitMood())
            {
                this.notification.BalloonTipClicked += new EventHandler(notification_BalloonTipClicked);
                this.notification.ShowBalloonTip(
                    BALLON_TIMEOUT,
                    BALLON_TITLE,
                    String.Format("Come on, share your {0} mood!", DateTime.Now.TimeOfDay < Helper.TIME_MIDDLE ? "morning" : "afternoon"), 
                    ToolTipIcon.None);
                Logger.Log("BallonToolTip shown");
            }
            
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void UpdateStatus()
        {
            Logger.Log("Update status");
            EnableProgressBar();
            if (Api.IsAuthentificated())
            {
                statusToolStripStatusLabel.Text = STATUS_AUTHENTIFICATED;
                statusToolStripStatusLabel.ToolTipText = "Connected and authentificated to the API server.";
                statusToolStripStatusLabel.ForeColor = Color.Green;
                this.authentificated = true;
            }
            else if (Api.IsConnected())
            {
                statusToolStripStatusLabel.Text = STATUS_CONNECTED;
                statusToolStripStatusLabel.ToolTipText = "Connected but not authentificated to the API server.";
                statusToolStripStatusLabel.ForeColor = Color.Orange;
                this.authentificated = false;
            }
            else
            {
                statusToolStripStatusLabel.Text = STATUS_DISCONNECTED;
                statusToolStripStatusLabel.ToolTipText = "Not connected to the API server. Maybe the API server is wrong?";
                statusToolStripStatusLabel.ForeColor = Color.Red;
                this.authentificated = false;
            }
            DisableProgressBar();
            
            this.UpdateSubmitButtons();
            this.UpdateMoods();
        }

        private void UpdateSubmitButtons()
        {
            Logger.Log("Update buttons state");
            if (this.authentificated && Helper.CanSubmitMood())
            {
                EnableSubmitButtons();
            }
            else
            {
                DisableSubmitButtons();
            }
            this.UpdateSubmitLabel();
        }

        private void UpdateMoods()
        {
            Logger.Log("Update moods chart");

            EnableProgressBar();
            Api api = new Api(
                Properties.Settings.Default.API_Server,
                Properties.Settings.Default.API_Key,
                Properties.Settings.Default.API_Token);
            if (api.CheckApi())
            {
                try
                {
                    ApiMoods moods = api.GetMoods(DateTime.Now.ToString("yyyy-MM-dd"));
                    if (moods.moods_count > 0)
                    {
                        int[] result = Helper.GetMoodsCount(moods);

                        goodMoodPictureBox.Size = new Size(result[0] * panelMoods.Width / moods.moods_count, panelMoods.Height);
                        badMoodPictureBox.Size = new Size(result[1] * panelMoods.Width / moods.moods_count, panelMoods.Height);
                        badMoodPictureBox.Location = new Point(result[0] * panelMoods.Width / moods.moods_count, 0);

                        goodMoodLabel.Text = result[0].ToString();
                        badMoodLabel.Text = result[1].ToString();

                        EnableMoodChart();
                    }
                    else
                    {
                        //("No shared mood for today. Submit yours!");

                        goodMoodPictureBox.Size = new Size(0, 0);
                        badMoodPictureBox.Size = new Size(0, 0);

                        panelMoods.BackColor = Color.Gray;

                        goodMoodLabel.Text = "0";
                        badMoodLabel.Text = "0";

                        EnableMoodChart();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                    DisableMoodChart();
                }
            }
            else
            {
                DisableMoodChart();
            }
            DisableProgressBar();
        }

        private void EnableProgressBar()
        {
            toolStripProgressBar.Visible = true;
        }
        private void DisableProgressBar()
        {
            toolStripProgressBar.Visible = false;
        }

        private void EnableMoodChart()
        {
            goodMoodLabel.Visible = true;
            badMoodLabel.Visible = true;
            panelMoods.Visible = true;
        }
        private void DisableMoodChart()
        {
            goodMoodLabel.Visible = false;
            badMoodLabel.Visible = false;
            panelMoods.Visible = false;
        }


        private void EnableSubmitButtons()
        {
            goodPictureBox.Enabled = true;
            goodPictureBox.Image = Properties.Resources.Good;

            badPictureBox.Enabled = true;
            badPictureBox.Image = Properties.Resources.Bad;
        }
        private void DisableSubmitButtons()
        {
            goodPictureBox.Enabled = false;
            badPictureBox.Enabled = false;

            goodPictureBox.Image = Properties.Resources.GoodDisabled;
            badPictureBox.Image = Properties.Resources.BadDisabled;

            if (!Helper.CanSubmitMood() && (Properties.Data.Default.LastMood != 0))
            {
                if (Properties.Data.Default.LastMood == ApiMood.GOOD)
                    goodPictureBox.Image = Properties.Resources.Good;
                else
                    badPictureBox.Image = Properties.Resources.Bad;
            }
        }


        private void SubmitMood(int submitMood)
        {
            if (!Helper.CanSubmitMood())
            {
                bool morning = DateTime.Now.Hour < 13;
                MessageBox.Show(
                    String.Format("You have already submit your mood for this {0}." +
                        Environment.NewLine + "Submit your mood again {1} :)",
                        morning ? "morning" : "afternoon",
                        morning ? "this afternoon" : "tomorrow"),
                    "Holy crap!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (Api.IsAuthentificated())
            {
                EnableProgressBar();
                Api api = new Api(
                    Properties.Settings.Default.API_Server,
                    Properties.Settings.Default.API_Key,
                    Properties.Settings.Default.API_Token);
                try
                {

                    ApiMood mood = api.SubmitMood(submitMood, api.GetToken());
                    Properties.Data.Default.LastSubmit = DateTime.Now;
                    Properties.Data.Default.LastMood = submitMood;
                    Properties.Data.Default.Save();

                    this.notification.ShowBalloonTip(
                        BALLON_TIMEOUT,
                        BALLON_TITLE,
                        "Thanks for sharing your mood :) !",
                        ToolTipIcon.None);

                    Logger.Log("Submited mood: " + mood.Mood + " at " + Helper.TimestampToDate(mood.timestamp));
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message + Environment.NewLine + ex.StackTrace);
                    MessageBox.Show("Unable to submit your mood." + Environment.NewLine + "Please try again.",
                        "Holy crap!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                DisableProgressBar();
            }
            this.UpdateSubmitButtons();
            this.UpdateMoods();
        }

        private void goodPictureBox_MouseEnter(object sender, EventArgs e)
        {
            goodPictureBox.Image = Properties.Resources.GoodHover;
        }
        private void goodPictureBox_MouseLeave(object sender, EventArgs e)
        {
            goodPictureBox.Image = Properties.Resources.Good;
        }
        private void badPictureBox_MouseEnter(object sender, EventArgs e)
        {
            badPictureBox.Image = Properties.Resources.BadHover;
        }
        private void badPictureBox_MouseLeave(object sender, EventArgs e)
        {
            badPictureBox.Image = Properties.Resources.Bad;
        }

        private void goodPictureBox_Click(object sender, EventArgs e)
        {
            SubmitMood(ApiMood.GOOD);
        }

        private void badPictureBox_Click(object sender, EventArgs e)
        {
            SubmitMood(ApiMood.BAD);
        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitMood(ApiMood.GOOD);
        }

        private void statusToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            this.UpdateStatus();
        }

        private void submitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Properties.Data.Default.LastSubmit = DateTime.Now.AddDays(-1);
            this.UpdateSubmitButtons();
        }

        private void lastSubmitpersistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Data.Default.LastSubmit = DateTime.Now.AddDays(-1);
            Properties.Data.Default.Save();
            this.UpdateSubmitButtons();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void submitButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSubmitButtons();
        }

        private void goodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitMood(ApiMood.GOOD);
        }

        private void badToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitMood(ApiMood.BAD);
        }

        private void lastSubmitmorningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Data.Default.LastSubmit = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0);
            this.UpdateSubmitButtons();
        }

        private void UpdateSubmitLabel()
        {
            if (Helper.CanSubmitMood())
            {
                submitStatusToolStripStatusLabel.Text = "Not voted"; ;
                submitStatusToolStripStatusLabel.ToolTipText = String.Format("Submit your {0} mood!",
                    DateTime.Now.TimeOfDay < Helper.TIME_MIDDLE ? "morning" : "afternoon");
            }
            else
            {
                submitStatusToolStripStatusLabel.Text = "Voted";
                submitStatusToolStripStatusLabel.ToolTipText = String.Format("{0} mood shared",
                    DateTime.Now.TimeOfDay < Helper.TIME_MIDDLE ? "Morning" : "Afternoon");
            }
        }

        private void notification_BalloonTipClicked(object sender, EventArgs e)
        {
            this.ShowOutOfTray();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void browseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Api.IsConnected())
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.API_Server + Api.DETAILS_PAGE);
            }
            else
            {
                MessageBox.Show("You are not connected to a server." + Environment.NewLine + "Please fix it and try again.",
                    "Holy crap!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
