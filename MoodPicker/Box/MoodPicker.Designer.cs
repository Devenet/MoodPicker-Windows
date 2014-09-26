namespace MoodPicker
{
    partial class MoodPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoodPicker));
            this.navbar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastSubmitpersistantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastSubmitmorningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.notification_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.badPictureBox = new System.Windows.Forms.PictureBox();
            this.goodPictureBox = new System.Windows.Forms.PictureBox();
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.submitToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.submitStatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMoods = new System.Windows.Forms.Panel();
            this.badMoodPictureBox = new System.Windows.Forms.PictureBox();
            this.goodMoodPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.goodMoodLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.badMoodLabel = new System.Windows.Forms.Label();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navbar.SuspendLayout();
            this.notification_menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodPictureBox)).BeginInit();
            this.status_strip.SuspendLayout();
            this.panelMoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badMoodPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodMoodPictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(461, 24);
            this.navbar.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsStripMenuItem,
            this.toolStripSeparator3,
            this.closeStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // settingsStripMenuItem
            // 
            this.settingsStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsStripMenuItem.Name = "settingsStripMenuItem";
            this.settingsStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsStripMenuItem.Text = "&Settings";
            this.settingsStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.settingsStripMenuItem.Click += new System.EventHandler(this.settingsStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // closeStripMenuItem
            // 
            this.closeStripMenuItem.Name = "closeStripMenuItem";
            this.closeStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeStripMenuItem.Text = "&Close";
            this.closeStripMenuItem.Click += new System.EventHandler(this.closeStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Visible = false;
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "About this application";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.submitToolStripMenuItem1});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "&Debug";
            this.debugToolStripMenuItem.Visible = false;
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
            this.lastSubmitpersistantToolStripMenuItem,
            this.lastSubmitmorningToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.submitToolStripMenuItem.Text = "LastSubmit";
            this.submitToolStripMenuItem.Click += new System.EventHandler(this.submitToolStripMenuItem_Click_1);
            // 
            // lastSubmitpersistantToolStripMenuItem
            // 
            this.lastSubmitpersistantToolStripMenuItem.Name = "lastSubmitpersistantToolStripMenuItem";
            this.lastSubmitpersistantToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.lastSubmitpersistantToolStripMenuItem.Text = "LastSubmit (persistant)";
            this.lastSubmitpersistantToolStripMenuItem.Click += new System.EventHandler(this.lastSubmitpersistantToolStripMenuItem_Click);
            // 
            // lastSubmitmorningToolStripMenuItem
            // 
            this.lastSubmitmorningToolStripMenuItem.Name = "lastSubmitmorningToolStripMenuItem";
            this.lastSubmitmorningToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.lastSubmitmorningToolStripMenuItem.Text = "LastSubmit (morning)";
            this.lastSubmitmorningToolStripMenuItem.Click += new System.EventHandler(this.lastSubmitmorningToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.submitButtonsToolStripMenuItem});
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem1.Text = "&Update";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // submitButtonsToolStripMenuItem
            // 
            this.submitButtonsToolStripMenuItem.Name = "submitButtonsToolStripMenuItem";
            this.submitButtonsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.submitButtonsToolStripMenuItem.Text = "SubmitButtons";
            this.submitButtonsToolStripMenuItem.Click += new System.EventHandler(this.submitButtonsToolStripMenuItem_Click);
            // 
            // submitToolStripMenuItem1
            // 
            this.submitToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodToolStripMenuItem,
            this.badToolStripMenuItem});
            this.submitToolStripMenuItem1.Name = "submitToolStripMenuItem1";
            this.submitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.submitToolStripMenuItem1.Text = "&Submit";
            // 
            // goodToolStripMenuItem
            // 
            this.goodToolStripMenuItem.Name = "goodToolStripMenuItem";
            this.goodToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.goodToolStripMenuItem.Text = "Good";
            this.goodToolStripMenuItem.Click += new System.EventHandler(this.goodToolStripMenuItem_Click);
            // 
            // badToolStripMenuItem
            // 
            this.badToolStripMenuItem.Name = "badToolStripMenuItem";
            this.badToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.badToolStripMenuItem.Text = "Bad";
            this.badToolStripMenuItem.Click += new System.EventHandler(this.badToolStripMenuItem_Click);
            // 
            // notification
            // 
            this.notification.BalloonTipTitle = "Mood Picker";
            this.notification.ContextMenuStrip = this.notification_menu;
            this.notification.Icon = ((System.Drawing.Icon)(resources.GetObject("notification.Icon")));
            this.notification.Text = "Mood Picker";
            this.notification.Visible = true;
            this.notification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notification_MouseDoubleClick);
            // 
            // notification_menu
            // 
            this.notification_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem1});
            this.notification_menu.Name = "notification_menu";
            this.notification_menu.Size = new System.Drawing.Size(105, 54);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(101, 6);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.quitToolStripMenuItem1.Text = "&Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1800000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.badPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.goodPictureBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 128);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // badPictureBox
            // 
            this.badPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.badPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badPictureBox.Image = global::MoodPicker.Properties.Resources.Bad;
            this.badPictureBox.Location = new System.Drawing.Point(245, 14);
            this.badPictureBox.Name = "badPictureBox";
            this.badPictureBox.Size = new System.Drawing.Size(200, 100);
            this.badPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.badPictureBox.TabIndex = 1;
            this.badPictureBox.TabStop = false;
            this.badPictureBox.Click += new System.EventHandler(this.badPictureBox_Click);
            this.badPictureBox.MouseEnter += new System.EventHandler(this.badPictureBox_MouseEnter);
            this.badPictureBox.MouseLeave += new System.EventHandler(this.badPictureBox_MouseLeave);
            // 
            // goodPictureBox
            // 
            this.goodPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goodPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goodPictureBox.Image = global::MoodPicker.Properties.Resources.Good;
            this.goodPictureBox.Location = new System.Drawing.Point(15, 14);
            this.goodPictureBox.Name = "goodPictureBox";
            this.goodPictureBox.Size = new System.Drawing.Size(200, 100);
            this.goodPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.goodPictureBox.TabIndex = 0;
            this.goodPictureBox.TabStop = false;
            this.goodPictureBox.Click += new System.EventHandler(this.goodPictureBox_Click);
            this.goodPictureBox.MouseEnter += new System.EventHandler(this.goodPictureBox_MouseEnter);
            this.goodPictureBox.MouseLeave += new System.EventHandler(this.goodPictureBox_MouseLeave);
            // 
            // status_strip
            // 
            this.status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel,
            this.submitToolStripStatusLabel,
            this.toolStripProgressBar,
            this.submitStatusToolStripStatusLabel});
            this.status_strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.status_strip.Location = new System.Drawing.Point(0, 258);
            this.status_strip.Name = "status_strip";
            this.status_strip.ShowItemToolTips = true;
            this.status_strip.Size = new System.Drawing.Size(461, 24);
            this.status_strip.SizingGrip = false;
            this.status_strip.TabIndex = 3;
            // 
            // statusToolStripStatusLabel
            // 
            this.statusToolStripStatusLabel.AutoToolTip = true;
            this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
            this.statusToolStripStatusLabel.Size = new System.Drawing.Size(59, 19);
            this.statusToolStripStatusLabel.Text = "Loading...";
            this.statusToolStripStatusLabel.Click += new System.EventHandler(this.statusToolStripStatusLabel_Click);
            // 
            // submitToolStripStatusLabel
            // 
            this.submitToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.submitToolStripStatusLabel.Name = "submitToolStripStatusLabel";
            this.submitToolStripStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.submitToolStripStatusLabel.Text = "Submitted";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 18);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // submitStatusToolStripStatusLabel
            // 
            this.submitStatusToolStripStatusLabel.AutoToolTip = true;
            this.submitStatusToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.submitStatusToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.submitStatusToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.submitStatusToolStripStatusLabel.Name = "submitStatusToolStripStatusLabel";
            this.submitStatusToolStripStatusLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.submitStatusToolStripStatusLabel.Size = new System.Drawing.Size(77, 19);
            this.submitStatusToolStripStatusLabel.Text = "Share infos";
            // 
            // panelMoods
            // 
            this.panelMoods.Controls.Add(this.badMoodPictureBox);
            this.panelMoods.Controls.Add(this.goodMoodPictureBox);
            this.panelMoods.Location = new System.Drawing.Point(12, 193);
            this.panelMoods.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panelMoods.Name = "panelMoods";
            this.panelMoods.Size = new System.Drawing.Size(437, 52);
            this.panelMoods.TabIndex = 4;
            // 
            // badMoodPictureBox
            // 
            this.badMoodPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.badMoodPictureBox.Location = new System.Drawing.Point(230, 0);
            this.badMoodPictureBox.Name = "badMoodPictureBox";
            this.badMoodPictureBox.Size = new System.Drawing.Size(100, 52);
            this.badMoodPictureBox.TabIndex = 1;
            this.badMoodPictureBox.TabStop = false;
            // 
            // goodMoodPictureBox
            // 
            this.goodMoodPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.goodMoodPictureBox.Location = new System.Drawing.Point(0, 0);
            this.goodMoodPictureBox.Name = "goodMoodPictureBox";
            this.goodMoodPictureBox.Size = new System.Drawing.Size(100, 52);
            this.goodMoodPictureBox.TabIndex = 0;
            this.goodMoodPictureBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.97531F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.02469F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.Controls.Add(this.goodMoodLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dayLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.badMoodLabel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 170);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 23);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // goodMoodLabel
            // 
            this.goodMoodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodMoodLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodMoodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.goodMoodLabel.Location = new System.Drawing.Point(3, 0);
            this.goodMoodLabel.Name = "goodMoodLabel";
            this.goodMoodLabel.Size = new System.Drawing.Size(121, 23);
            this.goodMoodLabel.TabIndex = 0;
            this.goodMoodLabel.Text = "label1";
            this.goodMoodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dayLabel
            // 
            this.dayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayLabel.Location = new System.Drawing.Point(130, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(170, 23);
            this.dayLabel.TabIndex = 1;
            this.dayLabel.Text = "label2";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // badMoodLabel
            // 
            this.badMoodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.badMoodLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badMoodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.badMoodLabel.Location = new System.Drawing.Point(306, 0);
            this.badMoodLabel.Name = "badMoodLabel";
            this.badMoodLabel.Size = new System.Drawing.Size(127, 23);
            this.badMoodLabel.TabIndex = 2;
            this.badMoodLabel.Text = "label3";
            this.badMoodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseDetailsToolStripMenuItem,
            this.forceUpdateToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.detailsToolStripMenuItem.Text = "&Tools";
            // 
            // browseDetailsToolStripMenuItem
            // 
            this.browseDetailsToolStripMenuItem.Name = "browseDetailsToolStripMenuItem";
            this.browseDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.browseDetailsToolStripMenuItem.Text = "&Browse details";
            this.browseDetailsToolStripMenuItem.Click += new System.EventHandler(this.browseDetailsToolStripMenuItem_Click);
            // 
            // forceUpdateToolStripMenuItem
            // 
            this.forceUpdateToolStripMenuItem.Name = "forceUpdateToolStripMenuItem";
            this.forceUpdateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.forceUpdateToolStripMenuItem.Text = "&Force update";
            this.forceUpdateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // MoodPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelMoods);
            this.Controls.Add(this.status_strip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.navbar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoodPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mood Picker";
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.notification_menu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.badPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodPictureBox)).EndInit();
            this.status_strip.ResumeLayout(false);
            this.status_strip.PerformLayout();
            this.panelMoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.badMoodPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodMoodPictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navbar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notification;
        private System.Windows.Forms.ToolStripMenuItem closeStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip notification_menu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox goodPictureBox;
        private System.Windows.Forms.PictureBox badPictureBox;
        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel submitToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastSubmitpersistantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastSubmitmorningToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel submitStatusToolStripStatusLabel;
        private System.Windows.Forms.Panel panelMoods;
        private System.Windows.Forms.PictureBox badMoodPictureBox;
        private System.Windows.Forms.PictureBox goodMoodPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label goodMoodLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label badMoodLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceUpdateToolStripMenuItem;
    }
}