using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar___Class
{
    internal class Dort_Islem
    {

         public void toplam(int s1, int s2)
         {
             yazdir(s1 + s2);
         }

         private void yazdir(int sonuc)
         {
            Console.WriteLine($"Sonuc => {sonuc}");
         }

    }
}
