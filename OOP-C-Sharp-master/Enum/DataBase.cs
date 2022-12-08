using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class DataBase
    {
        public static ArrayList liste = new ArrayList();    


        public KayıtSonuc kayıt(Musteir m)
        {
            liste.Add(m);
            return KayıtSonuc.kayıtBasarili; 
        }
    }
}
