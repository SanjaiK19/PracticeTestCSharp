using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class DeliveryChargeCalculator
    {
        public static void CalculateCharge(double weight,double distance,bool express = false,bool insurance = false)
        {
            if(weight <= 0 ||  distance <= 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            double charge = 40 + (12 * weight) + (3 * distance);
            if (express) charge += 80;
            if (insurance) charge += 25;
            Console.WriteLine($"Delivery charge : {charge}");
        }

        public static void Main()
        {
            CalculateCharge(10, 8);
            CalculateCharge(11,11,true,true);
        }
    }
}
