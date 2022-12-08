using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int => max2147483647
            int number = 456;
            Console.WriteLine(number);

            //byte0-255
            byte data = 15;
            Console.WriteLine(data);

            //sbyte => -128 +128
            sbyte no = -128;
            Console.WriteLine(no);

            //short => -32.768 + 32.767  
            short s = -30000;
            Console.WriteLine(s);

            //long => 9,223,372,036,854,775,807 
            long l = 9454646546;
            Console.WriteLine(l);

            //16byte
            decimal decimall=3.14m;
            Console.WriteLine(decimall);
            //8byte
            double doublee = 3.20d;
            Console.WriteLine(doublee);
            //4byte
            float f = 5.65f;
            Console.WriteLine(f);

            //boolen => true || false
            Boolean cevap=true;
            Console.WriteLine(cevap);

            //char => tek karakter /*-+,abcde...,0123..9
            char tekHarf = 'a';
            Console.WriteLine(tekHarf);

            //datetime => tarih 
            DateTime tarih= DateTime.Now;
            Console.WriteLine(tarih.ToString());



            string yas;
            Console.WriteLine("yasinizi giriniz\n\n\n"+"\n");
            yas = Console.ReadLine(); //alınan her bilgi string bir ifadedir.
            Console.WriteLine("yasiniz: "+yas);

            Console.ReadLine(); 
           }

    }
}
