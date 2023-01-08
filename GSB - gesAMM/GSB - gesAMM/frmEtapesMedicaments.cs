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
    public partial class frmEtapesMedicaments : Form
    {
        public frmEtapesMedicaments()
        {
            InitializeComponent();
        }

        private void frmEtapesMedicaments_Load(object sender, EventArgs e)
        {
            globale.cnx = new System.Data.SqlClient.SqlConnection();
            globale.cnx.ConnectionString = globale.BddConnection;
            globale.cnx.Open();

            foreach (medicaments unMed in bd.medList())
            {
                cbListMed.Items.Add(unMed.getDepotLegal() + " - " + unMed.getNomCommercial());
            }
        }

        private void cbListMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvWorkflowEtapes.Items.Clear();

            string[] depotLegal = cbListMed.Text.Split('-');
            string medDepotLegal = depotLegal[0];


            // Affichage des anciennes étapes (de la table historique)

            if (bd.medWrkEtapes(medDepotLegal) != null)
            {
                foreach(Tuple<int, string, DateTime, string, string, DateTime> values in bd.medWrkEtapes(medDepotLegal))
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = values.Item1.ToString();
                    item.SubItems.Add(values.Item2.ToString());
                    item.SubItems.Add(values.Item3.ToString());
                    item.SubItems.Add(values.Item4.ToString());
                    item.SubItems.Add(values.Item5.ToString());

                    if (values.Item6 != Convert.ToDateTime("01/01/0001 00:00:00"))
                        item.SubItems.Add(values.Item6.ToString());

                    else
                        item.SubItems.Add("");

                    lvWorkflowEtapes.Items.Add(item);
                }
            }
        }
    }
}
