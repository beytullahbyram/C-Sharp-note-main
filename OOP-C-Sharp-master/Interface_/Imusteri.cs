using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    public interface Imusteri
    {
        //field tanımlanamaz, protperty tanımlanabilir
        //otomatik public olarak tanımlanır
        int id { get; set; }

        string name { get; set; }

        string surname { get; set; }    

        string  TCno { get; set; }

        //metotların yalnızca imzası olur, gövdesi olmaz
        int add(string name, string surname);

        int delete(int id);
    
    
    
    }

}
