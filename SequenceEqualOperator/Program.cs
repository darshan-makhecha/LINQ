using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEqualOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // it is return TRUE 
            string[] countries1 = { "USA", "India", "UK" };
            string[] countries2 = { "USA", "India", "UK" };

            var result = countries1.SequenceEqual(countries2);

            Console.WriteLine("Are Equal = " + result);
            Console.WriteLine();
            Console.WriteLine("==================");
            Console.WriteLine();
            // it is return false because it is not case sensitive 
            string[] c1 = { "USA", "INDIA", "UK" };
            string[] c2 = { "usa", "india", "uk" };

            var r1 = c1.SequenceEqual(c2);

            Console.WriteLine("Are Equal = " + r1);
            Console.WriteLine();
            Console.WriteLine("==================");
            Console.WriteLine();
            // it is return TRUE 
            string[] c3 = { "USA", "INDIA", "UK" };
            string[] c4 = { "usa", "india", "uk" };

            var r2 = c3.SequenceEqual(c4, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Are Equal = " + r2);
            Console.Read();
        }
    }
}
