using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class program
    {
        static void Main()
        {
            List<int> Numbers = new List<int> { 0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> Enenumbers = Enumerable.Where(Numbers, n => n % 2 != 0);

            foreach (int evenumber in Enenumbers) 
            {
                Console.WriteLine(evenumber);
            }
        }
    }
}
