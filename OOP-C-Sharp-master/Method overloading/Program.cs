using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

        }

        static void topla(int s1,int s2)
        {
            int toplam=s1+s2;
        }

        static void topla(int s1, int s2,int s3)
        {
            int toplam = s1 + s2 + s3;
        }

        static int topla(int s1,int s2,int s3,int s4)
        {
            int toplam = s1+s2 +s3+ s4;
            return toplam;
        }
        static double topla(int s1, int s2, int s3, int s4)
        {
            double toplam = s1 + s2 + s3+s4;
            return toplam;
        }
    }
}
