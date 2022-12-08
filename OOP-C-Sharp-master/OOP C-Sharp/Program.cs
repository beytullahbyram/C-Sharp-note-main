using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("adını gir");
            string  ad =Console.ReadLine();

            //ArrayList isimler =new ArrayList();
            //isimler.Add(ad);

            SortedList liste = new SortedList();   
            liste.Add("isim",ad);

            Mesaj2(liste);

            Console.WriteLine("2 adet sayı gir");
            int s1=Convert.ToInt32(Console.ReadLine());
            int s2= Convert.ToInt32(Console.ReadLine());

            Mesaj(s1,s2);


        }
        //[erişim belirleyici]  [geri dönüş tipi] [metod adı] (varsa parametre)
        //Metod tanımlama yukarıdaki gibi gerçekleşir
        public static void Mesaj(int s1,int s2)
        {
            Console.WriteLine($" sonuc =>>> {s1 +s2}");
            Console.WriteLine("2 adet sayı gir");
            int s11 = Convert.ToInt32(Console.ReadLine());
            int s22 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" carpma sonuc  "+Carpma(s11,s22));
            int Carpma(int s111, int s222)
            {
                return s111 * s222;
            }
        }

        private static void Mesaj2(SortedList ad)
        {
            foreach (var item in ad)
            {
                Console.WriteLine($"Hosgeldin {item} private method");

            }
        }
    }
}



