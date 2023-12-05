namespace _ClubManagement.PressentationLayer
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HoTentxt = new System.Windows.Forms.Label();
            this.MSSVtxt = new System.Windows.Forms.Label();
            this.btnQLSK = new System.Windows.Forms.Button();
            this.btnQLDN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(187, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 608);
            this.panel1.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(12, 73);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(149, 52);
            this.Main.TabIndex = 1;
            this.Main.Text = "Quản lý clb";
            this.Main.UseVisualStyleBackColor = true;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(11, 247);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(149, 52);
            this.Account.TabIndex = 2;
            this.Account.Text = "Quản lý tài khoản";
            this.Account.UseVisualStyleBackColor = true;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(12, 568);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(149, 52);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Thoát";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::_ClubManagement.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HoTentxt
            // 
            this.HoTentxt.AutoSize = true;
            this.HoTentxt.Location = new System.Drawing.Point(73, 22);
            this.HoTentxt.Name = "HoTentxt";
            this.HoTentxt.Size = new System.Drawing.Size(35, 13);
            this.HoTentxt.TabIndex = 5;
            this.HoTentxt.Text = "label1";
            // 
            // MSSVtxt
            // 
            this.MSSVtxt.AutoSize = true;
            this.MSSVtxt.Location = new System.Drawing.Point(73, 45);
            this.MSSVtxt.Name = "MSSVtxt";
            this.MSSVtxt.Size = new System.Drawing.Size(35, 13);
            this.MSSVtxt.TabIndex = 6;
            this.MSSVtxt.Text = "label2";
            // 
            // btnQLSK
            // 
            this.btnQLSK.Location = new System.Drawing.Point(12, 131);
            this.btnQLSK.Name = "btnQLSK";
            this.btnQLSK.Size = new System.Drawing.Size(148, 52);
            this.btnQLSK.TabIndex = 7;
            this.btnQLSK.Text = "Quản lý sự kiện";
            this.btnQLSK.UseVisualStyleBackColor = true;
            this.btnQLSK.Click += new System.EventHandler(this.btnQLSK_Click);
            // 
            // btnQLDN
            // 
            this.btnQLDN.Location = new System.Drawing.Point(13, 189);
            this.btnQLDN.Name = "btnQLDN";
            this.btnQLDN.Size = new System.Drawing.Size(148, 52);
            this.btnQLDN.TabIndex = 8;
            this.btnQLDN.Text = "Quản lý đăng nhập";
            this.btnQLDN.UseVisualStyleBackColor = true;
            this.btnQLDN.Click += new System.EventHandler(this.btnQLDN_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 632);
            this.Controls.Add(this.btnQLDN);
            this.Controls.Add(this.btnQLSK);
            this.Controls.Add(this.MSSVtxt);
            this.Controls.Add(this.HoTentxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Main;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HoTentxt;
        private System.Windows.Forms.Label MSSVtxt;
        private System.Windows.Forms.Button btnQLSK;
        private System.Windows.Forms.Button btnQLDN;
    }
}