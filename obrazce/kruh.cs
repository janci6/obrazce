using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazce
{
    class kruh : obrazec
    {
        double polomer;
        public kruh (double polomer)
        {
            this.polomer = polomer;
        }
        public override double vypocitajobsah()
        {
            return Math.PI * polomer * polomer;
        }
    }
}
