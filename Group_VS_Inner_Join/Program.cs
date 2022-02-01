using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_VS_Inner_Join
{
    class Program
    {
        public static void Main()
        {
            // group join

            Console.WriteLine();
            Console.WriteLine("Group join give below");
            Console.WriteLine();

            var result = from d in Department.GetAllDepartments()
                         join e in Employee.GetAllEmployees()
                         on d.ID equals e.DepartmentID into eGroup
                         select new
                         {
                             Department = d,
                             Employees = eGroup
                         };
            foreach (var department in result)
            {
                Console.WriteLine(department.Department.Name);
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Inner join give below");
            Console.WriteLine();
            /*
                        GroupJoin                                               InnerJoin
                      --------------------------------     ----------------------------------------------
                =>          Into keyword add must                          
                =>          Hierarchical Result set             Flat result set
                =>          Nonmethcing data print              Matching data print
                =>          Groupjoin extension                 Join extension 
          
           */
            // inner join
            var r1 = Employee.GetAllEmployees()
                                     .Join(Department.GetAllDepartments(),
                                      e => e.DepartmentID,
                                      d => d.ID, (employee, department) => new
                                      {
                                          e = employee,
                                          d = department
                                      });
            foreach (var employee in r1)
            {
                Console.WriteLine(employee.e.Name + "\t" + employee.d.Name);

            }














            Console.Read();
        }
    }
}
