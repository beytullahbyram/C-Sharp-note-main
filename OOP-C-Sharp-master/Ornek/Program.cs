using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisiklet_Kiralama
{
     internal class Program
    {
        static void Main(string[] args)
        {
            /*
             bisiklet,kullanıcı, kiralama
                su kadar sure binildi ucret tutarı
            baslangıc suresi
            bitis suresi

            kirayı baslat 
            kiralamayı bitir
            ucreti hesapla 
            yazdır

            marka model vites sayısı renk
            isim soyisim no
            süre baslangıc bitis kiralanan bisiklet, kirayalan bir kullanıcı
             */

            Bisiklet bisiklet = new Bisiklet()
            {
                marka = "abc",
                model="yaris",
                renk="mavi",
                vites=21
            };

            Bisiklet bisiklet2 = new Bisiklet()
            {
                marka = "xyz",
                model = "gunluk",
                renk = "siyah",
                vites = 18
            };

            Kullanıcı kullanıcı = new Kullanıcı()
            { 
                Name ="Beytullah",
                SurName = "bayram",
                No="05384735197"
            };

            Kullanıcı kullanıcı2 = new Kullanıcı()
            {
                Name = "ahmet",
                SurName = "kilic",
                No = "0512321321"
            };
            Kiralama k = new Kiralama();
            k.kullanıcı = kullanıcı;
            k.baslat();
            System.Threading.Thread.Sleep(1000);
            k.bitir();
            //Kiralama.Kirala(kullanıcı, bisiklet);


        }
    }
}
