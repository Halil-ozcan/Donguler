using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
            }

            Console.WriteLine("Lütfen Bir sayı Giriniz");
            string kullaniciDeger = Console.ReadLine();

            int sayac1 = int.Parse(kullaniciDeger);

            while(sayac1 !=-1)
            {
                Console.WriteLine(sayac1);
                sayac1--;
            }


            Console.Clear();

            Console.WriteLine("Lütfen toplamak istedğiniz sayilari giriniz");
            Console.WriteLine("Not : -1 değeri işlemlerinizi durdurur.");


            int ornekKullanimToplam = 0;
            while(true)
            {
                string KullaniciGelenDeger = Console.ReadLine();
                int kullaniciDegerİnt = int.Parse(KullaniciGelenDeger);
                if(kullaniciDegerİnt < 0)
                {
                    break;
                }
                else
                {
                    ornekKullanimToplam = ornekKullanimToplam + kullaniciDegerİnt;
                }
            }

            Console.WriteLine("Toplam deger : {0}", ornekKullanimToplam);
        }
    }
}
