using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enam
{
    internal class DataBase
    {

        public static ArrayList liste=new ArrayList();


        public int musteriKayit(Musteri m)
        {
            liste.Add(m);
            return 1001;
        }

    }
}
