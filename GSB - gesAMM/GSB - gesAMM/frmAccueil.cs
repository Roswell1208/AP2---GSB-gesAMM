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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccueil maForm = new frmAccueil();
            //maForm.MdiParent = this;
            maForm.Show();
        }

        private void saisieDÈcision…tapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaisieEtape maForm = new frmSaisieEtape();
            //maForm.MdiParent = this;
            maForm.Show();
        }

        private void nouveauMÈdicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewMedicament maForm = new frmNewMedicament();
            //maForm.MdiParent = this;
            maForm.Show();
        }

        private void afficherParFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAfficherFamille maForm = new frmAfficherFamille();
            //maForm.MdiParent = this;
            maForm.Show();
        }

        private void mise¿Jour…tapesNormÈesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateEtapeNormee maForm = new frmUpdateEtapeNormee();
            //maForm.MdiParent = this;
            maForm.Show();
        }

        private void etatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEtapesMedicaments maForm = new frmEtapesMedicaments();
            //maForm.MdiParent = this;
            maForm.Show();
        }

        private void mÈdicamentsEnCoursDeValidationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicamentsEnCours maForm = new frmMedicamentsEnCours();
            //maForm.MdiParent = this;
            maForm.Show();
        }
    }
}