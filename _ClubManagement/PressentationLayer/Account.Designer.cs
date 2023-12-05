namespace _ClubManagement.PressentationLayer
{
    partial class Account
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
            this.avata = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Khoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateInf = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.TextBox();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateMK = new System.Windows.Forms.Button();
            this.clearmk = new System.Windows.Forms.Button();
            this.MKmoi2 = new System.Windows.Forms.TextBox();
            this.MKMoi = new System.Windows.Forms.TextBox();
            this.MK = new System.Windows.Forms.TextBox();
            this.Tentxt = new System.Windows.Forms.Label();
            this.MSSVtxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiemHD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // avata
            // 
            this.avata.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.avata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avata.Image = global::_ClubManagement.Properties.Resources.download;
            this.avata.Location = new System.Drawing.Point(12, 12);
            this.avata.Name = "avata";
            this.avata.Size = new System.Drawing.Size(82, 87);
            this.avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avata.TabIndex = 0;
            this.avata.TabStop = false;
            this.avata.Click += new System.EventHandler(this.avata_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Khoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.updateInf);
            this.groupBox1.Controls.Add(this.Mail);
            this.groupBox1.Controls.Add(this.HoTen);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Khoa
            // 
            this.Khoa.FormattingEnabled = true;
            this.Khoa.Location = new System.Drawing.Point(64, 100);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(81, 21);
            this.Khoa.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên";
            // 
            // updateInf
            // 
            this.updateInf.Location = new System.Drawing.Point(64, 158);
            this.updateInf.Name = "updateInf";
            this.updateInf.Size = new System.Drawing.Size(124, 23);
            this.updateInf.TabIndex = 6;
            this.updateInf.Text = "update";
            this.updateInf.UseVisualStyleBackColor = true;
            this.updateInf.Click += new System.EventHandler(this.updateInf_Click);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(64, 74);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(175, 20);
            this.Mail.TabIndex = 1;
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(64, 48);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(175, 20);
            this.HoTen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.updateMK);
            this.groupBox2.Controls.Add(this.clearmk);
            this.groupBox2.Controls.Add(this.MKmoi2);
            this.groupBox2.Controls.Add(this.MKMoi);
            this.groupBox2.Controls.Add(this.MK);
            this.groupBox2.Location = new System.Drawing.Point(277, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 193);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đổi mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nhập lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mật khẩu cũ";
            // 
            // updateMK
            // 
            this.updateMK.Location = new System.Drawing.Point(136, 158);
            this.updateMK.Name = "updateMK";
            this.updateMK.Size = new System.Drawing.Size(117, 23);
            this.updateMK.TabIndex = 8;
            this.updateMK.Text = "update";
            this.updateMK.UseVisualStyleBackColor = true;
            this.updateMK.Click += new System.EventHandler(this.updateMK_Click);
            // 
            // clearmk
            // 
            this.clearmk.Location = new System.Drawing.Point(9, 158);
            this.clearmk.Name = "clearmk";
            this.clearmk.Size = new System.Drawing.Size(121, 23);
            this.clearmk.TabIndex = 6;
            this.clearmk.Text = "clear";
            this.clearmk.UseVisualStyleBackColor = true;
            // 
            // MKmoi2
            // 
            this.MKmoi2.Location = new System.Drawing.Point(79, 100);
            this.MKmoi2.Name = "MKmoi2";
            this.MKmoi2.Size = new System.Drawing.Size(159, 20);
            this.MKmoi2.TabIndex = 4;
            // 
            // MKMoi
            // 
            this.MKMoi.Location = new System.Drawing.Point(79, 74);
            this.MKMoi.Name = "MKMoi";
            this.MKMoi.Size = new System.Drawing.Size(159, 20);
            this.MKMoi.TabIndex = 3;
            // 
            // MK
            // 
            this.MK.Location = new System.Drawing.Point(79, 48);
            this.MK.Name = "MK";
            this.MK.Size = new System.Drawing.Size(159, 20);
            this.MK.TabIndex = 2;
            // 
            // Tentxt
            // 
            this.Tentxt.AutoSize = true;
            this.Tentxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tentxt.Location = new System.Drawing.Point(100, 28);
            this.Tentxt.Name = "Tentxt";
            this.Tentxt.Size = new System.Drawing.Size(76, 25);
            this.Tentxt.TabIndex = 3;
            this.Tentxt.Text = "label1";
            // 
            // MSSVtxt
            // 
            this.MSSVtxt.AutoSize = true;
            this.MSSVtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSSVtxt.Location = new System.Drawing.Point(100, 62);
            this.MSSVtxt.Name = "MSSVtxt";
            this.MSSVtxt.Size = new System.Drawing.Size(57, 20);
            this.MSSVtxt.TabIndex = 4;
            this.MSSVtxt.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm Hoạt động:";
            // 
            // DiemHD
            // 
            this.DiemHD.AutoSize = true;
            this.DiemHD.Location = new System.Drawing.Point(195, 86);
            this.DiemHD.Name = "DiemHD";
            this.DiemHD.Size = new System.Drawing.Size(35, 13);
            this.DiemHD.TabIndex = 6;
            this.DiemHD.Text = "label8";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 330);
            this.Controls.Add(this.DiemHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MSSVtxt);
            this.Controls.Add(this.Tentxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.avata);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Tentxt;
        private System.Windows.Forms.Label MSSVtxt;
        private System.Windows.Forms.Button updateInf;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.Button updateMK;
        private System.Windows.Forms.Button clearmk;
        private System.Windows.Forms.TextBox MKmoi2;
        private System.Windows.Forms.TextBox MKMoi;
        private System.Windows.Forms.TextBox MK;
        private System.Windows.Forms.ComboBox Khoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DiemHD;
    }
}