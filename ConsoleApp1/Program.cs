using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            EmployeeDBContext context = new EmployeeDBContext();
            // here return only IT and HR department name 
            IEnumerable<Department> departments = context.Departments.Where(x => x.Name == "IT" || x.Name == "HR");

                foreach (Department dept in departments) 
                {
                    Console.WriteLine("Department = " + dept.Name);
                    // emp check if emp male then print name with department name
                    IEnumerable<Employee> employees = dept.Employees.Where(x => x.Gender == "m");   
                    foreach (Employee employee in employees) 
                    {
                        Console.WriteLine("\t Employee Name = " + employee.FirstName + " " + employee.LastName);
                     }
                    Console.WriteLine();
                }
            Console.Read();
        }
    }
}
