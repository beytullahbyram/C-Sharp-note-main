using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //sealed kalıtım yapmayı durdurur.egitmen sınıfı artık kalıtım yapamaz
    sealed class Egitmen : Personel
    {

        public string brans { get; set; }


        public void egitmenMetot()
        {
            MethodTemelTip();
            
        }
        public Egitmen()
        {
            Console.WriteLine("Egitmen contructor");
        }

        







    }
}
