using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ClubManagement.DTO
{
    public class Member
    {
        public string ID { get; set; }
        public string DptmtID { get; set; }
        public string Name { get; set; }
        public byte Gender { get; set; }
        public string BirthDate { get; set; }
        public int MaViTri { get; set; }
        public int MaPhgBan { get; set; }
    }
}
