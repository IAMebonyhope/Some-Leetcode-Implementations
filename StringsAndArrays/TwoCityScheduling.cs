using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    //Site: LeetCode
    //Category: Top Interview Questions(BloomBerg)
    //Difficulty: Easy
    class TwoCityScheduling
    {
        public class DiffComparer : IComparer<int[]>
        {
            public int Compare(int[] a, int[] b)
            {
                return (a[1] - a[0]).CompareTo(b[1] - b[0]);
            }
        }

        public int TwoCitySchedCost(int[][] costs)
        {

            Array.Sort(costs, new DiffComparer());
            int minCost = 0;

            for (int i = 0; i < (costs.Length / 2); i++)
            {
                minCost += costs[i][1] + costs[costs.Length - 1 - i][0];
            }

            return minCost;
        }

    }
}
