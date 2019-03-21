namespace testPasswordExtractor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSend = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.cmbNetwork = new System.Windows.Forms.ComboBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.btnGetCode = new System.Windows.Forms.Button();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.btnBrowseExcel = new System.Windows.Forms.Button();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.grp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(157, 375);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(128, 45);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(34, 61);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTo.Size = new System.Drawing.Size(275, 106);
            this.txtTo.TabIndex = 1;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(34, 218);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(385, 141);
            this.txtMsg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numbers  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your message :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Number :";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(18, 66);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(180, 22);
            this.txtFrom.TabIndex = 6;
            // 
            // cmbNetwork
            // 
            this.cmbNetwork.FormattingEnabled = true;
            this.cmbNetwork.Items.AddRange(new object[] {
            "Orange",
            "Vodafone",
            "Etisalat"});
            this.cmbNetwork.Location = new System.Drawing.Point(54, 104);
            this.cmbNetwork.Name = "cmbNetwork";
            this.cmbNetwork.Size = new System.Drawing.Size(126, 24);
            this.cmbNetwork.TabIndex = 7;
            this.cmbNetwork.Text = "Select Operator";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.btnGetCode);
            this.grp1.Controls.Add(this.cmbNetwork);
            this.grp1.Controls.Add(this.txtFrom);
            this.grp1.Location = new System.Drawing.Point(12, 16);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(228, 237);
            this.grp1.TabIndex = 8;
            this.grp1.TabStop = false;
            this.grp1.Text = "Set Your Number";
            // 
            // btnGetCode
            // 
            this.btnGetCode.Location = new System.Drawing.Point(45, 152);
            this.btnGetCode.Name = "btnGetCode";
            this.btnGetCode.Size = new System.Drawing.Size(145, 49);
            this.btnGetCode.TabIndex = 0;
            this.btnGetCode.Text = "Get Code";
            this.btnGetCode.UseVisualStyleBackColor = true;
            this.btnGetCode.Click += new System.EventHandler(this.btnGetCode_Click);
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.btnCode);
            this.grp2.Controls.Add(this.txtCode);
            this.grp2.Controls.Add(this.label4);
            this.grp2.Location = new System.Drawing.Point(246, 16);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(222, 237);
            this.grp2.TabIndex = 9;
            this.grp2.TabStop = false;
            this.grp2.Text = "Enter Code";
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(40, 152);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(145, 49);
            this.btnCode.TabIndex = 2;
            this.btnCode.Text = "Enter Code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 66);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(173, 22);
            this.txtCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Recieved Code :";
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.btnBrowseExcel);
            this.grp3.Controls.Add(this.txtTo);
            this.grp3.Controls.Add(this.btnSend);
            this.grp3.Controls.Add(this.label2);
            this.grp3.Controls.Add(this.txtMsg);
            this.grp3.Controls.Add(this.label1);
            this.grp3.Location = new System.Drawing.Point(12, 259);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(456, 438);
            this.grp3.TabIndex = 10;
            this.grp3.TabStop = false;
            this.grp3.Text = "Send Message";
            // 
            // btnBrowseExcel
            // 
            this.btnBrowseExcel.Location = new System.Drawing.Point(317, 78);
            this.btnBrowseExcel.Name = "btnBrowseExcel";
            this.btnBrowseExcel.Size = new System.Drawing.Size(102, 74);
            this.btnBrowseExcel.TabIndex = 5;
            this.btnBrowseExcel.Text = "Browse Excel File";
            this.btnBrowseExcel.UseVisualStyleBackColor = true;
            this.btnBrowseExcel.Click += new System.EventHandler(this.btnBrowseExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 709);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.grp3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Whatsapp Sender";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.grp3.ResumeLayout(false);
            this.grp3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ComboBox cmbNetwork;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Button btnGetCode;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grp3;
        private System.Windows.Forms.Button btnBrowseExcel;
    }
}

