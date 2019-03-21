namespace testPasswordExtractor
{
    partial class registeredNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registeredNumber));
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseExcel = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(135, 345);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(128, 45);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your message :";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 188);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(385, 141);
            this.txtMsg.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numbers  :";
            // 
            // btnBrowseExcel
            // 
            this.btnBrowseExcel.Location = new System.Drawing.Point(295, 48);
            this.btnBrowseExcel.Name = "btnBrowseExcel";
            this.btnBrowseExcel.Size = new System.Drawing.Size(102, 74);
            this.btnBrowseExcel.TabIndex = 11;
            this.btnBrowseExcel.Text = "Browse Excel File";
            this.btnBrowseExcel.UseVisualStyleBackColor = true;
            this.btnBrowseExcel.Click += new System.EventHandler(this.btnBrowseExcel_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(12, 31);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTo.Size = new System.Drawing.Size(275, 106);
            this.txtTo.TabIndex = 10;
            // 
            // registeredNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 422);
            this.Controls.Add(this.btnBrowseExcel);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registeredNumber";
            this.Text = "Whatsapp Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseExcel;
        private System.Windows.Forms.TextBox txtTo;
    }
}