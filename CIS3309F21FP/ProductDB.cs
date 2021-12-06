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
    class ProductDB
    {
        public static Product GetProduct(string productCode)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement
                = "SELECT ProductCode, Description, UnitPrice, OnHandQuantity "
                + "FROM Products "
                + "WHERE ProductCode = @ProductCode";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductCode", productCode);

            try
            {
                connection.Open();
                SqlDataReader productReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleResult);
                if (productReader.Read())
                {
                    Product p = new Product();
                    p.Code = productReader["ProductCode"].ToString();
                    p.Description = productReader["Description"].ToString();
                    p.Price = (decimal)productReader["UnitPrice"];
                    p.OnHandQuantity = (int)productReader["OnHandQuantity"];
                    return p;
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
        public static ProductList GetALlProducts() {
            ProductList products = new ProductList();
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement
               = "SELECT ProductCode, Description, UnitPrice, OnHandQuantity "
               + "FROM Products";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader productReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                while (productReader.Read())
                {

                        Product p = new Product(
                        productReader["ProductCode"].ToString(),
                        productReader["Description"].ToString(),
                        (decimal)productReader["UnitPrice"],
                        (int)productReader["OnHandQuantity"]);
                        products.Add(p);

                }
                return products;

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

        public static int UpdateProduct(string code, string description, decimal price, int onHandQuantity)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "ProductCode = @ProductCode, " +
                "Description = @Description, " +
                "UnitPrice = @UnitPrice " +
                "OnHandQuantity = @OnHandQuantity " +
                "WHERE ProductCode = @ProductCode ";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@ProductCode", code);
            updateCommand.Parameters.AddWithValue("Description", description);
            updateCommand.Parameters.AddWithValue("@UnitPrice", price);
            updateCommand.Parameters.AddWithValue("@OnHandQuantity", onHandQuantity);


            return MMABooksDB.ExecuteNonQuery(updateCommand, connection);
        }
        public static int UpdateProduct(Product p) { 
            return UpdateProduct(p.Code, p.Description, p.Price, p.OnHandQuantity);
        }
        public static int UpdateOnHandQuantity(string productCode, int amount) {
            SqlConnection connection = MMABooksDB.GetConnection();
            Product p =GetProduct(productCode);
            if (amount > 0) {
                p.OnHandQuantity += amount;
            }
            else { 
                p.OnHandQuantity -= amount;
            }
            string updateStatement =
                "UPDATE Products SET " +
                "OnHandQuantity = @OnHandQuantity " +
                "WHERE ProductCode = @ProductCode ";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@OnHandQuantity",p.OnHandQuantity );
            updateCommand.Parameters.AddWithValue("@ProductCode", p.Code);

            return MMABooksDB.ExecuteNonQuery(updateCommand, connection);

        }
    }
}
