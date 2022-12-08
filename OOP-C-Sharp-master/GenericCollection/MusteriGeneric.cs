using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class MusteriGeneric<T> //Classı generic yaptık
    {
        public T id { get; set; }
        public T musteriNo { get; set; }

        public string isim { get; set; }

        public string soyisim { get; set; }

        public DateTime dogumTarih { get; set; }

        public int MusteriNoAl()
        {
            return musteriNo;
        }







    }
}
