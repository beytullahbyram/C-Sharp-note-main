using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisiklet_Kiralama
{
    public class Kiralama
    {

        public int id { get; set; }
        public  float sure { get; set; }
        public  DateTime baslangıc { get; set; }
        public  DateTime bitis { get; set; }
        public string kiralananBisiklet { get; set; }
        public string kiralayanKullanıcı { get; set; }
        public  float ucret { get; set; }

        public  Kullanıcı kullanıcı;


        public  void baslat()
        {
            baslangıc = DateTime.Now;   
        }

        public  void bitir()
        {
            bitis= DateTime.Now;
            UcretHesapla();
        }

        private  void UcretHesapla()
        {
            TimeSpan zaman= bitis - baslangıc;
            sure = zaman.Seconds;
            ucret = 0.9f * sure;
            Console.WriteLine($"sayin { kullanıcı.Name } {kullanıcı.SurName}  {sure} sn kullanım sureniz icin odenecek tutar => {ucret}");
        }

        //public static void Kirala(Kullanıcı k,Bisiklet b)
        //{
        //    baslangıc = DateTime.Now;
        //    System.Threading.Thread.Sleep(5000);



        //    bitis=DateTime.Now;
        //    sure = baslangıc - bitis;
        //    UcretHesap(baslangıc,bitis);
        //}

        //public static int UcretHesap(DateTime baslangıc,DateTime bitis)
        //{
        //    return 2;
        //}

    }
}
