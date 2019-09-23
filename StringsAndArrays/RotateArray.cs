using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    //Site: LeetCode
    //Category: Top Interview Questions
    //Difficulty: Medium
    class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;

            reverseArray(nums, 0, nums.Length - 1);
            reverseArray(nums, 0, k - 1);
            reverseArray(nums, k, nums.Length - 1);
            
        }

        public void reverseArray(int[] nums, int start, int end)
        {
            Console.WriteLine(nums[start]);
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
