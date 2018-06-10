/*Prime Strings 

A String is called prime if it can't be constructed by concatenating multiple (more than one) equal strings. 

For example: 
"abac" is prime, but "xyxy" is not ("xyxy" = "xy" + "xy"). 

Implement a program which outputs whether a given string is prime. 

Examples 
Input: "xyxy" 
Output: "not prime" 

Input: "aaaa" 
Output: "not prime" 

Input: "hello" 
Output: "prime"*/

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Prime_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string.");
            while (true)
            {
                string str = Console.ReadLine();
                if (IsPrime(str)) Console.WriteLine("prime");
                else Console.WriteLine("not prime");

                Console.WriteLine();
            }
        }

        static bool IsPrime(string str)
        {
            for (int len = 1; len <= str.Length/2; len++)
            {
                string substr = str.Substring(0, len);
                if (IsConstructedBy(str, substr))
                    return false;
            }

            return true;
        }

        static bool IsConstructedBy(string big_str, string small_str)
        {
            int big_str_l = big_str.Length;
            int sm_str_l = small_str.Length;
            if ((big_str_l < sm_str_l * 2) || (big_str_l % sm_str_l != 0))
                return false;

            for(int i = 0; i <= big_str_l - sm_str_l; i += sm_str_l)
            {
                string part = big_str.Substring(i, sm_str_l);
                if (!String.Equals(part, small_str))
                    return false;
            }
            
            return true;
        }
    }
}
