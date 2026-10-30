using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class DailySalesReview
    {
        public static void Main(string[] args)
        {
            int[] dailySales = { 12500, 9800, 15400, 8700, 19100, 16800, 11200 };

            int salesTarget = Convert.ToInt32(Console.ReadLine());
            int days = dailySales.Length;
            int TotalSales = 0;
            int HighestSales = 0;
            int LowestSales = Int32.MaxValue;

            for(int itr = 0;itr < days; itr++)
            {
                TotalSales += dailySales[itr];
                if (HighestSales < dailySales[itr]) HighestSales = dailySales[itr];
                if(LowestSales > dailySales[itr]) LowestSales = dailySales[itr];
                if (dailySales[itr] < salesTarget) Console.WriteLine($"Day {itr+1} doesn't meet the target sales");

            }
            double averageSales = TotalSales/days;
            Console.WriteLine($"Total sales : {TotalSales}");
            Console.WriteLine($"Highest sales : {HighestSales}");
            Console.WriteLine($"Lowest sales : {LowestSales}");
            Console.WriteLine($"Average sales : {averageSales}");
            for(int itr = 0;itr < days; itr++)
            {
                if (dailySales[itr] == HighestSales)
                {
                    Console.WriteLine($"Highest sales on day {itr+1}");
                }
            }
        }
    }
}
