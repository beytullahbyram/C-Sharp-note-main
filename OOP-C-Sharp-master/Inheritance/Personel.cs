using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Personel:TemelTip
    {

        public DateTime iseBaslamaTarihi { get; set; }
        public DateTime isBitisTarihi { get; set; }

        public int izinGunSayisi { get; set; }
        
        protected void PersonelMetot()
        {
            Console.WriteLine("personel metot");
        }

      public Personel()
        {
            Console.WriteLine("personel constructor");
        }





    }
}
