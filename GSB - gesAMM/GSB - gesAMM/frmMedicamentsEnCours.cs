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
    public partial class frmMedicamentsEnCours : Form
    {
        public frmMedicamentsEnCours()
        {
            InitializeComponent();
        }

        private void frmMedicamentsEnCours_Load(object sender, EventArgs e)
        {
            lv_med.Items.Clear();

            bd.lireLesMedEnCours();


            //foreach (string laFamille in globale.lesFamilles.Keys)
            //{
                foreach(string leMedicament in globale.lesMedicaments.Keys)
                {
                    ListViewItem unMedicament = new ListViewItem();
                    unMedicament.Text = globale.lesMedicaments[leMedicament].getDepotLegal();
                    unMedicament.SubItems.Add(globale.lesMedicaments[leMedicament].getNomCommercial());
                    //unMedicament.SubItems.Add(globale.lesFamilles[laFamille].getLibelle());
                    lv_med.Items.Add(unMedicament);

                    //string depotLegal = globale.lesMedicaments[leMedicament].getDepotLegal();
                    //string nomCommercial = globale.lesMedicaments[leMedicament].getNomCommercial();
                    //string Libelle = globale.lesFamilles[laFamille].getLibelle();
                }
            //}
        }

        private void lv_med_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_medwork.Items.Clear();
            bd.lireLesMedEnCours();


            foreach (string leMedicament in globale.lesMedicaments.Keys)
            {
                if (lv_med.SelectedItems.Count > 0) // Vérifie qu'au moins un Items a été sélectionné
                {
                    foreach (ListViewItem item in lv_med.SelectedItems)
                    {
                        if (globale.lesMedicaments[leMedicament].getDepotLegal() == item.Text)
                        {
                            ListViewItem lvi = new ListViewItem();
                            //lvi.Text = (globale.lesEtapesNormees[laetapeNormee].getNumEtape());
                            //lvi.SubItems.Add(globale.lesEtapesNormees[laetapeNormee].getDate());
                            //lvi.SubItems.Add(globale.lesEtapesNormees[laetapeNormee].getNorme());
                            lv_medwork.Items.Add(lvi);
                        }
                    }
                }
            }
        }
    }
}
