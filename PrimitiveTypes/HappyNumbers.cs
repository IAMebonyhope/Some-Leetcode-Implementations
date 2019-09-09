using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class HappyNumbers
    {
        //Site: LeetCode
        //Category: Problems
        //Difficulty: Easy
        public bool IsHappy(int n)
        {
            int slow = n;
            int fast = n;

            while ((slow != 1) && (fast != 1))
            {
                slow = sumOfSquares(slow);
                fast = sumOfSquares(sumOfSquares(fast));

                if ((slow != 1) && (fast != 1) && (slow == fast))
                {
                    return false;
                }
            }

            return true;
        }


        private int sumOfSquares(int n)
        {

            int result = 0;

            while (n > 0)
            {
                int remainder = n % 10;
                result += (remainder * remainder);
                n = n / 10;
            }

            return result;
        }
    }
}
