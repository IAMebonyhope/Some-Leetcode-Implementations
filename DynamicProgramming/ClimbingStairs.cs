using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {

            return helper(n, new Dictionary<int, int>());

        }

        private int helper(int n, Dictionary<int, int> memo)
        {
            Console.WriteLine(n);
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return 0;
            }

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            int x = (helper(n - 2, memo) + helper(n - 1, memo));
            memo.Add(n, x);

            return x;
        }
    }
}
