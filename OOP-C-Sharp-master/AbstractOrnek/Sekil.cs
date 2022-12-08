using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal abstract class Sekil
    {
        public abstract string sekilad { get; set; } //property abstract tanımlanabilir //abstract yaptık ve sonrasında kullanacagımız zaman implement edip get ve set işlemlerini yazmalıyız

        //public abstract int deger;//field abstract yapılamazlar
        public void Yazdir()
        {
            Console.WriteLine("sekil adı=>>"+sekilad);
        }

        public abstract void Alan();
        public abstract void Cevre();


    }
}
