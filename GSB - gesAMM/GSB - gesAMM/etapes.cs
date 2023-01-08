using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB___gesAMM
{
    internal class etapes
    {
        private int etp_num;
        private string etp_libelle;

        public etapes(int leNum, string leLibelle)
        {
            this.etp_num = leNum;
            this.etp_libelle = leLibelle;
        }

        public int getNum() { return this.etp_num; }
        public string getLibelle() { return this.etp_libelle; }
    }
}
