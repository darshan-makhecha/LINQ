using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast_and_ofTypeOperators
{
    class Program
    {
        public static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("4");
            list.Add("dfs");
            //            IEnumerable<int> res = list.Cast<int>();
            IEnumerable<int> res = list.OfType<int>();
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }




        }
    }
}
