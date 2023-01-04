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
            }

            else
            {
                MessageBox.Show("Erreur, la dernière étape a été refusée pour ce médicament.");
            }
        }
    }
}
