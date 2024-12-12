using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ic_Ice_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int y = 1; y <= 9; y++)
                {
                    int carpimSonuc = i * y;
                    Console.Write("{0}*{1}={2}\t", i, y, carpimSonuc);
                }
                Console.WriteLine();
            }

        }
    }
}
