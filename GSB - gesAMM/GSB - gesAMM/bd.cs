using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
