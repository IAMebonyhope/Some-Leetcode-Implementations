using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class MergeInterval
    {
        public class DiffComparer : IComparer<int[]>
        {
            public int Compare(int[] a, int[] b)
            {
                return (a[0]).CompareTo(b[0]);
            }
        }

        public int[][] Merge(int[][] intervals)
        {

            if (intervals.Length == 0)
            {
                return intervals;
            }

            List<int[]> result = new List<int[]>();

            Array.Sort(intervals, new DiffComparer());

            result.Add(intervals[0]);

            int i = 1;
            while (i < intervals.Length)
            {
                if (result[result.Count - 1][1] >= intervals[i][0])
                {

                    result[result.Count - 1][1] = Math.Max(result[result.Count - 1][1], intervals[i][1]);

                }

                else
                {
                    result.Add(intervals[i]);
                }

                i++;
            }

            return result.ToArray();

        }
    }
}
