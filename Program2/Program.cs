using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Program
    {
        static void Main()
        {
            String strName = "darshan";
            // if comment value pass then 2 change in StringHelper.cs => 1 is write static on line 8 and  ==> 2 change is this type in pass parameter first then it will work 
            //string res = strName.ChangeFirstLetterCase();
            string res = StringHelper.ChangeFirstLetterCase(strName);
            Console.WriteLine(res);

        }
}