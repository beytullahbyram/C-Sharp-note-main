using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticler
{
    class ogrenci
    {
        private string _ad;
        private string _soyad;
        
        public string Ad 
        {
            get { return _ad.ToUpper(); } //1.yol
            set { _ad = value; } 
        }


        public  string Soyad 
        {
            get { return _soyad; }
            set { _soyad = value.ToUpper(); }//2.yol
        }
        public static void Mesaj()
        {
            Console.WriteLine("Class üzerinden erişildi");
        }
        public void Test()
        {
            Console.WriteLine("Nesne üzerinden erişildi ");
        }

        
        static ogrenci()
        {
            Console.WriteLine("Yalnızca bir kez calısır static ctor");
        }
        public ogrenci()
        {
            Console.WriteLine("Her nesne olusunca calısan standart ctor");

        }
    }
}
