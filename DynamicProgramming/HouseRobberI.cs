using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class HouseRobberI
    {
        public int Rob(int[] nums)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            return Math.Max(helper(nums, 0, dict), helper(nums, 1, dict));
        }

        private int helper(int[] nums, int start, Dictionary<int, int> memo)
        {

            if (start >= nums.Length)
            {
                return 0;
            }

            if (memo.ContainsKey(start))
            {
                return memo[start];
            }

            int n1 = nums[start] + helper(nums, start + 2, memo);
            int n2 = nums[start] + helper(nums, start + 3, memo);

            int x = Math.Max(n1, n2);
            memo.Add(start, x);

            return x;
        }
    }
}
