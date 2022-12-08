using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m=new Musteri();

            m.musteriID = 1;
            m.isim = "beytu";
            m.soyisim = "bayram";
            m.tcKimlikNo = "123123123";
            m.olusturmaTarihi =DateTime.Now;
            //m.musteriAdresleri = new MusteriAdres[4];// constructorda yazılır burada yazılması gereksiz
            m.musteriAdresleri[0]=new MusteriAdres()//0ıncı indexe asagıdaki bilgiler girildi
            {
                //I
                il="istanbbul",
                ilce="kadıkoy",
                adres="boga heykeli",
                adresTip="is"
            };
            m.musteriIletisimBilgileri[0] = new MusteriIletisim()
            {
                alanKodu = "34500",
                iletisimTip = 1,
                aktifPasif = true,
            };
            m.musteriSiparisBilgileri[0] = new MusteriSiparisBilgileri() 
            { 
                siparisNumarasi = "A1b1",
                
            };
            m.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                urunIsmi="kalem",
                id=1,
                fiyat=20
            };
            m.musteriSiparisBilgileri[0].urunler[1] = new Urun()
            {
                urunIsmi = "defter",
                id = 2,
                fiyat = 200
            };




            ////II
            //m.musteriAdresleri[1] = new MusteriAdres();
            //m.musteriAdresleri[1].il = "istanbul";
            //m.musteriAdresleri[1].ilce = "sultangazi";
            //m.musteriAdresleri[1].adres= "esentepe ";
            //m.musteriAdresleri[1].adresTip = "is";





            Musteri m2 = new Musteri()
            {
                musteriID=2,
                isim = "deneme",
                soyisim = "deneme",
                tcKimlikNo="54546546",
                olusturmaTarihi=DateTime.Now 
            };



        }
    }
}
