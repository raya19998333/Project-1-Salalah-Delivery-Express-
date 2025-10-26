using Project_1____Salalah_Delivery_Express_.Moduls;
using Project_1____Salalah_Delivery_Express_.Moduls;
using Project_1____Salalah_Delivery_Express_.Moduls;
using Project_1____Salalah_Delivery_Express_.Moduls;
using Project_1____Salalah_Delivery_Express_.Moduls;

namespace Project_1____Salalah_Delivery_Express_
{
    internal class Program
    {
        static void Main(string[] args)
        {


          Customer  customer1 = new Customer("Ali", "Salalah Industrial Area");
            Customer customer2 = new Customer("Fatima", "Salalah City");

            Driver driver1 = new Driver("Raya", "92424321");
            Driver driver2 = new Driver("Ali", "87654321");

            Delivery delivery1 = new Delivery(customer1, driver1);
            Delivery delivery2 = new Delivery(customer2, driver2);
            Delivery delivery3 = new Delivery(customer1, driver1);

            delivery1.UpdateStatus(DeliveryStatus.OnTheWay);
            delivery2.UpdateStatus(DeliveryStatus.Delivered);

            delivery1.PrintDetails();
            delivery2.PrintDetails();
            delivery3.PrintDetails();

            driver1.PrintDeliveries();
        }
    }
}
