using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _ClubManagement.DAL;
using _ClubManagement.DTO;

namespace _ClubManagement.BLL
{
    public class MemberBLL
    {
        MemberDAL dal = new MemberDAL();
        public Member[] GetList(string query)
        {
            return dal.GetList(query);
        }
        public bool Add(Member member)
        {
            try
            {
                return dal.Add(member);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
