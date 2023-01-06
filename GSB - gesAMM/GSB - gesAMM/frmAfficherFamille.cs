using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB___gesAMM
{
    public partial class frmAfficherFamille : Form
    {
        public frmAfficherFamille()
        {
            InitializeComponent();
        }

        private void frmAfficherFamille_Load(object sender, EventArgs e)
        {
            lv_med_fam.Items.Clear();

            bd.lireLesMedicamentsFamilles();

            //foreach (string FamCode in bd.lireLesMedicamentsFamilles().Keys)
            //{
                //int nbMed = bd.lireLesMedicamentsFamilles().Keys;

                foreach (string laFamille in globale.lesFamilles.Keys)
                {
                    ListViewItem unMedicament = new ListViewItem();
                    unMedicament.Text = globale.lesFamilles[laFamille].getCode();
                    unMedicament.SubItems.Add(globale.lesFamilles[laFamille].getLibelle());
                    unMedicament.SubItems.Add(globale.lesFamilles[laFamille].getNvMediAmm());
                    lv_med_fam.Items.Add(unMedicament);
                }

            //}

        }

        private void lv_med_fam_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_med_selec.Items.Clear();

            bd.lireLesMedicamentsSelectionne();

            foreach (string leMedicament in globale.lesMedicaments.Keys)
            {
                if (lv_med_fam.SelectedItems.Count > 0) // Vérifie qu'au moins un Items a été sélectionné
                {
                    foreach (ListViewItem item in lv_med_fam.SelectedItems)
                    {
                        if (globale.lesMedicaments[leMedicament].getFamCode() == item.Text)
                        {
                            // Votre code ici
                            ListViewItem unMedicament = new ListViewItem();
                            unMedicament.Text = globale.lesMedicaments[leMedicament].getDepotLegal();
                            unMedicament.SubItems.Add(globale.lesMedicaments[leMedicament].getNomCommercial());
                            unMedicament.SubItems.Add(globale.lesMedicaments[leMedicament].getFamCode());
                            unMedicament.SubItems.Add(globale.lesMedicaments[leMedicament].getComposition());
                            unMedicament.SubItems.Add(globale.lesMedicaments[leMedicament].getEffets());
                            unMedicament.SubItems.Add(globale.lesMedicaments[leMedicament].getContreIndic());
                            unMedicament.SubItems.Add(globale.lesMedicaments[leMedicament].getPrixEchantillon());
                            lv_med_selec.Items.Add(unMedicament);
                        }
                    }
                }
            }
        }
    }
}
