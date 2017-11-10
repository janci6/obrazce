using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazce
{
    partial class stvorec : obrazec, Ikreslenie, Izmenrozmer
    {
        double strana;

        public stvorec(double strana)
        {
            this.strana = strana;
        }
        public override double vypocitajobsah()
        {
            return strana * strana;

        }
        public void vytlac()
        {
            Console.WriteLine("tlacim ");
        }
        public void vykresli()
        {
            Console.WriteLine("kreslim");
        }
        public void zmenrozmer(double rozdiel)
        {
            strana = strana - rozdiel;

        }
    }
}

