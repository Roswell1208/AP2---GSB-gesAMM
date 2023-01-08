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

        // BDD Hugo
        //public static string BddConnection = "Data Source=BTS2021-25\\SQLEXPRESS01;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";

        // BDD Vincent
        public static string BddConnection = "Data Source=BTS2021-20\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";

        // BDD Esteban
        // public static string BddConnection = "Data Source=BTS2021-29\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
        
        
        public static Dictionary<string, famille> lesFamilles = new Dictionary<string, famille>();
        public static Dictionary<string, medicaments> lesMedicaments = new Dictionary<string, medicaments>();
        public static Dictionary<string, etapeNormees> lesEtapesNormees = new Dictionary<string, etapeNormees>();
        public static List<etapes> lesEtapes = new List<etapes>();
        public static List<decisions> lesDecisions = new List<decisions>();
        public static string user;
    }
}
