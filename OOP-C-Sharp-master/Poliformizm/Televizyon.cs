using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm
{
    internal class Televizyon:Urun
    {
        public override void EkranaYaz(string deger)
        {
            Console.WriteLine("Televizyon clasındaki override ekrana yaz methodu calıstı");

        }
    }
}
