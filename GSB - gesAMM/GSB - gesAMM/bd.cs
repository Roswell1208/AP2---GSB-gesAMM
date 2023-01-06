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

        // Page de connexion

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




        // A.Saisie de la décision d'une étape

        public static List<medicaments> medList()
        {
            List<medicaments> listMed = new List<medicaments>();

            //objet SQLCommand pour définir la requête à utiliser
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


        public static Tuple<int, DateTime, string, string, DateTime> medDerniereEtape(string medDepotLegal)
        {
            int numEtape;
            DateTime dateEtape;
            string libelleEtape;
            string norme;
            DateTime dateNorme;


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



        public static Tuple<int, string, string, DateTime> etapeSuivante(int etapeNum)
        {
            int numEtape;
            string libelleEtape;
            string norme;
            DateTime dateNorme;


            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_etape_suivante", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // set up the parameters
            maRequete.Parameters.Add("@numEtape", SqlDbType.Int);

            // set parameter values
            maRequete.Parameters["@numEtape"].Value = etapeNum;


            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture du résultat de la requête
            while (SqlExec.Read())
            {
                numEtape = Convert.ToInt32(SqlExec["ETP_NUM"]);
                libelleEtape = SqlExec["ETP_LIBELLE"].ToString();
                norme = SqlExec["NORME"].ToString();
                dateNorme = Convert.ToDateTime(SqlExec["NORME_DATE"]);

                return new Tuple<int, string, string, DateTime>(numEtape, libelleEtape, norme, dateNorme);
            }

            return null;
        }


        public static void saisieDecision(string medDepotLegal, int numEtape, int idDecision, DateTime dateDecision)
        {
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_saisieDecision", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // set up the parameters
            maRequete.Parameters.Add("@medDepotLegal", SqlDbType.VarChar, 5000);
            maRequete.Parameters.Add("@numEtape", SqlDbType.Int);
            maRequete.Parameters.Add("@idDecision", SqlDbType.Int);
            maRequete.Parameters.Add("@dateDecision", SqlDbType.DateTime);

            // set parameter values
            maRequete.Parameters["@medDepotLegal"].Value = medDepotLegal;
            maRequete.Parameters["@numEtape"].Value = numEtape;
            maRequete.Parameters["@idDecision"].Value = idDecision;
            maRequete.Parameters["@dateDecision"].Value = dateDecision;

            // exécuter la procedure stockée dans un curseur 
            maRequete.ExecuteNonQuery();
        }




        // D.Consultation du workflow des étapes d'un médicament


        public static List<Tuple<int, string, DateTime, string, string, DateTime>> medWrkEtapes(string medDepotLegal)
        {
            int numEtape;
            string libelleEtape;
            DateTime dateDecision;
            string libelleDecision;
            string norme;
            DateTime dateNorme;

            List<Tuple<int, string, DateTime, string, string, DateTime>> listTuples = new List<Tuple<int, string, DateTime, string, string, DateTime>>();


            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_wrkEtapes", globale.cnx);
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
                numEtape = Convert.ToInt32(SqlExec["ETP_NUM"]);
                libelleEtape = SqlExec["ETP_LIBELLE"].ToString();
                dateDecision = Convert.ToDateTime(SqlExec["WRK_DATE"]);
                libelleDecision = SqlExec["DCS_LIBELLE"].ToString();
                norme = SqlExec["NORME"].ToString();

                if (SqlExec["NORME_DATE"].ToString() == "")
                {
                    dateNorme = Convert.ToDateTime("01/01/0001 00:00:00");
                }

                else
                {
                    dateNorme = Convert.ToDateTime(SqlExec["NORME_DATE"]);
                }
                    


                Tuple<int, string, DateTime, string, string, DateTime> myTuple = new Tuple<int, string, DateTime, string, string, DateTime>(numEtape, libelleEtape, dateDecision, libelleDecision, norme, dateNorme);
                
                listTuples.Add(myTuple);
            }

            return listTuples;
        }
    }
}
