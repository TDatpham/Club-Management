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
    public partial class QLSK_Admin : Form
    {
        string Mssv;
        public QLSK_Admin()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void load_cb()
        {
            DataHelper.Instance.ComboBoxLoad(cbx: cbSK, select: "select MASK, TENSK from SUKIEN",
               tableName: "SUKIEN", displayMember: "TENSK", valueMember: "MASK");
        }
        private void QLSK_Admin_Load(object sender, EventArgs e)
        {
            load_cb();
            dt = DataHelper.Instance.ExecuteQuery("select * from TOCHUC");
            dataGridView.DataSource = dt;
        }

        private void txtmssv_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "MSSV like '%" + txtmssv.Text + "%'";
        }
    }
}
