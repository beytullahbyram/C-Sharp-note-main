using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class BaseClass
    {
        public BaseClass()
        {
            kayıtTarihi=DateTime.Now;
        }
        public DateTime kayıtTarihi { get; set; }

        public DateTime guncellemeTarihi { get; set; }
        public void Test()
        {
            Console.WriteLine("baseclass method");
        }

        public abstract void abstractMetot(); // abstract metotların sadece metot imzası vardır gövdesi olamaz
        //{
        //    Console.WriteLine("abs metot");
        //}

    }
}
