namespace GSB___gesAMM
{
    partial class frmSaisieEtape
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
            this.cbListMed = new System.Windows.Forms.ComboBox();
            this.lvLastEtapeMed = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSaisieEtape = new System.Windows.Forms.GroupBox();
            this.dtpDateDecision = new System.Windows.Forms.DateTimePicker();
            this.btnValider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbRefusee = new System.Windows.Forms.RadioButton();
            this.rbAcceptee = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDateNorme = new System.Windows.Forms.TextBox();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.tbLibelleEtape = new System.Windows.Forms.TextBox();
            this.tbNumEtape = new System.Windows.Forms.TextBox();
            this.gbSaisieEtape.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbListMed
            // 
            this.cbListMed.FormattingEnabled = true;
            this.cbListMed.Location = new System.Drawing.Point(233, 55);
            this.cbListMed.Name = "cbListMed";
            this.cbListMed.Size = new System.Drawing.Size(305, 28);
            this.cbListMed.TabIndex = 0;
            this.cbListMed.SelectedIndexChanged += new System.EventHandler(this.cbListMed_SelectedIndexChanged);
            // 
            // lvLastEtapeMed
            // 
            this.lvLastEtapeMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvLastEtapeMed.Location = new System.Drawing.Point(33, 117);
            this.lvLastEtapeMed.Name = "lvLastEtapeMed";
            this.lvLastEtapeMed.Size = new System.Drawing.Size(505, 261);
            this.lvLastEtapeMed.TabIndex = 1;
            this.lvLastEtapeMed.UseCompatibleStateImageBehavior = false;
            this.lvLastEtapeMed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Num Etape";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Etape";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Libelle Etape";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Norme";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date Norme";
            this.columnHeader5.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisissez un médicament :";
            // 
            // gbSaisieEtape
            // 
            this.gbSaisieEtape.Controls.Add(this.dtpDateDecision);
            this.gbSaisieEtape.Controls.Add(this.btnValider);
            this.gbSaisieEtape.Controls.Add(this.label7);
            this.gbSaisieEtape.Controls.Add(this.label6);
            this.gbSaisieEtape.Controls.Add(this.rbRefusee);
            this.gbSaisieEtape.Controls.Add(this.rbAcceptee);
            this.gbSaisieEtape.Controls.Add(this.label5);
            this.gbSaisieEtape.Controls.Add(this.label4);
            this.gbSaisieEtape.Controls.Add(this.label3);
            this.gbSaisieEtape.Controls.Add(this.label2);
            this.gbSaisieEtape.Controls.Add(this.tbDateNorme);
            this.gbSaisieEtape.Controls.Add(this.tbNorme);
            this.gbSaisieEtape.Controls.Add(this.tbLibelleEtape);
            this.gbSaisieEtape.Controls.Add(this.tbNumEtape);
            this.gbSaisieEtape.Enabled = false;
            this.gbSaisieEtape.Location = new System.Drawing.Point(591, 16);
            this.gbSaisieEtape.Name = "gbSaisieEtape";
            this.gbSaisieEtape.Size = new System.Drawing.Size(387, 427);
            this.gbSaisieEtape.TabIndex = 3;
            this.gbSaisieEtape.TabStop = false;
            this.gbSaisieEtape.Text = "Saisie de l\'étape n+1 :";
            // 
            // dtpDateDecision
            // 
            this.dtpDateDecision.Location = new System.Drawing.Point(73, 294);
            this.dtpDateDecision.Name = "dtpDateDecision";
            this.dtpDateDecision.Size = new System.Drawing.Size(250, 27);
            this.dtpDateDecision.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(103, 342);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(198, 67);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date de la décision :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Décision :";
            // 
            // rbRefusee
            // 
            this.rbRefusee.AutoSize = true;
            this.rbRefusee.Location = new System.Drawing.Point(172, 205);
            this.rbRefusee.Name = "rbRefusee";
            this.rbRefusee.Size = new System.Drawing.Size(82, 24);
            this.rbRefusee.TabIndex = 10;
            this.rbRefusee.TabStop = true;
            this.rbRefusee.Text = "Refusée";
            this.rbRefusee.UseVisualStyleBackColor = true;
            this.rbRefusee.CheckedChanged += new System.EventHandler(this.rbRefusee_CheckedChanged);
            // 
            // rbAcceptee
            // 
            this.rbAcceptee.AutoSize = true;
            this.rbAcceptee.Location = new System.Drawing.Point(172, 175);
            this.rbAcceptee.Name = "rbAcceptee";
            this.rbAcceptee.Size = new System.Drawing.Size(92, 24);
            this.rbAcceptee.TabIndex = 9;
            this.rbAcceptee.TabStop = true;
            this.rbAcceptee.Text = "Acceptée";
            this.rbAcceptee.UseVisualStyleBackColor = true;
            this.rbAcceptee.CheckedChanged += new System.EventHandler(this.rbAcceptee_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date de la norme :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Norme :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Libelle de l\'étape :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numéro de l\'étape :";
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Location = new System.Drawing.Point(172, 125);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.ReadOnly = true;
            this.tbDateNorme.Size = new System.Drawing.Size(181, 27);
            this.tbDateNorme.TabIndex = 4;
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(172, 92);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.ReadOnly = true;
            this.tbNorme.Size = new System.Drawing.Size(181, 27);
            this.tbNorme.TabIndex = 2;
            // 
            // tbLibelleEtape
            // 
            this.tbLibelleEtape.Location = new System.Drawing.Point(172, 59);
            this.tbLibelleEtape.Name = "tbLibelleEtape";
            this.tbLibelleEtape.ReadOnly = true;
            this.tbLibelleEtape.Size = new System.Drawing.Size(181, 27);
            this.tbLibelleEtape.TabIndex = 1;
            // 
            // tbNumEtape
            // 
            this.tbNumEtape.Location = new System.Drawing.Point(172, 26);
            this.tbNumEtape.Name = "tbNumEtape";
            this.tbNumEtape.ReadOnly = true;
            this.tbNumEtape.Size = new System.Drawing.Size(181, 27);
            this.tbNumEtape.TabIndex = 0;
            // 
            // frmSaisieEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 460);
            this.Controls.Add(this.gbSaisieEtape);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvLastEtapeMed);
            this.Controls.Add(this.cbListMed);
            this.Name = "frmSaisieEtape";
            this.Text = "frmSaisieEtape";
            this.Load += new System.EventHandler(this.frmSaisieEtape_Load);
            this.gbSaisieEtape.ResumeLayout(false);
            this.gbSaisieEtape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbListMed;
        private ListView lvLastEtapeMed;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private GroupBox gbSaisieEtape;
        private TextBox tbDateNorme;
        private TextBox tbNorme;
        private TextBox tbLibelleEtape;
        private TextBox tbNumEtape;
        private Button btnValider;
        private Label label7;
        private Label label6;
        private RadioButton rbRefusee;
        private RadioButton rbAcceptee;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpDateDecision;
    }
}