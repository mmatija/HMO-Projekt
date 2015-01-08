using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO_Projekt
{
    public class CitanjeDatoteke
    {

        public CitanjeDatoteke(string datoteka)
        {
            StreamReader reader = new StreamReader("HMO-projekt_instanca_problema.txt");
            //StreamReader reader = new StreamReader(datoteka);
            string line = reader.ReadLine();    //učitaj broj korisnika
            Podaci.brojKorisnika = Convert.ToInt32(line);

            line = reader.ReadLine();   //učitaj broj skladišta
            Podaci.brojSkladista = Convert.ToInt32(line);

            
            for (int i = 0; i < Podaci.brojSkladista; i++)     //stvori objekt za svako skladište
                Podaci.skladista.Add(new Podaci.Skladiste());

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < Podaci.brojSkladista; i++)    //učitaj koordinate svih skladišta
            {
                line = reader.ReadLine();
                string[] koordinate = line.Split(new char[] { '\t' });
                int x = Convert.ToInt32(koordinate[0]);
                int y = Convert.ToInt32(koordinate[1]);
                Podaci.skladista[i].x = x;
                Podaci.skladista[i].y = y;
            }

            
            for (int i = 0; i < Podaci.brojKorisnika; i++)
                Podaci.korisnici.Add(new Podaci.Korisnik());

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < Podaci.brojKorisnika; i++)
            {
                line = reader.ReadLine();
                string[] koordinate = line.Split(new char[] { '\t' });
                int x = Convert.ToInt32(koordinate[0]);
                int y = Convert.ToInt32(koordinate[1]);
                Podaci.korisnici[i].x = x;
                Podaci.korisnici[i].y = y;
                Podaci.korisnici[i].posluzen = false;

            }

            reader.ReadLine();  //preskoči prazan red
            line = reader.ReadLine();   //učitaj kapacitet vozila
            Podaci.kapacitetVozila = Convert.ToInt32(line);
            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < Podaci.brojSkladista; i++)
            {
                line = reader.ReadLine();
                Podaci.skladista[i].kapacitet = Convert.ToInt32(line);
            }

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < Podaci.brojKorisnika; i++)
            {
                line = reader.ReadLine();
                Podaci.korisnici[i].potraznja = Convert.ToInt32(line);
            }

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < Podaci.brojSkladista; i++)
            {
                line = reader.ReadLine();
                Podaci.skladista[i].trosakOtvaranja = Convert.ToInt32(line);
            }

            reader.ReadLine();     //preskoči prazan red
            line = reader.ReadLine();   //učitaj trošak vozila
            Podaci.trosakVozila = Convert.ToInt32(line);
            reader.Close();
        }

    }
}
