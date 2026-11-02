using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class OrderInputConversionDesk
    {
        public static void Main()
        {
            string[] text = {
                "12",
                "abc",
                null,
                "999999999999"
            };
            foreach (string value in text)
            {
                Console.WriteLine("\nInput : " + (value ?? null));
                //Parse
                try
                {
                    Console.WriteLine("Parse : " + int.Parse(value));
                }
                catch (Exception ex){
                    Console.WriteLine("Parse error : "+ ex.GetType().Name);
                }
                //Try parse

                int result;
                if (int.TryParse(value, out result)) {
                    Console.WriteLine("try parse : "+result);
                }
                else Console.WriteLine("Try parse failed");

                try
                {
                    Console.WriteLine("Convert : " + Convert.ToInt32(value));
                }
                catch (Exception ex) {
                    Console.WriteLine("Convert Error : "+ex.GetType().Name);
                }
            }

            string price = "250.50";
            decimal amount = decimal.Parse(price);
            Console.WriteLine($"\nPrice : {amount}");
        }
    }
}
