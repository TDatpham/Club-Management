using _ClubManagement.DAL;
using _ClubManagement.DataAccesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ClubManagement.PressentationLayer
{
    public partial class Account : Form
    {
        string Mssv = " ";
        public string url;
        readonly DataHelper helper = new DataHelper();
        string Ten;
        public Account(string mssv,string ten)
        {
            InitializeComponent();
            Mssv = mssv;
            MSSVtxt.Text = Mssv;
            Tentxt.Text = ten;
            Ten = ten;
            DiemHD.Text = DataHelper.Instance.getint32("select DIEMHD from THANHVIEN where MSSV = '" + Mssv + "'").ToString();
        }

        private void Change_avata(string urlstr)
        {
            updateAccountDLA.Instance.updateImgAVA(urlstr,Mssv);
        }

        private void avata_Click(object sender, EventArgs e)
        {
            string urlstr = " ";
            
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";


                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    avata.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
                

            }
            
            urlstr =img.Instance.ImageToBase64(url);
            
            Change_avata(urlstr);


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clearinf_Click(object sender, EventArgs e)
        {

        }
        private void updateinf()
        {
            string makhoa = updateAccountDLA.Instance.getMaKhoa(Khoa.Text);
            updateAccountDLA.Instance.changeInf(Mssv, HoTen.Text, Mail.Text, makhoa);
        }
        private string updateMail()
        {
            string mail = updateAccountDLA.Instance.getmail(Mssv);
            return mail;
        }
        private void updateInf_Click(object sender, EventArgs e)
        {
            updateinf();
            MessageBox.Show("cập nhật thành công");
        }

        private void Account_Load(object sender, EventArgs e)
        {
            helper.ComboBoxLoad(cbx: Khoa, select: "select * from KHOA",
                tableName: "KHOA", displayMember: "TENKHOA", valueMember: "MAKHOA");

            HoTen.Text = Ten;
            Mail.Text = updateMail();
            if (img.Instance.AVA(Mssv) != " ")
                avata.Image = img.Instance.Base64ToImage(img.Instance.AVA(Mssv));
            
        }

        private void updateMK_Click(object sender, EventArgs e)
        {
            if (updateAccountDLA.Instance.Checkmk(Mssv,MK.Text))
            {
                if (MKMoi.Text == MKmoi2.Text)
                {
                    updateAccountDLA.Instance.DoiMK(Mssv, MKMoi.Text);
                    MessageBox.Show("đổi mk thành công");
                }

                else
                    MessageBox.Show("MK không khớp");
            }
            else
            {
                MessageBox.Show("sai mk cũ");
            }


        }
    }
}
