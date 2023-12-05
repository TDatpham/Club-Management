using _ClubManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ClubManagement.DAL
{
    public class EventDAL
    {
        DataHelper helper = new DataHelper();
        private Event GetEventInfoFromDataRow(DataRow row)
        {
            Event e = new Event();
            e.SKID = row["MASK"].ToString().Trim();
            e.Date = row["NGAYTOCHUC"].ToString().Trim();
            e.Name = row["TENSK"].ToString().Trim();
            e.Description = row["CHITIETSK"].ToString().Trim();
            e.Bonus = int.Parse(row["DIEMCONG"].ToString());

            return e;
        }
        public Event[] GetList()
        {
            DataTable table = helper.ExecuteQuery("select MASK, NGAYTOCHUC, TENSK, CHITIETSK, DIEMCONG from SUKIEN where GETDATE() < NGAYTOCHUC");

            int n = table.Rows.Count;

            if (n == 0)
                return null;

            Event[] list = new Event[n];
            for (int i = 0; i < n; i++)
            {
                Event @event = GetEventInfoFromDataRow(table.Rows[i]);
                list[i] = @event;
            }

            return list;
        }
        public bool Add(Event @event)
        {
            string query = string.Format("insert into SUKIEN values ('{0}', N'{1}', N'{2}', {3})",
                @event.Date, @event.Name, @event.Description, @event.Bonus);

            try
            {
                helper.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
