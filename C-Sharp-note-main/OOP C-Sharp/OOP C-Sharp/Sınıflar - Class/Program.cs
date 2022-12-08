using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar___Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------

            Musteri_Customer m1 =new Musteri_Customer();
            m1.tcNo = "1234567";

            Console.WriteLine(m1.musteriControl());
            //--------------------------------------------
            Console.WriteLine("sayi gir");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Dort_Islem dort_Islem = new Dort_Islem();
            dort_Islem.toplam(sayi1, sayi2);
            //--------------------------------------------

            Arac arac1 = new Arac();
            arac1.marka = "honda";
            arac1.model = "civic";
            arac1.yıl = "2022";
            arac1.yakıt = "benzin";
            arac1.vites= "otomatik";
            arac1.alıs = 200000;
            arac1.satıs= 250000;
            arac1.indirim = 2500;
            arac1.km = 20000;
            
            arac1.FiyatAta(6000000);//Müşterinin almak istediği fiyat parametre olarak girilir.
            
            Arac arac2 = new Arac("opel","astra",2003);
            arac2.yıl = "2010";
            arac2.yakıt = "lpd";
            arac2.vites = "vites";
            arac2.alıs = 300000;
            arac2.satıs = 450000;
            arac2.indirim = 5500;
            arac2.BilgiYazdir();
            arac2.FiyatAta(20);



            //-----------------------------------
            Console.Clear();
            Ogrenci ogr1=new Ogrenci();

            //  ogr1.id = 5; hata verir cünkü değer atama engellendi


            //1.deger ataması yapılmasın ama değer okunabilsin
            Console.WriteLine(ogr1.id);

            //2.deger atama yapılsın ama değer okunmasın
            ogr1.Sifre = "sdfsd";
            //Console.WriteLine(ogr1.Sifre);//Hata verir cünkü geti kapadık

            //3.deger ataması yapılsın ama değerin ilk 4 hanesi görüntülensin 
            ogr1.tcNo = "12345678911";
            Console.WriteLine(ogr1.tcNo);


            //4. ad soyad girilsin ve email olustursun. email değişkeni set edilemesin.
            ogr1.ad = "beytu";
            ogr1.soyad = "bayram"; //bunlar girilince arka tarafda ad.soyad@hotmail.com
            //ogr1.emailAdress = "asdf";//set edilemesin ama email adres olussun ve yazılsın 
            Console.WriteLine(ogr1.emailAdress);

        }
    }

}
