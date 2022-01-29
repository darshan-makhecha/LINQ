using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partitioningOperators
{
    class Program
    {
        static void Main()
        {
            string[] countries = { "Australia", "Canada","USA","London","UK","India"};
            // it disply first 3 countries name 
            // (from country in countries select country).take(3)
            Console.WriteLine("i am use of take method");
            Console.WriteLine();
            IEnumerable<string> res=  countries.Take(3);
            foreach (string str in res) {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            Console.WriteLine("i am use of skip method");
            Console.WriteLine();
            // it disply remainning countries name
            // meanse which value pass after name display 
            IEnumerable<string> res1 = countries.Skip(3);
            foreach (string skip in res1)
            {
                Console.WriteLine(skip);
            }
            Console.WriteLine();
            Console.WriteLine("i am use of TakeWhile method");
            Console.WriteLine();
            // it countries length check and after name display
            // meanse which value pass after name display 
            IEnumerable<string> data = countries.TakeWhile(s => s.Length > 2);
            foreach (string tw in data)
            {
                Console.WriteLine(tw);
            }
            Console.WriteLine();
            Console.WriteLine("i am use of Skipwhile method");
            Console.WriteLine();
            // it countries length check and after name display
            // meanse which value pass after name display 
            IEnumerable<string> d1 = countries.TakeWhile(s => s.Length > 2);
            foreach (string sw in d1)
            {
                Console.WriteLine(sw);
            }
            Console.Read();
        }
    }
}
