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
    class ValidParentheses
    {
        public bool IsValid(string s)
        {

            Dictionary<char, char> mydict = new Dictionary<char, char>();
            mydict.Add('(', ')');
            mydict.Add('{', '}');
            mydict.Add('[', ']');

            Stack<char> myStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (mydict.ContainsKey(s[i]))
                {
                    myStack.Push(s[i]);
                }
                else if ((myStack.Count > 0) && (mydict[myStack.Peek()] == s[i]))
                {
                    myStack.Pop();
                }
                else
                {
                    return false;
                }
            }

            if (myStack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
