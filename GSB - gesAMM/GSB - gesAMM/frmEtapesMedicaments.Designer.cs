namespace GSB___gesAMM
{
    partial class frmEtapesMedicaments
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvWorkflowEtapes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbListMed
            // 
            this.cbListMed.FormattingEnabled = true;
            this.cbListMed.Location = new System.Drawing.Point(217, 107);
            this.cbListMed.Name = "cbListMed";
            this.cbListMed.Size = new System.Drawing.Size(242, 28);
            this.cbListMed.TabIndex = 0;
            this.cbListMed.SelectedIndexChanged += new System.EventHandler(this.cbListMed_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisissez un médicament :";
            // 
            // lvWorkflowEtapes
            // 
            this.lvWorkflowEtapes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvWorkflowEtapes.Location = new System.Drawing.Point(21, 170);
            this.lvWorkflowEtapes.Name = "lvWorkflowEtapes";
            this.lvWorkflowEtapes.Size = new System.Drawing.Size(906, 358);
            this.lvWorkflowEtapes.TabIndex = 2;
            this.lvWorkflowEtapes.UseCompatibleStateImageBehavior = false;
            this.lvWorkflowEtapes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° de l\'étape";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libelle de l\'étape";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date de la décision";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Libelle de la décision";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Norme";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date de la norme";
            this.columnHeader6.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(179, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consultation du workflow des étapes d\'un médicament :";
            // 
            // frmEtapesMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvWorkflowEtapes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbListMed);
            this.Name = "frmEtapesMedicaments";
            this.Text = "frmEtapesMedicaments";
            this.Load += new System.EventHandler(this.frmEtapesMedicaments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbListMed;
        private Label label1;
        private ListView lvWorkflowEtapes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label2;
    }
}