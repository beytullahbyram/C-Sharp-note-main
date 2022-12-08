using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Hashtable koleksiyonu ise elemanlarını içeride hash 
             algoritması ile oluşturduğu indekslere göre tutar ve bulur
             */
            Hashtable hlist =new Hashtable();
            hlist.Add(1, "bir"); //object key, object value
            hlist.Add(2, 2);
            hlist.Add(3, true);

            //Dictionary <T Key, T Value>   T = tip
            Dictionary<int, string> dlist = new Dictionary<int, string>();
            //dlistin key'i int, value ise string olmalıdır.
            dlist.Add(1, "bir");
            dlist.Add(2, "iki");
            dlist.Add(3, "üç");
            dlist.Add(4, "dört");


            bool silindiMi =dlist.Remove(2); //2.keye sahip key ve value silinir. Geriye bool tip döndürür silinirse True, silinmezse False

            string gelenDeger = dlist[3];//Key numarası parametre olarak gider geriye value döner

            string yeniDeger = "yirmi";
            dlist[2] = yeniDeger; //gelenDeger değişkenindeki değerini buradaki 2.keydeki valueye attık.

            bool arananSonuc=dlist.ContainsKey(4);//Key numarası parametre olarak gitti. dlist içinde 4 diye bir key olup olmadığını kontrol eder.

            if (arananSonuc) dlist[4] = "dört";
            else Console.WriteLine("Böyle bir key bulunamadı");


            foreach (DictionaryEntry item in hlist) //HastTable yazdırma işlemi
            {
                Console.WriteLine(item);//System.Collections.DictionaryEntry
                Console.WriteLine(item.Key);//Key
            }


            foreach (KeyValuePair<int,string> item in dlist) // foreach (var item in dlist) { } //DictionaryList yazdırma işlemi
            {
                Console.WriteLine(item); //[key, value]
                Console.WriteLine(item.Value);

            }

            /*
             SortedList koleksiyonunun kullanım amacı elemanlarının
            her zaman anahtarlarına göre sıralı tutuluyor oluşudu
             */
            SortedList sorted =new SortedList();
            sorted.Add(1, "bir");
            sorted.Add(2, "iki");
            sorted.Add(100, "yüz");
            sorted.Add(50, "elli");


            SortedList<int,string> sortedList = new SortedList<int,string>();
            sortedList.Add(1, "bir");
            sortedList.Add(2, "iki");
            sortedList.Add(3, "üç");
            sortedList.Add(5, "beş");
            foreach (KeyValuePair<int,string> item in sortedList)
            {
                Console.WriteLine(item.Value, item.Key);
            }

        }
    }
}
