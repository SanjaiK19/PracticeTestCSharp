using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class Customer
    {
        public string name { get; set; }
        public int id { get; set; }
        public string city { get; set; }
    }
    public class DuplicateCustomerCheck
    {
        public static void Main()
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();


            customer1.name = "Aadhi";
            customer1.city = "Chennai";
            customer1.id = 1;

            customer2.name = "Aadhi";
            customer2.city = "Chennai";
            customer2.id = 1;

            customer3 = customer1;

            Console.WriteLine(customer2.name == customer1.name);
            Console.WriteLine(customer1.name.Equals(customer2.name));

            Console.WriteLine(customer1 == customer3);
            Console.WriteLine(customer1.Equals(customer3));

            string str1 = "Cust1";
            string str2 = "Cust1";

            object obj1 = str1;
            object obj2 = str2;

            Console.WriteLine(str1 == str2);
            Console.WriteLine(obj1 == obj2);
            Console.WriteLine(obj1.Equals(obj2));
        }
    }
}
