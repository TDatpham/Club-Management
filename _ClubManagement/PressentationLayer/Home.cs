using _ClubManagement.DAL;
using _ClubManagement.DataAccesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ClubManagement.PressentationLayer
{
    public partial class Home : Form
    {
        string Name;
        string Mssv;
        Int16 RoleID;
        public Home(string name,string mssv,Int16 roleid)
        {
            InitializeComponent();
            HoTentxt.Text = name;
            MSSVtxt.Text = mssv;
            Mssv = mssv;
            Name = name;
            RoleID = roleid;
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account(Mssv,Name));
        }

        private void Main_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main(Name,Mssv,RoleID));
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(img.Instance.AVA(Mssv) != " ")
                pictureBox1.Image = img.Instance.Base64ToImage(img.Instance.AVA(Mssv));

            DateTime test = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            DataHelper.Instance.ExecuteNonQuery("insert into LICHSUDN values ('" + Mssv + "','" + test.ToString(format) + "',N'Đăng nhập')");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLSK_Click(object sender, EventArgs e)
        {
            if(RoleID == 0)
            {
                OpenChildForm(new QLSK_Admin());
            }
            else
            {
                OpenChildForm(new QLSK(Mssv));
            }
        }

        private void btnQLDN_Click(object sender, EventArgs e)
        {
            if (RoleID == 0)
            {
                OpenChildForm(new LSDN_Admin(Mssv));
            }
            else
            {
                OpenChildForm(new LSDN(Mssv));
            }
        }
    }
}
