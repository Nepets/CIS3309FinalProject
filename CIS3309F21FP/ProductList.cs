using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309F21FP
{
    class ProductList : List<Product>
    {
        public override string ToString()
        {
            string output = "";
            foreach (Product p in this)
            {
                output += p.ToString();
                output += Environment.NewLine;
            }
            return output;

        }
    }
}
