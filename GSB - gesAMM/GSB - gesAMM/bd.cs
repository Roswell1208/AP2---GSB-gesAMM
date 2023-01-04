using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GSB___gesAMM
{
    internal class bd
    {
        public static bool userListCheck(string monIdentifiant, string monMotDePasse)
        {
            bool loginOk = false;

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeTousUser", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des user
            while (SqlExec.Read())
            {
                string unIdentifiant = SqlExec["identifiant"].ToString();
                string unMotDePasse = SqlExec["motDePasse"].ToString();

                if (unIdentifiant == monIdentifiant && unMotDePasse == monMotDePasse)
                {
                    loginOk = true;
                }
            }
            
            return loginOk;
        }


        public static Tuple<int, DateTime, string, string, DateTime> medDerniereEtape(string medDepotLegal)
        {
            int numEtape;
            DateTime dateEtape;
            string libelleEtape;
            string norme;
            DateTime dateNorme;


            bool test = false;

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_workflow_med", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // set up the parameters
            maRequete.Parameters.Add("@medDepotLegal", SqlDbType.VarChar, 5000);

            // set parameter values
            maRequete.Parameters["@medDepotLegal"].Value = medDepotLegal;


            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture du résultat de la requête
            while (SqlExec.Read())
            {
                numEtape = Convert.ToInt32(SqlExec["WRK_ETP_NUM"]);
                dateEtape = Convert.ToDateTime(SqlExec["WRK_DATE"]);
                libelleEtape = SqlExec["ETP_LIBELLE"].ToString();

                
                norme = SqlExec["NORME"].ToString();
                dateNorme = Convert.ToDateTime(SqlExec["NORME_DATE"]);

                return new Tuple<int, DateTime, string, string, DateTime>(numEtape, dateEtape, libelleEtape, norme, dateNorme);
            }

            return null;
        }

        public static List<medicaments> medList()
        {
            List<medicaments> listMed = new List<medicaments>();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("SELECT * FROM MEDICAMENT", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.Text;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des user
            while (SqlExec.Read())
            {
                string depotLegal = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomCommercial = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string fam_code = SqlExec["FAM_CODE"].ToString();
                string composition = SqlExec["MED_COMPOSITION"].ToString();
                string effets = SqlExec["MED_EFFETS"].ToString();
                string contreIndic = SqlExec["MED_CONTREINDIC"].ToString();
                string prixEchantillon = SqlExec["MED_PRIXECHANTILLON"].ToString();

                medicaments newMed = new medicaments(depotLegal, nomCommercial, fam_code, composition, effets, contreIndic, prixEchantillon);

                listMed.Add(newMed);
            }

            return listMed;
        }
    }
}
