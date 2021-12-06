using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace CIS3309F21FP
{
    class OrderOptionsDB
    {
        public static OrderOptions GetOrderOptions()
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement
                = "SELECT SalesTaxRate, FirstBookShipCharge, AdditionalBookShipCharge "
                + "FROM OrderOptions";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader orderReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleResult);
                if (orderReader.Read())
                {
                    OrderOptions o = new OrderOptions();
                    o.SalesTaxRate = (decimal)orderReader["SalesTaxRate"];
                    o.FirstBookShipCharge = (decimal)orderReader["FirstBookShipCharge"];
                    o.AdditionalBookShipCharge = (decimal)orderReader["AdditionalBookShipCharge"];
                    return o;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
