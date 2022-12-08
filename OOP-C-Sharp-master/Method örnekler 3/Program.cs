using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Method_örnekler_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            // Dışarıdan girilen sayının tek mi çift mi olduğunu bulan methodu yazın.

            // I
            string sayi = Console.ReadLine();
            Console.WriteLine($"sayi = > {TekCiftStr(sayi)}");
            // II
            int sayiInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"sayi cift mi ?  = > {TekCiftBool(sayiInt)}");
            #endregion

            
            #region Örnek 2
            //Girilen 2 sayıdan hangisinin büyük olduğunun cevabını verecek
            int sayiInt2 = Convert.ToInt32(Console.ReadLine());
            int sayiInt3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Sonuc { BuyukKucuk(sayiInt2,sayiInt3) }");

            int sonuc = BuyukKucukInt(sayiInt2, sayiInt3);
            string sonucStr = (sonuc == 0) ? "Sonuc sifirdir" : ($"{sonuc} Sayisi büyüktür ");
            Console.WriteLine(sonucStr);
            #endregion


            #region Örnek 3
            //Girilen fiyat ve indirim oranına göre malın fiyatını hesaplayan(kdv ekle) methodu yazın
            //Girilen 2 sayıdan hangisinin büyük olduğunun cevabını verecek
            Console.WriteLine("Fiyat gir");
            int fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İndirim gir");
            int indirim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sonuc => { FiyatHesapla(fiyat,indirim) } ");

            #endregion

            #region Örnek 4
            //Bir ücgenin kenar bilgilerini girin. eşkenar çeşitkenar ikizkenar olup olmadığını söyleyen methodu yazın

            Console.WriteLine("Sırayla kenar uzunluklarını giriniz => ");
            int k1=Convert.ToInt32(Console.ReadLine());
            int k2 = Convert.ToInt32(Console.ReadLine());
            int k3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ücgen ceşidi =>  {UcgenHesap(k1,k2,k3)}  ");

            #endregion


            #region Örnek 5

            //10 adet random sayıyı bir diziye atın sonra bu diziyi methoda gönderin bu method bu sayıların ortalamasını bulsun ve geriye ortalamayı döndürsün

            Random rnd=new Random();

            int[] randomSayilar=new int[10];

            for (int i = 0; i < randomSayilar.Length; i++)
            {
                randomSayilar[i] = rnd.Next(1, 1000);
                Console.WriteLine(randomSayilar[i]);
            }

            Console.WriteLine($"Sayiların ortalaması {RandomOrtalamaHesaplama(randomSayilar)}");

            #endregion

            
            #region Örnek 6
            //Dışarıdan giriln sayıyı methoda gönderip faktöriyeli hesaplansın

            Console.WriteLine("Faktöriyel için sayı giriniz");
            int fact=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sonuc => {FactHesap(fact)}   Girdiğiniz sayı asal mı => {AsalHesapla(fact)}");

            #endregion


            #region Örnek 7

            //10 adet random sayıyı dizeye at methoda gönder. bu method tek sayıları bulup bir diziye atıp geriye bu diziyi göndersin ekrana bu tek sayıları göndersin ve yazalım bu yazma işlemini baska bir method yapsın

            Console.Clear();
            Random rnd1 = new Random();

            int[] randomSayilar1 = new int[10];

            for (int i = 0; i < randomSayilar1.Length; i++)
            {
                randomSayilar1[i] = rnd1.Next(1, 10);
                Console.WriteLine(randomSayilar1[i]);
            }
            
            Console.WriteLine("Tek sayıları filtreleme ------");
            TekSayiYazdir(RandomTekSayi(randomSayilar1));

            #endregion


        }
        #region Örnek 1
        // I
        static string TekCiftStr(string sayi)
        {
            string cevap = "";
            if (Convert.ToInt32(sayi) % 2 == 0)
                cevap = "cift";
            else 
                cevap = "tek";
            return cevap;
        }
        // II
        static bool TekCiftBool(int sayi)
        {
            bool cevap;
            if (sayi % 2 == 0) return cevap = true;
            else return cevap = false;
        }
        #endregion
        
        
        #region Örnek 2
        // I
        static string BuyukKucuk(int x, int y){
            string mesaj= "";
            if (x < y) mesaj = $"{y} sayisi daha büyük";

            else mesaj = $"{x} sayisi daha büyük";

            return mesaj;   
        
        }


        // II
        static int BuyukKucukInt(int x, int y)
        {
            if (x < y)  return y;

            else if (x==y) return 0;

            else return x;

        }
        #endregion

        
        #region Örnek 3
        static double FiyatHesapla(double fiyat, double indirim)
        {
            double sonuc=fiyat - ( (fiyat * (indirim / 100)));
            return sonuc + (sonuc * 0.18);
            //return (fiyat * ((100 - indirim) / 100)) + ( (18 / 100));
        }
        #endregion


        #region Örnek 4
        static string UcgenHesap(int k1,int k2,int k3)
        {
            string ucgenSonuc = ""; // string ucgenSonuc=string.Empty;

            if(k1 == k2 && k2 == k3) ucgenSonuc = "Eşkenar ücgendir";

            else if(k1 == k3  || k1 == k2 || k3 == k2) ucgenSonuc = "İkizkenar ücgendir";

            else if (k1 != k2 && k2 != k3 && k1 != k3) ucgenSonuc = "Çeşitkenar ücgendir";

            return ucgenSonuc;

        }
        #endregion


        #region Örnek 5
        static double RandomOrtalamaHesaplama(int[] RandomSayilar)
        {
            double sonuc = 0;
            foreach (var item in RandomSayilar)
            {
                sonuc += item;
            }
            return  sonuc /10;
        }

        #endregion

        
        #region Örnek 6
        static int FactHesap(int sayi)
        {
            int sonuc = 1;
            for(int i = 1; i <= sayi; i++) sonuc *= i;
            return sonuc;
        }
        static bool AsalHesapla(int sayi)
        {
  
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) return false;
            }

            return true;

        }
        #endregion

        s
        #region Örnek 7
        static int[] RandomTekSayi(int[] randomSayilar)
        {
            int[] TekSayilar=new int[10];

            for (int i = 0; i < randomSayilar.Length; i++)
            {
                if(randomSayilar[i] %2 != 0)
                {
                    TekSayilar[i]=randomSayilar[i];
                }
            }

            return TekSayilar;

        }

        static void TekSayiYazdir(int[] TekSayilar)
        {
            foreach (var item in TekSayilar)
            {
                if (item != 0) Console.WriteLine(item);
            }
        }
        #endregion

    }
}
