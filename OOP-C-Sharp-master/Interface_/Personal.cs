using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    internal class Personal :Musteri,Ipersonal
    {
        public string SicilNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Test()
        {
            Console.WriteLine(surname, name, TCno, add("", ""), delete(1));//Musteri clasındaki degerlere ulaştık;
        }
    }
}
