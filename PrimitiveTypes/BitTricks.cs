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
    }
}
