using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {

            List<IList<int>> pascal = new List<IList<int>>();

            if (numRows > 0)
            {
                pascal.Add(new List<int> { 1 });
            }

            for (int i = 1; i < numRows; i++)
            {
                List<int> row = new List<int>();
                row.Add(1);

                for (int j = 1; j < i; j++)
                {
                    row.Add(pascal[i - 1][j - 1] + pascal[i - 1][j]);
                }

                row.Add(1);

                pascal.Add(row);
            }

            return pascal;
        }
    }
}
