using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    //Site: LeetCode
    //Category: Top Interview Questions
    //Difficulty: Easy
    class MySqrt
    {
        public int mySqrt(int x)
        {

            if (x == 0)
            {
                return x;
            }

            int start = 1;
            int end = x;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if ((mid <= (x / mid)) && ((mid + 1) > x / (mid + 1)))
                {
                    return mid;
                }
                else if (mid > (x / mid))
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return start;
        }
    }
}
