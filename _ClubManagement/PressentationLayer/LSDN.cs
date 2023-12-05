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
    public partial class LSDN : Form
    {
        string Mssv;
        public LSDN(string mssv)
        {
            InitializeComponent();
            Mssv = mssv;

        }
        DataTable dt = new DataTable();
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void LSDN_Load(object sender, EventArgs e)
        {
            

            DateTime test = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            DataHelper.Instance.ExecuteNonQuery("insert into LICHSUDN values ('" + Mssv + "','" + test.ToString(format) + "',N'Lịch Sử Đăng Nhập')");

            dt = DataHelper.Instance.ExecuteQuery("select * from LICHSUDN where MSSV = '" + Mssv + "'");
            dataGridView.DataSource = dt;


        }
    }
}
