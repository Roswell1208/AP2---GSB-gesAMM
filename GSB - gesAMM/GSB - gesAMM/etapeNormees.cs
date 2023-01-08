using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB___gesAMM
{
    internal class etapeNormees
    {
        private string norme;
        private string date;
        private string NumEtape;

        public etapeNormees(string laNorme, string laDate, string leNumEtape)
        {
            this.norme = laNorme;
            this.date = laDate;
            this.NumEtape = leNumEtape;
        }

        public string getNorme() { return this.norme; }
        public string getDate() { return this.date; }
        public string getNumEtape() { return this.NumEtape; }
    }
}
