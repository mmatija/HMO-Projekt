using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO_Projekt
{
    class KolonijaMrava
    {
        KolonijaMrava(int brojMrava, float ro, int alfa, int beta)
        {
            this.brojMrava = brojMrava;
            this.ro = ro;
            this.alfa = alfa;
            this.beta = beta;
        }

        float ro;
        int alfa;
        int beta;
        int brojMrava;
    }
}
