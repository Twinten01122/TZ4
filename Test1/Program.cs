using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZ4;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int i = 0;


            int[] f = { 8, 12, 14, 15, 120, 225, 487, 522 };

            for (i = 0; i < f.Length; i++)
            {

                string s = Numbers.Factorization(f[i]);
                Console.WriteLine(s);
            }
        }

    }
}
