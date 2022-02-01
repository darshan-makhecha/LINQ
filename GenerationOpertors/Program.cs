using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationOpertors
{
    class Program
    {
        static void Main()
        {  // range is used to anuy kind of range like 1 to 10 then it is use
           // here use of range to display even number in 1 to 10 number
           IEnumerable<int> r = Enumerable.Range(1, 10).Where(a =>a%2 ==0);
            foreach (int a in r) {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("========");
            Console.WriteLine();

            //Repeat 
            // which data repeat and hoe much time repeat then it is use
            // lije this 
            var b = Enumerable.Repeat("Hello", 5);

            foreach (var d in b) {
                Console.WriteLine(d);
            }
             
            // empty it is used to check collection is empty or not



            Console.Read();
        }
    }
}
