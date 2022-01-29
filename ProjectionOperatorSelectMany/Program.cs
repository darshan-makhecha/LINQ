using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectionOperatorSelectMany
{
    class Program
    {
        static void Main()
        {                                                                       //here Distinct meanse repeat data not dispay                       
            IEnumerable<string> sub = Student.GetAllStudetns().SelectMany(s => s.Subjects).Distinct(); ;
            foreach (string s in sub) {
                Console.WriteLine(s);
            }
            IEnumerable<string> sub1 = from Student in Student.GetAllStudetns()
                                       from subject in Student.Subjects
                                       select subject;

            foreach (string s in sub1)
            {
                Console.WriteLine(s);
            }
            string[] stringArray = {
                " A B C D E F G H I J K L M N O P Q R S T U V W X Y Z ",
                "1 2 3 4 5 6 7 8 9"
            };

            IEnumerable<char> a = stringArray.SelectMany(s => s);
            foreach (char s in a)
            {
                Console.WriteLine(s);
            }

             var abc = Student.GetAllStudetns().SelectMany(s => s.Subjects, (Student, subject) => new { StudentName = Student.Name, subjectName = subject });
             foreach (var s in abc)
               {
                   Console.WriteLine(s.StudentName + " ->  " + s.subjectName );
                  // Console.WriteLine(s);
               }
          
            IEnumerable<List<string>> result = Student.GetAllStudetns().Select(s => s.Subjects);
            foreach (List<string> stringList in result) {
                foreach (String str in stringList) {
                    Console.WriteLine(str);
                }
            }

            Console.WriteLine("============");
            IEnumerable<string> res = Student.GetAllStudetns().SelectMany(s => s.Subjects);
            foreach (string str in res)
            {
                    Console.WriteLine(str);
                
            }

            Console.Read();
        }
    }
}
