using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = 0;

            Console.WriteLine(result);*/

            string str = Console.ReadLine();

            RunLengthEncoding rnl = new RunLengthEncoding();

            Console.WriteLine(rnl.Compress(str));


            Console.ReadLine();
        }
    }
}
