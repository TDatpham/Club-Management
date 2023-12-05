using _ClubManagement.DAL;
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
    public partial class LSDN_Admin : Form
    {
        string Mssv;
        public LSDN_Admin(string mssv)
        {
            InitializeComponent();
            Mssv = mssv;
        }
        DataTable dt = new DataTable();
        private void LSDN_Admin_Load(object sender, EventArgs e)
        {
            DateTime test = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            DataHelper.Instance.ExecuteNonQuery("insert into LICHSUDN values ('" + Mssv + "','" + test.ToString(format) + "',N'Lịch Sử Đăng Nhập')");

            dt = DataHelper.Instance.ExecuteQuery("select * from LICHSUDN");
            dataGridView.DataSource = dt;

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "MSSV like '%" + textBox.Text + "%'";
        }

        private void Pagetxt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "PAGE like '%" + Pagetxt.Text + "%'";
        }
    }
}
