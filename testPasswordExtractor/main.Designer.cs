namespace testPasswordExtractor
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnRegisteredNumber = new System.Windows.Forms.Button();
            this.btnNewNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisteredNumber
            // 
            this.btnRegisteredNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteredNumber.Location = new System.Drawing.Point(41, 60);
            this.btnRegisteredNumber.Name = "btnRegisteredNumber";
            this.btnRegisteredNumber.Size = new System.Drawing.Size(192, 107);
            this.btnRegisteredNumber.TabIndex = 0;
            this.btnRegisteredNumber.Text = "Registered Number";
            this.btnRegisteredNumber.UseVisualStyleBackColor = true;
            this.btnRegisteredNumber.Click += new System.EventHandler(this.btnRegisteredNumber_Click);
            // 
            // btnNewNumber
            // 
            this.btnNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumber.Location = new System.Drawing.Point(280, 60);
            this.btnNewNumber.Name = "btnNewNumber";
            this.btnNewNumber.Size = new System.Drawing.Size(192, 107);
            this.btnNewNumber.TabIndex = 1;
            this.btnNewNumber.Text = "New Number";
            this.btnNewNumber.UseVisualStyleBackColor = true;
            this.btnNewNumber.Click += new System.EventHandler(this.btnNewNumber_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 234);
            this.Controls.Add(this.btnNewNumber);
            this.Controls.Add(this.btnRegisteredNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Whatsapp Sender";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisteredNumber;
        private System.Windows.Forms.Button btnNewNumber;
    }
}