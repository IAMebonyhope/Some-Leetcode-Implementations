using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    class QuickSort
    {
        public static void quickSort(int[] ar)
        {

            quicksort_helper(ar, 0, ar.Length);

        }

        private static void quicksort_helper(int[] arr, int left, int right)
        {
            int pivot_index = partition(arr, left, right);
            if (left < pivot_index - 1)
            {
                quicksort_helper(arr, left, pivot_index - 1);
            }
            if (right > pivot_index + 1)
            {
                quicksort_helper(arr, pivot_index + 1, right);
            }

            print(arr, left, right);
            Console.WriteLine();
        }

        private static int partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            int i = left + 1;
            int j = left + 1;

            while (j < right)
            {
                if (arr[j] < pivot)
                {
                    swap(arr, i, j);
                    i++;
                }

                j++;
            }

            swap(arr, i - 1, left);
            return i - 1;
        }

        private static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private static void print(int[] arr, int left, int right)
        {
            for (int i = left; i < right; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
