using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class SortByFrequency
    {
        public string FrequencySort(string s)
        {


            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]] += 1;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }

            int count = 0;
            string output = "";
            foreach (KeyValuePair<char, int> entry in dict.OrderByDescending(key => key.Value))
            {
                string x = new String(entry.Key, entry.Value);
                output += x;
            }

            return output;

        }
    }
}
