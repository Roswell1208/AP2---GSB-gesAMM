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
        }
    }
}
