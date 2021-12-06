using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309F21FP
{
    class OrderOptions
    {
        public OrderOptions() { }

        public OrderOptions(decimal salesTaxRate, decimal firstBookShipCharge, decimal additionalBookShipCharge) { 
            this.SalesTaxRate = salesTaxRate;
            this.FirstBookShipCharge = firstBookShipCharge;
            this.AdditionalBookShipCharge = additionalBookShipCharge;
        
        }
        public decimal SalesTaxRate { get; set; }
        public decimal FirstBookShipCharge { get; set; }
        public decimal AdditionalBookShipCharge { get; set; }

        public override string ToString() => this.SalesTaxRate.ToString() + " "+this.FirstBookShipCharge+" "+ this.AdditionalBookShipCharge;
        
           
        
    }
}
