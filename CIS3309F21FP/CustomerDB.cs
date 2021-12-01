using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CIS3309F21FP
{
    class CustomerDB
    {
        public static Customer GetCustomer(int customerID)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement
                = "SELECT CustomerID, Name, Address, City, State, ZipCode "
                + "FROM Customers "
                + "WHERE CustomerID = @CustomerID";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustomerID", customerID);

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)custReader["CustomerID"];
                    customer.Name = custReader["Name"].ToString();
                    customer.Address = custReader["Address"].ToString();
                    customer.City = custReader["City"].ToString();
                    customer.State = custReader["State"].ToString();
                    customer.ZipCode = custReader["ZipCode"].ToString();
                    return customer;
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
        public static int InsertCustomer(string name, string address,string city, string state, string zipCode) {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertStatement =
                "INSERT Customers " +
                "(Name, Address, City, State, ZipCode) " +
                "VALUES (@Name, @Address, @City, @State, @ZipCode)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@Name", name);
            insertCommand.Parameters.AddWithValue(
                "@Address", address);
            insertCommand.Parameters.AddWithValue(
                "@City", city);
            insertCommand.Parameters.AddWithValue(
                "@State",state);
            insertCommand.Parameters.AddWithValue(
                "@ZipCode", zipCode);
            return MMABooksDB.ExecuteNonQuery(insertCommand, connection);
        }
        public static int InsertCustomer(Customer customer) {
            return InsertCustomer(customer.Name, customer.Address,customer.City, customer.State, customer.ZipCode);
        }
        public static int GetMaxID() {
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement = "SELECT  MAX(CustomerID) "
                 + "FROM Customers ";
           
            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int maxID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return maxID;

            }
            catch (SqlException )
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
