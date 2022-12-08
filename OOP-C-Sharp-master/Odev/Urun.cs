using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Urun
    {
        //I
        private int _urunID {  get; set; }  
        public int urunID 
        { 
            get { return _urunID; }  
            private set { } 
        }


        private string _urunKod { get; set; }  
        public string urunKod 
        { 
            get { return _urunKod; }
            private set { }
        
        
        }
        public string urunAdi { get; set; }
        public string  urunAck { get; set; }


        public static List<Urun> urunListesi;
        public static ArrayList liste;  
        static public int sayac=0;
        public Urun() //Standart constructor
        {
            _urunID = sayac ;
            _urunKod = "A"+_urunID ;  
            sayac++;
        }

        static Urun()
        {
            liste=new ArrayList();
            urunListesi= new List<Urun>();
        }

        public void UrunEkle(Urun u)
        {
            liste.Add(u);
            urunListesi.Add(u);
        }


        static public void UrunYazdir()
        {
            foreach (Urun item in liste)
            {
                //Urun u =(Urun) item; // tür dönüşümü Urum item in liste yaparsak tür dönüşümüne gerek yok 
                Console.WriteLine("ARRAY LIST"+item._urunKod);
            }
        }

        static public void UrunYazdir2()
        {
            foreach (Urun item in urunListesi)
            {
                //Urun u =(Urun) item; // tür dönüşümü Urum item in liste yaparsak tür dönüşümüne gerek yok 
                Console.WriteLine("LIST  "+item._urunKod);
            }
        }
        //II
        //----------------------------------------------
        ////private string _urunkod { get; set; }
        //    private int _urunid { get; set; }
        //    public string urunismi { get; set; }
        //    public string urunbilgi { get; set; }

        //    public int urunid
        //    {
        //        get { return _urunid; }
        //        set { _urunid = value; }
        //    }


        //    public string urunkod
        //    {
        //        get { return _urunkod; }
        //        set
        //        {
        //            _urunkod = "a" + value;
        //        }
        //    }


    }



}
