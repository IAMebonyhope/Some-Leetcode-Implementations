using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];

            left[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = left[i - 1] * nums[i];
            }

            right[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * nums[i];
            }

            nums[0] = right[1];
            for (int i = 1; i < nums.Length - 1; i++)
            {
                nums[i] = left[i - 1] * right[i + 1];
            }
            nums[nums.Length - 1] = left[nums.Length - 2];

            return nums;
        }

        //constant space except for output array
        public int[] ProductExceptSelf2(int[] nums)
        {
            int left = 1;
            int[] right = new int[nums.Length];


            right[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * nums[i];
            }


            for (int i = 0; i < nums.Length - 1; i++)
            {
                right[i] = left * right[i + 1];
                left *= nums[i];
            }
            right[nums.Length - 1] = left;


            return right;
        }
    }
}
