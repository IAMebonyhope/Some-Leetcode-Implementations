using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class MakingAnagrams
    {
        static int makeAnagram(string a, string b)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (dict.ContainsKey(a[i]))
                {
                    dict[a[i]] += 1;
                }
                else
                {
                    dict.Add(a[i], 1);
                }
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (dict.ContainsKey(b[i]))
                {
                    dict[b[i]] -= 1;
                }
                else
                {
                    dict.Add(b[i], -1);
                }
            }

            int count = 0;

            foreach (KeyValuePair<char, int> entry in dict)
            {
                if (entry.Value != 0)
                {
                    count += Math.Abs(entry.Value);
                }
                Console.WriteLine(entry.Key);
            }

            return count;
        }
    }
}
