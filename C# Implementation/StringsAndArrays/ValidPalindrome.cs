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
    class ValidPalindrome
    {
        public bool validPalindrome(string s)
        {
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
                    return (isPalindrome(s, i + 1, j) || isPalindrome(s, i, j - 1));
                }

                i++;
                j--;

            }


            return true;

        }

        private bool isPalindrome(string s, int i, int j)
        {

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
