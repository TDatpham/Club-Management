using _ClubManagement.DAL;
using AccountDLA.DLA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Security.Cryptography;

namespace _ClubManagement.DataAccesslayer
{
    internal class updateAccountDLA
    {
        public static updateAccountDLA instance;
        public static updateAccountDLA Instance
        {
            get { if (instance == null) instance = new updateAccountDLA(); return instance; }
            private set { instance = value; }
        }

        public void updateImgAVA(string url,string mssv)
        {
            string query = "update THANHVIEN set AVATA='" + url + "' where MSSV='" + mssv + "'";
            DataHelper.Instance.ExecuteNonQuery(query);
        }

        public void changeInf(string mssv,string HoTen,string Mail, string Khoa)
        {
            string query = "update THANHVIEN set HOTEN =N'" + HoTen + "', MAIL = '" + Mail + "', MAKHOA = '" + Khoa + "' where MSSV='" + mssv + "'";
            DataHelper.Instance.ExecuteNonQuery(query);
        }
        public string getmail(string mssv)
        {
            string query = "select MAIL from THANHVIEN where MSSV = '" + mssv + "'";
            string Mail = DataHelper.Instance.getstring(query);
            return Mail;
        }
        public string getMaKhoa(string TenKhoa)
        {
            string query = "select MAKHOA from Khoa where TENKHOA = N'" + TenKhoa + "'";
            string MaKhoa = DataHelper.Instance.getstring(query);
            return MaKhoa;
        }
        public void DoiMK(string mssv, string mk)
        {
            byte[] salt; new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(mk, salt, 100000); byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36]; Array.Copy(salt, 0, hashBytes, 0, 16); Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            string query = "update ACCOUNT set PSWRD = REPLACE(LTRIM(RTRIM('" + savedPasswordHash + "')),' ',' ') where MSSV='" + mssv + "'";
            DataHelper.Instance.ExecuteNonQuery(query);
        }

        public bool Checkmk(string MSSV, string passWord)
        {
            string query = "SELECT PSWRD FROM ACCOUNT WHERE MSSV = '" + MSSV + "'";
            string savedPasswordHash = DataHelper.Instance.getstring(query);
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[16]; Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(passWord, salt, 100000); byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;
            return true;

        }
    }
   

}
