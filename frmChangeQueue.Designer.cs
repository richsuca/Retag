namespace Retag
{
    partial class frmChangeQueue
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
            this.lvChanges = new System.Windows.Forms.ListView();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdProcess = new System.Windows.Forms.Button();
            this.lblAPIToken = new System.Windows.Forms.Label();
            this.txtAPIToken = new System.Windows.Forms.TextBox();
            this.ttApiToken = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lvChanges
            // 
            this.lvChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvChanges.HideSelection = false;
            this.lvChanges.Location = new System.Drawing.Point(18, 22);
            this.lvChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvChanges.Name = "lvChanges";
            this.lvChanges.Size = new System.Drawing.Size(2126, 1016);
            this.lvChanges.TabIndex = 0;
            this.lvChanges.UseCompatibleStateImageBehavior = false;
            this.lvChanges.View = System.Windows.Forms.View.Details;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Location = new System.Drawing.Point(1937, 1059);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(207, 50);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // cmdProcess
            // 
            this.cmdProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdProcess.Location = new System.Drawing.Point(1072, 1059);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(298, 50);
            this.cmdProcess.TabIndex = 2;
            this.cmdProcess.Text = "Apply to Pinboard";
            this.cmdProcess.UseVisualStyleBackColor = true;
            this.cmdProcess.Click += new System.EventHandler(this.CmdProcess_Click);
            // 
            // lblAPIToken
            // 
            this.lblAPIToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAPIToken.AutoSize = true;
            this.lblAPIToken.Location = new System.Drawing.Point(12, 1062);
            this.lblAPIToken.Name = "lblAPIToken";
            this.lblAPIToken.Size = new System.Drawing.Size(168, 45);
            this.lblAPIToken.TabIndex = 3;
            this.lblAPIToken.Text = "API Token:";
            // 
            // txtAPIToken
            // 
            this.txtAPIToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAPIToken.Location = new System.Drawing.Point(186, 1059);
            this.txtAPIToken.Name = "txtAPIToken";
            this.txtAPIToken.Size = new System.Drawing.Size(880, 50);
            this.txtAPIToken.TabIndex = 4;
            // 
            // ttApiToken
            // 
            this.ttApiToken.IsBalloon = true;
            this.ttApiToken.ShowAlways = true;
            this.ttApiToken.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmChangeQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2164, 1122);
            this.Controls.Add(this.txtAPIToken);
            this.Controls.Add(this.lblAPIToken);
            this.Controls.Add(this.cmdProcess);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lvChanges);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChangeQueue";
            this.Text = "Change Queue";
            this.Load += new System.EventHandler(this.FrmChangeQueue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvChanges;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdProcess;
        private System.Windows.Forms.Label lblAPIToken;
        private System.Windows.Forms.TextBox txtAPIToken;
        private System.Windows.Forms.ToolTip ttApiToken;
    }
}