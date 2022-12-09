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
        /*public static void lireLesMedicamentsFamilles()
        {
            globale.lesClients.Clear();

            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_med_famille", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int idClient = int.Parse(SqlExec["idClient"].ToString());
                string nomClient = SqlExec["nomClient"].ToString();

                client leClient = new client(idClient, nomClient);

                globale.lesClients.Add(leClient);
            }
        }*/
    }
}
