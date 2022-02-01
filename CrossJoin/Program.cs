using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossJoin
{
    class Program
    {
        static void Main()
        {
            /*
             * 
             * Employee.GetAllEmployees().join(Departments(),
             * e => true,
             * d => true,
             * (e,d) => new {e,d});
             * 
             */
            var result = from d in Department.GetAllDepartments()
                         from e in Employee.GetAllEmployees()
                       
                         select new
                         {
                             e,d
                         };
            foreach (var a in result) {
                Console.WriteLine(a.e.Name + "\t" + a.d.Name);
            }
            Console.Read();
        }
    }
}
