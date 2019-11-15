using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class CountPrimes
    {
        //Site: LeetCode
        //Category: Top Interview Questions
        //Difficulty: Easy
        public int countPrimes(int n)
        {
            //using the concept of sieve of erathesthones

            int primes = 0;
            bool[] numbers = new bool[n];

            // Loop's ending condition is i * i < n instead of i < sqrt(n)
            // to avoid repeatedly calling an expensive function sqrt().
            for (int i = 2; (i*i) < n; i++)
            {
                if (numbers[i] == false)
                {
                    for (int j = (i * i); j < n; j += i)
                    {
                        numbers[j] = true;
                    }
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (numbers[i] == false)
                    primes += 1;
            }
            return primes;
        }

    }
}
