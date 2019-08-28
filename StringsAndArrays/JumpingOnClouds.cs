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
    class JumpingOnClouds
    {
        public static int jumpingOnClouds(int[] c)
        {

            int jumps = 0;
            int count = 0;

            if (c.Length == 0)
            {
                return 0;
            }

            while (count < (c.Length - 1))
            {

                if (((count + 2) >= c.Length) && (c[count + 1] != 0))
                {
                    break;
                }
                else if (((count + 2) < c.Length) && (c[count + 2] == 0))
                {
                    count += 2;
                }
                else
                {
                    count += 1;
                }

                jumps += 1;
            }

            return jumps;

        }
    }
}
