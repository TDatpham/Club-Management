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
    public partial class QLSK : Form
    {
        string Mssv;
        public QLSK(string mssv)
        {
            InitializeComponent();
            Mssv = mssv;
        }
        DataTable dt = new DataTable();
        private void QLSK_Load(object sender, EventArgs e)
        {
            dt = DataHelper.Instance.ExecuteQuery("select * from SUKIEN where MASK = (select MASK from TOCHUC where MSSV = '" + Mssv + "')");
            dataGridView.DataSource = dt;
        }
    }
}
