namespace _ClubManagement.PressentationLayer
{
    partial class KhoiPhucMK
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
            this.btnOTP = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.MKtxt = new System.Windows.Forms.TextBox();
            this.MKtxt2 = new System.Windows.Forms.TextBox();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.OTPtxt = new System.Windows.Forms.TextBox();
            this.MK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOTP
            // 
            this.btnOTP.Location = new System.Drawing.Point(188, 94);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.Size = new System.Drawing.Size(75, 23);
            this.btnOTP.TabIndex = 0;
            this.btnOTP.Text = "get OTP";
            this.btnOTP.UseVisualStyleBackColor = true;
            this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Location = new System.Drawing.Point(132, 120);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(75, 23);
            this.btnKhoiPhuc.TabIndex = 1;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // MKtxt
            // 
            this.MKtxt.Location = new System.Drawing.Point(82, 16);
            this.MKtxt.Name = "MKtxt";
            this.MKtxt.Size = new System.Drawing.Size(181, 20);
            this.MKtxt.TabIndex = 2;
            // 
            // MKtxt2
            // 
            this.MKtxt2.Location = new System.Drawing.Point(82, 42);
            this.MKtxt2.Name = "MKtxt2";
            this.MKtxt2.Size = new System.Drawing.Size(181, 20);
            this.MKtxt2.TabIndex = 3;
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(82, 68);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(181, 20);
            this.Mailtxt.TabIndex = 4;
            // 
            // OTPtxt
            // 
            this.OTPtxt.Location = new System.Drawing.Point(82, 94);
            this.OTPtxt.Name = "OTPtxt";
            this.OTPtxt.Size = new System.Drawing.Size(100, 20);
            this.OTPtxt.TabIndex = 5;
            // 
            // MK
            // 
            this.MK.AutoSize = true;
            this.MK.Location = new System.Drawing.Point(13, 19);
            this.MK.Name = "MK";
            this.MK.Size = new System.Drawing.Size(42, 13);
            this.MK.TabIndex = 6;
            this.MK.Text = "MK mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập lại mk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "OTP";
            // 
            // KhoiPhucMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 165);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MK);
            this.Controls.Add(this.OTPtxt);
            this.Controls.Add(this.Mailtxt);
            this.Controls.Add(this.MKtxt2);
            this.Controls.Add(this.MKtxt);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.btnOTP);
            this.Name = "KhoiPhucMK";
            this.Text = "KhoiPhucMK";
            this.Load += new System.EventHandler(this.KhoiPhucMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOTP;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.TextBox MKtxt;
        private System.Windows.Forms.TextBox MKtxt2;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.TextBox OTPtxt;
        private System.Windows.Forms.Label MK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}