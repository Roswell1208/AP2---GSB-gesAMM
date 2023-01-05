namespace GSB___gesAMM
{
    partial class frmUpdateEtapeNormee
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
            this.lv_etape = new System.Windows.Forms.ListView();
            this.Norme = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Etape_Num = new System.Windows.Forms.ColumnHeader();
            this.gp_maj = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_envoyer = new System.Windows.Forms.Button();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_maj.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_etape
            // 
            this.lv_etape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.lv_etape.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Norme,
            this.Date,
            this.Etape_Num});
            this.lv_etape.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_etape.Location = new System.Drawing.Point(35, 78);
            this.lv_etape.Name = "lv_etape";
            this.lv_etape.Size = new System.Drawing.Size(342, 328);
            this.lv_etape.TabIndex = 0;
            this.lv_etape.UseCompatibleStateImageBehavior = false;
            this.lv_etape.View = System.Windows.Forms.View.Details;
            // 
            // Norme
            // 
            this.Norme.Text = "Norme";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Etape_Num
            // 
            this.Etape_Num.Text = "NumEtape";
            // 
            // gp_maj
            // 
            this.gp_maj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.gp_maj.Controls.Add(this.label3);
            this.gp_maj.Controls.Add(this.label2);
            this.gp_maj.Controls.Add(this.btn_envoyer);
            this.gp_maj.Controls.Add(this.tb_date);
            this.gp_maj.Controls.Add(this.tb_num);
            this.gp_maj.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gp_maj.Location = new System.Drawing.Point(424, 78);
            this.gp_maj.Name = "gp_maj";
            this.gp_maj.Size = new System.Drawing.Size(342, 328);
            this.gp_maj.TabIndex = 1;
            this.gp_maj.TabStop = false;
            this.gp_maj.Text = "Mise à jour des étapes normées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numéro";
            // 
            // btn_envoyer
            // 
            this.btn_envoyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(137)))), ((int)(((byte)(192)))));
            this.btn_envoyer.Location = new System.Drawing.Point(121, 231);
            this.btn_envoyer.Name = "btn_envoyer";
            this.btn_envoyer.Size = new System.Drawing.Size(106, 41);
            this.btn_envoyer.TabIndex = 2;
            this.btn_envoyer.Text = "Envoyer";
            this.btn_envoyer.UseVisualStyleBackColor = false;
            this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(93, 173);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(155, 30);
            this.tb_date.TabIndex = 1;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(93, 84);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(155, 30);
            this.tb_num.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des étapes normées";
            // 
            // frmUpdateEtapeNormee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gp_maj);
            this.Controls.Add(this.lv_etape);
            this.Name = "frmUpdateEtapeNormee";
            this.Text = "frmUpdateEtapeNormee";
            this.Load += new System.EventHandler(this.frmUpdateEtapeNormee_Load);
            this.gp_maj.ResumeLayout(false);
            this.gp_maj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_etape;
        private ColumnHeader Norme;
        private ColumnHeader Date;
        private ColumnHeader Etape_Num;
        private GroupBox gp_maj;
        private Button btn_envoyer;
        private TextBox tb_date;
        private TextBox tb_num;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}