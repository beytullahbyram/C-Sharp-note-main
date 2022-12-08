using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_ornek
{
    public sealed class Televizyon : Urun
    {

        public bool  smartTv { get; set; }

        public bool HDMI { get; set; }

        public string ekranBoyutu { get; set; }

    }
}
