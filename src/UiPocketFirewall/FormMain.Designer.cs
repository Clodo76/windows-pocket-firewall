namespace UiPocketFirewall
{
    partial class FormMain
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cmdStartStop = new System.Windows.Forms.Button();
            this.lstRules = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdRuleEdit = new System.Windows.Forms.Button();
            this.cmdRuleAdd = new System.Windows.Forms.Button();
            this.cmdRuleRemove = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdRuleUp = new System.Windows.Forms.Button();
            this.cmdRuleDown = new System.Windows.Forms.Button();
            this.cboWeight = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chkDynamic = new System.Windows.Forms.CheckBox();
            this.chkPersistent = new System.Windows.Forms.CheckBox();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Enabled";
            // 
            // cmdStartStop
            // 
            this.cmdStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStartStop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStartStop.ForeColor = System.Drawing.Color.White;
            this.cmdStartStop.Location = new System.Drawing.Point(12, 364);
            this.cmdStartStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdStartStop.Name = "cmdStartStop";
            this.cmdStartStop.Size = new System.Drawing.Size(756, 45);
            this.cmdStartStop.TabIndex = 0;
            this.cmdStartStop.Text = "button1";
            this.cmdStartStop.UseVisualStyleBackColor = true;
            this.cmdStartStop.Click += new System.EventHandler(this.cmdStartStop_Click);
            // 
            // lstRules
            // 
            this.lstRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            columnHeader1,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.lstRules.FullRowSelect = true;
            this.lstRules.GridLines = true;
            this.lstRules.Location = new System.Drawing.Point(12, 56);
            this.lstRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(718, 288);
            this.lstRules.TabIndex = 1;
            this.lstRules.UseCompatibleStateImageBehavior = false;
            this.lstRules.View = System.Windows.Forms.View.Details;
            this.lstRules.SelectedIndexChanged += new System.EventHandler(this.lstRules_SelectedIndexChanged);
            this.lstRules.DoubleClick += new System.EventHandler(this.lstRules_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 380;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Running";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Layer";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Action";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.toolStripMenuItem1});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(780, 25);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripSeparator2,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 19);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(146, 22);
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(146, 22);
            this.mnuFileOpen.Text = "&Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(146, 22);
            this.mnuFileSave.Text = "&Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuFileSaveAs.Size = new System.Drawing.Size(146, 22);
            this.mnuFileSaveAs.Text = "Save &As";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(146, 22);
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 19);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelpAbout.Size = new System.Drawing.Size(126, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // cmdRuleEdit
            // 
            this.cmdRuleEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRuleEdit.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Edit;
            this.cmdRuleEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRuleEdit.Location = new System.Drawing.Point(736, 136);
            this.cmdRuleEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdRuleEdit.Name = "cmdRuleEdit";
            this.cmdRuleEdit.Size = new System.Drawing.Size(32, 32);
            this.cmdRuleEdit.TabIndex = 17;
            this.toolTip.SetToolTip(this.cmdRuleEdit, "Edit");
            this.cmdRuleEdit.UseVisualStyleBackColor = true;
            this.cmdRuleEdit.Click += new System.EventHandler(this.cmdRuleEdit_Click);
            // 
            // cmdRuleAdd
            // 
            this.cmdRuleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRuleAdd.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Add;
            this.cmdRuleAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRuleAdd.Location = new System.Drawing.Point(736, 56);
            this.cmdRuleAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdRuleAdd.Name = "cmdRuleAdd";
            this.cmdRuleAdd.Size = new System.Drawing.Size(32, 32);
            this.cmdRuleAdd.TabIndex = 16;
            this.toolTip.SetToolTip(this.cmdRuleAdd, "Add");
            this.cmdRuleAdd.UseVisualStyleBackColor = true;
            this.cmdRuleAdd.Click += new System.EventHandler(this.cmdRuleAdd_Click);
            // 
            // cmdRuleRemove
            // 
            this.cmdRuleRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRuleRemove.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Remove;
            this.cmdRuleRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRuleRemove.Location = new System.Drawing.Point(736, 96);
            this.cmdRuleRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdRuleRemove.Name = "cmdRuleRemove";
            this.cmdRuleRemove.Size = new System.Drawing.Size(32, 32);
            this.cmdRuleRemove.TabIndex = 15;
            this.toolTip.SetToolTip(this.cmdRuleRemove, "Remove");
            this.cmdRuleRemove.UseVisualStyleBackColor = true;
            this.cmdRuleRemove.Click += new System.EventHandler(this.cmdRuleRemove_Click);
            // 
            // cmdRuleUp
            // 
            this.cmdRuleUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRuleUp.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Up;
            this.cmdRuleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRuleUp.Location = new System.Drawing.Point(736, 176);
            this.cmdRuleUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdRuleUp.Name = "cmdRuleUp";
            this.cmdRuleUp.Size = new System.Drawing.Size(32, 32);
            this.cmdRuleUp.TabIndex = 18;
            this.toolTip.SetToolTip(this.cmdRuleUp, "Move Up");
            this.cmdRuleUp.UseVisualStyleBackColor = true;
            this.cmdRuleUp.Click += new System.EventHandler(this.cmdRuleUp_Click);
            // 
            // cmdRuleDown
            // 
            this.cmdRuleDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRuleDown.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Down;
            this.cmdRuleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRuleDown.Location = new System.Drawing.Point(736, 216);
            this.cmdRuleDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdRuleDown.Name = "cmdRuleDown";
            this.cmdRuleDown.Size = new System.Drawing.Size(32, 32);
            this.cmdRuleDown.TabIndex = 19;
            this.toolTip.SetToolTip(this.cmdRuleDown, "Move Down");
            this.cmdRuleDown.UseVisualStyleBackColor = true;
            this.cmdRuleDown.Click += new System.EventHandler(this.cmdRuleDown_Click);
            // 
            // cboWeight
            // 
            this.cboWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeight.FormattingEnabled = true;
            this.cboWeight.Items.AddRange(new object[] {
            "Automatic",
            "Max priority",
            "Low",
            "Medium",
            "High"});
            this.cboWeight.Location = new System.Drawing.Point(606, 25);
            this.cboWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboWeight.Name = "cboWeight";
            this.cboWeight.Size = new System.Drawing.Size(162, 23);
            this.cboWeight.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(534, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Priority:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(95, 25);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(436, 23);
            this.txtDescription.TabIndex = 21;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 25);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 23);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Name:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkDynamic
            // 
            this.chkDynamic.AutoSize = true;
            this.chkDynamic.Checked = true;
            this.chkDynamic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDynamic.Location = new System.Drawing.Point(15, 419);
            this.chkDynamic.Name = "chkDynamic";
            this.chkDynamic.Size = new System.Drawing.Size(289, 19);
            this.chkDynamic.TabIndex = 24;
            this.chkDynamic.Text = "Dynamic - Rules dropped if this program is closed";
            this.chkDynamic.UseVisualStyleBackColor = true;
            this.chkDynamic.Visible = false;
            // 
            // chkPersistent
            // 
            this.chkPersistent.AutoSize = true;
            this.chkPersistent.Location = new System.Drawing.Point(359, 419);
            this.chkPersistent.Name = "chkPersistent";
            this.chkPersistent.Size = new System.Drawing.Size(207, 19);
            this.chkPersistent.TabIndex = 25;
            this.chkPersistent.Text = "Persistent - Rules survive at reboot";
            this.chkPersistent.UseVisualStyleBackColor = true;
            this.chkPersistent.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(780, 448);
            this.Controls.Add(this.chkPersistent);
            this.Controls.Add(this.chkDynamic);
            this.Controls.Add(this.cboWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmdRuleDown);
            this.Controls.Add(this.cmdRuleUp);
            this.Controls.Add(this.cmdRuleEdit);
            this.Controls.Add(this.cmdRuleAdd);
            this.Controls.Add(this.cmdRuleRemove);
            this.Controls.Add(this.lstRules);
            this.Controls.Add(this.cmdStartStop);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "PocketFirewall";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStartStop;
        private System.Windows.Forms.ListView lstRules;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.Button cmdRuleEdit;
        private System.Windows.Forms.Button cmdRuleAdd;
        private System.Windows.Forms.Button cmdRuleRemove;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button cmdRuleUp;
        private System.Windows.Forms.Button cmdRuleDown;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cboWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chkDynamic;
        private System.Windows.Forms.CheckBox chkPersistent;
    }
}

