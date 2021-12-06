using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309F21FP
{
    class InvoiceLineItem
    {
        public InvoiceLineItem() { }
        public InvoiceLineItem( string productCode, decimal price, int quantity,decimal itemTotal) { 
            this.ProductCode = productCode;
            this.Price = price;
            this.Quantity = quantity;
            this.ItemTotal = itemTotal;
        }
        public int InvoiceID { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal ItemTotal { get; set; }

        public override string ToString() => ProductCode + " " + Price.ToString() + " x " + Quantity.ToString() + " = " + ItemTotal.ToString();




    }
}
