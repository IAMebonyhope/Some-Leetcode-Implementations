using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class AlternatingChar
    {
        static int alternatingCharacters(string s)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();

            dict.Add('A', 'B');
            dict.Add('B', 'A');

            char first = s[0];
            char second = dict[s[0]];
            int deletions = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != second)
                {
                    deletions++;
                }
                else
                {
                    first = s[i];
                    second = dict[s[i]];
                }
            }

            return deletions;

        }
    }
}
