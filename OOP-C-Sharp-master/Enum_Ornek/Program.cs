using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci o=new Ogrenci()
            {
                ad="beytu",
                alanBilgi=(Alan)3, // I
                soyad="bayram"
            };


            Ogrenci o1 = new Ogrenci()
            {
                ad = "beyza",
                alanBilgi = Alan.sayisal,//II
                soyad = "yıldız"
            };



        }
    }
}
