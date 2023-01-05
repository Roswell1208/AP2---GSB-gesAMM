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
    public partial class frmUpdateEtapeNormee : Form
    {
        public frmUpdateEtapeNormee()
        {
            InitializeComponent();
        }

        private void frmUpdateEtapeNormee_Load(object sender, EventArgs e)
        {
            lv_etape.Items.Clear();

            bd.lireLesEtapesNormees();

            foreach (string uneEtape in globale.lesEtapesNormees.Keys)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = globale.lesEtapesNormees[uneEtape].getNorme();
                lvi.SubItems.Add(globale.lesEtapesNormees[uneEtape].getDate());
                lvi.SubItems.Add(globale.lesEtapesNormees[uneEtape].getNumEtape());
                lv_etape.Items.Add(lvi);
            }
        }

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            // Faut il update l'etape Norme ? OU insert dans l'historique ??
        }
    }
}
