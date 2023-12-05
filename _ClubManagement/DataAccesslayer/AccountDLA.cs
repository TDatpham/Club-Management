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
            string query = "SELECT * FROM dbo.ACCOUNT WHERE USERNAME = '" + userName + "' and PSWRD = '" + passWord + "'";
            DataTable result = DataHelper.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;

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

    }
}


