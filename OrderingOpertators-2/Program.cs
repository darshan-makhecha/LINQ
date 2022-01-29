using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingOpertators_2
{
    class Program
    {
        static void Main()
        {  // student marks disply in descending order BUT name print in ascending order   for john thenbyDescding order use because 105 disply first after 104 display                             
            /*
                from s in student.GetAllStudent()
                orderby s.TotalMarks, s.Name ,s.studentId descending 
                select s;
            */
            IOrderedEnumerable<Student> stud =  Student.GetAllStudents().OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenByDescending(s => s.StudentID);

            foreach (Student s in stud) {
                Console.WriteLine(s.TotalMarks + " \t" + s.Name + " \t" + s.StudentID);
            }
            Console.WriteLine();

            // REVERSE METHOD 

            IEnumerable<Student> stud1 = Student.GetAllStudents();
            Console.WriteLine("Before calling Reverse Method");
            foreach (Student s1 in stud1) {
                Console.WriteLine(s1.Name);
            }
            Console.WriteLine();
            
            Console.WriteLine("After calling Reverse Method");
            
            IEnumerable<Student> res = stud1.Reverse() ;
            foreach (Student s2 in res)
            {
                Console.WriteLine(s2.Name);
            }
            Console.Read();
        }
    }
}
