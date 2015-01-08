﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO_Projekt
{
    class Podaci
    {
        public class Skladiste
        {
            public int id;
            public int x;      //x koordinata skladišta
            public int y;      //y koordinata skladišta
            public int kapacitet;  //kapacitet skladišta
            public int trosakOtvaranja;    //trošak otvaranja skladišta
        }

        public class Korisnik
        {
            public int id;
            public int x;
            public int y;
            public int potraznja;
            public bool posluzen;
        }

        public static int brojKorisnika = 0;
        public static int brojSkladista = 0;
        public static int kapacitetVozila = 0;
        public static int trosakVozila = 0;
        public static List<Skladiste> skladista = new List<Skladiste>();
        public static List<Korisnik> korisnici = new List<Korisnik>();

        //udaljenosti između svih čvorova (udaljenosti[i,j] označava udaljenosti između čvorova i,j)
        //u redcima su korisnici, a u stupcima i korisnici i skladišta
        public static int[,] udaljenosti = new int[brojKorisnika, brojKorisnika+brojSkladista];
        
        
    }
}
