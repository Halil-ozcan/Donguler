using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KullaniciGelenDeger = string.Empty;
            int kullaniciDegerİnt = 0;
            int faktoriyelHesapla = 1;

            Console.WriteLine("Lütfen Faktoriyel Hesabı Yapmak İstediğiniz değeri Yazınız");
            KullaniciGelenDeger = Console.ReadLine();

            kullaniciDegerİnt = int.Parse(KullaniciGelenDeger);

            for (int i = kullaniciDegerİnt; i > 1; i--)
            {
                faktoriyelHesapla = faktoriyelHesapla * i; 
            }
            Console.WriteLine("{0} değerinin faktoriyel Sonucu : {1}", KullaniciGelenDeger, faktoriyelHesapla);
        }
    }
}
