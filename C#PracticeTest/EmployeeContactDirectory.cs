using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string Name { get; set; }    
        public string Email { get; set; }   

    }

    public class Manager : Employee
    {
        public string Department { get; set; }
        public int TeamSize { get; set; }  
    }
    public class EmployeeContactDirectory
    {
        public static void Main()
        {
            
            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee();
            //Manager manager1 = new Manager();
            //Manager manager2 = new Manager();

            List<Employee> employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, Name = "Aadhi", Email = "aadhi@gmail.com" },
                new Employee { EmployeeId = 2, Name = "Kabilan", Email = "kabilan@example.com" },
                new Manager { EmployeeId = 3, Name = "Kevin", Email = "kevin@example.com", Department = "HR", TeamSize = 5 },
                new Manager { EmployeeId = 4, Name = "Pranash", Email = "pranesh@example.com", Department = "IT", TeamSize = 10 }
            };
            foreach (Employee employee in employees)
            {
                if(employee is Manager manager)
                {
                    if (manager.TeamSize > 1)
                    {
                        Console.WriteLine($"Manager: {manager.Name}, Email: {manager.Email}, Department: {manager.Department}, Team Size: {manager.TeamSize}");
                    }
                    else
                    {
                        Console.WriteLine($"Manager: {manager.Name}, Email: {manager.Email}, Department: {manager.Department}, Team Size: Invalid team size,enter valid size");
                    }
                }
                else
                {
                    Console.WriteLine($"Employee: {employee.Name}, Email: {employee.Email}");
                } 
                Console.ReadLine();
            }
        }
    }
}
