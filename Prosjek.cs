using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak21
{
    internal class Prosjek
    {
        //todo
        string nazivPredmeta;
        int ocijene;

        public Prosjek(string nazivPredmeta, int ocijene)
        {
            this.NazivPredmeta = nazivPredmeta;
            this.Ocijene = ocijene;
        }
        public Prosjek()
        {

         }
        public string NazivPredmeta { get => nazivPredmeta; set => nazivPredmeta = value; }
        public int Ocijene { get => ocijene; set => ocijene = value; }

    }
}
