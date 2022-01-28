using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public  class StringHelper
    {
        public static string ChangeFirstLetterCase(string inputString)
        {
            if (inputString.Length > 0) {
                // convert first character uppercase using char array
                char[] charArray = inputString.ToCharArray();
                         // if char is upper then convert lower     after ? else part  if lower then convert upper case 
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                        // return chararry r
                return new string(charArray);    
            }
            return inputString;
        }
    }
}