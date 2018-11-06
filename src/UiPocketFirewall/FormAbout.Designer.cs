namespace UiPocketFirewall
{
    partial class FormAbout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.cmdOk = new System.Windows.Forms.Button();
			this.lblAppName = new System.Windows.Forms.Label();
			this.lnkGitHub = new System.Windows.Forms.LinkLabel();
			this.lblVersion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmdOk
			// 
			this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdOk.Location = new System.Drawing.Point(152, 204);
			this.cmdOk.Margin = new System.Windows.Forms.Padding(4);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Size = new System.Drawing.Size(237, 34);
			this.cmdOk.TabIndex = 0;
			this.cmdOk.Text = "Ok";
			this.cmdOk.UseVisualStyleBackColor = true;
			// 
			// lblAppName
			// 
			this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppName.Location = new System.Drawing.Point(18, 28);
			this.lblAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAppName.Name = "lblAppName";
			this.lblAppName.Size = new System.Drawing.Size(507, 34);
			this.lblAppName.TabIndex = 1;
			this.lblAppName.Text = "AppName";
			this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lnkGitHub
			// 
			this.lnkGitHub.Location = new System.Drawing.Point(28, 129);
			this.lnkGitHub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lnkGitHub.Name = "lnkGitHub";
			this.lnkGitHub.Size = new System.Drawing.Size(496, 34);
			this.lnkGitHub.TabIndex = 2;
			this.lnkGitHub.TabStop = true;
			this.lnkGitHub.Text = "https://github.com/Clodo76/windows-pocket-firewall";
			this.lnkGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lnkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHub_LinkClicked);
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(24, 74);
			this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(501, 34);
			this.lblVersion.TabIndex = 3;
			this.lblVersion.Text = "AppVersion";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(543, 256);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lnkGitHub);
			this.Controls.Add(this.lblAppName);
			this.Controls.Add(this.cmdOk);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.LinkLabel lnkGitHub;
        private System.Windows.Forms.Label lblVersion;
    }
}