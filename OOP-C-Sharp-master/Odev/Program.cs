using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             urun class 
            urunıd, urunkodu, urunadi, urunacıklamasi,

            10 adet ürün adı ve acıklaması girilecek
            urunıd=1,2,4,5,6 vb.  urunkod=a1,a2,a3,a4... vb

            sadece ad ve acıklama girilecek 
            bunlar bir arrayliste atıplıp ekranda yazdırılacak
             */


            //----------------------------------

            //I
            for (int i = 0; i < 3; i++)
            {
                Urun u = new Urun();
                Console.WriteLine("urun adı gir");
                u.urunAdi=Console.ReadLine();
                Console.WriteLine("urun acıklama gir");
                u.urunAck = Console.ReadLine();
                u.UrunEkle(u);
            
            }
            Urun.UrunYazdir2();









            //----------------------------------
            //II
            //List<Urun> urunListesi = new List<Urun>();

            //for (int i = 1; i < 3; i++)
            //{
            //    Urun urun = new Urun();
            //    urun.urunid = i;
            //    urun.urunkod = i.ToString();
            //    Console.WriteLine("ısmi gir");
            //    urun.urunismi = Console.ReadLine();

            //    Console.WriteLine("bilgi gir");
            //    urun.urunbilgi = Console.ReadLine();
            //    urunListesi.Add(urun);
            //}


            //foreach (var item in urunListesi)
            //{
            //    Console.WriteLine("isim " + item.urunismi);
            //    Console.WriteLine("bilgi " + item.urunbilgi);
            //    Console.WriteLine("id " + item.urunid);
            //    Console.WriteLine("kod " + item.urunkod);

            //}

        }
    }
}
