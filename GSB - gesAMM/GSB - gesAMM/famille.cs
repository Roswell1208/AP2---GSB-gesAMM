using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB___gesAMM
{
    internal class famille
    {
        private string fam_code;
        private string fam_libelle;
        private string fam_nb_medi_amm;



        public famille(string leCode, string leLibelle, string leNbMediAmm)
        {
            this.fam_code = leCode;
            this.fam_libelle = leLibelle;
            this.fam_nb_medi_amm = leNbMediAmm;
        }



        public string getCode() { return this.fam_code; }
        public string getLibelle() { return this.fam_libelle; }
        public string getNbMediAmm() { return this.fam_nb_medi_amm; }
    }
}
