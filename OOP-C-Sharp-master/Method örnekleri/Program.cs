using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_örnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir öğrencinin 3 notu girip ortalamayı hesapla ve bnunu ekrana yazdır.
             */
            Console.WriteLine("Notları giriniz:");
            int not1 = Convert.ToInt32(Console.ReadLine());
            int not2 = Convert.ToInt32(Console.ReadLine());
            int not3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(OrtHesap(not1,not2,not3));
            OrtDegerlendirme(OrtHesap(not1,not2,not3));
        }

        static int OrtHesap(int n1,int n2, int n3)
        {
            return (n1 + n2 + n3) / 3;
        }
        static void OrtDegerlendirme(int ort)
        {
            if (ort >= 50) Console.WriteLine("Gectin"); else Console.WriteLine("Kaldin");
        }
    }
}
