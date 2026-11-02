using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll;

namespace Payroll
{
    public class Core
    {
        public class Employee
        {
            private void PrivateMethod() { Console.WriteLine("Private method called"); }
            protected void ProtectedMethod() { Console.WriteLine("Protected method called"); }
            internal void InternalMethod() { Console.WriteLine("Internal method called"); }
            protected internal void ProtectedInternalMethod() { Console.WriteLine("Protected internal method called"); }
            public void PublicMethod() { Console.WriteLine("Public method called"); }
        }
        public class DerivedEmployee : Employee
        {
            public void AccessMethods()
            {
                PublicMethod(); // Allowed: Public access from any assembly
                ProtectedMethod(); // Allowed: Protected access within the same assembly (Payroll.Core)
                InternalMethod(); // Allowed: Internal access within the same assembly (Payroll.Core)
                ProtectedInternalMethod(); // Allowed: Protected internal access within the same assembly (Payroll.Core)
                // PrivateMethod(); // Not allowed: Private access from a different class
            }
        }
    }
    public class PayrollAssemblyBoundaries
    {
        public static void Main()
        {
            Payroll.Core.Employee emp = new Payroll.Core.Employee();
            emp.PublicMethod(); // Allowed: Public access from any assembly
            // emp.ProtectedMethod(); // Not allowed: Protected access from a different assembly
            // emp.InternalMethod(); // Not allowed: Internal access from a different assembly
            // emp.ProtectedInternalMethod(); // Not allowed: Protected internal access from a different assembly
            Payroll.Core.DerivedEmployee derivedEmp = new Payroll.Core.DerivedEmployee();
            derivedEmp.PublicMethod(); // Allowed: Public access from any assembly
            //derivedEmp.ProtectedMethod(); // Allowed: Protected access within the same assembly (Payroll.Core)
            // derivedEmp.InternalMethod(); // Not allowed: Internal access from a different assembly
            // derivedEmp.ProtectedInternalMethod(); // Not allowed: Protected internal access from a different assembly
            Console.WriteLine("Access demonstration completed.");
        }
    }
}
