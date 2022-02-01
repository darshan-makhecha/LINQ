using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcateOpertor
{
    class Program
    {
        static void Main(string[] args)
        {
            // concate opertaor is used to displayy value and combaine 2 collection 
            // but Difference between Union And Concate is Concate is not Remove a duplicate value or Data Where Union remove duplicate value or Data 
            int[] num1 = { 1, 2, 3 };
            int[] num2 = { 1, 4, 5 };

            var result = num1.Concat(num2);
            foreach (int a in result) {
                Console.WriteLine(a);
            }
        }
    }
}
