using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class MergeKSortedArrays
    {
        class Solution
        {
            static void Main(string[] args)
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hello, World");
                }
            }

            static List<int> SortedArray(int[][] arr, int k)
            {

                List<int> result = new List<int>();

                int[] nextPointers = new int[k];

                while (isValidPointers())
                {

                    int smallest = getSmallestElement(arr, nextPointers);

                    result.Add(smallest);
                }

                return result;
            }

            static int getSmallestElement(int[][] arr, int[] pointers)
            {

                Dictionary<int, int> smallests = new Dictionary<int, int>();


                for (int i = 0; i < arr.Length; i++)
                {

                    int k = pointers[i];

                    if (arr[i].Length > k)
                    {
                        smallests.Add(i, arr[i][k]);
                    }

                }


                entry = Dict.SortByValue(smallest);

                pointers[entry.Key] += 1;

                return entry.Value;
            }

        }

    }
}
