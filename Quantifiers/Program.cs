using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] num1 = { 1, 2, 3, 4, 5, 45 };
            // it check number < 10 then return TRUE
            var result = numbers.All(x => x < 10);
            Console.WriteLine(result);
            Console.WriteLine("===========");
            // it check the number avilable in collection 
            var r = numbers.Any();
            Console.WriteLine(r);
            Console.WriteLine("===============");
            // ot check the number is > 10 then it return TRUE
            var r1 = num1.Any(x => x > 10);
            Console.WriteLine(r1);
            Console.WriteLine("===============");
            // it check 3 is contain in collection
            var r2 = numbers.Contains(3);
            Console.WriteLine(r2);
            Console.WriteLine("===============");
            //it is check string avilable or not in collection
            string[] countries = { "USA", "INDIA", "UK" };
            var r3 = countries.Contains("india", StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(r3);



            Console.Read();
        }
    }
}
