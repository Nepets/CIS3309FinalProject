using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309F21FP
{
	class Product
	{
		public Product() { }

		public Product(string code, string description, decimal price, int onHandQuantity)
		{
			this.Code = code;
			this.Description = description;
			this.Price = price;
			this.OnHandQuantity = onHandQuantity;
		}

		public string Code
		{
			get; set;
		}

		public string Description
		{
			get; set;
		}

		public decimal Price
		{
			get; set;
		}
		public int OnHandQuantity {
			get; set;
		}
		public  override string ToString() => this.Code + "|" + this.Description + "|$" + string.Format("{0:#.00}",this.Price) + "|" + this.OnHandQuantity; 
	}
	
}
