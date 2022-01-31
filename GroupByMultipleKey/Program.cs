using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByMultipleKey
{
    class Program
    {
        static void Main()
        {
            var empGroups = Employee.GetAllEmployees()
              .GroupBy(x => new { x.Department, x.Gender })
              .OrderBy(a => a.Key.Department).ThenBy(g => g.Key.Gender)
              .Select(g => new {
                  Dept = g.Key.Department,
                  Gender = g.Key.Gender,
                  Employees = g.OrderBy(a => a.Name)
                });
            /*
             * from employee in employee.GetAllEmployee();
             * group employee by new {employee.department, employee.gender} into eGroup
             * orderby eGroup.key.Department, egroup.key.Gender
             * select new{
             *  Dept = g.Key.Department,
                  Gender = g.Key.Gender,
                  Employees = g.OrderBy(a => a.Name)
             * };
             * 
             */
            Console.WriteLine();
            foreach (var group in empGroups)
            {
                Console.WriteLine("{0} department {1} employees count = {2}", group.Dept, group.Gender, group.Employees.Count());
                Console.WriteLine("---------------------");

                foreach (var emp in group.Employees)
                {
                    Console.WriteLine(emp.Name + "\t" + emp.Gender + " \t" + emp.Department + " \t");
                    Console.WriteLine();
                   
                }
            }
            Console.Read();

        }
    }
}
