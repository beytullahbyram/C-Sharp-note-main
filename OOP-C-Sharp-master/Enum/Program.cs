using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteir m=new Musteir();

            m.ad = "BEYTU";
            DataBase db=new DataBase();
            KayıtSonuc sonuc = db.kayıt(m);
            Console.WriteLine(sonuc);

            if (sonuc  == KayıtSonuc.kayıtBasarili)
            {
                Console.Write("Kayıt basarılı");
            }else if(sonuc == KayıtSonuc.kayıtBasarisiz)
            {
                Console.Write("Kayıt basarısız");

            }





        }
    }
}
