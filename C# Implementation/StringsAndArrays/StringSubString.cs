using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class StringSubString
    {
        //Site: LeetCode
        //Category: Top Interview Questions
        //Difficulty: Easy
        public int StrStr(string haystack, string needle)
        {
            int index = -1;

            if (needle.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i <= (haystack.Length - needle.Length); i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (isEqualString(haystack, i, needle))
                    {
                        return i;
                    }
                }
            }

            return index;
        }

        private bool isEqualString(string s1, int k, string s2)
        {

            for (int i = 0; i < s2.Length; i++)
            {
                if (s1[i + k] != s2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
