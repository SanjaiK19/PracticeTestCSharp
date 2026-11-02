using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class MonthlyAttendenceExport
    {
        public static void Main()
        {
            Stopwatch watch = Stopwatch.StartNew();
            watch.Start();
            string str = "Addendence Report\n";
            for (int i = 0; i < 1000; i++) {
                str += $"Addendence {i}\n";
            }

            str += "Total 1000";
            watch.Stop();

            Console.WriteLine("String Time: " + watch.ElapsedMilliseconds);

            watch.Restart();
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine("Addendence Report\n");
            for (int i = 0; i < 1000; i++) { 
                strBuild.AppendLine($"Addendence {i}\n");
            }

            strBuild.Append("Total 1000");

            watch.Stop();   
            Console.WriteLine("StringBuilder time : "+ watch.ElapsedMilliseconds);
            Console.WriteLine($"Check content : {str == strBuild.ToString()}");
        }
    }
}
