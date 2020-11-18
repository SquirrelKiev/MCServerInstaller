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
            this.PaperVersion = new System.Windows.Forms.ComboBox();
            this.CopyIPCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MOTDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderPathBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.Extra = new System.Windows.Forms.TabPage();
            this.oxyMode = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.FolderPathSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLog = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.TabControl.Size = new System.Drawing.Size(360, 291);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(352, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PaperVersion
            // 
            this.PaperVersion.FormattingEnabled = true;
            this.PaperVersion.Location = new System.Drawing.Point(130, 120);
            this.PaperVersion.Name = "PaperVersion";
            this.PaperVersion.Size = new System.Drawing.Size(93, 21);
            this.PaperVersion.TabIndex = 9;
            // 
            // CopyIPCheckbox
            // 
            this.CopyIPCheckbox.AutoSize = true;
            this.CopyIPCheckbox.Checked = true;
            this.CopyIPCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CopyIPCheckbox.Location = new System.Drawing.Point(114, 224);
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
            this.label3.Location = new System.Drawing.Point(157, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MOTD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MOTDTextBox
            // 
            this.MOTDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MOTDTextBox.Location = new System.Drawing.Point(42, 172);
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
            this.label2.Location = new System.Drawing.Point(132, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minecraft Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolderPathBrowseButton
            // 
            this.FolderPathBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FolderPathBrowseButton.Location = new System.Drawing.Point(139, 65);
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
            this.label1.Location = new System.Drawing.Point(146, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder Path";
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FolderPathTextBox.Location = new System.Drawing.Point(42, 39);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.ReadOnly = true;
            this.FolderPathTextBox.Size = new System.Drawing.Size(269, 20);
            this.FolderPathTextBox.TabIndex = 0;
            this.FolderPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FolderPathTextBox.TextChanged += new System.EventHandler(this.FolderPathTextBox_TextChanged);
            // 
            // Extra
            // 
            this.Extra.Controls.Add(this.textBox1);
            this.Extra.Controls.Add(this.oxyMode);
            this.Extra.Location = new System.Drawing.Point(4, 22);
            this.Extra.Name = "Extra";
            this.Extra.Padding = new System.Windows.Forms.Padding(3);
            this.Extra.Size = new System.Drawing.Size(352, 265);
            this.Extra.TabIndex = 1;
            this.Extra.Text = "Extra Settings";
            this.Extra.UseVisualStyleBackColor = true;
            // 
            // oxyMode
            // 
            this.oxyMode.Location = new System.Drawing.Point(271, 236);
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
            this.CreateButton.Location = new System.Drawing.Point(287, 405);
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
            this.progressBar.Location = new System.Drawing.Point(22, 405);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(259, 23);
            this.progressBar.TabIndex = 11;
            // 
            // ProgressLog
            // 
            this.ProgressLog.Location = new System.Drawing.Point(22, 309);
            this.ProgressLog.Multiline = true;
            this.ProgressLog.Name = "ProgressLog";
            this.ProgressLog.ReadOnly = true;
            this.ProgressLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProgressLog.Size = new System.Drawing.Size(340, 90);
            this.ProgressLog.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 1;
            // 
            // MCServerInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 440);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

