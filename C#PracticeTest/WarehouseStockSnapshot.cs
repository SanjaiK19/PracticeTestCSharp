using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class WarehouseStockSnapshot
    {
        public static void PrintLable(object value,string variable)
        {
           Console.WriteLine($"Variable : {variable}, Value : {value}, Type : {value.GetType().Name}");
        }
        public static void Main(string[] args)
        {
            var itemCode = 101;
            var quantity = 2;
            var unitPrice = 90.0;
            var quantityList = new int[] {2,4,1,5 };

            double inventoryValue = 0;
            foreach (var quan in quantityList) inventoryValue += unitPrice * quan;
            Console.WriteLine($"Inventory value : {inventoryValue}");
            PrintLable(itemCode, "itemCode");
            PrintLable(quantity, "quantity");
            PrintLable(unitPrice, "unitPrice");
            Console.WriteLine($"Variable : quantityList, Value: {String.Join(",",quantityList)} , Type : {quantityList.GetType().Name}");

            //itemCode = "Hello" // Try to assign string but throws error
        }
    }
}
