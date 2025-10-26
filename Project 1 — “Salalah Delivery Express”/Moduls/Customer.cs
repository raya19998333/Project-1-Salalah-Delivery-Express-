using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1____Salalah_Delivery_Express_.Moduls
{
     class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Customer: {Name}, Address: {Address}");
        }
    }
}
