using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class BitTricks
    {
        //count number of bits that are set to 1
        public int countBits(int x)
        {
            int noOfBits = 0;
            uint h = (uint)x;

            while (h != 0)
            {
                noOfBits += (int)(h & 1);
                h >>= 1;
            }

            return noOfBits;
        }

        public bool isNumOdd(int x)
        {
            if((x & 1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //gets bit at position i
        public int getBit(int num, int i)
        {
            return num & (1 << i);
        }

        //set bit at position i to 1
        public int setBit(int num, int i)
        {
            return num | (1 << i);
        }

        //set the bit at position i to 0
        public int clearBit(int num, int i)
        {
            int mask = ~(1 << i);
            return num & mask;
        }

        //set all bits from MSB to position i to 0
        public int clearBitsFromMSB(int num, int i)
        {
            int mask = (1 << i) - 1;
            return num & mask;
        }

        //set all bits from position i to LSB to 0
        public int clearBitsToLSB(int num, int i)
        {
            int mask = (-1 << (i+1));
            return num & mask;
        }

        //update bit at position i with v; where v = 0 or 1
        public int updateBit(int num, int i, int v)
        {
            int mask = ~(1 << i);
            int mask2 = v << i;

            return (num & mask) | mask2;
        }
    }
}
