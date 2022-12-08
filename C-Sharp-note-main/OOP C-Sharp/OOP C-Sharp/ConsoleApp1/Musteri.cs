using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Musteri
    {
        /*
         her kullanıcı adı db ye atılacak sanal db ye 
        kullanıcı adını kontol edecek o listede var mı yok mu
        varsa kayıtlı oldugu soylenecek
        yoksa ekleyecek
         */

        static private ArrayList liste;   


        static  Musteri() // Static olusturduk cünkü herseferinde yeniden oluşturmasın 
        {
            liste =new ArrayList();
        }
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string sifre { get; set; }
        private string _kullanıcıAdi;
        public string kullanıcıAdi 
        {
            get { return _kullanıcıAdi;}
            set
            {
                bool kontrol = Musteri_kontrol(_kullanıcıAdi);
                if (kontrol)
                {
                    _kullanıcıAdi = value;
                    Console.WriteLine($"kayıt tamam  eklenen kayıt =>>>> {_kullanıcıAdi}");
                }
                else
                {
                    Console.WriteLine($"kullanıcı kayıtlı  =>>>> {_kullanıcıAdi}");
                    _kullanıcıAdi = string.Empty;
                }
            } 
        }
        public bool  Musteri_kontrol(string kullanıcıAdii)
        {
            bool sonuc=true;
            foreach (var item in liste)
            {
                if (item == kullanıcıAdii)
                {
                    sonuc = false;
                }
            }
            return sonuc;
        }

        static public void MusteriEkle(Musteri m)
        {
            if (m !=null && !string.IsNullOrEmpty(m.kullanıcıAdi))              
            {
                if (EmailKontrol(m.emailAdres))
                {
                    liste.Add(m);
                    Console.WriteLine(m.emailAdres);
                }else
                {
                    Console.WriteLine("bu email kayıtlı");
                }
            }
            //Musteri tip =(Musteri)m;
            //foreach (var item in liste)
            //{
            //    Musteri tip2 = (Musteri)item; // Tür dönüşümü ile itemin müsteri tipinde bir degisken oldugunu soyledik
            //    Console.WriteLine($" liste detay   =>>>>>>      <<<<<<<<<<<<<<<<<<<<<<<{tip.emailAdres}      {tip.kullanıcıAdi}");
            //}
        }
        static bool  EmailKontrol(string email)
        {
            bool kontrol=true;
            for (int i = 0; i < liste.Count; i++)
            {
                Musteri m = (Musteri)liste[i];


                if(m.emailAdres == email)
                {
                     kontrol = false;
                    break;
                }
            }
            return kontrol;
            //Musteri tip2 = (Musteri)item; // Tür dönüşümü ile itemin müsteri tipinde bir degisken oldugunu soyledik
        }

    }
}
