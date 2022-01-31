using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementOperators
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            // if value is not then error disply
            int res = numbers.First();
            Console.WriteLine("Result :" + res);

            // if value is not then error disply
            int res1 = numbers.First(x => x % 2 == 0);
            Console.WriteLine("Result :" + res1);

            // if value is not the return 0
            int res2 = numbers.FirstOrDefault();
            Console.WriteLine("Result :" + res2);

            int res3 = numbers.Last();
            Console.WriteLine("Result :" + res3);

            // input index then output value
            int res4 = numbers.ElementAt(1);
            Console.WriteLine("Result :" + res4);
            
            // it given a single value return
         //   int res5 = numbers.Single();
           // Console.WriteLine("Result :" + res5);

            var res6 = numbers.DefaultIfEmpty();
            foreach (var i in res6)
            {
                Console.WriteLine(i);
            }

             
            Console.Read();
        }
    }
}
