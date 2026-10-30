using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    internal class EmployeeOnboardingDetails
    {
        public static double CalculateBonus(double?[] bonus,ref int totalNonNullBonus)
        {
            double tot = 0;
            foreach (var bon in bonus)
            {
                if (bon.HasValue)
                { 
                    tot += bon.Value;
                    totalNonNullBonus += 1;
                }
            }
            return tot;
        }
        public static int[] BonousRecord(double?[] bonus)
        {
            int[] record = new int[3];
            foreach (var bon in bonus)
            {
                if (bon.HasValue)
                {
                    if (bon == 0) record[0] += 1;
                    else if (bon > 0) record[1] += 1;
                }
                else
                {
                    record[2] += 1;
                }
            }
            return record;
        }

        public static void UpdataMissingAge(ref int? item,dynamic value)
        {
            item = value;
        }
        public static void Main(string[] args)
        {
            int? age = null;
            double?[] bonus = {1000,null,900};
            DateTime? joiningDate = null;

            int totalNonNullBonus = 0;
            double totalBonus = CalculateBonus(bonus,ref totalNonNullBonus);
            int[] record = BonousRecord(bonus);

            if (!age.HasValue)
            {
                UpdataMissingAge(ref age,19);
            }
            if(!joiningDate.HasValue)
            {
                joiningDate = DateTime.Today;
            }
        }
    }
}
