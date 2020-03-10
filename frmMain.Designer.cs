namespace Retag
{
    partial class frmMain
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
            this.lstUrl = new System.Windows.Forms.ListBox();
            this.optEverything = new System.Windows.Forms.RadioButton();
            this.optNonTweets = new System.Windows.Forms.RadioButton();
            this.optTweets = new System.Windows.Forms.RadioButton();
            this.ie = new System.Windows.Forms.WebBrowser();
            this.dlgFile = new System.Windows.Forms.OpenFileDialog();
            this.lblDataFile = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdShowChangeQueue = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cboTagFilter = new System.Windows.Forms.ComboBox();
            this.lstTags = new System.Windows.Forms.ListBox();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrl
            // 
            this.lstUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUrl.FormattingEnabled = true;
            this.lstUrl.IntegralHeight = false;
            this.lstUrl.ItemHeight = 45;
            this.lstUrl.Location = new System.Drawing.Point(556, 103);
            this.lstUrl.Name = "lstUrl";
            this.lstUrl.Size = new System.Drawing.Size(2281, 554);
            this.lstUrl.TabIndex = 0;
            this.lstUrl.SelectedIndexChanged += new System.EventHandler(this.LstUrl_SelectedIndexChanged);
            // 
            // optEverything
            // 
            this.optEverything.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optEverything.AutoSize = true;
            this.optEverything.Checked = true;
            this.optEverything.Location = new System.Drawing.Point(2224, 31);
            this.optEverything.Name = "optEverything";
            this.optEverything.Size = new System.Drawing.Size(199, 49);
            this.optEverything.TabIndex = 4;
            this.optEverything.TabStop = true;
            this.optEverything.Text = "Everything";
            this.optEverything.UseVisualStyleBackColor = true;
            this.optEverything.CheckedChanged += new System.EventHandler(this.OptEverything_CheckedChanged);
            // 
            // optNonTweets
            // 
            this.optNonTweets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optNonTweets.AutoSize = true;
            this.optNonTweets.Location = new System.Drawing.Point(2458, 31);
            this.optNonTweets.Name = "optNonTweets";
            this.optNonTweets.Size = new System.Drawing.Size(222, 49);
            this.optNonTweets.TabIndex = 5;
            this.optNonTweets.Text = "Non-Tweets";
            this.optNonTweets.UseVisualStyleBackColor = true;
            this.optNonTweets.CheckedChanged += new System.EventHandler(this.OptNonTweets_CheckedChanged);
            // 
            // optTweets
            // 
            this.optTweets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optTweets.AutoSize = true;
            this.optTweets.Location = new System.Drawing.Point(2701, 31);
            this.optTweets.Name = "optTweets";
            this.optTweets.Size = new System.Drawing.Size(148, 49);
            this.optTweets.TabIndex = 6;
            this.optTweets.Text = "Tweets";
            this.optTweets.UseVisualStyleBackColor = true;
            this.optTweets.CheckedChanged += new System.EventHandler(this.OptTweets_CheckedChanged);
            // 
            // ie
            // 
            this.ie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ie.Location = new System.Drawing.Point(556, 678);
            this.ie.MinimumSize = new System.Drawing.Size(20, 20);
            this.ie.Name = "ie";
            this.ie.ScriptErrorsSuppressed = true;
            this.ie.Size = new System.Drawing.Size(2278, 905);
            this.ie.TabIndex = 7;
            // 
            // dlgFile
            // 
            this.dlgFile.FileOk += new System.ComponentModel.CancelEventHandler(this.DlgFile_FileOk);
            // 
            // lblDataFile
            // 
            this.lblDataFile.AutoSize = true;
            this.lblDataFile.Location = new System.Drawing.Point(12, 33);
            this.lblDataFile.Name = "lblDataFile";
            this.lblDataFile.Size = new System.Drawing.Size(150, 45);
            this.lblDataFile.TabIndex = 0;
            this.lblDataFile.Text = "Data File:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(158, 28);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(1714, 50);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.TextChanged += new System.EventHandler(this.TxtFilePath_TextChanged);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(1887, 28);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(214, 48);
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "Open";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.CmdBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdHelp);
            this.panel1.Controls.Add(this.cmdShowChangeQueue);
            this.panel1.Controls.Add(this.lblFilterBy);
            this.panel1.Controls.Add(this.cboTagFilter);
            this.panel1.Controls.Add(this.lstTags);
            this.panel1.Location = new System.Drawing.Point(20, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 1482);
            this.panel1.TabIndex = 11;
            // 
            // cmdShowChangeQueue
            // 
            this.cmdShowChangeQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdShowChangeQueue.Location = new System.Drawing.Point(209, 1394);
            this.cmdShowChangeQueue.Name = "cmdShowChangeQueue";
            this.cmdShowChangeQueue.Size = new System.Drawing.Size(278, 67);
            this.cmdShowChangeQueue.TabIndex = 7;
            this.cmdShowChangeQueue.Text = "Change Queue";
            this.cmdShowChangeQueue.UseVisualStyleBackColor = true;
            this.cmdShowChangeQueue.Click += new System.EventHandler(this.CmdShowChangeQueue_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(12, 15);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(140, 45);
            this.lblFilterBy.TabIndex = 4;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // cboTagFilter
            // 
            this.cboTagFilter.FormattingEnabled = true;
            this.cboTagFilter.Location = new System.Drawing.Point(162, 15);
            this.cboTagFilter.Name = "cboTagFilter";
            this.cboTagFilter.Size = new System.Drawing.Size(325, 53);
            this.cboTagFilter.TabIndex = 5;
            this.cboTagFilter.SelectedIndexChanged += new System.EventHandler(this.CboTagFilter_SelectedIndexChanged);
            // 
            // lstTags
            // 
            this.lstTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTags.FormattingEnabled = true;
            this.lstTags.IntegralHeight = false;
            this.lstTags.ItemHeight = 45;
            this.lstTags.Location = new System.Drawing.Point(20, 82);
            this.lstTags.Name = "lstTags";
            this.lstTags.Size = new System.Drawing.Size(467, 1294);
            this.lstTags.TabIndex = 4;
            this.lstTags.SelectedIndexChanged += new System.EventHandler(this.LstTags_SelectedIndexChanged);
            this.lstTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LstTags_KeyUp);
            // 
            // cmdHelp
            // 
            this.cmdHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdHelp.Location = new System.Drawing.Point(20, 1394);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(75, 67);
            this.cmdHelp.TabIndex = 8;
            this.cmdHelp.Text = "?";
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.CmdHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2854, 1609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblDataFile);
            this.Controls.Add(this.ie);
            this.Controls.Add(this.optTweets);
            this.Controls.Add(this.optNonTweets);
            this.Controls.Add(this.optEverything);
            this.Controls.Add(this.lstUrl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Pinboard Tag Redo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrl;
        private System.Windows.Forms.RadioButton optEverything;
        private System.Windows.Forms.RadioButton optNonTweets;
        private System.Windows.Forms.RadioButton optTweets;
        private System.Windows.Forms.WebBrowser ie;
        private System.Windows.Forms.OpenFileDialog dlgFile;
        private System.Windows.Forms.Label lblDataFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cboTagFilter;
        private System.Windows.Forms.ListBox lstTags;
        private System.Windows.Forms.Button cmdShowChangeQueue;
        private System.Windows.Forms.Button cmdHelp;
    }
}

