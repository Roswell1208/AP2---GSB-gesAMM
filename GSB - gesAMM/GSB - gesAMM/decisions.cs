using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB___gesAMM
{
    internal class decisions
    {
        private int dcs_id;
        private string dcs_libelle;

        public decisions(int leId, string leLibelle)
        {
            this.dcs_id = leId;
            this.dcs_libelle = leLibelle;
        }

        public int getId() { return this.dcs_id; }
        public string getLibelle() { return this.dcs_libelle; }
    }
}
