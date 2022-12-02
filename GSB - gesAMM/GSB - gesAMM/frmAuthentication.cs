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
    public partial class frmAuthentication : Form
    {
        public frmAuthentication()
        {
            InitializeComponent();
        }

        private Boolean controlValidite()
        {
            return (tbIdentifiant.Text.Length >= 8 && tbMotDePasse.Text.Length >= 8);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAuthentication_Load(object sender, EventArgs e)
        {
            btnValider.Enabled = controlValidite();

            globale.cnx = new System.Data.SqlClient.SqlConnection();
            globale.cnx.ConnectionString = "Data Source=BTS2021-25\\SQLEXPRESS01;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
            globale.cnx.Open();
        }

        private void tbIdentifiant_TextChanged(object sender, EventArgs e)
        {
            btnValider.Enabled = controlValidite();
        }

        private void tbMotDePasse_TextChanged(object sender, EventArgs e)
        {
            btnValider.Enabled = controlValidite();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (bd.userListCheck(tbIdentifiant.Text, tbMotDePasse.Text) == true)
            {
                frmAccueil maForm = new frmAccueil();
                maForm.Show();
            }
            else
            {
                MessageBox.Show("Identifiant et/ou mot de passe incorrects", "MEDIA35", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
