using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    //Site: LeetCode
    //Category: Top Interview Questions
    //Difficulty: Medium
    class StringToIntegerAtoi
    {
        public int MyAtoi(string str)
        {

            double result = 0;
            char sign = ' ';
            bool seenChar = false;

            if (str == "")
            {
                return (int)result;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {

                    if ((str[i] != '+') && (str[i] != '-') && (!char.IsDigit(str[i])))
                    {
                        break;
                    }
                    else if ((str[i] == '+') || (str[i] == '-'))
                    {
                        if ((sign != ' ') || (seenChar == true))
                        {
                            break;
                        }
                        else
                        {
                            sign = str[i];
                        }
                    }
                    else
                    {
                        result = (result * 10) + (double)Char.GetNumericValue(str[i]);
                    }

                    seenChar = true;
                }
                else if (seenChar == true)
                {
                    break;
                }
            }

            return validateResult(result, sign);
        }

        public int validateResult(double result, char sign)
        {
            if (result == 0)
            {
                return (int)result;
            }

            if (sign == '-')
            {
                result = -1 * result;
            }

            if (result > Int32.MaxValue)
            {
                result = Int32.MaxValue;
            }
            else if (result < Int32.MinValue)
            {
                result = Int32.MinValue;
            }


            return (int)result;

        }
    }
}
