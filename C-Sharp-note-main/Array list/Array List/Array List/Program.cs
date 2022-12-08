using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Collection ArrayList
            //Collections
            ArrayList arrList1 =new ArrayList();
            ArrayList arrList2 = new ArrayList();

            arrList1.Add("sfd");
            arrList1.Add(1);

            arrList1[0] = 5;
            arrList1[1] = "hello";


            arrList2.Add(2);
            arrList2.Add(3);
            
            arrList1.AddRange(arrList2); //arrList2 has been added to the arrList1 list

            int count=arrList1.Count;
            int capacity= arrList1.Capacity;

            //string indexStr = arrList1[0].ToString();   // object => string
            //int indexInt = (int)arrList1[1];            // object => int
            //object indexObject = arrList1[2];           // object => object

            //arrList1.Remove(1);     //1 number deleted
            //arrList1.Remove("sfd"); //"sfd" string deleted
            //arrList1.RemoveAt(0); // 0 no index deleted  
            //arrList1.RemoveRange(0, 5); // deleted  from 0 to 5     0 = index

            arrList2.Add("b");
            arrList2.Add("c");
            arrList2.Add("d");
            arrList2.Add("a");
            foreach(var i in arrList2)
            {
                Console.WriteLine(i);

            }

            //arrList2.Sort(); // A-Z 
            //arrList2.Reverse(); // turn down
            //arrList2.Clear();// all deleted 
            //arrList2.TrimToSize(); // returns to its original state 
            //bool control=arrList2.Contains("a"); //is there letter "a" in list arrList2  =>  return bool
            //int control2=arrList2.IndexOf("a"); //is there letter "a" in list arrList2  =>  return index // is there letter is if no return => -1 
            #endregion
 #region ArrayList sample
            Console.Clear();
            int inputInt =0,control=0,secim=0;
            string yeniDeger = "",eskiDeger="",silinecekDeger="",inputStr="";

            ArrayList arrayList1 = new ArrayList();
            do
            {
                Console.WriteLine(">>>>>>>>>Menü<<<<<<<<<");
                Console.WriteLine("1-Değer ekle");
                Console.WriteLine("2-Değer listele");
                Console.WriteLine("3-Değer ara");
                Console.WriteLine("4-Değer degistir");
                Console.WriteLine("5-Değer sil");
                Console.WriteLine("6-Cikis");
                secim = Convert.ToInt16(Console.ReadLine());


                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Eklemek istediğiniz değerin türünü giriniz 1=string & 2=int");
                        control = Convert.ToInt32(Console.ReadLine());
                        if (control == 1)
                        {
                            Console.WriteLine("Yaz => ");
                            inputStr = Console.ReadLine();
                            arrayList1.Add(inputStr);
                        }else if(control == 2)
                        {
                            Console.WriteLine("Yaz => ");
                            inputInt = Convert.ToInt32(Console.ReadLine());
                            arrayList1.Add(inputInt);
                        }
                        else Console.WriteLine("Düzgün bir değer gir");

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Listeleniyor");
                        foreach (var item in arrayList1) Console.WriteLine($"=>>>>{item}");
                        break;
                    case 3:
                        Console.WriteLine("aramak degeri gir");
                        inputStr = Console.ReadLine();
                        Console.Clear();

                        foreach (var item in arrayList1)
                        {
                            if (item.ToString() == inputStr)
                            {
                                Console.WriteLine($"aradıgın deger bulundu  => {item.ToString()} ");
                                break;
                            }

                        }
                        break;
                    case 4:
                        foreach (var item in arrayList1) Console.WriteLine(item);

                        Console.WriteLine("degistirmek istedigin degeri giriniz");
                        eskiDeger = Console.ReadLine();

                        Console.WriteLine("yeni deger giriniz");
                        yeniDeger=Console.ReadLine();

                        for (int i = 0; i < arrayList1.Count; i++)
                        {
                            if(arrayList1[i].ToString() == eskiDeger)
                            {
                                Console.WriteLine("bulundu degisti");
                                arrayList1[i] = yeniDeger;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("silmek istedigin degeri giriniz");
                        silinecekDeger=Console.ReadLine();
                        foreach (var item in arrayList1)
                        {
                            if (item.ToString() == silinecekDeger)
                            {
                                arrayList1.Remove(silinecekDeger);
                                Console.WriteLine("Silindi");
                                break;
                            }
                        }
                        break;
                    default:
                        break;
                }

            } while (secim != 6);



            #endregion
        
        }
    }
}
