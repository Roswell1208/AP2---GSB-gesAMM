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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
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
            this.pb_gsb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuGSB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gsb)).BeginInit();
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
            this.médicamentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.médicamentToolStripMenuItem.Name = "médicamentToolStripMenuItem";
            this.médicamentToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.médicamentToolStripMenuItem.Text = "Médicament";
            // 
            // saisieDécisionÉtapeToolStripMenuItem
            // 
            this.saisieDécisionÉtapeToolStripMenuItem.Name = "saisieDécisionÉtapeToolStripMenuItem";
            this.saisieDécisionÉtapeToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.saisieDécisionÉtapeToolStripMenuItem.Text = "Saisie décision étape";
            this.saisieDécisionÉtapeToolStripMenuItem.Click += new System.EventHandler(this.saisieDécisionÉtapeToolStripMenuItem_Click_1);
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
            this.miseÀJourÉtapesNorméesToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourÉtapesNorméesToolStripMenuItem_Click_1);
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
            // pb_gsb
            // 
            this.pb_gsb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.pb_gsb.Image = ((System.Drawing.Image)(resources.GetObject("pb_gsb.Image")));
            this.pb_gsb.Location = new System.Drawing.Point(197, 69);
            this.pb_gsb.Margin = new System.Windows.Forms.Padding(2);
            this.pb_gsb.Name = "pb_gsb";
            this.pb_gsb.Size = new System.Drawing.Size(385, 253);
            this.pb_gsb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_gsb.TabIndex = 1;
            this.pb_gsb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenue chez GSB";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_gsb);
            this.Controls.Add(this.MenuGSB);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.MenuGSB;
            this.Name = "frmAccueil";
            this.Text = "GSB-gesAMM";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.MenuGSB.ResumeLayout(false);
            this.MenuGSB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gsb)).EndInit();
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
        private PictureBox pb_gsb;
        private Label label1;
    }
}