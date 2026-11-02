using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public abstract class InsurancePolicy
    {
        int PolicyNumber;
        string Name;
        public abstract double PremiumCalculation();
    }
    public class HealthPolicy : InsurancePolicy
    {
        public int PolicyNumber;
        public string Name;
        public double BasePremium;
        public double healthPermium;
        public override double PremiumCalculation()
        {
            if(BasePremium <= 0)
            {
                Console.WriteLine("Provide valid amount");
                return 0;
            }
            healthPermium = BasePremium + 500;
            return healthPermium;
        }
    }
    public class MotorPolicy : InsurancePolicy
    {
        public int PolicyNumber;
        public string Name;
        public double MotorPremium;
        public double VehicleValue;
        public override double PremiumCalculation()
        {
            if (VehicleValue<=0)
            {
                Console.WriteLine("Provide valid amount");
                return 0;
            }
            MotorPremium = VehicleValue * 3/100;
            return MotorPremium;
        }
    }

    public class InsurancePolicyFamily
    {
        public static void Main()
        {
            List<InsurancePolicy> PolicyList = new List<InsurancePolicy>();
            HealthPolicy healthPolicy = new HealthPolicy();
            MotorPolicy motorPolicy = new MotorPolicy();

            healthPolicy.Name = "Aadhi";
            healthPolicy.PolicyNumber = 120;
            healthPolicy.BasePremium = 1000;
            //healthPolicy.PremiumCalculation();

            motorPolicy.Name = "Kabilan";
            motorPolicy.PolicyNumber = 100;
            motorPolicy.VehicleValue = 225000;
            //motorPolicy.PremiumCalculation();


            PolicyList.Add(healthPolicy);
            PolicyList.Add(motorPolicy);

            foreach (InsurancePolicy policy in PolicyList)
            {
                if (policy is HealthPolicy)
                {
                    HealthPolicy health = (HealthPolicy)policy;
                    Console.WriteLine($"Healthcare policy premium summary:\nName :{health.Name}\nPolicy number : {health.PolicyNumber}\nPremium amount : {policy.PremiumCalculation()}");
                }
                else if (policy is MotorPolicy)
                {
                    MotorPolicy motor = (MotorPolicy)policy;
                    Console.WriteLine($"MotorCare policy premium summary:\nName :{motor.Name}\nPolicy number : {motor.PolicyNumber}\nVehical Value : {motor.VehicleValue}\nPremium amount : {policy.PremiumCalculation()}");
                }
            }
            healthPolicy.Name = "Aadhi";
            healthPolicy.PolicyNumber = 120;
            healthPolicy.BasePremium = 0;
            healthPolicy.PremiumCalculation();

        }
    }
}
