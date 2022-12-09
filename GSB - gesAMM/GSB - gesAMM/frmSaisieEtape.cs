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
    }
}
