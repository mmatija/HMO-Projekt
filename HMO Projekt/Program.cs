using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace HMO_Projekt
{

    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args) Console.WriteLine(s);
            new CitanjeDatoteke("\"+args[0]+\"");
            /*StreamWriter writer = new StreamWriter("ispis.txt");
            for (int i = 0; i < Podaci.brojKorisnika + Podaci.brojSkladista; i++)
            {
                for (int j = 0; j < Podaci.brojKorisnika + Podaci.brojSkladista; j++)
                {
                    writer.Write("{0}\t\t", Podaci.udaljenosti[i, j]);
                }
                writer.WriteLine();
            }*/
        }

    }
}
