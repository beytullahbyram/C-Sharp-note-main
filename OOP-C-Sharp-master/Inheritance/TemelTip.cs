using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class TemelTip
    {
        public int id { get; set; }

        public string tcNo { get; set; }

        public string ad { get; set; }
        public string soyad { get; set; }

        public int cinsiyet { get; set; }

        public DateTime kayıtTarihi { get; set; }

        public int kayıtKullanıcı { get; set; }

        public DateTime guncellemeTarihi { get; set; }


        public int guncelleyenKullanıcı { get; set; }
        public bool silindi { get; set; }


        public void MethodTemelTip()
        {
            Console.WriteLine("temel tip sınıfındaki metot");
        }

        public TemelTip()
        {
            Console.WriteLine("TEMEL TİP CONSTRUCTOR");
        }














    }
}
