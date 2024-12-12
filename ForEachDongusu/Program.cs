using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new[] { "Halil Özcan", "Hakan Baytar", "Cemal kamçı", "Ezgi Topçu" };

            foreach(var item in isimler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
