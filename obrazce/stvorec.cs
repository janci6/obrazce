using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazce
{
    partial class stvorec : obrazec
    {
        double strana;

        public stvorec (double strana)
        {
            this.strana = strana;
        }
        public override double vypocitajobsah()
        {
            return strana * strana;
          
        }
    }
}
