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

        DateTime date_av;
        string norme_av;
        string NumEtape;

        private void chargerListe()
        {
            lv_etape.Items.Clear();

            bd.lireLesEtapesNormees();

            foreach (string uneEtape in globale.lesEtapesNormees.Keys)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = globale.lesEtapesNormees[uneEtape].getNumEtape();
                lvi.SubItems.Add(globale.lesEtapesNormees[uneEtape].getDate());
                lvi.SubItems.Add(globale.lesEtapesNormees[uneEtape].getNorme());


                date_av =  Convert.ToDateTime(globale.lesEtapesNormees[uneEtape].getDate());
                norme_av = globale.lesEtapesNormees[uneEtape].getNorme();
                NumEtape = globale.lesEtapesNormees[uneEtape].getNumEtape();
                lv_etape.Items.Add(lvi);
            }
        }
        private void frmUpdateEtapeNormee_Load(object sender, EventArgs e)
        {
            chargerListe();
            btn_envoyer.Enabled = false;
        }
        

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            if (dt_date.Value.ToString() != "" && tb_norme.Text != "")
            {
               try
               {
                    // Vérifier qu'on ne peut pas insérer une date < ou > à celle du jour
                    //MessageBox.Show(bd.ajouterHistorique(globale.user, "", tb_norme.Text, DateTime.Now, dt_date.Value, DateTime.Now, 1).ToString());
                    if (bd.updateEtape(lv_etape.SelectedItems[0].Text, dt_date.Value, tb_norme.Text)
                        && bd.ajouterHistorique(globale.user, norme_av, tb_norme.Text, date_av, dt_date.Value, DateTime.Now, Convert.ToInt32(NumEtape)))
                    {
                        MessageBox.Show("L'étape et l'ajout ont bien été modifié");
                        chargerListe();
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la modification de l'étape");
                    }
               }
               catch
               {
                   MessageBox.Show("Erreur, le n° de l'étape doit être un string");
               }
            }
            else
            {
                MessageBox.Show("Erreur, il faut renseigner tous les champs");
            }
        }

        private void lv_etape_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.lireLesEtapesNormees();

            foreach (string laetapeNormee in globale.lesEtapesNormees.Keys)
            {
                if (lv_etape.SelectedItems.Count > 0) // Vérifie qu'au moins un Items a été sélectionné
                {
                    foreach (ListViewItem item in lv_etape.SelectedItems)
                    {
                        if (globale.lesEtapesNormees[laetapeNormee].getNumEtape() == item.Text)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = (globale.lesEtapesNormees[laetapeNormee].getNumEtape());
                            lvi.SubItems.Add(globale.lesEtapesNormees[laetapeNormee].getDate());
                            lvi.SubItems.Add(globale.lesEtapesNormees[laetapeNormee].getNorme());
                            lv_etape.Items.Add(lvi);
                        }
                    }
                }
            }
            btn_envoyer.Enabled = true;
        }
    }
}
