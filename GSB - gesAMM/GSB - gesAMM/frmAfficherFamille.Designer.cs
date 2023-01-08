namespace GSB___gesAMM
{
    partial class frmAfficherFamille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_med_fam = new System.Windows.Forms.ListView();
            this.Code = new System.Windows.Forms.ColumnHeader();
            this.Nom = new System.Windows.Forms.ColumnHeader();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.lv_med_selec = new System.Windows.Forms.ListView();
            this.Numéro = new System.Windows.Forms.ColumnHeader();
            this.NomMed = new System.Windows.Forms.ColumnHeader();
            this.NomFam = new System.Windows.Forms.ColumnHeader();
            this.Composition = new System.Windows.Forms.ColumnHeader();
            this.Effets = new System.Windows.Forms.ColumnHeader();
            this.Indication = new System.Windows.Forms.ColumnHeader();
            this.Prix = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_med_fam
            // 
            this.lv_med_fam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.lv_med_fam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Nom,
            this.Nombre});
            this.lv_med_fam.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_med_fam.Location = new System.Drawing.Point(12, 113);
            this.lv_med_fam.Name = "lv_med_fam";
            this.lv_med_fam.Size = new System.Drawing.Size(344, 298);
            this.lv_med_fam.TabIndex = 0;
            this.lv_med_fam.UseCompatibleStateImageBehavior = false;
            this.lv_med_fam.View = System.Windows.Forms.View.Details;
            this.lv_med_fam.SelectedIndexChanged += new System.EventHandler(this.lv_med_fam_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Text = "Code Famille";
            // 
            // Nom
            // 
            this.Nom.DisplayIndex = 2;
            this.Nom.Text = "Nom Commercial";
            // 
            // Nombre
            // 
            this.Nombre.DisplayIndex = 1;
            this.Nombre.Text = "Nombre Médicaments";
            // 
            // lv_med_selec
            // 
            this.lv_med_selec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.lv_med_selec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numéro,
            this.NomMed,
            this.NomFam,
            this.Composition,
            this.Effets,
            this.Indication,
            this.Prix});
            this.lv_med_selec.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_med_selec.Location = new System.Drawing.Point(381, 113);
            this.lv_med_selec.Name = "lv_med_selec";
            this.lv_med_selec.Size = new System.Drawing.Size(407, 298);
            this.lv_med_selec.TabIndex = 1;
            this.lv_med_selec.UseCompatibleStateImageBehavior = false;
            this.lv_med_selec.View = System.Windows.Forms.View.Details;
            // 
            // Numéro
            // 
            this.Numéro.Text = "Numéro";
            // 
            // NomMed
            // 
            this.NomMed.Text = "Nom";
            // 
            // NomFam
            // 
            this.NomFam.Text = "NomFam";
            // 
            // Composition
            // 
            this.Composition.Text = "Composition";
            // 
            // Effets
            // 
            this.Effets.Text = "Effets";
            // 
            // Indication
            // 
            this.Indication.Text = "Indication";
            // 
            // Prix
            // 
            this.Prix.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des familles et nombre de médicaments autorisés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(451, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Médicaments de la famille sélectionnée";
            // 
            // frmAfficherFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(137)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_med_selec);
            this.Controls.Add(this.lv_med_fam);
            this.Name = "frmAfficherFamille";
            this.Text = "frmAfficherFamille";
            this.Load += new System.EventHandler(this.frmAfficherFamille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_med_fam;
        private ColumnHeader Code;
        private ColumnHeader Nombre;
        private ColumnHeader Nom;
        private ListView lv_med_selec;
        private ColumnHeader Numéro;
        private ColumnHeader NomMed;
        private Label label1;
        private Label label2;
        private ColumnHeader NomFam;
        private ColumnHeader Composition;
        private ColumnHeader Effets;
        private ColumnHeader Indication;
        private ColumnHeader Prix;
    }
}