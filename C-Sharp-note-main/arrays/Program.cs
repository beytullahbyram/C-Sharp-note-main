using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"xxxx","yyy","zzzz","aaaaa","klşkşl","lkşlşll","şlkşlllll","mmmm","mmmnn","nnnn" };
            string[] ogrlis = new string[5]; //Dizinin her bir elemanı string değerdir.
            int[] numberArray=new int[5] {1,2,3,4,5};   //Dizinin her bir elemanı int değerdir.

                //  10                 10 <     2
            for (int i = names.Length; i < names.Length-8; i--) //Son iki eleman
            {
                Console.WriteLine(names[i-8]);    
            }
            Console.WriteLine("-----------------");



            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            Array.Sort(names); //Alfabetik olarak sıralar
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            int res=Array.BinarySearch(numberArray, 5); // Aranan ifadenin kaçıncı indexte olduğunu gösterir.
            Console.WriteLine(res);

            #region Ornek1 dısarıdan 10 sayı gir bunları bir diziye ekle ve yazdır
            Console.Clear();
            int[] number=new int[10];
            int sayac = 0;
            int sayi;
            //while (sayac < 10)
            //{
            //    sayi=Convert.ToInt32(Console.ReadLine());
            //    number[sayac]=sayi; 
            //    sayac++;
            //}

            for (int i = 0; i < number.Length; i++) Console.Write($"{number[i]}\t");
            #endregion

            #region Ornek2 10 elemanlı diziye dışarıdan random sayılar atılsın
            Console.Clear();
            Random rnd=new Random();
            int[] randNumber=new int[10];
            for (int i = 0; i < randNumber.Length; i++)
            {
                int random = rnd.Next(1, 11);
                randNumber[i]=random;   
            }
            for (int i = 0; i < randNumber.Length; i++) Console.WriteLine   ($"{randNumber[i]}\t");

            //Dizinin içinde kac tane 4 sayısı oldugunu bulma
            int sayac2 = 0;   
            for (int i = 0; i < randNumber.Length; i++) if (randNumber[i] == 4)   sayac2++;
            Console.WriteLine($"Dizide {sayac2} tane 4 sayısı var");
            #endregion


            #region arr select
            Console.Clear();
            int[] numbers = { 1, 2, 3, 4, 5 };
            var items = numbers.Select(x => x*x);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Ornek3 Dizi uzunluğu belirleme ve dizinin elemanlarının toplamı ile ortalamasını bulma
            //dısarıdan girilen sayi dizinin kac elemanlı olup oldugunu belirleyecek
            //ve dizinin elemanlarını tekrardan dısarıdan girilecek
            //ve bu elemanları toplamı ile ortalaması alınacak
            Console.WriteLine("Diziniz kaç elemanlı olsun?");
            int arrNumbers=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[arrNumbers];
            int sum = 0, avg = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Dizinin sayilarını giriniz: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum+=arr[i];
                avg = sum / arr.Length;
            }
            Console.WriteLine($"Dizinin toplamı=>{sum}  dizinin ortalaması => {avg}");
            #endregion

            #region Ornek4 20elemanlı bir diziye random sayılar atılsın -100 +100 aralığında içinde kaç adet pozitif negatif odldugunu bulalım
            Console.Clear();
            Random randd = new Random();
            int[] arrNumbers1 = new int[20];
            int neg = 0, pos = 0;
            for(int i=0; i< arrNumbers1.Length; i++)
            {
                int numbers1 = randd.Next(-100, +100);
                arrNumbers1[i] = numbers1;
                if(arrNumbers1[i] < 0)
                {
                    neg++;
                }else if(arrNumbers1[i] > 0)
                {
                    pos++;
                }
            }
            Console.WriteLine($"{neg} adet negatif sayı vardır \n{pos} pozitif adet sayi vardır");
            #endregion



            #region Ornek5 Kullancıdan alınan metnin içindeki sesli harf sayısını veren uygulama
            Console.Clear();
            Console.WriteLine("Metninizi giriniz:");
            string text=Console.ReadLine();
            char[] letters = new char[] {'a','e','i','o','u'};
            int counter=0;
            for (int i = 0; i < letters.Length; i++)
            {
                for (int m = 0; m < text.Length; m++)
                {
                    if (letters[i] == text[m]) counter++;
                }
            }
            Console.WriteLine($"Metniniz de {counter} adet sesli harf bulunmaktadır.");
            #endregion


            #region Ornek6 Verilen string içerisindeki harf ve karakterlerden hangisinden kaç tane olduğunu bulan
            Console.WriteLine("Metninizi giriniz:");
            string text2=Console.ReadLine();
            int counter2 = 0;   
            string karakter = "0123456789abcdefghjklmnoprstuyvz?/*-+.";
            int[] miktar = new int[karakter.Length];
            int indexno = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < karakter.Length; j++)
                {
                    counter2++;
                    if(text[i] == karakter[j])
                    {
                        indexno=text2.IndexOf(karakter,);
                        Console.WriteLine(indexno);
                    }
                }
            }


            #endregion



        }
    }
}
