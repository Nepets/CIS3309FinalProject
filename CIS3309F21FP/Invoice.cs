using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309F21FP
{
    class Invoice
    {


        List<InvoiceLineItem> invoiceLineItems;
        OrderOptions oo;
        DateTime invoiceDate;

        public int InvoiceID {get;set;}
        public int CustomerID {get;set;}
        public string InvoiceDate
        {
            get { return invoiceDate.ToShortDateString(); }
            set { invoiceDate = DateTime.Parse(value); }
        }
        public decimal ProductTotal {get;set;}
        public decimal SalesTax {get;set;}
        public decimal Shipping {get;set;}
        public decimal InvoiceTotal {get;set;}
        public List<InvoiceLineItem> InvoiceLineItems
        {
            get { return invoiceLineItems; }
        }
        public InvoiceLineItem this[int i] => invoiceLineItems[i];


        public  void SetDate() {
            this.invoiceDate = DateTime.Now;
        }
        public Invoice() {
            SetDate();
            this.oo = OrderOptionsDB.GetOrderOptions();
            this.invoiceLineItems = new List<InvoiceLineItem>();
        }

        public Invoice(int invoiceId, int CustomerId, DateTime invoiceDate, decimal productTotal, decimal salesTax, decimal shipping, decimal invoiceTotal)
        {
            SetDate();
            this.oo = OrderOptionsDB.GetOrderOptions();
            this.invoiceLineItems = new List<InvoiceLineItem>();
            this.InvoiceID = invoiceId;
            this.CustomerID = CustomerId;
            this.invoiceDate = invoiceDate;
            this.ProductTotal = productTotal;
            this.SalesTax = salesTax;
            this.Shipping = shipping;
            this.InvoiceTotal = invoiceTotal;
        }

        public void CalcProductTotal() {
            decimal total = 0;
            foreach (InvoiceLineItem item in this.invoiceLineItems) {
                total += item.Price;
            }

             this.ProductTotal = total;
        }
        public void CalcShipping()
        {
            decimal shipping = 0;
            if (invoiceLineItems.Count > 0)
            {
                shipping = oo.FirstBookShipCharge + (oo.AdditionalBookShipCharge * (invoiceLineItems[0].Quantity - 1));
                for (int i = 1; i < invoiceLineItems.Count; i++)
                {
                    shipping += oo.AdditionalBookShipCharge * invoiceLineItems[i].Quantity;
                }

            }
            this.Shipping = shipping;
        }
        public void CalcSalesTax()
        {
            this.SalesTax = oo.SalesTaxRate * (this.ProductTotal + this.Shipping);
        }
        public void CalcInvoiceTotal()
        {
            this.InvoiceTotal = this.ProductTotal + this.Shipping + this.SalesTax;
        }

        public void CalcAll()
        {
            CalcProductTotal();
            CalcShipping();
            CalcSalesTax();
            CalcInvoiceTotal();
        }

        public void UpdateInvoiceLineItem(int i, decimal price, int quantity)
        {
            invoiceLineItems[i].Price = price;
            invoiceLineItems[i].Quantity = quantity;
            CalcAll();
        }

        public void Add(InvoiceLineItem item) { 
            invoiceLineItems.Add(item);
            CalcAll();
        }
        public void RemoveAt(int i) {
            invoiceLineItems.RemoveAt(i);
            CalcAll();
        
        }

        public void Clear() {
            invoiceLineItems.Clear();
            CalcAll();
        }


        public override string ToString() => this.InvoiceID + " " + this.CustomerID + " " + this.InvoiceDate + " " + this.ProductTotal + " " + this.SalesTax + " " + this.Shipping + " " + this.InvoiceTotal;



        
    }
}
