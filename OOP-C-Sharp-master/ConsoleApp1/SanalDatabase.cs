using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SanalDatabase
    {
        static private ArrayList liste;

        public void yeniKayit(int veri)
        {
            liste.Add(veri);
        }
       
        static  SanalDatabase() // Ctor yalnızca bir kere çalışır oda başlangıçta 
        {
            liste = new ArrayList();
        }

        //public SanalDatabase() // Standart ctor her nesne ulaştığında çalışır
        //{
        //    liste = new ArrayList();

        //}

    }
}
