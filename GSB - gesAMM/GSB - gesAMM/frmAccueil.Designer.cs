namespace GSB___gesAMM
{
    partial class frmAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuGSB = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieDécisionÉtapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauMédicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherParFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourÉtapesNorméesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workflowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsEnCoursDeValidationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuGSB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuGSB
            // 
            this.MenuGSB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuGSB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.médicamentToolStripMenuItem,
            this.etapeToolStripMenuItem,
            this.workflowToolStripMenuItem});
            this.MenuGSB.Location = new System.Drawing.Point(0, 0);
            this.MenuGSB.Name = "MenuGSB";
            this.MenuGSB.Size = new System.Drawing.Size(800, 28);
            this.MenuGSB.TabIndex = 0;
            this.MenuGSB.Text = "MenuGSB";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // médicamentToolStripMenuItem
            // 
            this.médicamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieDécisionÉtapeToolStripMenuItem,
            this.nouveauMédicamentToolStripMenuItem,
            this.afficherParFamilleToolStripMenuItem});
            this.médicamentToolStripMenuItem.Name = "médicamentToolStripMenuItem";
            this.médicamentToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.médicamentToolStripMenuItem.Text = "Médicament";
            // 
            // saisieDécisionÉtapeToolStripMenuItem
            // 
            this.saisieDécisionÉtapeToolStripMenuItem.Name = "saisieDécisionÉtapeToolStripMenuItem";
            this.saisieDécisionÉtapeToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.saisieDécisionÉtapeToolStripMenuItem.Text = "Saisie décision étape";
            this.saisieDécisionÉtapeToolStripMenuItem.Click += new System.EventHandler(this.saisieDécisionÉtapeToolStripMenuItem_Click);
            // 
            // nouveauMédicamentToolStripMenuItem
            // 
            this.nouveauMédicamentToolStripMenuItem.Name = "nouveauMédicamentToolStripMenuItem";
            this.nouveauMédicamentToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.nouveauMédicamentToolStripMenuItem.Text = "Nouveau médicament";
            this.nouveauMédicamentToolStripMenuItem.Click += new System.EventHandler(this.nouveauMédicamentToolStripMenuItem_Click);
            // 
            // afficherParFamilleToolStripMenuItem
            // 
            this.afficherParFamilleToolStripMenuItem.Name = "afficherParFamilleToolStripMenuItem";
            this.afficherParFamilleToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.afficherParFamilleToolStripMenuItem.Text = "Afficher par famille";
            this.afficherParFamilleToolStripMenuItem.Click += new System.EventHandler(this.afficherParFamilleToolStripMenuItem_Click);
            // 
            // etapeToolStripMenuItem
            // 
            this.etapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseÀJourÉtapesNorméesToolStripMenuItem});
            this.etapeToolStripMenuItem.Name = "etapeToolStripMenuItem";
            this.etapeToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.etapeToolStripMenuItem.Text = "Etapes";
            // 
            // miseÀJourÉtapesNorméesToolStripMenuItem
            // 
            this.miseÀJourÉtapesNorméesToolStripMenuItem.Name = "miseÀJourÉtapesNorméesToolStripMenuItem";
            this.miseÀJourÉtapesNorméesToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.miseÀJourÉtapesNorméesToolStripMenuItem.Text = "Mise à jour étapes normées";
            this.miseÀJourÉtapesNorméesToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourÉtapesNorméesToolStripMenuItem_Click);
            // 
            // workflowToolStripMenuItem
            // 
            this.workflowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etatToolStripMenuItem,
            this.médicamentsEnCoursDeValidationToolStripMenuItem});
            this.workflowToolStripMenuItem.Name = "workflowToolStripMenuItem";
            this.workflowToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.workflowToolStripMenuItem.Text = "Workflow";
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.etatToolStripMenuItem.Text = "Etapes d\'un médicament";
            this.etatToolStripMenuItem.Click += new System.EventHandler(this.etatToolStripMenuItem_Click);
            // 
            // médicamentsEnCoursDeValidationToolStripMenuItem
            // 
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Name = "médicamentsEnCoursDeValidationToolStripMenuItem";
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Text = "Médicaments en cours de validation";
            this.médicamentsEnCoursDeValidationToolStripMenuItem.Click += new System.EventHandler(this.médicamentsEnCoursDeValidationToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuGSB);
            this.MainMenuStrip = this.MenuGSB;
            this.Name = "frmAccueil";
            this.Text = "GSB-gesAMM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuGSB.ResumeLayout(false);
            this.MenuGSB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuGSB;
        private ToolStripMenuItem etapeToolStripMenuItem;
        private ToolStripMenuItem médicamentToolStripMenuItem;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem workflowToolStripMenuItem;
        private ToolStripMenuItem saisieDécisionÉtapeToolStripMenuItem;
        private ToolStripMenuItem nouveauMédicamentToolStripMenuItem;
        private ToolStripMenuItem afficherParFamilleToolStripMenuItem;
        private ToolStripMenuItem miseÀJourÉtapesNorméesToolStripMenuItem;
        private ToolStripMenuItem etatToolStripMenuItem;
        private ToolStripMenuItem médicamentsEnCoursDeValidationToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}