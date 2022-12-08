using ConsoleApp1;
using System;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogr=new ogrenci();
            ogr.Ad = "Beytullah";
            ogr.Soyad= "Bayram";
            
            
            ogr.Test();//Nesne üzerinden erişildi

            Console.WriteLine(ogr.Ad);
            Console.WriteLine(ogr.Soyad);

            ogrenci.Mesaj();//Class üzerinden erişildi


            //ogrenci ogr2 = new ogrenci();
            //ogr2.Ad = "";
            //ogr2.Soyad = "";
            //ogr.Test();

            //ogrenci.Mesaj();


            //Static olan metotlardan yalnızca static olan metotlar çağırılabilir
            //Static olmayan metotlardan static olan metotlarda çağırılabilir
            //Static class, static field, static metot olusturulabilir 


            //----------------------------------
            Console.Clear();

            SanalDatabase sb = new SanalDatabase();
            sb.yeniKayit(65);
            sb.yeniKayit(11);
            sb.yeniKayit(22);

            SanalDatabase sb1 = new SanalDatabase();
            sb1.yeniKayit(223);
            sb1.yeniKayit(2233);
            sb1.yeniKayit(223312);



            //----------------------------------
            Musteri m1=new Musteri();
            m1.musteriID = 1;
            m1.isim="beytu";
            m1.soyisim = "ddddddddddddddddd";
            m1.emailAdres = "beytu@hotmail";
            m1.sifre= "beytu@hotmail";
            m1.kullanıcıAdi= "beytubayrammm";

            Musteri.MusteriEkle(m1);


            Musteri m2 = new Musteri();
            m2.musteriID = 1;
            m2.isim = "beytu";
            m2.soyisim = "cccccccccccccccccc";
            m2.emailAdres = "bbbbbbbbbbbbbbbbbbbb";
            m2.sifre = "beytu@hotmail";
            m2.kullanıcıAdi = "asdfasfdsa";
            Musteri.MusteriEkle(m2);


            Musteri m3 = new Musteri();
            m3.musteriID = 1;
            m3.isim = "beytu";
            m3.soyisim = "bbbbbbbbbbbbbbbbbbbb";
            m3.emailAdres = "bbbbbbbbbbbbbbbbbbbb";
            m3.sifre = "beytu@hotmail";
            m3.kullanıcıAdi = "deneme";

            Musteri.MusteriEkle(m3);



            Musteri m4 = new Musteri();
            m4.musteriID = 1;
            m4.isim = "aaaaaaaaaaaaaaaaaaaa";
            m4.soyisim = "bayram";
            m4.emailAdres = "aaaaaaaaaaaaaaaaaaaaaaaa";
            m4.sifre = "beytu@hotmail";
            m4.kullanıcıAdi = "aa";

            Musteri.MusteriEkle(m4);

        }
    }
}