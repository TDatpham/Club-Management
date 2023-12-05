using _ClubManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using _ClubManagement.DAL;
using System.Runtime.Remoting.Contexts;

namespace AccountDLA.DLA
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }

        private AccountDAL() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT PSWRD FROM ACCOUNT WHERE USERNAME = '" + userName + "'";
            string savedPasswordHash = DataHelper.Instance.getstring(query);
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[16]; Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(passWord, salt, 100000); byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++) 
                if (hashBytes[i + 16] != hash[i]) 
                    return false;
            return true;

        }

        public string Getname(string MSSV)
        {
            string query = "SELECT HOTEN FROM dbo.THANHVIEN WHERE MSSV = '" + MSSV + "'";
            string name = DataHelper.Instance.getstring(query);
            return name;
        }

        public string MSSV(string USERNAME)
        {
            string query = "select MSSV from dbo.ACCOUNT where USERNAME = '" + USERNAME + "'";
            string MSSV = DataHelper.Instance.getstring(query);
            return MSSV;
        }
        public void KhoiPhucMK(string mail, string mk)
        {
            byte[] salt; new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(mk, salt, 100000); byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36]; Array.Copy(salt, 0, hashBytes, 0, 16); Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            string query = "update ACCOUNT set PSWRD = REPLACE(LTRIM(RTRIM('" + savedPasswordHash + "')),' ',' ') where MSSV = (select MSSV from THANHVIEN where MAIL='" + mail + "')";
            DataHelper.Instance.ExecuteNonQuery(query);
        }

        public bool checkmail(string mail)
        {
            
            string query = "SELECT * FROM THANHVIEN WHERE MAIL = '" + mail + "'";
            DataTable result = DataHelper.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;

        }
    }
}


