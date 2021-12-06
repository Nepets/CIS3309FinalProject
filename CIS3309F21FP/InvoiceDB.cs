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
    class InvoiceDB
    {
        public static int InsertInvoiceLineItem(int invoiceID, string productCode, decimal unitPrice, int quantity, decimal itemTotal)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string query = "INSERT " +
                "InvoiceLineItems (InvoiceID, ProductCode, UnitPrice, Quantity, ItemTotal) " +
                "VALUES (@InvoiceID, @ProductCode, @UnitPrice, @Quantity, @ItemTotal)";
            SqlCommand insertCommand = new SqlCommand(query, connection);
            insertCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
            insertCommand.Parameters.AddWithValue("@ProductCode", productCode);
            insertCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
            insertCommand.Parameters.AddWithValue("@Quantity", quantity);
            insertCommand.Parameters.AddWithValue("@ItemTotal", itemTotal);
            return MMABooksDB.ExecuteNonQuery(insertCommand, connection);
        }
        public static int InsertInvoiceLineItem(int invoiceID,InvoiceLineItem item)
        {
            return InsertInvoiceLineItem(invoiceID, item.ProductCode, item.Price, item.Quantity, item.ItemTotal);
        }


        public static int GetMaxID()
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement = "SELECT MAX(InvoiceID) " +
                "FROM Invoices;";

            try
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int maxID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return maxID;

            }
            catch (SqlException)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
        public static int InsertInvoice(Invoice invoice)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            invoice.CalcAll();
            string selectStatement = "INSERT Invoices (CustomerID, InvoiceDate, ProductTotal, SalesTax, Shipping, InvoiceTotal) VALUES (@CustomerID, @InvoiceDate, @ProductTotal, @SalesTax, @Shipping, @InvoiceTotal)";
            SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@CustomerID", invoice.CustomerID);
            command.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate);
            command.Parameters.AddWithValue("@ProductTotal", invoice.ProductTotal);
            command.Parameters.AddWithValue("@SalesTax", invoice.SalesTax);
            command.Parameters.AddWithValue("@Shipping", invoice.Shipping);
            command.Parameters.AddWithValue("@InvoiceTotal", invoice.InvoiceTotal);
            int result = MMABooksDB.ExecuteNonQuery(command, connection);
            bool error = false;
            if (result != -1)
            {
                int invoiceID = GetMaxID();
                foreach (InvoiceLineItem li in invoice.InvoiceLineItems)
                {
                    int result2 = InsertInvoiceLineItem(invoiceID, li);
                    if (result2 == -1) { error = true; }
                }
            }
            return (result == -1 || error) ? -1 : result;
        }

    }
}
