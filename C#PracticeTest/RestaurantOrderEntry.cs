using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    using System;
    using System.Collections.Generic;

    class Order
    {
        List<string> orderLines = new List<string>();
        double total = 0;

        void AddOrder(string item, int qty, double price, string instruction)
        {
            if (qty <= 0)
            {
                Console.WriteLine("Invalid Quantity");
                return;
            }

            if (item != "Burger" && item != "Pizza" && item != "Coffee")
            {
                Console.WriteLine("Unknown Item");
                return;
            }

            total += qty * price;

            if (instruction == "")
                orderLines.Add($"{item} x {qty}");
            else
                orderLines.Add($"{item} x {qty} ({instruction})");
        }
        public void AddItem(string item)
        {
            AddOrder(item, 1, GetPrice(item), "");
        }

        public void AddItem(string item, int qty)
        {
            AddOrder(item, qty, GetPrice(item), "");
        }
        public void AddItem(string item, int qty, string instruction)
        {
            AddOrder(item, qty, GetPrice(item), instruction);
        }

        double GetPrice(string item)
        {
            if (item == "Burger") return 120;
            if (item == "Pizza") return 250;
            if (item == "Coffee") return 80;
            return 0;
        }

        public void Display()
        {
            foreach (string line in orderLines)
                Console.WriteLine(line);

            Console.WriteLine("Total = " + total);
        }
    }

    public class RestaurantOrderEntry
    {
        static void Main()
        {
            Order order = new Order();

            order.AddItem("Burger");                    
            order.AddItem("Pizza", 2);                  
            order.AddItem("Coffee", 1, "No Sugar");     
            order.Display();
        }
    }
}
