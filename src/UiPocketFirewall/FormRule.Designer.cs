namespace UiPocketFirewall
{
    partial class FormRule
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRule));
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkEnabled = new System.Windows.Forms.CheckBox();
			this.cboLayer = new System.Windows.Forms.ComboBox();
			this.cboAction = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lstConditions = new System.Windows.Forms.ListView();
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tooLTip = new System.Windows.Forms.ToolTip(this.components);
			this.cmdConditionDown = new System.Windows.Forms.Button();
			this.cmdConditionUp = new System.Windows.Forms.Button();
			this.cmdConditionEdit = new System.Windows.Forms.Button();
			this.cmdConditionAdd = new System.Windows.Forms.Button();
			this.cmdConditionRemove = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cboWeight = new System.Windows.Forms.ComboBox();
			columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Field";
			columnHeader1.Width = 150;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(210, 22);
			this.txtName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(984, 31);
			this.txtName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 68);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 34);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enabled:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkEnabled
			// 
			this.chkEnabled.Location = new System.Drawing.Point(210, 68);
			this.chkEnabled.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.chkEnabled.Name = "chkEnabled";
			this.chkEnabled.Size = new System.Drawing.Size(182, 34);
			this.chkEnabled.TabIndex = 3;
			this.chkEnabled.UseVisualStyleBackColor = true;
			// 
			// cboLayer
			// 
			this.cboLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLayer.FormattingEnabled = true;
			this.cboLayer.Location = new System.Drawing.Point(210, 112);
			this.cboLayer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cboLayer.Name = "cboLayer";
			this.cboLayer.Size = new System.Drawing.Size(984, 33);
			this.cboLayer.TabIndex = 4;
			// 
			// cboAction
			// 
			this.cboAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAction.FormattingEnabled = true;
			this.cboAction.Location = new System.Drawing.Point(210, 162);
			this.cboAction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cboAction.Name = "cboAction";
			this.cboAction.Size = new System.Drawing.Size(984, 33);
			this.cboAction.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 112);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 34);
			this.label3.TabIndex = 6;
			this.label3.Text = "Layer:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 162);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 34);
			this.label4.TabIndex = 7;
			this.label4.Text = "Action:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lstConditions
			// 
			this.lstConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstConditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lstConditions.FullRowSelect = true;
			this.lstConditions.GridLines = true;
			this.lstConditions.Location = new System.Drawing.Point(210, 286);
			this.lstConditions.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.lstConditions.Name = "lstConditions";
			this.lstConditions.Size = new System.Drawing.Size(926, 406);
			this.lstConditions.TabIndex = 8;
			this.lstConditions.UseCompatibleStateImageBehavior = false;
			this.lstConditions.View = System.Windows.Forms.View.Details;
			this.lstConditions.SelectedIndexChanged += new System.EventHandler(this.lstConditions_SelectedIndexChanged);
			this.lstConditions.DoubleClick += new System.EventHandler(this.lstConditions_DoubleClick);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Operator";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Value";
			this.columnHeader3.Width = 300;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 286);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(176, 34);
			this.label5.TabIndex = 9;
			this.label5.Text = "Conditions:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(472, 762);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 39);
			this.button1.TabIndex = 12;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(614, 762);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(130, 39);
			this.button2.TabIndex = 13;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// cmdConditionDown
			// 
			this.cmdConditionDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdConditionDown.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Down;
			this.cmdConditionDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdConditionDown.Location = new System.Drawing.Point(1148, 526);
			this.cmdConditionDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cmdConditionDown.Name = "cmdConditionDown";
			this.cmdConditionDown.Size = new System.Drawing.Size(48, 48);
			this.cmdConditionDown.TabIndex = 16;
			this.tooLTip.SetToolTip(this.cmdConditionDown, "Move Down");
			this.cmdConditionDown.UseVisualStyleBackColor = true;
			this.cmdConditionDown.Click += new System.EventHandler(this.cmdConditionDown_Click);
			// 
			// cmdConditionUp
			// 
			this.cmdConditionUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdConditionUp.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Up;
			this.cmdConditionUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdConditionUp.Location = new System.Drawing.Point(1148, 466);
			this.cmdConditionUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cmdConditionUp.Name = "cmdConditionUp";
			this.cmdConditionUp.Size = new System.Drawing.Size(48, 48);
			this.cmdConditionUp.TabIndex = 15;
			this.tooLTip.SetToolTip(this.cmdConditionUp, "Move Up");
			this.cmdConditionUp.UseVisualStyleBackColor = true;
			this.cmdConditionUp.Click += new System.EventHandler(this.cmdConditionUp_Click);
			// 
			// cmdConditionEdit
			// 
			this.cmdConditionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdConditionEdit.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Edit;
			this.cmdConditionEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdConditionEdit.Location = new System.Drawing.Point(1148, 406);
			this.cmdConditionEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cmdConditionEdit.Name = "cmdConditionEdit";
			this.cmdConditionEdit.Size = new System.Drawing.Size(48, 48);
			this.cmdConditionEdit.TabIndex = 14;
			this.tooLTip.SetToolTip(this.cmdConditionEdit, "Edit");
			this.cmdConditionEdit.UseVisualStyleBackColor = true;
			this.cmdConditionEdit.Click += new System.EventHandler(this.cmdConditionEdit_Click);
			// 
			// cmdConditionAdd
			// 
			this.cmdConditionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdConditionAdd.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Add;
			this.cmdConditionAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdConditionAdd.Location = new System.Drawing.Point(1148, 286);
			this.cmdConditionAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cmdConditionAdd.Name = "cmdConditionAdd";
			this.cmdConditionAdd.Size = new System.Drawing.Size(48, 48);
			this.cmdConditionAdd.TabIndex = 11;
			this.tooLTip.SetToolTip(this.cmdConditionAdd, "Add");
			this.cmdConditionAdd.UseVisualStyleBackColor = true;
			this.cmdConditionAdd.Click += new System.EventHandler(this.cmdConditionAdd_Click);
			// 
			// cmdConditionRemove
			// 
			this.cmdConditionRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdConditionRemove.BackgroundImage = global::UiPocketFirewall.Properties.Resources.Remove;
			this.cmdConditionRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdConditionRemove.Location = new System.Drawing.Point(1148, 346);
			this.cmdConditionRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cmdConditionRemove.Name = "cmdConditionRemove";
			this.cmdConditionRemove.Size = new System.Drawing.Size(48, 48);
			this.cmdConditionRemove.TabIndex = 10;
			this.tooLTip.SetToolTip(this.cmdConditionRemove, "Remove");
			this.cmdConditionRemove.UseVisualStyleBackColor = true;
			this.cmdConditionRemove.Click += new System.EventHandler(this.cmdConditionRemove_Click);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(210, 622);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(928, 134);
			this.label6.TabIndex = 17;
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(22, 208);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(176, 34);
			this.label7.TabIndex = 18;
			this.label7.Text = "Weight/Priority:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cboWeight
			// 
			this.cboWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboWeight.FormattingEnabled = true;
			this.cboWeight.Items.AddRange(new object[] {
            "Automatic",
            "Max priority",
            "Low",
            "Medium",
            "High"});
			this.cboWeight.Location = new System.Drawing.Point(210, 208);
			this.cboWeight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.cboWeight.Name = "cboWeight";
			this.cboWeight.Size = new System.Drawing.Size(984, 33);
			this.cboWeight.TabIndex = 19;
			// 
			// FormRule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1221, 824);
			this.Controls.Add(this.cboWeight);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmdConditionDown);
			this.Controls.Add(this.cmdConditionUp);
			this.Controls.Add(this.cmdConditionEdit);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmdConditionAdd);
			this.Controls.Add(this.cmdConditionRemove);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lstConditions);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboAction);
			this.Controls.Add(this.cboLayer);
			this.Controls.Add(this.chkEnabled);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRule";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Rule";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.ComboBox cboLayer;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstConditions;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdConditionRemove;
        private System.Windows.Forms.Button cmdConditionAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdConditionEdit;
        private System.Windows.Forms.ToolTip tooLTip;
        private System.Windows.Forms.Button cmdConditionUp;
        private System.Windows.Forms.Button cmdConditionDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboWeight;
    }
}