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
    }
}
