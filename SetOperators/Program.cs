using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperators
{
    class Program  
    {
        static void Main()
        {

                // set operator : Distinct, Union ,Intersect,Except

            // Distinct :- 
 
//            string[] countries = { "USA", "usa", "INDIA", "UK", "UK" };
/*
            var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }*/

            List<Employee> list = new List<Employee>()
            // List<Employee> list = list.select(x => new{ x.ID , x.Name}).Disctinct();
{
    new Employee { ID = 101, Name = "Mike"},
    new Employee { ID = 101, Name = "Mike"},
    new Employee { ID = 102, Name = "Mary"}
            };

            var r1 = list.Distinct(new Class1()); // var r1 = list.Distinct();

            foreach (var v in r1)
            {
                Console.WriteLine(v.ID + "\t" + v.Name);
            }


            //union   ==> it remove duplicate value into 2 element collection

            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 1, 3, 6, 7, 8 };

            var result = numbers1.Union(numbers2);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }

            List<Employee> list1 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Susy"},
                new Employee { ID = 103, Name = "Mary"}
            };

            List<Employee> list2 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 104, Name = "John"}
            };
             // it remove  common elements
            var data = list1.Select(x => new { x.ID, x.Name })
                        .Union(list2.Select(x => new { x.ID, x.Name }));

            foreach (var v in data)
            {
                Console.WriteLine(v.ID + "\t" + v.Name);
            }
            Console.WriteLine();
            Console.WriteLine("=========");


            // it return duplicate element 
            var d1 = numbers1.Intersect(numbers2);

            foreach (var v in d1)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
            Console.WriteLine("=========");
            // it return not duplicate number in ecolllction
            var d2 = numbers1.Except(numbers2);

            foreach (var v in d2)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
            Console.WriteLine("=========");

            Console.Read();
        }
    }
}
