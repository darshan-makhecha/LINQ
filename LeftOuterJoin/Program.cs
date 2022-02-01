using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftOuterJoin
{
    class Program
    {
        static void Main()
        {
                    // sevance like method 
            var result = from e in Employee.GetAllEmployees()
                         join d in Department.GetAllDepartments()
                         on e.DepartmentID equals d.ID into eGroup
                         from d in eGroup.DefaultIfEmpty()
                         select new
                         {
                             EmployeeName = e.Name,
                             // if d (department) is null then disply NO departmet and else name print of department
                             DepartmentName = d ==null?"No Department": d.Name
                         };

            foreach (var v in result) {
                Console.WriteLine(v.EmployeeName + "\t" + v.DepartmentName);
            }

            Console.Read();
        }
    }
}
