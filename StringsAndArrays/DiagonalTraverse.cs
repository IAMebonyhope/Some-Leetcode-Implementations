using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class DiagonalTraverse
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {

            if ((matrix.Length < 1) || (matrix[0].Length < 1))
            {
                return new int[matrix.Length];
            }

            int[] result = new int[matrix.Length * matrix[0].Length];
            int counter = 0;
            bool up = true;

            for (int j = 0; j < matrix[0].Length; j++)
            {
                Console.WriteLine(counter);
                if (up == true)
                {
                    counter = getDiagonalUp(matrix, result, 0, j, counter);
                    up = false;
                }
                else
                {
                    counter = getDiagonalDown(matrix, result, 0, j, counter);
                    up = true;
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                Console.WriteLine(counter);
                if (up == true)
                {
                    counter = getDiagonalUp(matrix, result, i, matrix[0].Length - 1, counter);
                    up = false;
                }
                else
                {
                    counter = getDiagonalDown(matrix, result, i, matrix[0].Length - 1, counter);
                    up = true;
                }
            }

            return result;
        }

        public int getDiagonalUp(int[][] matrix, int[] result, int row, int col, int counter)
        {

            int counterBefore = counter;

            counter = getDiagonalDown(matrix, result, row, col, counter);

            Stack<int> stack = new Stack<int>();
            for (int x = counterBefore; x < counter; x++)
            {
                stack.Push(result[x]);
            }

            for (int x = counterBefore; x < counter; x++)
            {
                result[x] = stack.Pop();
            }

            return counter;
        }

        public int getDiagonalDown(int[][] matrix, int[] result, int row, int col, int counter)
        {

            int i = row;
            int j = col;

            while ((i < matrix.Length) && (j > -1))
            {
                result[counter] = matrix[i][j];
                i += 1;
                j -= 1;
                counter += 1;
            }

            return counter;
        }
    }
}
