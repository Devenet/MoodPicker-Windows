namespace MoodPicker.Box
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.blankLabel1 = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPictureBox.Image = global::MoodPicker.Properties.Resources.MoodPicker;
            this.logoPictureBox.Location = new System.Drawing.Point(17, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(106, 104);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(3, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(174, 32);
            this.productLabel.TabIndex = 13;
            this.productLabel.Text = "Product";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(3, 65);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.versionLabel.Size = new System.Drawing.Size(44, 13);
            this.versionLabel.TabIndex = 14;
            this.versionLabel.Text = "Version";
            // 
            // githubLink
            // 
            this.githubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.githubLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.githubLink.Location = new System.Drawing.Point(9, 136);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(307, 13);
            this.githubLink.TabIndex = 15;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "Website";
            this.githubLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.productLabel);
            this.flowLayoutPanel1.Controls.Add(this.descriptionLabel);
            this.flowLayoutPanel1.Controls.Add(this.blankLabel1);
            this.flowLayoutPanel1.Controls.Add(this.versionLabel);
            this.flowLayoutPanel1.Controls.Add(this.copyrightLabel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(141, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 110);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 32);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.descriptionLabel.Size = new System.Drawing.Size(62, 13);
            this.descriptionLabel.TabIndex = 16;
            this.descriptionLabel.Text = "Description";
            // 
            // blankLabel1
            // 
            this.blankLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blankLabel1.Location = new System.Drawing.Point(3, 45);
            this.blankLabel1.Name = "blankLabel1";
            this.blankLabel1.Size = new System.Drawing.Size(174, 20);
            this.blankLabel1.TabIndex = 15;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(3, 83);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.copyrightLabel.Size = new System.Drawing.Size(53, 13);
            this.copyrightLabel.TabIndex = 17;
            this.copyrightLabel.Text = "Copyright";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 158);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Mood Picker";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label blankLabel1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label copyrightLabel;
    }
}
