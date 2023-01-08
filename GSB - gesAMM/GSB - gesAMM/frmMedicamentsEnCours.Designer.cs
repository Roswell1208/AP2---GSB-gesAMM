namespace GSB___gesAMM
{
    partial class frmMedicamentsEnCours
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
            this.lv_med = new System.Windows.Forms.ListView();
            this.DepotLegal = new System.Windows.Forms.ColumnHeader();
            this.Nom = new System.Windows.Forms.ColumnHeader();
            this.Famille = new System.Windows.Forms.ColumnHeader();
            this.lv_medwork = new System.Windows.Forms.ListView();
            this.ETP_NUM = new System.Windows.Forms.ColumnHeader();
            this.DCS_ID = new System.Windows.Forms.ColumnHeader();
            this.DATE = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_med
            // 
            this.lv_med.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.lv_med.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DepotLegal,
            this.Nom,
            this.Famille});
            this.lv_med.Location = new System.Drawing.Point(69, 96);
            this.lv_med.Name = "lv_med";
            this.lv_med.Size = new System.Drawing.Size(312, 279);
            this.lv_med.TabIndex = 0;
            this.lv_med.UseCompatibleStateImageBehavior = false;
            this.lv_med.View = System.Windows.Forms.View.Details;
            this.lv_med.SelectedIndexChanged += new System.EventHandler(this.lv_med_SelectedIndexChanged);
            // 
            // DepotLegal
            // 
            this.DepotLegal.Text = "DepotLegal";
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            // 
            // Famille
            // 
            this.Famille.Text = "Famille";
            // 
            // lv_medwork
            // 
            this.lv_medwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.lv_medwork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ETP_NUM,
            this.DCS_ID,
            this.DATE});
            this.lv_medwork.Location = new System.Drawing.Point(447, 96);
            this.lv_medwork.Name = "lv_medwork";
            this.lv_medwork.Size = new System.Drawing.Size(310, 279);
            this.lv_medwork.TabIndex = 1;
            this.lv_medwork.UseCompatibleStateImageBehavior = false;
            this.lv_medwork.View = System.Windows.Forms.View.Details;
            // 
            // ETP_NUM
            // 
            this.ETP_NUM.Text = "ETP_NUM";
            // 
            // DCS_ID
            // 
            this.DCS_ID.Text = "DCS_ID";
            // 
            // DATE
            // 
            this.DATE.Text = "DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medicaments en cours de validation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(506, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Workflow de ses étapes";
            // 
            // frmMedicamentsEnCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(137)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_medwork);
            this.Controls.Add(this.lv_med);
            this.Name = "frmMedicamentsEnCours";
            this.Text = "frmMedicamentsEnCours";
            this.Load += new System.EventHandler(this.frmMedicamentsEnCours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_med;
        private ColumnHeader DepotLegal;
        private ColumnHeader Nom;
        private ColumnHeader Famille;
        private ListView lv_medwork;
        private ColumnHeader ETP_NUM;
        private ColumnHeader DCS_ID;
        private ColumnHeader DATE;
        private Label label1;
        private Label label2;
    }
}