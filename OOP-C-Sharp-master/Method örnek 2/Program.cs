using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_örnek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //dısarıdan girilen sayıya göre 10 adet random sayı üretip bunları ekrana yazın
            //fakat dısarıdan girilen sayıyı bir methoda gönderip işlemleri methodun içinde yapmasını
            Console.WriteLine("Sayiyi giriniz");
            int sayi1=Convert.ToInt32(Console.ReadLine());  
            Random(sayi1);
            
        }


        static void Random(int s1)
        {
            Random rnd=new Random();
            ArrayList arrayList1 = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                arrayList1.Add(rnd.Next(1, s1));
            }
            foreach (var item in arrayList1) Console.WriteLine($"Üretilen sayı => {item}");
        }




    }
}
