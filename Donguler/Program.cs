using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i + ". tekrar !");
            }

            for(int sayac = 1; sayac<=100; sayac++)
            {
                if(sayac % 2 == 0)
                {
                    Console.WriteLine(sayac + " - çift Sayıdır.");
                }
            }

            int toplam = 0;
            for(int sayac = 1; sayac<=100; sayac++)
            {
                if(sayac % 2 == 0)
                {
                    toplam = toplam + sayac;
                }
            }
            Console.WriteLine("toplam : {0}", toplam);
        }
    }
}
