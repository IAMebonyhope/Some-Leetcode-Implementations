using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class SearchAndInsert
    {
        public int SearchInsert(int[] nums, int target)
        {

            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {

                int mid = (high + low) / 2;

                if (nums[mid] == target)
                    return mid;

                else if (nums[mid] > target)
                    high = mid - 1;

                else
                    low = mid + 1;
            }

            return low;
        }
    }
}
