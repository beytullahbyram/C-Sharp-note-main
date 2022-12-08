using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REF_ve_OUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //REF VE OUT
           
            int  sayi = 0;
            degerAta(ref sayi);
            //refte değişkenin bir değeri olması lazım 
            //sayi değişkeni artık 10 değerindedir 

            int outsayi;
            //outda değişkenin bir değeri olmasa bile out kabul eder
            degerAtaOut(out outsayi);  
            
        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }

        static void degerAtaOut(out int gelenDeger)
        {
            gelenDeger = 100;
        }
    }
}
