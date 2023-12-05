using _ClubManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ClubManagement.DataAccesslayer
{
    internal class img
    {
        public static img instance;
        public static img Instance
        {
            get { if (instance == null) instance = new img(); return instance; }
            private set { instance = value; }
        }
        public string AVA(string mssv)
        {
            string query = "select AVATA from THANHVIEN where MSSV = '" + mssv + "'";
            return DataHelper.Instance.getByte(query);
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length); System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        public string ImageToBase64(string path)
        {
            // string path = "D:\SampleImage.jpg";
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

    }
}
