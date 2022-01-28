using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Student
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>();
            Student stud1 = new Student
            {
                ID = 101,
                Gender = "Male",
                Name = "Darshan"
            };
            listStudents.Add(stud1);

            Student stud2 = new Student
            {
                ID = 102,
                Gender = "Female",
                Name = "Anjali"
            };
            listStudents.Add(stud2);

            Student stud3 = new Student
            {
                ID = 103,
                Gender = "Female",
                Name = "Shital"
            };
            listStudents.Add(stud3);

            Student stud4 = new Student
            {
                ID = 104,
                Gender = "Male",
                Name = "Vivek"
            };
            listStudents.Add(stud4);

            Student stud5 = new Student
            {
                ID = 105,
                Gender = "Male",
                Name = "Aditya"
            };
            listStudents.Add(stud5);
            return listStudents;
        }
         
    }
}