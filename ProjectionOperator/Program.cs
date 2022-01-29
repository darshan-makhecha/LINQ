using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectionOperator
{
    class Program
    {
        static void Main()
        {
            IEnumerable<int> result = Employee.GetAllEmployees().Select(emp => emp.EmployeeID);

            foreach (int id in result)
            {
                // it return id 
                Console.WriteLine(id);
            }
            Console.WriteLine();
            Console.WriteLine("==========================");
            var nm = Employee.GetAllEmployees().Select(emp => emp.FirstName + " " + emp.LastName + " And Gender is :" + emp.Gender);
            foreach (string name in nm)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("==========================");

            var res = Employee.GetAllEmployees().Select(emp => new { FirstName = emp.FirstName, Gender = emp.Gender });
            foreach (var v in res)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.Read();


            var a = Employee.GetAllEmployees().Select(emp => emp.FirstName + " " + emp.LastName + " - Annual Salary is : " + emp.AnnualSalary + " And Monthly Salary is : " + emp.AnnualSalary / 12);
            foreach (var d in a)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.Read();




        }
    }
}
