using System;
using System.Collections.Generic; // for list add namespace
using System.Linq;      // for linq query add namespace
namespace RestrictionOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {  1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
            // add predicate for understand LINQ  where structure
            // add i am Func<int,bool> because x => x % 2 == 0 where first x is return int and those after => this sign given true or false so 
            // 2 method 

          //  Func<int, bool> predicate = x => x % 2 == 0;
          // IEnumerable<int> evennumber = numbers.Where(predicate);*//*

            // select use the index number print with value like  0 - 1 , 1-2 ......
            var result = numbers.Select((num ,index) => new  { Number = num , Index = index});
           

            IEnumerable<int> evennumber = numbers.Where(x => x % 2 == 0);
            // output will same but structure change 
            // i m use private() so also this methos willl accepts 
            // 3 method 
            //  IEnumerable<int> evennumber = numbers.Where(num =>IsEven(num));
            // select use so print index and value print data
            Console.WriteLine("Using Select print index number and data which pass in list");
            foreach (var item in result)
            {
                Console.WriteLine(item.Number + " - " + item.Index);
            }
            Console.WriteLine();
            int data = numbers.Count();
            Console.WriteLine("So, the element of this list is {0}", data);
            Console.WriteLine("===============");
            Console.WriteLine();
            Console.WriteLine("in list, Even number is :");
            Console.WriteLine();


            foreach (int i in evennumber)
            {
                Console.WriteLine(i);
            }
           

        }
        /*      3 method 
                private static bool IsEven(int number) {
                    return number % 2 == 0;
                }*/
    }
}
