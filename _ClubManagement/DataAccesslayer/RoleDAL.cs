using _ClubManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _ClubManagement.DataAccesslayer
{
    internal class RoleDAL
    {
        private static RoleDAL instance;

        internal static RoleDAL Instance
        {
            get { if (instance == null) instance = new RoleDAL(); return instance; }
            private set { instance = value; }
        }

        private RoleDAL() { }


        public Int16 ROLE(string USERNAME)
        {

            string query = "select IDROLE from dbo.ACCOUNT where USERNAME = '" + USERNAME + "'";
            Int16 IDROLE = DataHelper.Instance.getint(query);
            return IDROLE;
        }
    }
}
