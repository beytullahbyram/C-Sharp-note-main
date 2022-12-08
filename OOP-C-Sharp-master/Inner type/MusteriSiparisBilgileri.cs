using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_type
{
    internal class MusteriSiparisBilgileri
    {

        public string siparisNumarasi { get; set; }



        public Urun[] urunler;

        public MusteriSiparisBilgileri()
        {
            urunler = new Urun[2];
        }









    }
}
