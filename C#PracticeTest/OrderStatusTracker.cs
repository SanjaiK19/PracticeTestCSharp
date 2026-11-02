using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    enum OrderStatus
    {
        Pending,
        Packed,
        Shipped,
        Delivered,
        Cancelled
    }
    public class OrderStatusTracker
    {
        public static void Main()
        {
            OrderStatus status = OrderStatus.Pending;
            Console.WriteLine("Current Status : "+ status);
            string input = Console.ReadLine();

            OrderStatus next;
            if(!Enum.TryParse(input,true, out next) || !Enum.IsDefined(typeof(OrderStatus),next))
            {
                Console.WriteLine("Invalid Status");
                return;
            }

            bool valid = (status == OrderStatus.Pending && (next == OrderStatus.Packed || next == OrderStatus.Cancelled)) || 
                (status == OrderStatus.Packed && (next == OrderStatus.Shipped || next == OrderStatus.Cancelled)) ||
                (status == OrderStatus.Shipped && next == OrderStatus.Delivered);
            if(valid) Console.WriteLine("New Status : "+next);
            else Console.WriteLine("Invalid status transition");

        }
    }
}
