using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class SingleNumber
    {
        public int SingleNumber(int[] nums)
        {

            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            return result;
        }
    }
}
