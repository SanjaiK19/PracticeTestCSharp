using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    class Registration
    {
        public string Name;
        public static int Count = 0;
        public Registration(string name)
        {
            Name = name;
            Count++;
        }
    }
    public class TrainingBatchRegistration
    {
        public static void Main()
        {
            Registration r1 = new Registration("Aadhi");
            Registration r2 = new Registration("Kevin");
            Registration r3 = new Registration("Varrun");

            Registration r4 = r1;
            r4.Name = "Kabilan";

            Console.WriteLine(r1.Name);
            Console.WriteLine(r4.Name);
            Console.WriteLine(Registration.Count);
        }
    }
}
