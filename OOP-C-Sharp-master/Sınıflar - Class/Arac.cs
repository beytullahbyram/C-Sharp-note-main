using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar___Class
{
    internal class Arac
    {
        public string marka, model,yakıt,vites,yıl;
        public int km;
        public decimal alıs, satıs, indirim;


        // ctor tab tab kısayolu ile constructor oluşturulur
        public Arac()//Yapıcı method veya constructer
        {
            Console.WriteLine("Yapıcı method başladı");
        }
        public Arac(string markaaa,string modelll)// Yapıcı method II
        {
            marka = markaaa;    
            model = modelll;

        }

        ~Arac()//Yıkıcı method program sonlandıgında nesneler silinir. program bitince baslar
        {
            Console.WriteLine("Yıkıcı method calıstı");
        }

        public Arac(string marka, string model,int km)// Yapıcı method II
        {
            this.marka = marka;
            this.model = model;
            this.km = km;
        }

        public void BilgiYazdir()
        { 
            Console.WriteLine($"{marka}  {model}  {yıl}  {yakıt}  {vites}  {km}");
        }

        public void FiyatAta(decimal musteriFiyat)
        {
            if (satıs - indirim > musteriFiyat) Console.WriteLine("Geçersiz fiyat  " +"verilen fiyat =>"+ musteriFiyat);
            else Console.WriteLine("Fiyat güncellendi");
        }


    }
}
