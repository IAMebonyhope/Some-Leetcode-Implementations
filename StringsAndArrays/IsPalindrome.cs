using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    //Site: LeetCode
    //Category: Top Interview Questions
    //Difficulty: Easy
    class IsPalindrome
    {
        public bool isPalindrome(string s)
        {

            char[] arr = s.Where(c => char.IsLetterOrDigit(c)).ToArray();

            string str = new string(arr);
            s = str.ToLower();
            Console.WriteLine(s);
            if (s == "")
            {
                return true;
            }

            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;

        }
    }
}
