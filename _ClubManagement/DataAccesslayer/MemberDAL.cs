using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _ClubManagement.DTO;
using System.Windows.Forms;
using System.Data.SqlClient;
using _ClubManagement.DataAccesslayer;
using System.Security.Cryptography;

namespace _ClubManagement.DAL
{
    public class MemberDAL
    {
        DataHelper helper = new DataHelper();
        private string mk()
        {
            string pass = "admin123";
            byte[] salt; new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(pass, salt, 100000); byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36]; Array.Copy(salt, 0, hashBytes, 0, 16); Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        private Member GetMemberFromDataRow(DataRow row)
        {
            Member member = new Member();

            member.ID = row["MSSV"].ToString().Trim();
            member.DptmtID = row["MAKHOA"].ToString().Trim();
            member.Name = row["HOTEN"].ToString().Trim();
            member.Gender = byte.Parse(row["GIOITINH"].ToString());
            member.BirthDate = row["NGAYSINH"].ToString().Trim();
            member.MaViTri = int.Parse(row["STTVITRI"].ToString());
            member.MaPhgBan = int.Parse(row["MAPHGBAN"].ToString());

            return member;
        }
        public Member[] GetList(string query)
        {
            //DataTable table = helper.ExecuteQuery("select tv.MSSV, tv.MAKHOA, tv.HOTEN, tv.GIOITINH, tv.NGAYSINH, vt.STTVITRI, phg.MAPHGBAN from THANHVIEN tv inner join LAMVIEC lv on tv.MSSV = lv.MSSV left join VITRI vt on lv.STTVITRI = vt.STTVITRI left join PHONGBAN phg on lv.MAPHGBAN = phg.MAPHGBAN");
            DataTable table = helper.ExecuteQuery(query);

            int n = table.Rows.Count;

            if (n == 0)
                return null;

            Member[] list = new Member[n];
            for (int i = 0; i < n; i++)
            {
                Member m = GetMemberFromDataRow(table.Rows[i]);
                list[i] = m;
            }

            return list;
        }
        public bool Add(Member member)
        {
            string query1 = string.Format("insert into THANHVIEN values ('{0}', '{1}', N'{2}', {3}, '{4}', '{5}', '{6}', 0)",
                member.ID, member.DptmtID, member.Name, member.Gender, member.BirthDate,"1234@gmail.com", System.Convert.ToBase64String(System.IO.File.ReadAllBytes("Resources\\download.jpg")));

            string query2 = string.Format("insert into LAMVIEC values ('{0}', {1}, {2})",
                member.ID, member.MaViTri, member.MaPhgBan);

            string query3 = string.Format("insert into ACCOUNT values ('{0}', 1, '{1}', '{2}')", 
                member.ID, member.ID, mk());



            try
            {
                helper.ExecuteNonQuery(query1);
                helper.ExecuteNonQuery(query2);
                helper.ExecuteNonQuery(query3);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
