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
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            Console.Clear();
        }
    }
}
