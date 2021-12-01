using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS3309F21FP
{
    class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MMABooks.mdf;Integrated Security=True");
        }
        public static int ExecuteNonQuery(SqlCommand com, SqlConnection con) {
            try
            {
                con.Open();
                int count = com.ExecuteNonQuery();
                if (count > 0)
                    return 1;
                else
                    return -1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
 }

