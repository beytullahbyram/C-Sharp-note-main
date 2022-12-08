using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For ornek1 (carpma islemi olmadan carpma yapmak)
            Console.WriteLine("1. Sayıyı Girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Girin");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc=0;
            for(int i = 0; i < sayi2; i++)
            {
                sonuc += sayi;
            }
            Console.WriteLine($"{sayi} * {sayi2} = {sonuc}");
            #endregion


            #region For ornek2 (dısardan girilen sayinin mukemmel sayi olup olmadigini bulma)
            Console.WriteLine("Mukemmel Sayıyı Girin");
            int mukemmelsayi = Convert.ToInt32(Console.ReadLine());
            int mukemmelsayisonuc = 0;
            for(int i = 1; i < mukemmelsayi; i++)
            {
                    if (mukemmelsayi % i == 0)
                    {
                        mukemmelsayisonuc += i;
                    }
            }
            if(mukemmelsayisonuc == mukemmelsayi)
            {
                Console.WriteLine($"girdiginiz sayi mukemmeldir => {mukemmelsayisonuc}    {mukemmelsayi}");
            }
            else
            {
                Console.WriteLine($"sayi mukkemel degil => {mukemmelsayi}");
            }
            #endregion


            #region For ornek3 (fibonacci)
            Console.WriteLine("Fibonacci Sayıyı Girin");
            int fibonacci = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 2; i < fibonacci;i++)
            {
                c = a + b;
                a = b;  
                b = c;  
                Console.WriteLine(c);
                    
            }
            #endregion
            #region break contiune
            Console.Clear();
            int sayac=0;
            for(; ; )
            {
                sayac++;
                if (sayac == 5) 
                {
                    continue; //dongu basına gelir
                }
                if (sayac == 3)
                {
                    break; // donguden cıkar 
                }
                Console.WriteLine(sayac);
            }
            #endregion
            #region Ornek4 (dortgen cizimi)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write("*");
                }
                for (int j = 10; j > i; j--)
                {
                    Console.Write("");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("kısa kenar Girin");
            int kkenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("uzun kenar Girin");
            int ukenar = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= kkenar; i++)
            {
                for (int j = 1; j <= ukenar; j++)
                {
                    if(i == 1 || i == kkenar)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if(j == 1 || j == ukenar)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            #endregion
            #region carpım tablosu
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Console.Write($"{i}*{j}={i*j}\t");
                }
                Console.WriteLine();
            }
            #endregion

            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            string[] cars ={ "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
