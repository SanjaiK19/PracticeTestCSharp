using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class InvoiceValueExchange
    {
        public static void Main(string[] args)
        {
            int invoiceNumber = 1001;
            decimal total = 2499.50m;
            bool paidStatus = true;

            object num = invoiceNumber;
            object tot = total;
            object Ispaid = paidStatus;

            int unboxInvoice = (int)num;
            decimal unboxTotal = (decimal)tot;
            bool unboxPayment = (bool)Ispaid;

            Console.WriteLine($"Invoice Number : {unboxInvoice}");
            Console.WriteLine($"Total : {unboxTotal}");
            Console.WriteLine($"Paid status : {unboxPayment}");


            try
            {
                long unboxError = (long)Ispaid;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid conversion");
            }
        }
    }
}
