
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPaging
{
    class Program
    {
        static void Main()
        {
            do
            {
                IEnumerable<Student> stud = Student.GetAllStudents();

                Console.WriteLine();
                Console.WriteLine("Enter Number Between 1 to 4");
                int pageNUmber = 0;
                if (int.TryParse(Console.ReadLine(), out pageNUmber))
                {
                    if (pageNUmber >= 1 && pageNUmber <= 4) {

                        int pageSize = 3;
                        IEnumerable<Student> result = stud.Skip((pageNUmber - 1) * pageSize).Take(pageSize);
                        Console.WriteLine();
                        Console.WriteLine("Displauing page : " + pageNUmber);
                        foreach (Student s in result) {
                            Console.WriteLine(s.StudentID + " \t" + s.Name + " \t" + s.TotalMarks);
                        }
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("Page Number Must be Integer Between 1 to 4");
                    }
                }
                else {

                    Console.WriteLine("Page Number Must be Integer Between 1 to 4");
                }
            }while (1 == 1) ;
        }
       
    }
}
