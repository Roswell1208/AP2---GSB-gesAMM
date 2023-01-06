using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GSB___gesAMM
{
    internal class globale
    {
        public static SqlConnection cnx;
        public static Dictionary<string, famille> lesFamilles = new Dictionary<string, famille>();
        public static Dictionary<string, medicaments> lesMedicaments = new Dictionary<string, medicaments>();
        public static Dictionary<string, etapeNormees> lesEtapesNormees = new Dictionary<string, etapeNormees>();
        public static string user;
    }
}
