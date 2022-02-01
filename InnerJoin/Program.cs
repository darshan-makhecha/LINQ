using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin
{
    class Program
    {
        public static void Main()
        {
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID
                         select new
                         {
                             EmployeeName  = e.Name,
                             DepartmentName = d.Name
                             
                         };      
          /*  var result = Employee.GetAllEmployees().Join(Department.GetAllDepartments(),
                                                    e => e.DepartmentID,
                                                    d => d.ID,
                                                    (employee, department) => new
                                                    {
                                                        EmployeeName = employee.Name,
                                                        DepartmentName = department.Name
                                                    });*/
            foreach (var emp in result) {
                Console.WriteLine(emp.EmployeeName + "\t" + emp.DepartmentName);
            }

            Console.Read();   
        }
    }
}
