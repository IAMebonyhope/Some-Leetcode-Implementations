using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class MaxSubArray
    {
        public int maxSubArray(int[] nums)
        {
            int currSum = nums[0];
            int maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currSum = Math.Max(currSum + nums[i], nums[i]);
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
    }
}
