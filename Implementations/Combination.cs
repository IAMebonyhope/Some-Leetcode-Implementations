using StringsAndArrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    class Combination
    {
        public List<List<int>> powerSet(int[] arr)
        {
            List<List<int>> subsets = new List<List<int>>();
            int[] bitArr = new int[arr.Length];
            List<int[]> bitStringsArr = new List<int[]>();
            generateBitStrings(bitArr, bitStringsArr, 0);

            foreach(int[] bitString in bitStringsArr)
            {
                List<int> subset = new List<int>();
                for(int i=0; i<arr.Length; i++)
                {
                    if (bitString[i] == 1)
                        subset.Add(arr[i]);
                }

                subsets.Add(subset);
            }

            return subsets;
        }
        public void generateBitStrings(int[] bitArr, List<int[]> bitStringsArr, int i)
        {
            if( i == bitArr.Length)
            {
                bitStringsArr.Add(ArrayHelperClass<int>.copy1DArray(bitArr));
            }
            else
            {
                bitArr[i] = 1;
                generateBitStrings(bitArr, bitStringsArr, i + 1);

                bitArr[i] = 0;
                generateBitStrings(bitArr, bitStringsArr, i + 1);
            }
        }
    }
}
