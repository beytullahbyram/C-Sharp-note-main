using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1 Emeklilik hesaplama
            Console.WriteLine("Cinsiyet giriniz (E veya K): ");
            char cinsiyet=Convert.ToChar(Console.ReadLine().Trim().ToUpper());
            Console.WriteLine("Yasinizi giriniz : ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maas giriniz: ");
            int maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prim giriniz : ");
            int prim = Convert.ToInt32(Console.ReadLine());
            int ikramiye = 0;
            switch (cinsiyet)
            {
                case 'E':
                    if(yas >= 60)
                    {
                        Console.WriteLine($"{ikramiye = maas * 10} ikramiye ile emekli oldunuz");
                    }
                    else
                    {
                        if(prim >= 6000)
                        {
                            Console.WriteLine($"{ikramiye = maas * 10} ikramiye ile emekli oldunuz");
                        }
                        else
                        {
                            Console.WriteLine("Emekli olmadiniz");
                        }
                    }
                    break;
                case 'K':
                    if (yas >= 58)
                    {
                        Console.WriteLine($"{       ikramiye = maas * 10} ikramiye ile emekli oldunuz");
                    }
                    else
                    {
                        if (prim >= 5600)
                        {
                            Console.WriteLine($"{ikramiye = maas *11} ikramiye ile emekli oldunuz");
                        }
                        else
                        {
                            Console.WriteLine("Emekli olmadiniz");
                        }
                    }
                    break;
                default: Console.WriteLine("Hesaplamanamadi");
                    break;
            }
            #endregion

            #region Ornek2 İki adet sayı girip istediğimiz islemi yaptırmak
            Console.Clear();
            char islem, cevap; //Char veri tipi tek karakter alır ve kullanılırken '' ile kullanılır.
            int sayi1, sayi2;
            do
            {
                    Console.WriteLine("Yapmak istediğiniz islemi giriniz (+ - * /):");
                    islem=Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("1.Sayiyi giriniz: ");
                    sayi1 =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2.Sayiyi giriniz: ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    switch (islem)
                    {
                        case '/':
                            Console.WriteLine($"isleminiz => {sayi1 / sayi2}");
                            break;
                        case '+':
                            Console.WriteLine($"isleminiz => {sayi1 + sayi2}");
                            break;
                        case '-':
                            Console.WriteLine($"isleminiz => {sayi1 - sayi2}");
                            break;
                        case '*':
                            Console.WriteLine($"isleminiz => {sayi1 * sayi2}");
                            break;
                        default : Console.WriteLine("Hic bir islem yapilamadı");
                            break;
                    }
                    Console.WriteLine("Cikmak icin (E/H)");
                    cevap = Convert.ToChar(Console.ReadLine().Trim().ToUpper());
                    //Trim başında ve sonundaki boşlukları siler.
                    //ToUpper cevabı büyük harfe dönüştürür.
            } while (cevap == 'E');
            #endregion
            
            #region Ornek3 do while ile faktöriyel hesaplama
            Console.Clear() ;
            Console.WriteLine("Faktöriyel hesabı yapılacak sayiyi giriniz");
            int fac=Convert.ToInt32(Console.ReadLine());
            int result = 1;
            do
            {
                result *= fac--; // ==>> result = result * fac-- 
            } while ((fac > 0 ));
            Console.WriteLine($"Sonucunuz => {result}");
            #endregion

            #region Ornek4 do while ile faktöriyel hesaplama v2 (biz hayır diyene kadar bizden sayı isteyip faktöriyelini hesaplasın)
            Console.Clear();


            #endregion
        }
    }
}
