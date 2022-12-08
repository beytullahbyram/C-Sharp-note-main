using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ornek
{
    public class Islem : Idortislem
    {

        public int number1, number2;
        public int bol(int n1, int n2)
        {
            return n1 / n2;   
        }

        public int carp(int n1, int n2)
        {
            return n1 * n2;
        }

        public int cikar(int n1, int n2)
        {
            return n1 - n2;
        }

        public int topla(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
