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
        private string fam_nv_medi_amm;
        private string fam_nb_medi_max;



        public famille(string leCode, string leLibelle, string leNvMediAmm, string leNbMediMax)
        {
            this.fam_code = leCode;
            this.fam_libelle = leLibelle;
            this.fam_nv_medi_amm = leNvMediAmm;
            this.fam_nb_medi_max = leNbMediMax;
        }



        public string getCode() { return this.fam_code; }
        public string getLibelle() { return this.fam_libelle; }
        public string getNvMediAmm() { return this.fam_nv_medi_amm; }
        public string getNbMediMax() { return this.fam_nb_medi_max; }
    }
}
