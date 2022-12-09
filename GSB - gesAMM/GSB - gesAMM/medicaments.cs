using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB___gesAMM
{
    internal class medicaments
    {
        private string depotLegal;
        private string nomCommercial;
        private string fam_code;
        private string composition;
        private string effets;
        private string contreIndic;
        private string prixEchantillon;

        private List<famille> lesfamilles;



        public medicaments(string ledepotLegal, string lenomCommercial, string lafamCode, string laCompostion,
            string lesEffets, string lesContreIndic, string lePrixEchantillon)
        {
            this.depotLegal = ledepotLegal;
            this.nomCommercial = lenomCommercial;
            this.fam_code = lafamCode;
            this.composition = laCompostion;
            this.effets = lesEffets;
            this.contreIndic = lesContreIndic;
            this.prixEchantillon = lePrixEchantillon;
            this.lesfamilles = new List<famille>();
        }

        public string getDepotLegal() { return this.depotLegal; }
        public string getNomCommercial() { return this.nomCommercial; }



        public string getFamCode() { return this.fam_code; }
        public string getComposition() { return this.composition; }

        public string getEffets() { return this.effets; }
        public string getContreIndic() { return this.contreIndic; }
        public string getPrixEchantillon() { return this.prixEchantillon; }

        public List<famille> getLesFamilles() { return this.lesfamilles; }
    }
}
