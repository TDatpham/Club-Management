
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ClubManagement.DAL
{
    public class DataHelper
    {
        private static SqlConnection _connection = null;
        private static DataHelper instance;
        public static DataHelper Instance
        {
            get { if (instance == null) instance = new DataHelper(); return DataHelper.instance; }
            private set { DataHelper.instance = value; }
        }

        public DataHelper()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            _connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Execute select query
        /// </summary>
        /// <param name="query">a string of select query</param>
        /// <returns>DataTable of query</returns>
        /// <exception cref="Something went wrong"></exception>
        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();

            try
            {
                _connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Execute query erorr: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return table;
        }

        /// <summary>
        /// Execute insert, update, delete query
        /// </summary>
        /// <param name="query">a query string</param>
        /// <exception cref="Something went wrong"></exception>
        public void ExecuteNonQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);

            try
            {
                _connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execute non query error: " + ex.Message);
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }

                if (command != null)
                {
                    command.Dispose();
                }
            }
        }
        public string getstring (string query)
        {
            string value = " ";
            SqlCommand command = new SqlCommand(query, _connection);
            try
            {
                _connection.Open();
                // Execute the command and get a data reader
                SqlDataReader reader = command.ExecuteReader();

                // Read the data from the reader
                while (reader.Read())
                {
                    // Get the string value from the first column
                    value = reader.GetString(0);
                    // Do something with the value
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("Execute non query error: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            
            return value;
        }

        public Int16 getint(string query)
        {
            Int16 value = 3;
            SqlCommand command = new SqlCommand(query, _connection);
            try
            {
                _connection.Open();
                // Execute the command and get a data reader
                SqlDataReader reader = command.ExecuteReader();

                // Read the data from the reader
                while (reader.Read())
                {
                    // Get the string value from the first column
                    value = reader.GetInt16(0);
                    // Do something with the value
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Execute non query error: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return value;
        }

        public int getint32(string query)
        {
            int value = 3;
            SqlCommand command = new SqlCommand(query, _connection);
            try
            {
                _connection.Open();
                // Execute the command and get a data reader
                SqlDataReader reader = command.ExecuteReader();

                // Read the data from the reader
                while (reader.Read())
                {
                    // Get the string value from the first column
                    value = reader.GetInt32(0);
                    // Do something with the value
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Execute non query error: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return value;
        }
        public string getByte(string query)
        {
            byte[] getImg = new byte[0];
            byte[] imgData;
            SqlCommand cmd = new SqlCommand(query, _connection);
            try
            {
                _connection.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    getImg = (byte[])dr["AVATA"];
                }

                imgData = getImg;

            }
            catch (Exception ex)
            {
                throw new Exception("Execute non query error: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            string imgurl = System.Text.Encoding.Default.GetString(imgData);
            return imgurl;
        }
        public void ComboBoxLoad(ComboBox cbx, string select, string tableName, string displayMember, string valueMember)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(select, _connection);
            da.Fill(ds, tableName);
            cbx.DataSource = ds.Tables[0];
            cbx.DisplayMember = displayMember;
            cbx.ValueMember = valueMember;
        }
    }
}