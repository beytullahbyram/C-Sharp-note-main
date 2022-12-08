using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_ornek
{
    public class DataBase
    {
        public static void UrunYazdir(ArrayList db)
        {
            foreach (BaseClass item in db)
            {
                Console.WriteLine(item.barkod);
            }
        }

        public static ArrayList db=new ArrayList();

        public static void  urunEkle(Urun urun)
        {
            if (barkodControl(urun.barkod))
            {
                db.Add(urun);
                Console.WriteLine("Urun eklendi");

            }
            else
            {
                Console.WriteLine("Urun zaten ekli");
            }
        }


        public static bool barkodControl(string barkod)
        {
            bool control = true;
            if(db.Count > 0 && db !=null)
            {
                foreach (BaseClass item in db)
                {
                    if(item.barkod == barkod)
                    {
                        control = false;
                        break;
                    }
                }
            }

            return control; 
        }

    }
}
