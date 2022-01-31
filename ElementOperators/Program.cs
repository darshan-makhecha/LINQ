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
            Console.WriteLine("First() use and Result  :" + res);

            // if value is not then error disply
            int res1 = numbers.First(x => x % 2 == 0);
            Console.WriteLine("First even number  :" + res1);

            // if value is not the return 0
            int res2 = numbers.FirstOrDefault();
            Console.WriteLine("FirstOrDefault Result :" + res2);

            int res3 = numbers.Last();
            Console.WriteLine("Last Result :" + res3);

            // input index then output value here 5 is index and disply 5th element
            int res4 = numbers.ElementAt(5);
            Console.WriteLine("Element At Result :" + res4);

            // it given a single value return
            //   int res5 = numbers.Single();
            // Console.WriteLine("Result :" + res5);

            // if  pass no number then return 0
            // if list of number not pass but parameter pass then disply this number 
            Console.WriteLine("DefaultIfEmpty method :");
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var res6 = num.DefaultIfEmpty();
            foreach (var i in res6)
            {
                Console.WriteLine(i);
            }

             
            Console.Read();
        }
    }
}
