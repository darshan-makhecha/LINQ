using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPaging
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>
        {
            new Student
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 540
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
            new Student
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 480
            },
             new Student
            {
                StudentID= 105,
                Name = "John",
                TotalMarks = 546
            },
             new Student
            {
                StudentID= 106,
                Name = "Vandit",
                TotalMarks = 640
            },
             new Student
            {
                StudentID= 107,
                Name = "Aditya",
                TotalMarks = 745
            },
             new Student
            {
                StudentID= 108,
                Name = "vivek",
                TotalMarks = 650
            },
             new Student
            {
                StudentID= 109,
                Name = "Darshan",
                TotalMarks = 785
            },
             new Student
            {
                StudentID= 110,
                Name = "bhavnesh",
                TotalMarks = 790
            },
             new Student
            {
                StudentID= 111,
                Name = "ronak",
                TotalMarks = 740
            },

        };

            return listStudents;
        }
    }

}

