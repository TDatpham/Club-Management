using _ClubManagement.BLL;
using _ClubManagement.DAL;
using _ClubManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Reflection;

namespace _ClubManagement
{
    public partial class Main : Form
    {
        readonly MemberBLL bll = new MemberBLL();
        readonly EventBLL eventBLL = new EventBLL();
        readonly DataHelper helper = new DataHelper();
        Int16 role;
        string mssv = " ";
        
        public Main(string NAME, string MSSV, Int16 ROLE)
        {
            InitializeComponent();
            mssv = MSSV;
            role = ROLE;
        }
        public Main()
        {
            InitializeComponent();
        }
        


        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = ((DataTable)dgv.DataSource).Copy();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (!column.Visible)
                {
                    dt.Columns.Remove(column.Name);
                }
            }
            return dt;
        }
        DataTable dtINF = new DataTable();
        private void LoadData()
        {
            
            dtINF = DataHelper.Instance.ExecuteQuery("select tv.MSSV, tv.MAKHOA, tv.HOTEN, tv.GIOITINH, tv.NGAYSINH, vt.STTVITRI, phg.MAPHGBAN from THANHVIEN tv inner join LAMVIEC lv on tv.MSSV = lv.MSSV left join VITRI vt on lv.STTVITRI = vt.STTVITRI left join PHONGBAN phg on lv.MAPHGBAN = phg.MAPHGBAN");
            dgvInfo.DataSource = dtINF;//bll.GetList("select tv.MSSV, tv.MAKHOA, tv.HOTEN, tv.GIOITINH, tv.NGAYSINH, vt.STTVITRI, phg.MAPHGBAN from THANHVIEN tv inner join LAMVIEC lv on tv.MSSV = lv.MSSV left join VITRI vt on lv.STTVITRI = vt.STTVITRI left join PHONGBAN phg on lv.MAPHGBAN = phg.MAPHGBAN");
            dgvSchedule.DataSource = eventBLL.GetList();
            helper.ComboBoxLoad(cbx: cbxKhoa, select: "select * from KHOA",
                tableName: "KHOA", displayMember: "TENKHOA", valueMember: "MAKHOA");
            helper.ComboBoxLoad(cbx: cbxBan, select: "select * from PHONGBAN",
                tableName: "PHONGBAN", displayMember: "TENPHGBAN", valueMember: "MAPHGBAN");
            helper.ComboBoxLoad(cbx: cbxViTri, select: "select * from VITRI",
                tableName: "VITRI", displayMember: "TENVITRI", valueMember: "STTVITRI");


            


        }
        private void main_Load(object sender, EventArgs e)
        {
            
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while loading data",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            if(role == 1)
            {
                btnAdd.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Member member = GetMemberInfo();

            try
            {
                if (bll.Add(member))
                {
                    LoadData();
                    MessageBox.Show("Success!");
                    txtGender.Clear();
                    txtHoTen.Clear();
                    txtID.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Member GetMemberInfo()
        {
            Member member = new Member();

            member.ID = txtID.Text.Trim();
            member.DptmtID = cbxKhoa.SelectedValue.ToString().Trim();
            member.Name = txtHoTen.Text.Trim();
            member.Gender = byte.Parse(txtGender.Text.Trim());
            member.BirthDate = mtxtNgaySinh.Text.Trim();
            member.MaViTri = int.Parse(cbxViTri.SelectedValue.ToString());
            member.MaPhgBan = int.Parse(cbxBan.SelectedValue.ToString());

            return member;
        }
        Event GetEventInfo()
        {
            Event @event = new Event();
            @event.Date = dateTimePicker.Value.ToString("yyyy/MM/dd");
            @event.Name = txtEventName.Text.ToString().Trim();
            @event.Description = txtDetail.Text.ToString().Trim();
            @event.Bonus = int.Parse(txtBonus.Text);

            return @event;
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Event @event = GetEventInfo();

            try
            {
                if (eventBLL.Add(@event))
                {
                    LoadData();
                    MessageBox.Show("Success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtINF.DefaultView;
            dv.RowFilter = "MSSV like '%" + txtID.Text + "%'";
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtINF.DefaultView;
            dv.RowFilter = "HOTEN like '%" + txtHoTen.Text + "%'";
        }

        
        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int DIEMHD = DataHelper.Instance.getint32("select DIEMHD from THANHVIEN where MSSV = '" + mssv + "'");
            int indexOfContent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dgvSchedule.Rows[indexOfContent];
            DialogResult result = MessageBox.Show(dataGridViewRow.Cells["Description"].Value.ToString() + "\nĐiểm cộng: " + dataGridViewRow.Cells["Bonus"].Value.ToString(), dataGridViewRow.Cells["Name"].Value.ToString(),MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                try
                {
                    DataHelper.Instance.ExecuteNonQuery("insert into TOCHUC (MSSV,MASK) values ('" + mssv + "','" + dataGridViewRow.Cells["SKID"].Value.ToString() + "')");
                    DataHelper.Instance.ExecuteNonQuery("update THANHVIEN set DIEMHD = " + (Int32.Parse(dataGridViewRow.Cells["Bonus"].Value.ToString()) + DIEMHD).ToString() + "where MSSV = '" + mssv + "'");
                }
                catch {
                    MessageBox.Show("Đã đăng ký sự kiện này");
                }
                
            }
        }
    }
}
