using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    //Site: Hackerrank
    //Category: Problems
    //Difficulty: Easy
    class PermutatingTwoArrays
    {
        static string twoArrays(int k, int[] A, int[] B)
        {

            Array.Sort(A);
            Array.Sort(B);

            for (int i = 0; i < A.Length; i++)
            {
                int x = A[i];
                int y = B[B.Length - 1 - i];
                if ((x + y) < k)
                {
                    return "NO";
                }
            }


            return "YES";
        }
    }
}
