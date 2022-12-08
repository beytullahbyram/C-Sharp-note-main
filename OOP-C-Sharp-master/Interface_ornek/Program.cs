using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //interface içinde dort işlem metotları olacak
            //bir class içinde o interface iplement edilecek ve içinde işlemler barınacak
            Islem islem=new Islem();
            islem.number1 = 10;
            islem.number2 = 20;
            islem.topla(islem.number1,islem.number2);
        }
    }
}
