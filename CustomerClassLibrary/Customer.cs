using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClassLibrary
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set;}
        public string City { get; set; }
        public int Age { get; set; }
        public double Phone { get; set; }
        public double Pincode { get; set; }
    }

    public class ListOfCustomers
    {

        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                CustomerID = 1,
                CustomerName = "Asavari",
                City = "Mumbai",
                Age = 20,
                Phone = 7738905022,
                Pincode = 400068
            };

            Customer customer2 = new Customer()
            {
                CustomerID = 2,
                CustomerName = "Shama",
                City = "Banglore",
                Age = 20,
                Phone = 9969549915,
                Pincode = 400067
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);

            foreach (Customer c in customers)
            {
                Console.WriteLine("CustomerID={0}, CustomerName={1}, City={2}, Age={3}, Phone={4}, Pincode={5}", c.CustomerID, c.CustomerName, c.City, c.Age, c.Phone, c.Pincode);
            }

        }


    }
}
