using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringsAndArrays;

namespace Implementations
{
    class Permutation
    {
        public List<int[]> generate(int[] arr)
        {
            List<int[]> permutationList = new List<int[]>();
            permutations(arr, permutationList, 0, arr.Length);
            return permutationList;
        }
        public void permutations(int[] arr, List<int[]> permutationList, int l, int r)
        {
            if (l == r)
            {
                int[] currentPermutation = ArrayHelperClass<int>.copy1DArray(arr);
                permutationList.Add(currentPermutation);
            }
            else
            {

                for (int i = l; i < r; i++)
                {
                    ArrayHelperClass<int>.swapElements(arr, i, l);
                    permutations(arr, permutationList, l + 1, r);
                    ArrayHelperClass<int>.swapElements(arr, i, l);
                }
            }
        }
    }
}
