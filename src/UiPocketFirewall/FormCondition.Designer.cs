﻿namespace UiPocketFirewall
{
    partial class FormCondition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCondition));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.tabValue = new System.Windows.Forms.TabControl();
            this.tabValueText = new System.Windows.Forms.TabPage();
            this.tabValuePort = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.NumericUpDown();
            this.tabValuePortRange = new System.Windows.Forms.TabPage();
            this.txtPortTo = new System.Windows.Forms.NumericUpDown();
            this.txtPortFrom = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabValueApplication = new System.Windows.Forms.TabPage();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdPathBrowse = new System.Windows.Forms.Button();
            this.tabValueInterface = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cboInterface = new System.Windows.Forms.ComboBox();
            this.tabValueAddress = new System.Windows.Forms.TabPage();
            this.txtAddressMask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabValueProtocol = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cboProtocol = new System.Windows.Forms.ComboBox();
            this.tabValue.SuspendLayout();
            this.tabValuePort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            this.tabValuePortRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortFrom)).BeginInit();
            this.tabValueApplication.SuspendLayout();
            this.tabValueInterface.SuspendLayout();
            this.tabValueAddress.SuspendLayout();
            this.tabValueProtocol.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(280, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(185, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Field:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboField
            // 
            this.cboField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(140, 14);
            this.cboField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(385, 23);
            this.cboField.TabIndex = 14;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Operator:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOperator
            // 
            this.cboOperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(140, 45);
            this.cboOperator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(385, 23);
            this.cboOperator.TabIndex = 18;
            this.cboOperator.SelectedIndexChanged += new System.EventHandler(this.cboOperator_SelectedIndexChanged);
            // 
            // tabValue
            // 
            this.tabValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabValue.Controls.Add(this.tabValueText);
            this.tabValue.Controls.Add(this.tabValuePort);
            this.tabValue.Controls.Add(this.tabValuePortRange);
            this.tabValue.Controls.Add(this.tabValueApplication);
            this.tabValue.Controls.Add(this.tabValueInterface);
            this.tabValue.Controls.Add(this.tabValueAddress);
            this.tabValue.Controls.Add(this.tabValueProtocol);
            this.tabValue.Location = new System.Drawing.Point(17, 75);
            this.tabValue.Name = "tabValue";
            this.tabValue.Padding = new System.Drawing.Point(0, 0);
            this.tabValue.SelectedIndex = 0;
            this.tabValue.Size = new System.Drawing.Size(522, 100);
            this.tabValue.TabIndex = 25;
            // 
            // tabValueText
            // 
            this.tabValueText.Location = new System.Drawing.Point(4, 24);
            this.tabValueText.Name = "tabValueText";
            this.tabValueText.Size = new System.Drawing.Size(514, 72);
            this.tabValueText.TabIndex = 0;
            this.tabValueText.Text = "Text";
            this.tabValueText.UseVisualStyleBackColor = true;
            // 
            // tabValuePort
            // 
            this.tabValuePort.Controls.Add(this.label2);
            this.tabValuePort.Controls.Add(this.txtPort);
            this.tabValuePort.Location = new System.Drawing.Point(4, 24);
            this.tabValuePort.Name = "tabValuePort";
            this.tabValuePort.Padding = new System.Windows.Forms.Padding(3);
            this.tabValuePort.Size = new System.Drawing.Size(514, 72);
            this.tabValuePort.TabIndex = 1;
            this.tabValuePort.Text = "Port";
            this.tabValuePort.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(119, 3);
            this.txtPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 23);
            this.txtPort.TabIndex = 0;
            // 
            // tabValuePortRange
            // 
            this.tabValuePortRange.Controls.Add(this.txtPortTo);
            this.tabValuePortRange.Controls.Add(this.txtPortFrom);
            this.tabValuePortRange.Controls.Add(this.label7);
            this.tabValuePortRange.Controls.Add(this.label8);
            this.tabValuePortRange.Location = new System.Drawing.Point(4, 24);
            this.tabValuePortRange.Name = "tabValuePortRange";
            this.tabValuePortRange.Size = new System.Drawing.Size(514, 72);
            this.tabValuePortRange.TabIndex = 4;
            this.tabValuePortRange.Text = "PortRange";
            this.tabValuePortRange.UseVisualStyleBackColor = true;
            // 
            // txtPortTo
            // 
            this.txtPortTo.Location = new System.Drawing.Point(119, 30);
            this.txtPortTo.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtPortTo.Name = "txtPortTo";
            this.txtPortTo.Size = new System.Drawing.Size(120, 23);
            this.txtPortTo.TabIndex = 29;
            // 
            // txtPortFrom
            // 
            this.txtPortFrom.Location = new System.Drawing.Point(119, 1);
            this.txtPortFrom.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtPortFrom.Name = "txtPortFrom";
            this.txtPortFrom.Size = new System.Drawing.Size(120, 23);
            this.txtPortFrom.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "To:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "From:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabValueApplication
            // 
            this.tabValueApplication.Controls.Add(this.txtPath);
            this.tabValueApplication.Controls.Add(this.label6);
            this.tabValueApplication.Controls.Add(this.cmdPathBrowse);
            this.tabValueApplication.Location = new System.Drawing.Point(4, 24);
            this.tabValueApplication.Name = "tabValueApplication";
            this.tabValueApplication.Size = new System.Drawing.Size(514, 72);
            this.tabValueApplication.TabIndex = 2;
            this.tabValueApplication.Text = "Application";
            this.tabValueApplication.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(119, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(385, 23);
            this.txtPath.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(66, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Path:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdPathBrowse
            // 
            this.cmdPathBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPathBrowse.Location = new System.Drawing.Point(394, 32);
            this.cmdPathBrowse.Name = "cmdPathBrowse";
            this.cmdPathBrowse.Size = new System.Drawing.Size(110, 23);
            this.cmdPathBrowse.TabIndex = 25;
            this.cmdPathBrowse.Text = "Browse";
            this.cmdPathBrowse.UseVisualStyleBackColor = true;
            this.cmdPathBrowse.Click += new System.EventHandler(this.cmdPathBrowse_Click);
            // 
            // tabValueInterface
            // 
            this.tabValueInterface.Controls.Add(this.label9);
            this.tabValueInterface.Controls.Add(this.cboInterface);
            this.tabValueInterface.Location = new System.Drawing.Point(4, 24);
            this.tabValueInterface.Name = "tabValueInterface";
            this.tabValueInterface.Size = new System.Drawing.Size(514, 72);
            this.tabValueInterface.TabIndex = 3;
            this.tabValueInterface.Text = "Interface";
            this.tabValueInterface.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(38, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Interface:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboInterface
            // 
            this.cboInterface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterface.FormattingEnabled = true;
            this.cboInterface.Location = new System.Drawing.Point(119, 2);
            this.cboInterface.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboInterface.Name = "cboInterface";
            this.cboInterface.Size = new System.Drawing.Size(385, 23);
            this.cboInterface.TabIndex = 21;
            // 
            // tabValueAddress
            // 
            this.tabValueAddress.Controls.Add(this.txtAddressMask);
            this.tabValueAddress.Controls.Add(this.label5);
            this.tabValueAddress.Controls.Add(this.txtAddressIp);
            this.tabValueAddress.Controls.Add(this.label4);
            this.tabValueAddress.Location = new System.Drawing.Point(4, 24);
            this.tabValueAddress.Name = "tabValueAddress";
            this.tabValueAddress.Size = new System.Drawing.Size(514, 72);
            this.tabValueAddress.TabIndex = 5;
            this.tabValueAddress.Text = "IPAddress";
            this.tabValueAddress.UseVisualStyleBackColor = true;
            // 
            // txtAddressMask
            // 
            this.txtAddressMask.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressMask.Location = new System.Drawing.Point(119, 30);
            this.txtAddressMask.Name = "txtAddressMask";
            this.txtAddressMask.Size = new System.Drawing.Size(259, 22);
            this.txtAddressMask.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Subnet Mask:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddressIp
            // 
            this.txtAddressIp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressIp.Location = new System.Drawing.Point(119, 1);
            this.txtAddressIp.Name = "txtAddressIp";
            this.txtAddressIp.Size = new System.Drawing.Size(259, 22);
            this.txtAddressIp.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "IP Address:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabValueProtocol
            // 
            this.tabValueProtocol.Controls.Add(this.label10);
            this.tabValueProtocol.Controls.Add(this.cboProtocol);
            this.tabValueProtocol.Location = new System.Drawing.Point(4, 24);
            this.tabValueProtocol.Name = "tabValueProtocol";
            this.tabValueProtocol.Size = new System.Drawing.Size(514, 72);
            this.tabValueProtocol.TabIndex = 6;
            this.tabValueProtocol.Text = "Protocol";
            this.tabValueProtocol.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(38, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Protocol:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProtocol
            // 
            this.cboProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProtocol.FormattingEnabled = true;
            this.cboProtocol.Location = new System.Drawing.Point(119, 3);
            this.cboProtocol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProtocol.Name = "cboProtocol";
            this.cboProtocol.Size = new System.Drawing.Size(385, 23);
            this.cboProtocol.TabIndex = 28;
            // 
            // FormCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(551, 247);
            this.Controls.Add(this.tabValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOperator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboField);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCondition";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Condition";
            this.tabValue.ResumeLayout(false);
            this.tabValuePort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            this.tabValuePortRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPortTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortFrom)).EndInit();
            this.tabValueApplication.ResumeLayout(false);
            this.tabValueApplication.PerformLayout();
            this.tabValueInterface.ResumeLayout(false);
            this.tabValueAddress.ResumeLayout(false);
            this.tabValueAddress.PerformLayout();
            this.tabValueProtocol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.TabControl tabValue;
        private System.Windows.Forms.TabPage tabValueText;
        private System.Windows.Forms.TabPage tabValuePort;
        private System.Windows.Forms.TabPage tabValueApplication;
        private System.Windows.Forms.TabPage tabValueInterface;
        private System.Windows.Forms.TabPage tabValuePortRange;
        private System.Windows.Forms.TabPage tabValueAddress;
        private System.Windows.Forms.TextBox txtAddressMask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdPathBrowse;
        private System.Windows.Forms.ComboBox cboInterface;
        private System.Windows.Forms.NumericUpDown txtPort;
        private System.Windows.Forms.NumericUpDown txtPortTo;
        private System.Windows.Forms.NumericUpDown txtPortFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabValueProtocol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboProtocol;
    }
}