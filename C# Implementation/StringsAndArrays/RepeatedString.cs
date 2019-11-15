using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    //Site: Hackerrank
    //Category: Warm Up Interview Preparation Kit
    //Difficulty: Easy
    class RepeatedString
    {
        static long repeatedString(string s, long n)
        {

            long noA = countNumberOfAs(s, s.Length);

            noA = (n / s.Length) * noA;

            long repeatedS = (n / s.Length) * s.Length;

            int remainingFirstN = (int)(n - repeatedS);

            noA += countNumberOfAs(s, remainingFirstN);

            return noA;
        }

        static int countNumberOfAs(string s, int n)
        {
            int noA = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'a')
                {
                    noA += 1;
                }
            }

            return noA;
        }

    }
}
