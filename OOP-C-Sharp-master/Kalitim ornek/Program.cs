using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_ornek
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             *   ürünün alıs fiyatı 0 dan kücük olamaz
             *   satış fiyati alıs fiyatından kücük olamaz
             *   kampanya fiyatı alıs fiyatından kücük olamaz
             *   
             *   
             *   id random sayı atılsın giriş yapılmasın
             *   
             */
            

            Bilgisayar b=new Bilgisayar();
            b.ram = "16";
            b.marka = "dell";
            b.alisFiyati = 100; //0 ve alıs fiyatı olamaz
            b.satisFiyati = 90;
            b.kampanyaFiyat = 90;
            b.barkod = "abbb";

            Bilgisayar b2=new Bilgisayar();
            b2.barkod = "b";


            Televizyon televizyon = new Televizyon();
            televizyon.barkod = "c";

            Televizyon televizyon1 = new Televizyon();
            televizyon1.barkod = "c";

            Televizyon televizyon12 = new Televizyon();
            televizyon12.barkod = "cd";

            DataBase.urunEkle(b);
            DataBase.urunEkle(b2);
            DataBase.urunEkle(televizyon);
            DataBase.urunEkle(televizyon1);
            DataBase.urunEkle(televizyon12);

            DataBase.UrunYazdir(DataBase.db);

        }
    }
}
