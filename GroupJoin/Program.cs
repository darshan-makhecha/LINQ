using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupJoin
{
    class Program
    {
        static void Main()
        {
            var empByDept = from d in Department.GetAllDepartments()
                            join e in Employee.GetAllEmployees()
                            on d.ID equals e.DepartmentID
                            into egroup
                            select new
                            {
                                 Department = d,
                                Employee = egroup
                            };
            /*var empByDept =  Department.GetAllDepartments()
                                         .GroupJoin(Employee.GetAllEmployees(),
                                         d => d.ID,
                                         e => e.DepartmentID,
                                         (Department, Employee) => new { 
                                            Department = Department,
                                            employees = Employee
                                         });
            */
            foreach (var department in empByDept) {
                Console.WriteLine(department.Department.Name);
                foreach (var employee in department.Employee) {
                    Console.WriteLine(" " + employee.Name);

                }Console.WriteLine();
                 
            }
            Console.Read();
                                             
        }
    }
}
