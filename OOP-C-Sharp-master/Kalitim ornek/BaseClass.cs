using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_ornek
{
    public class BaseClass
    {
        private int _id;
        public int id
        {
            get
            {
                Random random = new Random();
                _id=random.Next(1,10);
                return _id;
            }
            private set { } 
        }

        private string _barkod;
        public string barkod 
        {
            get { return _barkod; }  
            set 
            {
                if (DataBase.barkodControl(value))
                {
                    _barkod = value;
                }
                else Console.WriteLine("urun zaten ekli");
            }
        }



        public DateTime olusturmaTarihi { get; set; }

        public int olusturanKullanici { get; set; }

        public DateTime guncellemeTarihi { get; set; }

        public int guncelleyenKullanıcı { get; set; }

        public bool silindi { get; set; }







    }
}
