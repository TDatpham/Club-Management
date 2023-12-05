using _ClubManagement.DAL;
using _ClubManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ClubManagement.BLL
{
    public class EventBLL
    {
        EventDAL dal = new EventDAL();

        public Event[] GetList()
        {
            return dal.GetList();
        }
        public bool Add(Event @event)
        {
            try
            {
                return dal.Add(@event);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
