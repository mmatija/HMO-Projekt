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
        }

    }
}
