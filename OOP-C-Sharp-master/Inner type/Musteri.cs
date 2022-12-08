using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_type
{
    internal class Musteri
    {
        public int musteriID { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarihi { get; set; }



        public MusteriAdres[] musteriAdresleri;
        public MusteriIletisim[] musteriIletisimBilgileri;
        public MusteriSiparisBilgileri[] musteriSiparisBilgileri;   

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[3];
            musteriIletisimBilgileri= new MusteriIletisim[3];
            musteriSiparisBilgileri=new MusteriSiparisBilgileri[10];
        }




    }
}
