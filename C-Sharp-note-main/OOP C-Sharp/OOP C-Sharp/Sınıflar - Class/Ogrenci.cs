using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar___Class
{
    internal class Ogrenci
    {

        //public int id;
        public string ad,soyad;
        private string _Ad, _Soyad;
        private int _id;
        private string _tcNo;
        private string _sifre;//field


        public string Sifre //kapsüllemeye müsait bir property
        {
            //get yazılmadı sifreyi getiremeyiz. ama değer atabiliriz asagıdaki set sayesinde
            set { _sifre = value; }
        }



        public int id 
        {
            get { 
                _id = IDgetir();
                return _id;
                }
            private set { } //Değer atama engellendi 
        }
        
        private int IDgetir()
        { 
            Random rnd=new Random();
            int randomsayi = rnd.Next(1, 100);
            return randomsayi;
        }
        


        public string tcNo 
        {
            get 
            {
                return _tcNo.Substring(0,4);
            } //deger okunmak istendiğinde calısır 
            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = true;
                    for (int i = 0; i < value.Length; i++)
                    {
                        kontrol = char.IsNumber(value[i]);
                        if (kontrol == false)
                        {
                            Console.WriteLine("tc no sayısal olmalı");
                            break;
                        }
                    }
                    if (kontrol) _tcNo = value;
                }
                else Console.WriteLine("eksik girdiniz");
            } //deger atama istendiğinde calısır 
        }
        private string tcAtama()
        {
            return "";
        }

     





        private string _emailAdress; //Field 
        public string emailAdress //Properties
        {
            get //deger okumak
            {
                _emailAdress = EmailOlustur();
                return _emailAdress;
            }
            private set { }//deger atamak
        }
        private string EmailOlustur()
        {
            return ad + "." + soyad + "@hotmail.com";
        }
        
        
        

    }
}
