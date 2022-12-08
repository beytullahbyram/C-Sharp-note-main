using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Ogrenci:TemelTip
    {
        public string bolum { get; set; }

        public int sınıf { get; set; }
        public Ogrenci()
        {
            Console.WriteLine("Ogenci constructor");
        }

    }
}
