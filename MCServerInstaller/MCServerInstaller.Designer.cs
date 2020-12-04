namespace MCServerInstaller
{
    partial class MCServerInstaller
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SkipPaperDownload = new System.Windows.Forms.CheckBox();
            this.ServerIconPreview = new System.Windows.Forms.PictureBox();
            this.ServerIconBrowseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ServerIconTextBox = new System.Windows.Forms.TextBox();
            this.PaperVersion = new System.Windows.Forms.ComboBox();
            this.CopyIPCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MOTDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderPathBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.Extra = new System.Windows.Forms.TabPage();
            this.FuckWyoming = new System.Windows.Forms.Button();
            this.OpPlayerList_User = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WorldTypeDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SeedBox = new System.Windows.Forms.TextBox();
            this.oxyMode = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.FolderPathSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLog = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerIconPreview)).BeginInit();
            this.Extra.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.Extra);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(360, 393);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SkipPaperDownload);
            this.tabPage1.Controls.Add(this.ServerIconPreview);
            this.tabPage1.Controls.Add(this.ServerIconBrowseButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ServerIconTextBox);
            this.tabPage1.Controls.Add(this.PaperVersion);
            this.tabPage1.Controls.Add(this.CopyIPCheckbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.MOTDTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.FolderPathBrowseButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.FolderPathTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SkipPaperDownload
            // 
            this.SkipPaperDownload.AutoSize = true;
            this.SkipPaperDownload.Location = new System.Drawing.Point(109, 321);
            this.SkipPaperDownload.Name = "SkipPaperDownload";
            this.SkipPaperDownload.Size = new System.Drawing.Size(139, 17);
            this.SkipPaperDownload.TabIndex = 14;
            this.SkipPaperDownload.Text = "Skip download of Paper";
            this.SkipPaperDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SkipPaperDownload.UseVisualStyleBackColor = true;
            // 
            // ServerIconPreview
            // 
            this.ServerIconPreview.Location = new System.Drawing.Point(5, 161);
            this.ServerIconPreview.Name = "ServerIconPreview";
            this.ServerIconPreview.Size = new System.Drawing.Size(32, 32);
            this.ServerIconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ServerIconPreview.TabIndex = 13;
            this.ServerIconPreview.TabStop = false;
            // 
            // ServerIconBrowseButton
            // 
            this.ServerIconBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ServerIconBrowseButton.Location = new System.Drawing.Point(139, 192);
            this.ServerIconBrowseButton.Name = "ServerIconBrowseButton";
            this.ServerIconBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.ServerIconBrowseButton.TabIndex = 12;
            this.ServerIconBrowseButton.Text = "Browse...";
            this.ServerIconBrowseButton.UseVisualStyleBackColor = true;
            this.ServerIconBrowseButton.Click += new System.EventHandler(this.ServerIconBrowseButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Server Icon";
            // 
            // ServerIconTextBox
            // 
            this.ServerIconTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ServerIconTextBox.Location = new System.Drawing.Point(42, 166);
            this.ServerIconTextBox.Name = "ServerIconTextBox";
            this.ServerIconTextBox.ReadOnly = true;
            this.ServerIconTextBox.Size = new System.Drawing.Size(269, 20);
            this.ServerIconTextBox.TabIndex = 10;
            this.ServerIconTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PaperVersion
            // 
            this.PaperVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaperVersion.FormattingEnabled = true;
            this.PaperVersion.Location = new System.Drawing.Point(109, 87);
            this.PaperVersion.Name = "PaperVersion";
            this.PaperVersion.Size = new System.Drawing.Size(135, 21);
            this.PaperVersion.TabIndex = 9;
            // 
            // CopyIPCheckbox
            // 
            this.CopyIPCheckbox.AutoSize = true;
            this.CopyIPCheckbox.Checked = true;
            this.CopyIPCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CopyIPCheckbox.Location = new System.Drawing.Point(109, 344);
            this.CopyIPCheckbox.Name = "CopyIPCheckbox";
            this.CopyIPCheckbox.Size = new System.Drawing.Size(121, 17);
            this.CopyIPCheckbox.TabIndex = 8;
            this.CopyIPCheckbox.Text = "Copy IP to clipboard";
            this.CopyIPCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MOTD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MOTDTextBox
            // 
            this.MOTDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MOTDTextBox.Location = new System.Drawing.Point(42, 127);
            this.MOTDTextBox.MaxLength = 128;
            this.MOTDTextBox.Name = "MOTDTextBox";
            this.MOTDTextBox.Size = new System.Drawing.Size(269, 20);
            this.MOTDTextBox.TabIndex = 6;
            this.MOTDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minecraft Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolderPathBrowseButton
            // 
            this.FolderPathBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FolderPathBrowseButton.Location = new System.Drawing.Point(135, 45);
            this.FolderPathBrowseButton.Name = "FolderPathBrowseButton";
            this.FolderPathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.FolderPathBrowseButton.TabIndex = 2;
            this.FolderPathBrowseButton.Text = "Browse...";
            this.FolderPathBrowseButton.UseVisualStyleBackColor = true;
            this.FolderPathBrowseButton.Click += new System.EventHandler(this.FolderPathBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder Path";
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FolderPathTextBox.Location = new System.Drawing.Point(42, 19);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.ReadOnly = true;
            this.FolderPathTextBox.Size = new System.Drawing.Size(269, 20);
            this.FolderPathTextBox.TabIndex = 0;
            this.FolderPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FolderPathTextBox.TextChanged += new System.EventHandler(this.FolderPathTextBox_TextChanged);
            // 
            // Extra
            // 
            this.Extra.Controls.Add(this.FuckWyoming);
            this.Extra.Controls.Add(this.OpPlayerList_User);
            this.Extra.Controls.Add(this.label8);
            this.Extra.Controls.Add(this.label7);
            this.Extra.Controls.Add(this.label6);
            this.Extra.Controls.Add(this.WorldTypeDropdown);
            this.Extra.Controls.Add(this.label4);
            this.Extra.Controls.Add(this.SeedBox);
            this.Extra.Controls.Add(this.oxyMode);
            this.Extra.Location = new System.Drawing.Point(4, 22);
            this.Extra.Name = "Extra";
            this.Extra.Padding = new System.Windows.Forms.Padding(3);
            this.Extra.Size = new System.Drawing.Size(352, 367);
            this.Extra.TabIndex = 1;
            this.Extra.Text = "Extra Settings";
            this.Extra.UseVisualStyleBackColor = true;
            // 
            // FuckWyoming
            // 
            this.FuckWyoming.Location = new System.Drawing.Point(190, 338);
            this.FuckWyoming.Name = "FuckWyoming";
            this.FuckWyoming.Size = new System.Drawing.Size(75, 23);
            this.FuckWyoming.TabIndex = 8;
            this.FuckWyoming.Text = "Wyoming";
            this.FuckWyoming.UseVisualStyleBackColor = true;
            this.FuckWyoming.Visible = false;
            this.FuckWyoming.Click += new System.EventHandler(this.FuckWyoming_Click);
            // 
            // OpPlayerList_User
            // 
            this.OpPlayerList_User.Location = new System.Drawing.Point(64, 137);
            this.OpPlayerList_User.Multiline = true;
            this.OpPlayerList_User.Name = "OpPlayerList_User";
            this.OpPlayerList_User.Size = new System.Drawing.Size(224, 81);
            this.OpPlayerList_User.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "OP Players (Seperate players by commas. NO SPACES)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "biomesop is 1.12.2 and below\r\nbiomesoplenty is 1.13 and up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "World Type";
            // 
            // WorldTypeDropdown
            // 
            this.WorldTypeDropdown.FormattingEnabled = true;
            this.WorldTypeDropdown.Items.AddRange(new object[] {
            "default",
            "flat",
            "biomesoplenty",
            "biomesop",
            "largeBiomes",
            "amplified"});
            this.WorldTypeDropdown.Location = new System.Drawing.Point(90, 58);
            this.WorldTypeDropdown.Name = "WorldTypeDropdown";
            this.WorldTypeDropdown.Size = new System.Drawing.Size(172, 21);
            this.WorldTypeDropdown.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeedBox
            // 
            this.SeedBox.Location = new System.Drawing.Point(43, 19);
            this.SeedBox.Name = "SeedBox";
            this.SeedBox.Size = new System.Drawing.Size(266, 20);
            this.SeedBox.TabIndex = 1;
            // 
            // oxyMode
            // 
            this.oxyMode.Location = new System.Drawing.Point(271, 338);
            this.oxyMode.Name = "oxyMode";
            this.oxyMode.Size = new System.Drawing.Size(75, 23);
            this.oxyMode.TabIndex = 0;
            this.oxyMode.Text = "oxy c laen";
            this.oxyMode.UseVisualStyleBackColor = true;
            this.oxyMode.Click += new System.EventHandler(this.oxyMode_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Enabled = false;
            this.CreateButton.Location = new System.Drawing.Point(287, 507);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "Create!";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // FolderPathSaveFile
            // 
            this.FolderPathSaveFile.FileName = "select.this.directory";
            this.FolderPathSaveFile.Filter = "All files|*.*";
            this.FolderPathSaveFile.Title = "Choose directory to install paper to";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar.Location = new System.Drawing.Point(22, 507);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(259, 23);
            this.progressBar.TabIndex = 11;
            // 
            // ProgressLog
            // 
            this.ProgressLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProgressLog.Location = new System.Drawing.Point(22, 411);
            this.ProgressLog.Multiline = true;
            this.ProgressLog.Name = "ProgressLog";
            this.ProgressLog.ReadOnly = true;
            this.ProgressLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProgressLog.Size = new System.Drawing.Size(340, 90);
            this.ProgressLog.TabIndex = 12;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "server-icon.png";
            this.OpenFileDialog.Filter = "PNG Files|*.png";
            // 
            // MCServerInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 542);
            this.Controls.Add(this.ProgressLog);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.CreateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MCServerInstaller";
            this.ShowIcon = false;
            this.Text = "Minecraft Server Installer";
            this.Load += new System.EventHandler(this.MCServerInstaller_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerIconPreview)).EndInit();
            this.Extra.ResumeLayout(false);
            this.Extra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox FolderPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FolderPathBrowseButton;
        private System.Windows.Forms.SaveFileDialog FolderPathSaveFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MOTDTextBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox ProgressLog;
        private System.Windows.Forms.CheckBox CopyIPCheckbox;
        private System.Windows.Forms.TabPage Extra;
        private System.Windows.Forms.Button oxyMode;
        private System.Windows.Forms.ComboBox PaperVersion;
        private System.Windows.Forms.TextBox SeedBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ServerIconBrowseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ServerIconTextBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.PictureBox ServerIconPreview;
        private System.Windows.Forms.CheckBox SkipPaperDownload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox WorldTypeDropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OpPlayerList_User;
        private System.Windows.Forms.Button FuckWyoming;
    }
}

