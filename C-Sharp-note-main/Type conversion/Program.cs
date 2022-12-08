using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tür dönüşümü ikiye ayrılır 
            //bilinçsiz tür dönüşümü => küçük tipin büyük tipe dönüştürülmesi => byte >> int 
            byte num1 = 100;
            int num2 = num1;
            double num3 = 10;
            num3 = num1;
            num3 = num2;    
            
            //--------------------------------------------

            //bilinçli tür dönüşümü büyük tipin küçük tipe dönüşmesi => int >> byte
            int num4 = 1250;
            num1 = (byte)num4;//modunu alır kalanı atar
            byte num5 = (byte)num3; 

            Console.WriteLine(num4);
            Console.WriteLine(num1);

            //veri kaybı olup olmadığını kontrol eder 
            checked{
 
            }

            //checked tam tersi 
            unchecked { 

            }


            Console.Clear();
            string name, soyad, dogumYili;
            int yas;
            Console.WriteLine("adınızı giriniz");
            name = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz");
            soyad = Console.ReadLine();
            Console.WriteLine("dogum tarihinizi giriniz");
            dogumYili = Console.ReadLine();


            yas=2022-Convert.ToInt32(dogumYili); // convert işleminde eğer çevirilecek işlem null ise sıfıra dönüştürür.
            //yas=2022-int.Parse(dogumYili); // parse işleminde eger parse edilecek işle null ise hata verir .

            //Console.WriteLine("Adiniz :" + name + "\nSoyadiniz: " + soyad + "\nYasiniz :"+yas );
            Console.WriteLine($"Adiniz: {name}  Soyadiniz: {soyad}  Yasiniz: {dogumYili}");

            //string name1 = "Mark";
            //var date = DateTime.Now;
            //// String interpolation:
            //Console.WriteLine($"Hello, {name1}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");


            Console.Clear();

            //var ile tanımlanan değişken ilk hani türde tanımlandıysa artık o türde tanımlama yapılabilir.
            var mesaj = 234;

            //oject ile tanımlanan değişkenler her türlü yapıyı kabul eder 
            object deneme = "asdfa";
            deneme = 23432;
            deneme = 12;


            deneme = mesaj;//boxing
            int y = (int)deneme; //Unboxing

            Console.WriteLine(y);
            Console.WriteLine(deneme);









        }
    }
}
