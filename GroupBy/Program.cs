using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy
{
    class Program
    {
        static void Main()
        {
            // create a group of department eg. IT and HR group in this Program
            // var employeeGroup =  Employee.GetAllEmployees().GroupBy(x => x.Department);
            var employeeGroup = from employee in Employee.GetAllEmployees()
                                group employee by employee.Department into eGroup
                                orderby eGroup.Key
                                select new
                                {
                                    key = eGroup.Key,
                                    Employees = eGroup.OrderBy(x =>x.Name)
                                };
            foreach (var i in employeeGroup) {
                //              i m find the people in department and male people also 
                Console.WriteLine("{0} = {1}", i.key, i.Employees.Count());
                // count(x => x.Gender =="Female")
                // like  Min(),max ,sum, avg also () use 
                Console.WriteLine("--------------");
                foreach (var employee in i.Employees) {
                    Console.WriteLine(employee.Name + "\t" + employee.Department);
                }
            }

            Console.Read();
        }
    }
}
