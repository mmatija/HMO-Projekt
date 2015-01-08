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

            Podaci.udaljenosti = new int[Podaci.brojKorisnika + Podaci.brojSkladista, Podaci.brojKorisnika + Podaci.brojSkladista];


            for (int i = 0; i < Podaci.brojSkladista; i++)  //stvori objekt za svako skladište 
                Podaci.skladista.Add(new Podaci.Skladiste());

            reader.ReadLine();  //preskoči prazan red

            for (int i = 0; i < Podaci.brojSkladista; i++)    //učitaj koordinate svih skladišta
            {
                line = reader.ReadLine();
                string[] koordinate = line.Split(new char[] { '\t' });
                int x = Convert.ToInt32(koordinate[0]);
                int y = Convert.ToInt32(koordinate[1]);
                Podaci.skladista[i].id = i;
                Podaci.skladista[i].x = x;
                Podaci.skladista[i].y = y;
                Podaci.skladista[i].odabrano = 0;
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
                Podaci.korisnici[i].id = i;
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

            //izračunaj udaljenosti između svih korisnika
            for (int i = 0; i < Podaci.brojKorisnika; i++)
            {
                for (int j = i; j < Podaci.brojKorisnika; j++)
                {
                    int x=Podaci.korisnici[i].x-Podaci.korisnici[j].x;
                    int y=Podaci.korisnici[i].y-Podaci.korisnici[j].y;
                    Podaci.udaljenosti[i, j] =(int) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))*100;
                    Podaci.prosjecnaUdaljenost += Podaci.udaljenosti[i, j];
                }

                //udaljenost između korisnika i skladišta
                for (int k=Podaci.brojKorisnika; k<Podaci.brojKorisnika+Podaci.brojSkladista; k++){
                    int x = Podaci.korisnici[i].x - Podaci.skladista[k - Podaci.brojKorisnika].x;
                    int y = Podaci.korisnici[i].y - Podaci.skladista[k - Podaci.brojKorisnika].y;
                    Podaci.udaljenosti[i, k] =(int) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))*100;
                    Podaci.prosjecnaUdaljenost += Podaci.udaljenosti[i, k];
                }
            }

            //izračunaj udaljenosti između skladišta (neće se koristiti, računa se samo radi forme)
            for (int i = 0; i < Podaci.brojSkladista; i++)
            {
                for (int j = i; j < Podaci.brojSkladista; j++)
                {
                    int x = Podaci.skladista[i].x - Podaci.skladista[j].x;
                    int y = Podaci.skladista[i].y - Podaci.skladista[j].y;
                    Podaci.udaljenosti[i + Podaci.brojKorisnika, j + Podaci.brojKorisnika] =(int) Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))*100;
                }
            }

                Podaci.prosjecnaUdaljenost = (int)Podaci.prosjecnaUdaljenost / (Podaci.brojKorisnika * (Podaci.brojKorisnika - 1) / 2 + Podaci.brojSkladista);

            //na elemente prije dijagonale upiši elemente simetrične s obzirom na dijagonalu matrice (jer je d(i,j)=d(j,i), d-udaljenost)
            for (int i = 0; i < Podaci.brojKorisnika+Podaci.brojSkladista; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Podaci.udaljenosti[i, j] = Podaci.udaljenosti[j, i];
                }
            }
        }
    }
}
