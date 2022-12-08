using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m=new Musteri();
            m.ad = "sdafdsa";
            string sonuc=m.ToString();  
            Console.WriteLine(sonuc);

            BaseClass B= new BaseClass();
            B.EkranaYaz("override method kullanıldı");
            Urun u = new Urun();
            u.EkranaYaz("urun");
            Televizyon te = new Televizyon();
            te.EkranaYaz("televizyon");
        }
    }
}
