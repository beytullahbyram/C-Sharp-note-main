using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adinizi girin");
            string name=Console.ReadLine();
            Console.WriteLine("yasinizi girin");
            string yas= Console.ReadLine();
            
            
            Console.Clear();
            Console.WriteLine("adiniz: "+name + "\nyasiniz: "+ Convert.ToInt32(yas));
        
        
        
        }
    }
}
