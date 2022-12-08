using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    internal class Musteri : Imusteri
    {
        private int _id;
        public int id 
        {   get { return _id;  }
            set {  _id = value; } 
        }
        public string name { get ; set ; }
        public string surname { get ; set ; }
        public string TCno { get ; set ; }

        public int add(string name, string surname)
        {
            return 1;
        }

        public int delete(int id)
        {
            return 1;
        }
    }
}
