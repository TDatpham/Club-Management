namespace _ClubManagement.PressentationLayer
{
    partial class Login
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
            this.UsernameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.hideck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameTXT
            // 
            this.UsernameTXT.Location = new System.Drawing.Point(82, 35);
            this.UsernameTXT.Name = "UsernameTXT";
            this.UsernameTXT.Size = new System.Drawing.Size(100, 20);
            this.UsernameTXT.TabIndex = 0;
            this.UsernameTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTXT_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(28, 100);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Đăng nhập";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            this.Loginbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Loginbtn_KeyDown);
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.Location = new System.Drawing.Point(82, 61);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.Size = new System.Drawing.Size(100, 20);
            this.PasswordTXT.TabIndex = 1;
            this.PasswordTXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTXT_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PassWord";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(141, 100);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // hideck
            // 
            this.hideck.AutoSize = true;
            this.hideck.Location = new System.Drawing.Point(188, 63);
            this.hideck.Name = "hideck";
            this.hideck.Size = new System.Drawing.Size(53, 17);
            this.hideck.TabIndex = 7;
            this.hideck.Text = "Show";
            this.hideck.UseVisualStyleBackColor = true;
            this.hideck.CheckedChanged += new System.EventHandler(this.hideck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(79, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quên Mật khẩu";
            this.label3.Click += new System.EventHandler(this.QuenMKTXT_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hideck);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameTXT);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.CheckBox hideck;
        private System.Windows.Forms.Label label3;
    }
}