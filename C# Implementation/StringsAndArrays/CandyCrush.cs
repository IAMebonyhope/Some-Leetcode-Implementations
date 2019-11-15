using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    public class CandyCrush
    {
        public int[][] candyCrush(int[][] board)
        {

            bool isStable = false;

            while (isStable == false)
            {

                isStable = true;
                isStable = crush(board, isStable);
                drop(board);
            }

            return board;
        }

        private bool crush(int[][] board, bool isStable)
        {

            isStable = columnCrush(board, isStable);
            isStable = rowCrush(board, isStable);

            return isStable;
        }

        private bool columnCrush(int[][] board, bool isStable)
        {

            int start = 0;
            int current = -1;

            for (int i = 0; i < board[0].Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {

                    if ((current != board[j][i]) || current == 0)
                    {
                        if ((j - start) >= 3)
                        {
                            isStable = false;
                            for (int k = start; k < j; k++)
                            {
                                board[k][i] *= -1;
                                Console.WriteLine(board[k][i] + " " + i);
                            }
                        }

                        start = j;
                        current = board[j][i];

                    }

                }

                if ((board.Length - start) >= 3)
                {
                    isStable = false;
                    for (int k = start; k < board.Length; k++)
                    {
                        board[k][i] *= -1;
                        Console.WriteLine(board[k][i] + " " + i);
                    }
                }

                start = 0;
                current = -1;
            }

            return isStable;

        }

        private bool rowCrush(int[][] board, bool isStable)
        {

            int start = 0;
            int current = -1;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {

                    if ((current != Math.Abs(board[i][j])) || (current == 0))
                    {
                        if ((j - start) >= 3)
                        {
                            isStable = false;
                            for (int k = start; k < j; k++)
                            {
                                if (board[i][k] > 0)
                                    board[i][k] *= -1;
                                Console.WriteLine(board[i][k] + " " + i);
                            }
                        }

                        start = j;
                        current = Math.Abs(board[i][j]);

                    }
                }

                if ((board[0].Length - start) >= 3)
                {
                    isStable = false;
                    for (int k = start; k < board[0].Length; k++)
                    {
                        if (board[i][k] > 0)
                            board[i][k] *= -1;
                        Console.WriteLine(board[i][k] + " " + i);
                    }
                }

                start = 0;
                current = -1;
            }

            return isStable;

        }

        private void drop(int[][] board)
        {



            for (int i = 0; i < board[0].Length; i++)
            {
                int start = board.Length - 1;
                for (int j = (board.Length - 1); j >= 0; j--)
                {

                    if (board[j][i] > 0)
                    {

                        board[start][i] = board[j][i];
                        start--;

                    }
                }

                for (int j = start; j >= 0; j--)
                {

                    board[j][i] = 0;

                }
            }
        }
    }
}
