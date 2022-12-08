using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Ornek1 (girdigin 10 adet sayinin toplamını bulma)
            Console.WriteLine("sayiyi giriniz:");
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam = toplam + Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(toplam);
            #endregion

            int toplam2 = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 8 == 0)
                {
                    toplam2 = toplam2 + i;
                }
            }
            Console.WriteLine(toplam2);


            //Console.Clear();
            //Console.WriteLine("sayiyi giriniz:");
            //int fac=Convert.ToInt32(Console.ReadLine());
            //int toplam3 = 1;
            //for (int i = fac; i > 1;i--)
            //{
            //        toplam3 = toplam3 * i;

            //}
            //Console.Write(toplam3);

            //----------------------------------


            //Console.Clear();
            //Console.WriteLine("sayiyi giriniz:");
            //int alinansayi = Convert.ToInt32(Console.ReadLine());
            //int toplam4 = 1;
            //for (int i = 1; i <=alinansayi; i++)
            //{
            //    if(i % 2 !=0 || i % 3 != 0)
            //    {
            //        toplam4 = toplam4 + i;  
            //    }

            //}
            //Console.Write(toplam4);


            #region For Ornek4 (asal sayi bulma)
            int sayac = 0;
            Console.WriteLine("Sayıyı Girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            }
            #endregion


        }
    }
}