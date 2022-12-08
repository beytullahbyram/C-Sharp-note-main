using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Musteri:BaseClass
    {
        public Musteri()
        {
            musteriID = 1;
        }

        public int musteriID { get; set; }

        public override void abstractMetot() //abstract metotu implement ettik
        {
            throw new NotImplementedException();
            //işlemler
        }
    }
}
