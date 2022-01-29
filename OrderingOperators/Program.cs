using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Name Before Sorting");
            List<Student> stud = Student.GetAllStudents();
            foreach(Student s in stud) {
                Console.WriteLine(s.Name);    
            }
            Console.WriteLine();
            Console.WriteLine("AFTER SORTING NAME");
            Console.WriteLine();

            //IOrderedEnumerable and  IEnumerable are also work because IOrderedEnumerable is inherit IEnumerable   
            // default sorting is acending order 
            IOrderedEnumerable<Student> stud1 =  Student.GetAllStudents().OrderBy(s => s.Name);
            foreach (Student s in stud1)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            Console.WriteLine("AFTER SORTING DESCINDING ORDER ");
            Console.WriteLine();
            IOrderedEnumerable<Student> stud2 = Student.GetAllStudents().OrderByDescending(s => s.Name);
                    // from student in Student.getAllStudents(),
                    // orderby student.Name descending/ascending
                    // select student;
            foreach (Student s in stud2)
            {
                Console.WriteLine(s.Name);
            }


            Console.WriteLine();
            Console.Read();
        }
    }
}
