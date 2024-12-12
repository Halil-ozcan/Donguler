using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusuAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahminAdet = 1;
            int sistemdekiSayi = 0;
            Random rd = new Random();
            sistemdekiSayi = rd.Next(1, 10);

            while(true)
            {
                Console.Write("{0} . deneme Lütfen sistemin Üretmiş olduğu sayıyı Tahmin ediniz : ", tahminAdet);
                string rdmKullaniciGelen = Console.ReadLine();

                int rdmKullaniciGelenİnt = int.Parse(rdmKullaniciGelen);

                if (rdmKullaniciGelenİnt == sistemdekiSayi)
                {
                    tahminAdet++;
                    Console.WriteLine("{0}. denemenizde Buldunuz. Tebrikler", tahminAdet);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0}. denemeniz Tahmin edemediniz Lütfen Tekrar Deneyiniz", tahminAdet);
                    tahminAdet++;
                }
            }
        }
    }
}
