using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class StringCompression
    {
        public int Compress(char[] chars)
        {

            char currentChar = chars[0];
            int noOfChars = 1;

            int lengthOfCompressed = 0;

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] != currentChar)
                {
                    lengthOfCompressed = computeCompression(chars, currentChar, noOfChars, lengthOfCompressed);
                    currentChar = chars[i];
                    noOfChars = 1;
                }
                else
                {
                    noOfChars += 1;
                }
            }

            lengthOfCompressed = computeCompression(chars, currentChar, noOfChars, lengthOfCompressed);

            return lengthOfCompressed;

        }


        public int computeCompression(char[] chars, char currentChar, int noOfChars, int lengthOfCompressed)
        {

            if (noOfChars > 1)
            {
                chars[lengthOfCompressed] = currentChar;
                lengthOfCompressed += 1;

                string noOfCharsStr = noOfChars.ToString();

                for (int i = 0; i < noOfCharsStr.Length; i++)
                {
                    chars[lengthOfCompressed] = noOfCharsStr[i];
                    lengthOfCompressed += 1;
                }

            }
            else
            {
                chars[lengthOfCompressed] = currentChar;
                lengthOfCompressed += 1;
            }


            return lengthOfCompressed;
        }
    }
}
