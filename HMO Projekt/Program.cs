using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace HMO_Projekt
{

    public class Skladiste
    {
        public int x;      //x koordinata skladišta
        public int y;      //y koordinata skladišta
        public int kapacitet;  //kapacitet skladišta
        public int trosakOtvaranja;    //trošak otvaranja skladišta
    }

    public class Korisnik
    {
        public int x;
        public int y;
        public int potraznja;
        public bool posluzen;
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args) Console.WriteLine(s);
            List<Skladiste> skladista = new List<Skladiste>();
            List<Korisnik> korisnici = new List<Korisnik>();
            int brojKorisnika=0;
            int brojSkladista=0;
            int kapacitetVozila=0;
            int trosakVozila=0;
            new CitanjeDatoteke("\"+args[0]+\"", ref skladista, ref korisnici, ref brojKorisnika, ref brojSkladista, ref kapacitetVozila, ref trosakVozila);

        }

    }
}
