using _ClubManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _ClubManagement.DataAccesslayer;
using AccountDLA.DLA;
using System.Net.Mail;

namespace _ClubManagement.PressentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PasswordTXT.UseSystemPasswordChar = true;
            
        }
        bool login ()
        {
            return AccountDAL.Instance.Login(UsernameTXT.Text, PasswordTXT.Text);
        }
        string GetMSSV()
        {
            string MSSV = AccountDAL.Instance.MSSV(UsernameTXT.Text);
            return MSSV;
        }
        string getname()
        {
            return AccountDAL.Instance.Getname(GetMSSV());
        }
        Int16 getRole()
        {
            return RoleDAL.Instance.ROLE(UsernameTXT.Text);
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (login())
            {
                Home form = new Home(getname(), GetMSSV(), getRole());
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("sai mk");
            }
        }



        private void QuenMKTXT_Click(object sender, EventArgs e)
        {
            KhoiPhucMK form = new KhoiPhucMK();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideck_CheckedChanged(object sender, EventArgs e)
        {
            if (hideck.Checked)
            {
                PasswordTXT.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTXT.UseSystemPasswordChar = true;
                
            }
        }

        private void Loginbtn_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void PasswordTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (login())
                {
                    Home form = new Home(getname(), GetMSSV(), getRole());
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("sai mk");
                }
            }
        }

        private void UsernameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTXT.Select();
            }
        }
    }
}
