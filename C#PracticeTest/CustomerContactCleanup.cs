using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class CustomerContactCleanup
    {
        public static void Main()
        {
            string name = "  Aadhi  Kabil";
            string phoneNumber = "900-111-2222";
            string code = "CoD1";

            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid Name");
            }
            else
            {
                name = string.Join(" ", name.Trim().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries));
                Console.WriteLine("Name : "+name);
            }
            Console.WriteLine("Phone : "+phoneNumber.Replace("-",""));
            Console.WriteLine("Code : "+ code.ToUpper());

        }
    }
}
