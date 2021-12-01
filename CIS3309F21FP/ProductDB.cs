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
                    if(productReader.Read())
                    {
                        Product p = new Product(
                        productReader["ProductCode"].ToString(),
                        productReader["Description"].ToString(),
                        (decimal)productReader["UnitPrice"],
                        (int)productReader["OnHandQuantity"]);
                        products.Add(p);
                    }
                    else
                    {
                        return null;
                    }

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
        public static int UpdateProduct(Product oldProduct,
                Product newProduct)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "ProductCode = @NewProductCode, " +
                "Description = @NewDescription, " +
                "UnitPrice = @NewUnitPrice " +
                "OnHandQuantity = @NewOnHandQuantity "+
                "WHERE ProductCode = @OldProductCode " +
                "AND Description = @OldDescription " +
                "AND UnitPrice = @OldUnitPrice "+
                "AND OnHandQuantity = @OldOnHandQuantity ";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewProductCode", newProduct.Code);
            updateCommand.Parameters.AddWithValue("@NewDescription", newProduct.Description);
            updateCommand.Parameters.AddWithValue("@NewUnitPrice", newProduct.Price);
            updateCommand.Parameters.AddWithValue("@NewOnHandQuantity", newProduct.OnHandQuantity);
            updateCommand.Parameters.AddWithValue("@OldProductCode", oldProduct.Code);
            updateCommand.Parameters.AddWithValue("@OldDescription", oldProduct.Description);
            updateCommand.Parameters.AddWithValue("@OldUnitPrice", oldProduct.Price);
            updateCommand.Parameters.AddWithValue("@OldOnHandQuantity", oldProduct.OnHandQuantity);

            return MMABooksDB.ExecuteNonQuery(updateCommand, connection);
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
