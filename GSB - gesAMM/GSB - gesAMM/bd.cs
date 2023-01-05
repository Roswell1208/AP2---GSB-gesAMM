using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

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

        public static void lireLesMedicamentsFamilles()
        {

            globale.lesFamilles.Clear();
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_med_famille", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {

                string nbMedicament = SqlExec["NbMedicaments"].ToString();
                string CodeFamille = SqlExec["FAM_CODE"].ToString();
                string LibelleFamille = SqlExec["FAM_LIBELLE"].ToString();

                
                famille uneFamille = new famille(CodeFamille, LibelleFamille, nbMedicament);

                globale.lesFamilles.Add(CodeFamille, uneFamille);
            }
        }

        public static void lireLesMedicamentsSelectionne()
        {
            globale.lesMedicaments.Clear();
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_med_selectionne", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {

                string DepotLegal = SqlExec["MED_DEPOTLEGAL"].ToString();
                string NomCommercial = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string CodeFamille = SqlExec["FAM_MED_CODE"].ToString();
                string Composition = SqlExec["MED_COMPOSITION"].ToString();
                string Effets = SqlExec["MED_EFFETS"].ToString();
                string ContreIndic = SqlExec["MED_CONTREINDIC"].ToString();
                string PrixEchantillon = SqlExec["MED_PRIXECHANTILLON"].ToString();

                medicaments unMedicament = new medicaments(DepotLegal, NomCommercial, CodeFamille, Composition, 
                    Effets, ContreIndic, PrixEchantillon);

                globale.lesMedicaments.Add(DepotLegal, unMedicament);
            }

        }

        public static void lireLesEtapesNormees()
        {
            globale.lesEtapesNormees.Clear();
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_etapeNormees", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {

                string CodeNorme = SqlExec["NORME"].ToString();
                string Date = SqlExec["NORME_DATE"].ToString();
                string NumEtape = SqlExec["ETAPE_ETP_NUM"].ToString();

                etapeNormees uneEtapeNormee = new etapeNormees(CodeNorme, Date, NumEtape);

                globale.lesEtapesNormees.Add(CodeNorme, uneEtapeNormee);
            }
        }
    }
}
