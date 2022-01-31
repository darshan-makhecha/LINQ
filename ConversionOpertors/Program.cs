using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOpertors
{
    class Program
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public int TotalMarks { get; set; }
        }
        public class Employee
        {
            public string Name { get; set; }
            public string JobTitle { get; set; }
            public string City { get; set; }
        }
        static void Main()
        {
            /*int[] a = { 15, 54, 63, 64, 85, 66, 31, 8 };
            List<int> result = a.ToList();

            foreach (int i in result) {
                Console.WriteLine(i);
            }*/

            /* List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

             string[] result = (from country in countries
                                orderby country ascending
                                select country).ToArray();

             foreach (string str in result)
             {
                 Console.WriteLine(str);
             }
            
            List<Student> listStudents = new List<Student>
            {
                new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };
            // convert to data in dictinary                         datatype = int          string 
            Dictionary<int, string> result = listStudents.ToDictionary(x => x.StudentID, x => x.Name);
            // int and string mix so keyValuePair so i write in foreach
            foreach (KeyValuePair<int, string> kvp in result)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            List<Student> listStudents = new List<Student>
            {
                new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };
            // convert to data in dictinary                         datatype = int        
            Dictionary<int, Student> result = listStudents.ToDictionary(x => x.StudentID );
            // int and string mix so keyValuePair so i write in foreach
            foreach (KeyValuePair<int, Student> kvp in result)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value.Name + " " + kvp.Value.TotalMarks);
            }*/
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "Pam", JobTitle = "Developer", City = "London" }
            };
            // group by job title or city level
            var EmpByjobTitle = listEmployees.ToLookup(x => x.JobTitle);
            var EmpByCityTitle = listEmployees.ToLookup(x => x.City);
            Console.WriteLine("Employees Grouped by Job Title");

            foreach(var kvp in EmpByCityTitle)
            {
                Console.WriteLine(" " + kvp.Key);
                foreach (var emp in EmpByCityTitle[kvp.Key]) {
                    Console.WriteLine(" " + emp.Name + " " + emp.City + " "+ emp.City);
                }
            }





            Console.Read();
        }
    }
}
