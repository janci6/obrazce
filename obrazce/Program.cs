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

            Ikreslenie k = stvorec2;
            Ikreslenie k1 = new kruh(10.2);

            k.vykresli();
            k1.vytlac();

            kruh kruh1 = new kruh(3);
            Izmenrozmer zmenakruhu = kruh1;
            zmenakruhu.zmenrozmer(2);
            Console.WriteLine( kruh1.vypocitajobsah());

            stvorec stvorec3 = new stvorec(4);
            Izmenrozmer zmenastvorca = stvorec3;
            zmenastvorca.zmenrozmer(2);
            Console.WriteLine( stvorec3.vypocitajobsah());

            Console.ReadLine();


        }
    }
}
