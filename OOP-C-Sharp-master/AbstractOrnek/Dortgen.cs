using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal class Dortgen : Sekil
    {



        public int taban { get; set; }
        public int yukseklik { get; set; }
        public int uzun{ get; set; }
        public int kısa{ get; set; }
        private string _sekilad;
        public override string sekilad
        { 
            get { return _sekilad; }
            set { _sekilad = value; }
        }

        public Dortgen()
        {
            this.sekilad = "Dörtgen";
        }
        public override void Alan()
        {
            Yazdir();
            double alan = taban * yukseklik;
            Console.WriteLine($"Daire alanı {alan}");
        }

        public override void Cevre()
        {
            double cevre = 2 * (uzun + kısa);
            Console.WriteLine($"Daire alanı {cevre}");


        }
    }
}
