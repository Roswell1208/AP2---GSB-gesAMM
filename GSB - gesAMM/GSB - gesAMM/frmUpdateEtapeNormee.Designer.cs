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
            this.Etape_num = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Norme = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_envoyer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gp_maj = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_norme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.gp_maj.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_etape
            // 
            this.lv_etape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.lv_etape.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Etape_num,
            this.Date,
            this.Norme});
            this.lv_etape.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_etape.Location = new System.Drawing.Point(35, 78);
            this.lv_etape.Name = "lv_etape";
            this.lv_etape.Size = new System.Drawing.Size(282, 360);
            this.lv_etape.TabIndex = 0;
            this.lv_etape.UseCompatibleStateImageBehavior = false;
            this.lv_etape.View = System.Windows.Forms.View.Details;
            this.lv_etape.SelectedIndexChanged += new System.EventHandler(this.lv_etape_SelectedIndexChanged);
            // 
            // Etape_num
            // 
            this.Etape_num.Text = "NumEtape";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Norme
            // 
            this.Norme.Text = "Norme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des étapes normées";
            // 
            // btn_envoyer
            // 
            this.btn_envoyer.BackColor = System.Drawing.Color.White;
            this.btn_envoyer.Location = new System.Drawing.Point(102, 245);
            this.btn_envoyer.Name = "btn_envoyer";
            this.btn_envoyer.Size = new System.Drawing.Size(153, 83);
            this.btn_envoyer.TabIndex = 2;
            this.btn_envoyer.Text = "Envoyer";
            this.btn_envoyer.UseVisualStyleBackColor = false;
            this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 4;
            // 
            // gp_maj
            // 
            this.gp_maj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.gp_maj.Controls.Add(this.label2);
            this.gp_maj.Controls.Add(this.tb_norme);
            this.gp_maj.Controls.Add(this.label4);
            this.gp_maj.Controls.Add(this.dt_date);
            this.gp_maj.Controls.Add(this.label3);
            this.gp_maj.Controls.Add(this.btn_envoyer);
            this.gp_maj.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gp_maj.Location = new System.Drawing.Point(361, 78);
            this.gp_maj.Name = "gp_maj";
            this.gp_maj.Size = new System.Drawing.Size(369, 360);
            this.gp_maj.TabIndex = 1;
            this.gp_maj.TabStop = false;
            this.gp_maj.Text = "Mise à jour des étapes normées";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Norme";
            // 
            // tb_norme
            // 
            this.tb_norme.Location = new System.Drawing.Point(102, 104);
            this.tb_norme.Name = "tb_norme";
            this.tb_norme.Size = new System.Drawing.Size(153, 30);
            this.tb_norme.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(61, 185);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(250, 30);
            this.dt_date.TabIndex = 5;
            // 
            // frmUpdateEtapeNormee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(137)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(751, 450);
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
        private Label label1;
        private Button btn_envoyer;
        private Label label3;
        private GroupBox gp_maj;
        private Label label4;
        private DateTimePicker dt_date;
        private Label label2;
        private TextBox tb_norme;
        private ColumnHeader Etape_num;
        private ColumnHeader Date;
        private ColumnHeader Norme;
    }
}