using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    //Site: LeetCode
    //Category: Top Interview Questions
    //Difficulty: Medium
    class WordBreak
    {
        public bool wordBreak(string s, IList<string> wordDict)
        {
            if (insertSpaces(s, 0, new HashSet<string>(), wordDict) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string insertSpaces(string str, int start, HashSet<string> set, IList<string> wordDict)
        {


            string temp = null;
            bool foundValid = false;
            int next = 0;

            for (int i = start; i < str.Length; i++)
            {
                temp += str[i];
                if ((!set.Contains(temp)) && (wordDict.Contains(temp)))
                {
                    foundValid = true;
                    next = i + 1;
                    break;
                }
            }

            if (foundValid == false)
            {

                return null;
            }

            if (next >= str.Length)
            {

                return temp;
            }


            string substr = insertSpaces(str, next, set, wordDict);

            if (substr != null)
            {

                return (temp + " " + substr);
            }
            else
            {

                set.Add(temp);
                return insertSpaces(str, start, set, wordDict);
            }

        }

    }
}
