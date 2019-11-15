using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    public class ArrayHelperClass<T>
    {
        public static void swapElements(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static T[] copy1DArray(T[] copyFrom)
        {
            T[] copyTo = new T[copyFrom.Length];

            if(copyFrom.Length < 1)
            {
                throw new ArgumentNullException("Array is empty");
            }

            for(int i=0; i<copyFrom.Length; i++)
            {
                copyTo[i] = copyFrom[i];
            }

            return copyTo;
        }

        public static void print1DArray(T[] arr)
        {
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void print2DArray(T[,] arr)
        {
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.GetLength(i); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.Write("\n");   
            }
        }
    }
}
