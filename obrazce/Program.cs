using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazce
{
    class Program
    {
        static void Main(string[] args)
        {

            obrazec kruh = new kruh(3.4);
            Console.WriteLine("obsah kruhu :{0}", kruh.vypocitajobsah());

            stvorec stvorec = new stvorec(4.2);
            Console.WriteLine("obsah stvorca :{0}", stvorec.vypocitajobsah());

            stvorec stvorec2 = new stvorec(4.2);



            Console.WriteLine("porovnani {0}", stvorec.porovnaj(stvorec, stvorec2));

            Console.ReadLine();


        }
    }
}
