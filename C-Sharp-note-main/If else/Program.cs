using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region if else
            //int sayi =  Convert.ToInt32(Console.ReadLine());
            //if (sayi == 20)
            //{
            //    Console.WriteLine("sayi 20 ye eşit");
            //}else if (sayi == 50)
            //{
            //    Console.WriteLine("sayi 50 ye eşit");
            //}
            //else
            //{
            //    Console.WriteLine("sayi 50 ye eşit değil ");
            //}

            //short if
            //int x = 20, y = 10;
            //var result = x > y ? "x is greater than y" : "x is less than y";

            #endregion

            #region Ornekler
            Console.WriteLine("1.Notu giriniz: ");
            decimal not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Notu giriniz: ");
            decimal not2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Devamsizlik giriniz: ");
            //int devamsizlik = Convert.ToInt32(Console.ReadLine());

            int sonucc = Convert.ToInt32(not2 +not1 ) / 2;

            //var res = (Convert.ToInt32(sonucc) <= 45 ) ? "gecti" : "kaldı";


            if (sonucc <= 45)
            {
                Console.WriteLine("kaldi");

            }else if(sonucc <=70 && sonucc >=45)
            {
                Console.WriteLine("orta");
            }
            else if (sonucc <= 100 && sonucc >= 70)
            {
                Console.WriteLine("pekiyi");
            }


            var result = sonucc <= 45 ? "kaldi" : 
                Convert.ToInt32(sonucc) <= 100 && Convert.ToInt32(sonucc) >= 70 ? "pekiyi" : 
                Convert.ToInt32(sonucc) <= 70 && Convert.ToInt32(sonucc) >= 45 ? "orta" :
                "notunuzu hesaplanamadı kontrol ediniz";
            Console.WriteLine(result);

            //---------------------------------------------------

            Console.WriteLine("Sayiyi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var result2 =
                sayi % 2 == 0 && sayi > 0 ? "sayi pozitif cift sayi" :
                sayi % 2 != 0 && sayi > 0 ? "sayi pozitik tek sayi" :
                sayi % 2==0 && sayi < 0 ? "sayi negatif cift sayi ":
                sayi % 2 != 0 && sayi < 0 ? "sayi negatif tek sayi " :
                sayi == 0 ? "notr":
                "sayiyi kontrol ediniz";
            Console.WriteLine(result2);


            Console.Clear();
            //-------------------------------------------------
            Console.WriteLine("Kodu giriniz: ");
            string code=Console.ReadLine().ToUpper();

            string result3 =
                code == "AA" || code == "BB" || code == "CC" ? "Admin yetkisi" :
                code == "FF" || code == "EE" || code == "GG" ? "Standart yetki" :
                code == "DD" ? "Güclü yetki" :
                "Hatali giriş";
             Console.WriteLine(result3);



            //--------------------------------------------------
            Console.WriteLine("Kullanici adi: ");
            string kullaniciAdi = Console.ReadLine().ToLower();
            Console.WriteLine("Sifre ");
            string sifre = Console.ReadLine().ToLower();

            string result4 =
                kullaniciAdi == "admin" && sifre == "admin" ? "giris basarili" :
                kullaniciAdi != "admin" ? "kullanici adi hatali" :
                sifre != "admin" ? "sifre hatali":
                "Bilgilerinizi kontrol ediniz";
            Console.WriteLine(result4);

            //--------------------------------------------------

            Console.WriteLine("Kac adet ürün alacaksiniz ");
            int adet = Convert.ToInt32(Console.ReadLine());
            double toplam =20 * adet;


            if(adet > 5 && adet < 10)
            {
                toplam = (toplam * 0.9);
            }else if(adet >= 10)
            {
                toplam = (toplam * 0.85);
            }
            double kdv = toplam * 1.18;
            Console.WriteLine(kdv);

            //----------------------------------------------------
            Console.Clear();
            Console.WriteLine("1-toplama");
            Console.WriteLine("2-cıkarma");
            Console.WriteLine("3-carpma");
            Console.WriteLine("4-bolme");

            Console.WriteLine("seciniz : ");
            int secim = Convert.ToInt32(Console.ReadLine());

            if(secim == 1 || secim==2 || secim==3|| secim== 4)
            {

                Console.WriteLine("1.Sayiyi giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.Sayiyi giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());


                if(secim == 1)
                {
                    Console.WriteLine(sayi1 + sayi2);
                }
                else if (secim == 2)
                {
                    Console.WriteLine(sayi1 - sayi2);
                }
                else if (secim == 3)
                {
                    Console.WriteLine(sayi1 * sayi2);
                }
                else if (secim == 4)
                {
                    if(sayi2 == 0)
                    {
                        Console.WriteLine("sayi 0 olamaz");
                    }
                    Console.WriteLine((Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2)));
                }
            }
            else
            {
                Console.WriteLine("dogru secim yap");
            }


            #endregion


















        }
    }
}
