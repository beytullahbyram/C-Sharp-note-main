using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sekil adında abs class olacak
            //daire,dortgen ve ucgen sınıflarımız olacak
            //bu classlarda alan ve cevre hesabı yapan metotlar olacak
            //bu classlar abs classdan kalıtılacak
            //sekil abs classında da sekilad field olacak
            //bu sekil sekil adını ekrana yazan bir metot olacak
            
            Daire daire = new Daire();
            daire.yariCap = 5;
            daire.Alan();
            daire.Cevre();


            Dortgen dortgen= new Dortgen();
            dortgen.taban = 10;
            dortgen.yukseklik = 10; 
            dortgen.kısa=10;
            dortgen.uzun=10;
            dortgen.Alan();
            dortgen.Cevre();

        }
    }
}
