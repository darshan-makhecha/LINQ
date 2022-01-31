using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsEnumerable_and_AsQueryable
{
    class Program
    {
        static void Main()
        {
    EmployeeDBDataContext db = new EmployeeDBDataContext();
            var res = db.Employees
                                .Where(x => x.Gender == "Male")
                                 
                                .OrderByDescending(x => x.Salary)
                                .Take(5);
            // it disply top 5 male employee and his details 
            Console.WriteLine();
            foreach (var e in res) {
                Console.WriteLine(e.Name + " \t" + e.Salary + " \t" + e.Gender);
            }
            // #region  name last #endregion
            Console.Read();
        }
    }
}
