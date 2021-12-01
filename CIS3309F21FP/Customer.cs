using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309F21FP
{
    class Customer
    {
        public Customer() { }
        public Customer(int cutstomerID, string name, string address, string city, string state, string zipcode) { 
            this.CustomerID = cutstomerID;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipcode;
        }

        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string toString() => this.CustomerID + " " + this.Name + " " + this.Address + " " + this.City + " " + this.State + " " + this.ZipCode;
    }
}

