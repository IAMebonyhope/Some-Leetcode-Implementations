using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class RunLengthEncoding
    {
        public string Compress(String str)
        {
            StringBuilder sb = new StringBuilder();

            char currentChar = str[0];
            int noOfChars = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != currentChar)
                {
                    sb.Append(noOfChars.ToString());
                    sb.Append(currentChar);
                    currentChar = str[i];
                    noOfChars = 1;
                }
                else
                {
                    noOfChars += 1;
                }
            }

            sb.Append(noOfChars.ToString());
            sb.Append(currentChar);

            return sb.ToString();

        }
    }
}
