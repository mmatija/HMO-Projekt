using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO_Projekt
{
    class KolonijaMrava
    {

        int trosakSkladista()
        {
            int sum = 0;
            foreach (Podaci.Skladiste s in Podaci.skladista)
            {
                sum += s.odabrano * s.trosakOtvaranja;
            }
            return sum;
        }

        KolonijaMrava(int brojMrava, float ro, int alfa, int beta)
        {
            this.brojMrava = brojMrava;
            this.ro = ro;
            this.alfa = alfa;
            this.beta = beta;

            for (int i = 0; i < Podaci.brojKorisnika+Podaci.brojSkladista; i++)
            {
                for (int j = 0; j < Podaci.brojKorisnika + Podaci.brojSkladista; j++)
                {
                    tau[i, j] = 1 / Podaci.prosjecnaUdaljenost;     //inicijaliziraj feromone
                    if (i == j) continue;
                    eta[i, j] = 1 / Podaci.udaljenosti[i, j];       //inicijaliziraj vrijednosti specifične za heuristiku

                }
            }
        }

        class Mrav
        {
            int pocetnoSkladiste;               //skladište iz kojeg mrav kreće
            List<int> put = new List<int>();    //konstruirani put

        }

        float ro;
        int alfa;
        int beta;
        int brojMrava;
        float[,] tau = new float[Podaci.brojKorisnika+Podaci.brojSkladista, Podaci.brojKorisnika+Podaci.brojSkladista];
        float[,] eta = new float[Podaci.brojKorisnika+Podaci.brojSkladista, Podaci.brojKorisnika+Podaci.brojSkladista];

    }
}
