using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB___gesAMM
{
    public partial class frmSaisieEtape : Form
    {
        public frmSaisieEtape()
        {
            InitializeComponent();
        }

        private void frmSaisieEtape_Load(object sender, EventArgs e)
        {
            globale.cnx = new System.Data.SqlClient.SqlConnection();
            globale.cnx.ConnectionString = globale.BddConnection;
            globale.cnx.Open();

            foreach(medicaments unMed in bd.medList())
            {
                cbListMed.Items.Add(unMed.getDepotLegal() + " - " + unMed.getNomCommercial());
            }
        }

        private void cbListMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvLastEtapeMed.Items.Clear();
            tbNumEtape.Clear();
            tbLibelleEtape.Clear();
            tbNorme.Clear();
            tbDateNorme.Clear();
            rbAcceptee.Checked = false;
            rbRefusee.Checked = false;

            gbSaisieEtape.Enabled = false;

            string[] depotLegal = cbListMed.Text.Split('-');
            string medDepotLegal = depotLegal[0];

            if (bd.medDerniereEtape(medDepotLegal) != null)
            {
                Tuple<int, DateTime, string, string, DateTime> values = bd.medDerniereEtape(medDepotLegal);

                ListViewItem item = new ListViewItem();

                item.Text = values.Item1.ToString();
                item.SubItems.Add(values.Item2.ToString());
                item.SubItems.Add(values.Item3.ToString());
                item.SubItems.Add(values.Item4.ToString());

                if (values.Item5 != Convert.ToDateTime("01/01/0001 00:00:00"))
                    item.SubItems.Add(values.Item5.ToString());

                else
                    item.SubItems.Add("");

                lvLastEtapeMed.Items.Add(item);



                // Si le médicament n'est pas déjà en authorisation de mise sur le marché

                if (values.Item1 < 8)
                {
                    gbSaisieEtape.Enabled = true;
                    Tuple<int, string, string, DateTime> values2 = bd.etapeSuivante(values.Item1);

                    tbNumEtape.Text = values2.Item1.ToString();
                    tbLibelleEtape.Text= values2.Item2.ToString();
                    tbNorme.Text = values2.Item3.ToString();

                    if (values2.Item4 != Convert.ToDateTime("01/01/0001 00:00:00"))
                        tbDateNorme.Text = values2.Item4.ToString();

                    else
                        tbDateNorme.Text = "";
                }
            }

            else
            {
                MessageBox.Show("Erreur, la dernière étape a été refusée pour ce médicament.");
            }
        }

        private void rbAcceptee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAcceptee.Checked == true && rbRefusee.Checked == false)
                btnValider.Enabled = true;

            else if (rbAcceptee.Checked == false && rbRefusee.Checked == true)
                btnValider.Enabled = true;

            else
                btnValider.Enabled = false;
        }

        private void rbRefusee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAcceptee.Checked == true && rbRefusee.Checked == false)
                btnValider.Enabled = true;

            else if (rbAcceptee.Checked == false && rbRefusee.Checked == true)
                btnValider.Enabled = true;

            else
                btnValider.Enabled = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string[] depotLegal = cbListMed.Text.Split('-');
            string medDepotLegal = depotLegal[0];

            int numEtape = Convert.ToInt32(tbNumEtape.Text);

            int idDecision;

            if(rbAcceptee.Checked == true)
                idDecision = 1;
            else
                idDecision = 2;

            DateTime dateDecision = dtpDateDecision.Value;


            bd.saisieDecision(medDepotLegal, numEtape, idDecision, dateDecision);
            MessageBox.Show("Etape mise à jour avec succès");

            lvLastEtapeMed.Items.Clear();
            cbListMed.Text = "";
            gbSaisieEtape.Enabled = false;
        }
    }
}
