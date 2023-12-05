using AccountDLA.DLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ClubManagement.PressentationLayer
{
    public partial class KhoiPhucMK : Form
    {
        public KhoiPhucMK()
        {
            InitializeComponent();
        }
        string otpp;
        private void btnOTP_Click(object sender, EventArgs e)
        {
            string MailAdmin = Mailtxt.Text;
            Random rnd = new Random();
            int getotp = rnd.Next(100, 999);
            if (checkmail())
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("mailclone2k3@gmail.com");
                    mail.To.Add(MailAdmin);
                    mail.Subject = "hello";
                    mail.IsBodyHtml = true;
                    mail.Body = getotp.ToString();

                    mail.Priority = MailPriority.High;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("mailclone2k3@gmail.com", "anpjdnvyqdjzsbmc");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    otpp = getotp.ToString();
                    btnKhoiPhuc.Enabled = true;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            else {
                MessageBox.Show("mail không tồn tại");
            }
            
        }

        private bool checkmail()
        {
            return AccountDAL.Instance.checkmail(Mailtxt.Text);
        }
        private void khoiphucmk()
        {
            AccountDAL.Instance.KhoiPhucMK(Mailtxt.Text, MKtxt.Text);
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (OTPtxt.Text == otpp)
            {
                if (MKtxt.Text == MKtxt2.Text)
                {
                    khoiphucmk();
                    MessageBox.Show("Khôi phục thành công mk");
                    btnKhoiPhuc.Enabled=false;
                }
                else
                {
                    MessageBox.Show("MK không khớp");
                }
            }
            else
            {
                MessageBox.Show("mã OTP không hợp lệ");
                btnKhoiPhuc.Enabled=false;
            }
           
            
        }

        private void KhoiPhucMK_Load(object sender, EventArgs e)
        {
            btnKhoiPhuc.Enabled=false;
        }
    }
}
