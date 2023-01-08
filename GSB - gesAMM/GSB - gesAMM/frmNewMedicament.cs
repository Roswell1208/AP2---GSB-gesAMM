using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GSB___gesAMM
{
    public partial class frmNewMedicament : Form
    {
        public frmNewMedicament()
        {
            InitializeComponent();
        }

        private void frmNewMedicament_Load(object sender, EventArgs e)
        {
            globale.cnx = new System.Data.SqlClient.SqlConnection();
            globale.cnx.ConnectionString = globale.BddConnection;
            globale.cnx.Open();

            foreach (famille uneFam in bd.familleList())
            {
                cbListFam.Items.Add(uneFam.getCode() + " - " + uneFam.getLibelle());
            }

            foreach (medicaments unMed in bd.medList())
            {
                globale.lesMedicaments.Add(unMed.getDepotLegal(), unMed);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbDepotLegal.Text != "" && tbNomCommercial.Text != "" && cbListFam.SelectedIndex != -1 && tbComposition.Text != "" 
                && tbEffets.Text != "" && tbContreIndic.Text != "" && tbPrixEchant.Text != "")
            {
                bool depotLegalCheck = false;

                foreach (string unDepotLegal in globale.lesMedicaments.Keys)
                {
                    if(tbDepotLegal.Text != unDepotLegal)
                    {
                        depotLegalCheck = true;
                    }

                    else
                    {
                        depotLegalCheck = false;
                        MessageBox.Show("Erreur, le dépot légal entré existe déjà");
                        break;
                    }
                }

                if (depotLegalCheck == true)
                {
                    string[] codesFamille = cbListFam.Text.Split('-');
                    string famCode = codesFamille[0];

                    bd.ajoutNewMed(tbDepotLegal.Text, tbNomCommercial.Text, famCode, tbComposition.Text, tbEffets.Text, tbContreIndic.Text, tbPrixEchant.Text);

                    MessageBox.Show("Requête envoyée");
                }
            }

            else
            {
                MessageBox.Show("Certaines données n'ont pas été renseignées");
            }
        }
    }
}
