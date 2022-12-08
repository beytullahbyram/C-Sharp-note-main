using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemelTip temelTip = new TemelTip();
            temelTip.ad = "Beytullah";
            temelTip.MethodTemelTip();

            Egitmen egitmen = new Egitmen();
            egitmen.ad = "";
            egitmen.brans = "Yazılım";
            egitmen.egitmenMetot();
            
            
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.sınıf = 203;
            ogrenci.bolum = "Full stack";



            TemelTip temelTip1;
            temelTip1 = egitmen; //temel tip object görevi görür. //boxing
            egitmen = (Egitmen)temelTip;                        //unboxing
            temelTip1= ogrenci; 
















        }
    }
}

