using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_ornek
{
    public class Urun : BaseClass
    {



        public string marka { get; set; }

        public string model { get; set; }


        private decimal _kampanyaFiyat { get; set; }    
        public decimal kampanyaFiyat 
        { 
            get { return _kampanyaFiyat; }
            set
            {
                if(value < _alisFiyati  )
                {
                    Console.WriteLine("Kampanya fiyatı alıs fiyatından kücük olamaz");
                
                }
                else
                {
                    _kampanyaFiyat = value; 
                }
            }
        }


        
        
        private decimal _alisFiyati { get; set; }
        public decimal alisFiyati {
            
            get { return _alisFiyati; } 
            set 
            {
                if(value < 0 || value == 0)
                {
                    Console.WriteLine("Alıs fiyati 0 veya daha kücük olamaz");
                }
                else
                {
                    _alisFiyati = value;
                }
            } 
        }




        private decimal _satisFiyat;
        public decimal satisFiyati
        {
            get { return _satisFiyat; }
            set 
            { 
                if(value < _alisFiyati)
                {
                    Console.WriteLine("Satis fiyatı alis fiyatından kucuk olamaz");

                }
                else
                {
                    _satisFiyat = value;    
                }
            }
        }






    }
}
