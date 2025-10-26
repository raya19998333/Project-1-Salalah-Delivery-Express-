using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1____Salalah_Delivery_Express_.Moduls
{
    class Delivery
    {
        
            public Customer Customer { get; set; }
            public Driver Driver { get; set; }
            public DeliveryStatus Status { get; set; }

        public Delivery(Customer customer, Driver driver)
        {
            Customer = customer;
            Driver = driver;
            Status = DeliveryStatus.Pending;
        }

            public void UpdateStatus(DeliveryStatus status)
            {
                Status = status;
            }

            public void PrintDetails()
            {
                Customer.PrintInfo();
                Console.WriteLine($"Driver: {Driver.Name}, Phone: {Driver.Phone}");
                Console.WriteLine($"Status: {Status}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }

