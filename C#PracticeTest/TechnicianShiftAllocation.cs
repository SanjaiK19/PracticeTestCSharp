using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class TechnicianShiftAllocation
    {
        public static void Main(string[] args)
        {
            int[][] jobs =
            {
                new int[] { 45,60,30},
                new int[] {90 },
                new int[] { },
                new int[] {20,35,50,40}
            };

            FindTechnicians(jobs);
            AddDuration(2, 10,ref jobs);

        }

        public static void FindTechnicians(int[][] job)
        {
            for (int itr = 0; itr < 4; itr++)
            {
                int totalTime = 0;
                foreach (int time in job[itr])
                {
                    totalTime += time;
                }
                if (totalTime == 0)
                {
                    Console.WriteLine($"Technician {itr + 1} has zero job");
                }
                else if (totalTime > 120)
                {
                    Console.WriteLine($"Technician {itr + 1} has more than 120 mins of work");
                }
            }
        }

        public static void AddDuration(int technicianNo,int duration,ref int[][] jobs)
        {
            int len = jobs[technicianNo - 1].Length + 1;
            int[] change = new int[len];
            for (int itr = 0; itr < len - 1; itr++) change[itr] = jobs[technicianNo - 1][itr];
            change[len - 1] = duration;
            jobs[technicianNo - 1] = change;
        }
    }
}
