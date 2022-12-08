using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar___Class
{
    internal class Musteri_Customer
    {
        //public her yerden erişilebilir
        //private sadece o classdan erişilebilir

        public string tcNo, isim, soyisim;
        public int  cinsiyet;

        
        private void mesaj()
        {
            cinsiyet = 0;
        }
        
        public void publicmethod()
        {
            tcNo = "123456789";
        }

        public bool musteriControl()
        {
            bool kontrol = true;
            dbKontrol(tcNo); // m1 üzerinden tanımladığımız için m1 tcNo bilgisi bu parametreye geldi
            //if(tcno == null)
            //{
            //    kontrol = false;
            //}
            return kontrol;

        }

        public bool dbKontrol(string tcno)
        {
            bool kontrol = true;    
            //işlemler
            return kontrol; 
        }

    }
}
