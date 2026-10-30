using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class BranchSalesMatrix
    {
        public static int CaluculateBranch(decimal[,] matrix,ref decimal[] branchTotal)
        {
            int branchHighest = 0;
            //decimal categoryTot = 0;
            for(int branch = 0; branch < 3; branch++)
            {
                decimal branchTot = 0;
                for(int category = 0; category < 4; category++)
                {
                    branchTot += matrix[branch, category];
                }
                branchTotal[branch] = branchTot;
            }
            for(int itr = 1; itr < 3; itr++)
            {
                if (branchTotal[branchHighest] < branchTotal[itr])
                    branchHighest = itr;
            }
            return branchHighest;
        }
        public static decimal[] CaluclateCategory(decimal[,] matrix)
        {
            decimal[] category = new decimal[4];
            for(int cat =  0; cat < 4; cat++)
            {
                decimal catTot = 0;
                for(int brh = 0;brh < 3; brh++)
                {
                    catTot += matrix[brh, cat];
                }
                category[cat] = catTot;
            }
            return category;
        }
        public static void displayArray(dynamic arr)
        {
            foreach(var itr in arr)
            {
                Console.WriteLine(itr);
            }
        }
        public static void Main(string[] args)
        {
            decimal[,] branchSales = {
            {12000, 9000, 5000, 7000 },
            {8000,11000,6000,9500 },
            {15000,7000,8500,4000 } };

            decimal[] branchTotal = new decimal[3];
            decimal[] categoryTotal = CaluclateCategory(branchSales);
            int highestSalesBranch = CaluculateBranch(branchSales, ref branchTotal);
            Console.WriteLine($"Branch with Highest sales : {highestSalesBranch + 1}");
            Console.WriteLine("Branch sales");
            displayArray(branchTotal);
            Console.WriteLine("Category sales");
            displayArray(categoryTotal);
        }
    }
}
