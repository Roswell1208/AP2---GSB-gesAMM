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

    }
}
