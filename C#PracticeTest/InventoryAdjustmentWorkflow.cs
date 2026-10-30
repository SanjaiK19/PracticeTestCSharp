using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class InventoryAdjustmentWorkflow
    {
        public static void UpdateStockQuantity(ref int stock,int value)
        {
            if(stock + value >= 0)
            {
                stock += value;
                Console.WriteLine($"Stock update success\nCurrent stock : {stock}");
            }
            else
            {
                Console.WriteLine("Stock update failed because stock goes negative");
            }
        }

        public static bool Validate(int stockAfterUpdate,int stockBeforeUpdate)
        {
            if (stockAfterUpdate != stockBeforeUpdate)
            {
                Console.WriteLine("Stock update validated");
                return true;
            }
            else
            {
                Console.WriteLine("Stock update failed");
                return false;
            }
        }
        public static void TestAdjustment(int stockAfter,int stockBefore)
        {
            if (stockAfter > stockBefore) Console.WriteLine("Positive Adjustment");
            else if (stockAfter < stockBefore) Console.WriteLine("Negative Adjustment");
            else Console.WriteLine("No impact in stocks");
        }
        public static void DisplayStock(int stock,string str)
        {
            Console.WriteLine($"Stock {str} update : {stock}");
        }

        public static void Main()
        {
            int stock = 100;
            var beforeUpdate = stock;

            DisplayStock(stock, "Before");
            UpdateStockQuantity(ref stock,-10);
            Validate(stock,beforeUpdate);
            TestAdjustment(stock,beforeUpdate);
            DisplayStock(stock, "After");

            beforeUpdate = stock;
            string change = Console.ReadLine();
            int value;
            if (!int.TryParse(change,out value))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                DisplayStock(stock, "Before");
                UpdateStockQuantity(ref stock, value);
                Validate(stock, beforeUpdate);
                TestAdjustment(stock,value);
                DisplayStock(stock, "After");
            }


        }
    }
}
