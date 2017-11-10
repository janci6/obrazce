using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazce
{
    sealed class kruh : obrazec, Ikreslenie, Izmenrozmer
    {
        double polomer;
        public kruh(double polomer)
        {
            this.polomer = polomer;
        }
        public override double vypocitajobsah()
        {
            return Math.PI * polomer * polomer;
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
            polomer = polomer - rozdiel;
        }
    }
}
