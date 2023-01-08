using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
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
                string fam_code = SqlExec["FAM_MED_CODE"].ToString();
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

        public static Boolean ajouterHistorique(string nom_user, string etp_av, string etp_ap, DateTime date_av, DateTime date_ap, DateTime date_maj, int etp_num)
        {
            SqlCommand maRequete = new SqlCommand("prc_ajout_historique", globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramHIST_USER = new SqlParameter("@HIST_USR", System.Data.SqlDbType.VarChar, 32);
            paramHIST_USER.Value = nom_user;
            SqlParameter paramETP_AV = new SqlParameter("@norme_av", System.Data.SqlDbType.VarChar, 32);
            paramETP_AV.Value = etp_av;
            SqlParameter paramETP_AP = new SqlParameter("@norme_ap", System.Data.SqlDbType.VarChar, 32);
            paramETP_AP.Value = etp_ap;
            SqlParameter paramDATE_AV = new SqlParameter("@ancienneDate", System.Data.SqlDbType.Date);
            paramDATE_AV.Value = date_av;
            SqlParameter paramDATE_AP = new SqlParameter("@HIST_DATE_AP", System.Data.SqlDbType.Date);
            paramDATE_AP.Value = date_ap;
            SqlParameter paramDATE_MAJ = new SqlParameter("@HIST_DATE_MAJ", System.Data.SqlDbType.Date);
            paramDATE_MAJ.Value = date_maj;

            SqlParameter paramETP_NUM = new SqlParameter("@HIST_ETP_NUM", System.Data.SqlDbType.Int, 32);
            paramETP_NUM.Value = etp_num;

            maRequete.Parameters.Add(paramHIST_USER);
            maRequete.Parameters.Add(paramETP_AV);
            maRequete.Parameters.Add(paramETP_AP);
            maRequete.Parameters.Add(paramDATE_AV);
            maRequete.Parameters.Add(paramDATE_AP);
            maRequete.Parameters.Add(paramDATE_MAJ);
            maRequete.Parameters.Add(paramETP_NUM);

            // exécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                // vérifie les potentiels msg d'erreur
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public static Boolean updateEtape(string etape, DateTime date, string norme)
        {
            SqlCommand maRequete = new SqlCommand("prc_update_etpnorme", globale.cnx);
            // Il s’agit d’une procédure stockée:
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // Ajouter les parameters à la procédure stockée
            SqlParameter paramETAPE = new SqlParameter("@etp_num", System.Data.SqlDbType.Int);
            paramETAPE.Value = etape;
            SqlParameter paramDATE = new SqlParameter("@norme_date", System.Data.SqlDbType.Date);
            paramDATE.Value = date;
            SqlParameter paramNORME = new SqlParameter("@norme", System.Data.SqlDbType.VarChar, 32);
            paramNORME.Value = norme;

            maRequete.Parameters.Add(paramETAPE);
            maRequete.Parameters.Add(paramDATE);
            maRequete.Parameters.Add(paramNORME);

            // exécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void lireLesMedEnCours()
        {
            globale.lesFamilles.Clear();
            globale.lesMedicaments.Clear();
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_med_encours", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();


            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                //string FamCode = SqlExec["FAM_MED_CODE"].ToString();
                string DepotLegal = SqlExec["MED_DEPOTLEGAL"].ToString();
                string NomCommerc = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                //string FamLibelle = SqlExec["FAM_LIBELLE"].ToString();
                string CodeFamille = SqlExec["FAM_CODE"].ToString();

                //if(globale.lesFamilles.ContainsKey(CodeFamille))
                //{
                //}

                //else
                //{
                    //famille unefamille = new famille(CodeFamille, FamLibelle, null, null);
                    medicaments unMedicament = new medicaments(DepotLegal, NomCommerc, null, null, null, null, null);

                    //globale.lesFamilles.Add(CodeFamille, unefamille);
                    globale.lesMedicaments.Add(DepotLegal, unMedicament);
                //}
            }
        }

        public static List<workflow> lireWorkflowMed()
        {
            //globale.lesMedicaments.Clear();
            List<workflow> wrk_med = new List<workflow>();
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_work_selection_med", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();


            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string MedDepot = SqlExec["WRK_MED_DEPOT"].ToString();
                string ETP_NUM = SqlExec["WRK_ETP_NUM"].ToString();
                string DCS_ID = SqlExec["WRK_DCS_ID"].ToString();
                string Date = SqlExec["WRK_DATE"].ToString();

                //medicaments unMedicament = new medicaments(DepotLegal, NomCommerc, null, null, null, null, null);

                //globale.lesMedicaments.Add(DepotLegal, unMedicament);

                workflow newMed = new workflow(MedDepot, ETP_NUM, DCS_ID, Date);

                wrk_med.Add(newMed);
            }

            return wrk_med;
        }



        // C. Ajout d'un nouveau médicament

        public static List<famille> familleList()
        {
            List<famille> listFam = new List<famille>();

            //objet SQLCommand pour définir la requête à utiliser
            SqlCommand maRequete = new SqlCommand("SELECT * FROM FAMILLE", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.Text;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des user
            while (SqlExec.Read())
            {
                string famCode = SqlExec["FAM_CODE"].ToString();
                string famLibelle = SqlExec["FAM_LIBELLE"].ToString();
                string famNbMed = SqlExec["FAM_NB_MEDI_AMM"].ToString();

                famille newFamille = new famille(famCode, famLibelle, famNbMed);

                listFam.Add(newFamille);
            }

            return listFam;
        }


        public static void ajoutNewMed(string medDepotLegal, string nomCommercial, string famCode,
            string composition, string effets, string contreIndic, string prixEchant)
        {
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_ajoutNewMed", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // set up the parameters
            maRequete.Parameters.Add("@medDepotLegal", SqlDbType.VarChar, 5000);
            maRequete.Parameters.Add("@nomCommercial", SqlDbType.VarChar, 5000);
            maRequete.Parameters.Add("@famCode", SqlDbType.VarChar, 5000);
            maRequete.Parameters.Add("@composition", SqlDbType.VarChar, 5000);
            maRequete.Parameters.Add("@effets", SqlDbType.VarChar, 5000);
            maRequete.Parameters.Add("@contreIndic", SqlDbType.VarChar, 5000);
            maRequete.Parameters.Add("@prixEchant", SqlDbType.VarChar, 5000);

            // set parameter values
            maRequete.Parameters["@medDepotLegal"].Value = medDepotLegal;
            maRequete.Parameters["@nomCommercial"].Value = nomCommercial;
            maRequete.Parameters["@famCode"].Value = famCode;
            maRequete.Parameters["@composition"].Value = composition;
            maRequete.Parameters["@effets"].Value = effets;
            maRequete.Parameters["@contreIndic"].Value = contreIndic;
            maRequete.Parameters["@prixEchant"].Value = prixEchant;

            // exécuter la procedure stockée dans un curseur 
            maRequete.ExecuteNonQuery();
        }

    }
}
