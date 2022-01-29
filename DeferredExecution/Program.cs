using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredExecution
{
    class Program
    {
        public class Student{
            
            public int StudentID { get; set; }
            public string Name { get; set; }
            public int TotalMarks { get; set; }

        }
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>
        {
            new Student
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student
            {
                StudentID= 103,
                Name = "Valarie",
                TotalMarks = 690
            },
            
            

        };

//when tolist() add this query then this query forced to run then called immediate excute query
// without tolist() method it is deffered ececution
            IEnumerable<Student> result = (from student in listStudents
                                        where student.TotalMarks > 800
                                        select student).ToList();

             
            // look after query i am add this record but at that time output not grenrated so when foreach loop check data then print this record it's called defered data
            // after query pass i am add record but output time display record
            listStudents.Add(new Student() { StudentID = 104, Name = "abc", TotalMarks = 850 });


            foreach (Student s in result) {
                Console.WriteLine(s.StudentID + " \t"+ s.Name + " \t" + s.TotalMarks);
            }

            Console.Read();
        }
    }
}
