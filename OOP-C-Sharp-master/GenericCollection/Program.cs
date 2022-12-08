using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add(1);
            liste.Add("value");

            // <T>  T tip herhangi bir tipi gösterir
            //generic listeler
            List<string> liste2 = new List<string>();//string tip bir liste

            //-------------------------------------------------------------------------------------------
            List<int> liste3 = new List<int>();//int tip bir liste

            liste3.Add(1);
            liste3.Add(2);
            foreach (var item in liste3)
            {
                Console.WriteLine(item);
            }



            int[] sayilar=new int[3];
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            //Sayilar dizisindeki elemanları liste3 e aktar
            //I.Yol
            foreach (var item in sayilar)
            {
                liste3.Add(item);
            }
            //II.Yol
            liste3.AddRange(sayilar);

            Console.WriteLine("Sayilar dizisindeki elemanlar eklendi---------");
            foreach (var item in liste3)
            {
                Console.WriteLine(item);
            }
            

            liste3.TrimExcess();//Capacity ve Count eşitlenir.

            //Bu yol ile elemanları ekrana tek tek yazdırabiliriz.
            Console.WriteLine("LINQ");
            liste3.ForEach(item => Console.WriteLine(item));


            int deger = liste3[0]; //Tür dönüşümü yapmadan 0'cı elemanı deger değişkenine atadık çünkü generic listlerin tipleri bellidir.
            

            Console.WriteLine("------------------------");
            liste3.Insert(0, 100);//0.indexe 100 değerini ekledik ve diğer değelerin indexleri ötelenir.
            liste3.ForEach(item => Console.WriteLine(item));


            Console.WriteLine("Any ile kontrol ediyoruz----------------");
            bool liste3Control =liste3.Any();//liste3'de herhangibir eleman olup olmadığına bakar.
            Console.WriteLine(liste3Control);


            Console.WriteLine("Any ile listenin içinde 50den büyük eleman var mı?----------------");
            bool liste3Control2 =liste3.Any(i => i > 50); //liste3'ün içinde 50den büyük eleman var mı? /// i listenin her bir elemanını kontrol eder.
            Console.WriteLine(liste3Control2);

            liste3.Sort();//A-Z'ye sıralar.
            liste3.Reverse();//Listeyi ters çevirir.
            bool silindimiKontrol=liste3.Remove(10);//Listenin içinde ilk bulduğu 10 sayısını siler ve geriye bool tip döndürür. Silerse true silemezse false
            liste3.RemoveAt(2);//Girdiğimiz 2.ci indexdeki değeri siler.
            int kacElemanSilindi=liste3.RemoveAll(i => i > 30);//30dan büyük elemanları siler. Kaç adet sildiğini geriye döndürür.
            liste3.Clear();//Listenin tüm elemanlarını siler.
            liste3.Max();//Listenin en yüksek değerini döndürür.
            liste3.Min();//Listernin en küçük değerini döndürür.
            liste3.Sum();//Listenin içindeki elemanlarının toplamını döndürür.


            //--------------------------------------------------------------------------------
            Console.WriteLine("Musteri class işlemleri-------------------");
            List<Musteri> musteriList = new List<Musteri>();   //Liste içine sadece Müsteri nesnesi atılabilir
            Musteri musteri1 = new Musteri() { adi="beytu", id=2};
            Musteri musteri2 = new Musteri() { adi="deneme isim", id=3 };

            //musteriList[0] = musteri1; listenin içi boş oldugu var olan musteri1 ile olmayan 0.indexe atanamaz eğer 0.index dolu olsaydı o zaman atama olurdu
            musteriList.Add(musteri1);//I.Yol
            musteriList.Add(musteri2);
            musteriList.Add(new Musteri() {adi="beytullah",id=1 });//II.Yol
            foreach (var item in musteriList)
            {
                //Console.WriteLine(item);//output =>  GenericCollection.Musteri
                Console.WriteLine(item.adi); //output =>  beytu, deneme isim, beytullah
            }
            //-------------------------------------------------------------------------




            //Bir Classı generic yapmak
            MusteriGeneric<int> musteriGeneric = new MusteriGeneric<int>(); //T tipini int olarak gönderdik.
            musteriGeneric.id = 1;
            musteriGeneric.musteriNo = 1232;
            musteriGeneric.isim = "Beytullah";

            MusteriGeneric<string> musteriGeneric2=new MusteriGeneric<string>();
            musteriGeneric2.id = "1";
            musteriGeneric2.musteriNo = "213";
            musteriGeneric2.isim = "Beytullah";
            //Yukarıdaki örnek mantığı anlamak için yazılmıştır.



            //Kullanım şekli aşağıdaki gibi
            GenericClass<Musteri> gcMusteri=new GenericClass<Musteri>();    



            //musteri generic classında id ve musterinoya t tipini gönderdik.


        }
    }
}
