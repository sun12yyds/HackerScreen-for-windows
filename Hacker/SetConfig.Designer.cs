﻿namespace Hacker
{
    partial class SetConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labTip = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.radNet = new System.Windows.Forms.RadioButton();
            this.radLocal = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optBar = new System.Windows.Forms.TrackBar();
            this.checkWebExit = new System.Windows.Forms.CheckBox();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkWebExit);
            this.groupBox1.Controls.Add(this.labTip);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.radNet);
            this.groupBox1.Controls.Add(this.radLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网页来源";
            // 
            // labTip
            // 
            this.labTip.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labTip.Location = new System.Drawing.Point(19, 56);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(207, 23);
            this.labTip.TabIndex = 3;
            this.labTip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(19, 85);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(207, 48);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Click += new System.EventHandler(this.txtInfo_Click);
            // 
            // radNet
            // 
            this.radNet.AutoSize = true;
            this.radNet.Location = new System.Drawing.Point(123, 33);
            this.radNet.Name = "radNet";
            this.radNet.Size = new System.Drawing.Size(47, 16);
            this.radNet.TabIndex = 1;
            this.radNet.TabStop = true;
            this.radNet.Text = "网络";
            this.radNet.UseVisualStyleBackColor = true;
            this.radNet.CheckedChanged += new System.EventHandler(this.radLocal_CheckedChanged);
            // 
            // radLocal
            // 
            this.radLocal.AutoSize = true;
            this.radLocal.Location = new System.Drawing.Point(19, 33);
            this.radLocal.Name = "radLocal";
            this.radLocal.Size = new System.Drawing.Size(47, 16);
            this.radLocal.TabIndex = 0;
            this.radLocal.TabStop = true;
            this.radLocal.Text = "本地";
            this.radLocal.UseVisualStyleBackColor = true;
            this.radLocal.CheckedChanged += new System.EventHandler(this.radLocal_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(295, 26);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(295, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optBar);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "不透明度";
            // 
            // optBar
            // 
            this.optBar.Location = new System.Drawing.Point(12, 30);
            this.optBar.Maximum = 100;
            this.optBar.Minimum = 10;
            this.optBar.Name = "optBar";
            this.optBar.Size = new System.Drawing.Size(220, 45);
            this.optBar.TabIndex = 0;
            this.optBar.TickFrequency = 10;
            this.optBar.Value = 100;
            // 
            // checkWebExit
            // 
            this.checkWebExit.AutoSize = true;
            this.checkWebExit.Location = new System.Drawing.Point(22, 142);
            this.checkWebExit.Name = "checkWebExit";
            this.checkWebExit.Size = new System.Drawing.Size(156, 16);
            this.checkWebExit.TabIndex = 5;
            this.checkWebExit.Text = "由网页决定是否退出屏保";
            this.checkWebExit.UseVisualStyleBackColor = true;
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Location = new System.Drawing.Point(303, 258);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(53, 12);
            this.linkHelp.TabIndex = 4;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "使用帮助";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // SetConfig
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(408, 289);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SetConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.RadioButton radNet;
        private System.Windows.Forms.RadioButton radLocal;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar optBar;
        private System.Windows.Forms.CheckBox checkWebExit;
        private System.Windows.Forms.LinkLabel linkHelp;
    }
}