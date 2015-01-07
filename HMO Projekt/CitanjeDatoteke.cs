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

        public CitanjeDatoteke(string datoteka, ref List<Skladiste> skladista, ref List<Korisnik> korisnici, ref int brojKorisnika, ref int brojSkladista, ref int kapacitetVozila, ref int trosakVozila)
        {
            StreamReader reader = new StreamReader("HMO-projekt_instanca_problema.txt");
            //StreamReader reader = new StreamReader(datoteka);
            string line = reader.ReadLine();    //učitaj broj korisnika
            brojKorisnika = Convert.ToInt32(line);

            line = reader.ReadLine();   //učitaj broj skladišta
            brojSkladista = Convert.ToInt32(line);

            
            for (int i = 0; i < brojSkladista; i++)     //stvori objekt za svako skladište
                skladista.Add(new Skladiste());

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < brojSkladista; i++)    //učitaj koordinate svih skladišta
            {
                line = reader.ReadLine();
                string[] koordinate = line.Split(new char[] { '\t' });
                int x = Convert.ToInt32(koordinate[0]);
                int y = Convert.ToInt32(koordinate[1]);
                skladista[i].x = x;
                skladista[i].y = y;
            }

            
            for (int i = 0; i < brojKorisnika; i++)
                korisnici.Add(new Korisnik());

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < brojKorisnika; i++)
            {
                line = reader.ReadLine();
                string[] koordinate = line.Split(new char[] { '\t' });
                int x = Convert.ToInt32(koordinate[0]);
                int y = Convert.ToInt32(koordinate[1]);
                korisnici[i].x = x;
                korisnici[i].y = y;
                korisnici[i].posluzen = false;

            }

            reader.ReadLine();  //preskoči prazan red
            line = reader.ReadLine();   //učitaj kapacitet vozila
            kapacitetVozila = Convert.ToInt32(line);
            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < brojSkladista; i++)
            {
                line = reader.ReadLine();
                skladista[i].kapacitet = Convert.ToInt32(line);
            }

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < brojKorisnika; i++)
            {
                line = reader.ReadLine();
                korisnici[i].potraznja = Convert.ToInt32(line);
            }

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < brojSkladista; i++)
            {
                line = reader.ReadLine();
                skladista[i].trosakOtvaranja = Convert.ToInt32(line);
            }

            reader.ReadLine();     //preskoči prazan red
            line = reader.ReadLine();   //učitaj trošak vozila
            trosakVozila = Convert.ToInt32(line);
            reader.Close();
        }

    }
}
