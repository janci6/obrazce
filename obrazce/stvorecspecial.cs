using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazce
{
    partial class stvorec
    {
        public static bool porovnaj(stvorec stvorec, stvorec stvorec2)
        {
            return stvorec.strana == stvorec2.strana;
        }
    }
}
