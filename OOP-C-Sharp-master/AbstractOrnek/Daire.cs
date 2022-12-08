using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal class Daire : Sekil
    {

        public double yariCap { get; set; }

        private string _sekilad;
        public override string sekilad { //implement ettik
            get { return _sekilad; } 
            set { _sekilad = value; }
        }

        public Daire()
        {
            this.sekilad = "daire";//this bu classtaki degiskeni temsil eder// 
            //base.sekilad = "daire";//base tanımlandıgı yeri gosteriyotr

        }
        public override void Alan()
        {
            Yazdir();
            double  alan= (Math.Pow(yariCap,2)) * 3.14f;
            Console.WriteLine($"Daire alanı {alan}");
        }

        public override void Cevre()
        {
            double cevre = yariCap * 2 * 3.14f;
            Console.WriteLine($"Daire cevresi {cevre}");

        }
    }
}
