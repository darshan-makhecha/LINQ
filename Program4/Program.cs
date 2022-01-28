using System;
using System.Linq;
namespace Program4
{
    class Program
    {
        static void Main()
        {
            //Aggrigate Function
            int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int result = number.Min();
            Console.WriteLine("smallest number in list is : "+ result);
            int res1 = number.Where(x => x % 2 == 0).Min();
            Console.WriteLine("smallest even number in list is : " + res1);
            int res2 = number.Where(x => x % 2 == 0).Sum();
            Console.WriteLine("sum of even number in list is : " + res2);
            int res3 = number.Where(x => x % 2 == 0).Count();
            Console.WriteLine("Total even number in list is : " + res3);
            double res4 = number.Where(x => x % 2 == 0).Average();
            Console.WriteLine("Average of  even number in list is : " + res4);
            Console.WriteLine("==================");
            Console.WriteLine();
            string[] Countries = { "USA", "India", "London" };

            int res5 = Countries.Length;
            Console.WriteLine(res5);
            int min = Countries.Min(x => x.Length);
            Console.WriteLine(min);
            Console.WriteLine("the smallest char of countries is {0} ", min);
            int max = Countries.Max(x => x.Length);
            Console.WriteLine(max);
            Console.WriteLine("the Largest char of countries is {0} ", max);
            Console.WriteLine("==========================");
            Console.WriteLine();
            /* countrie name mix in single part
            like
                    countries =  { "USA", "India", "London" } 
            convert with the help of LINQ
                    countries =  { "USA , India , London" }
            */

            //any 2  value stroe in one var then use this syntax   
            //string[] Countries = { "USA", "India", "London" };
                            
            string res6 = Countries.Aggregate((a, b) => a + "," + b);
            Console.WriteLine(res6);

            int[] num = { 2, 3, 4, 5, };
            // it multiply by 2*3 = 6 after 6*4 = 24 after 24*5 =120 then output is 120
            int res7 = num.Aggregate((a, b) => a * b);

            Console.WriteLine("the value is : " + res7);


        } 
    }
}
