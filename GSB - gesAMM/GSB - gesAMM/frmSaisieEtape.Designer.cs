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
            this.SuspendLayout();
            // 
            // cbListMed
            // 
            this.cbListMed.FormattingEnabled = true;
            this.cbListMed.Location = new System.Drawing.Point(46, 47);
            this.cbListMed.Name = "cbListMed";
            this.cbListMed.Size = new System.Drawing.Size(219, 28);
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
            this.lvLastEtapeMed.Location = new System.Drawing.Point(316, 36);
            this.lvLastEtapeMed.Name = "lvLastEtapeMed";
            this.lvLastEtapeMed.Size = new System.Drawing.Size(413, 261);
            this.lvLastEtapeMed.TabIndex = 1;
            this.lvLastEtapeMed.UseCompatibleStateImageBehavior = false;
            this.lvLastEtapeMed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Num Etape";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Etape";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Libelle Etape";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Norme";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date Norme";
            // 
            // frmSaisieEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvLastEtapeMed);
            this.Controls.Add(this.cbListMed);
            this.Name = "frmSaisieEtape";
            this.Text = "frmSaisieEtape";
            this.Load += new System.EventHandler(this.frmSaisieEtape_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbListMed;
        private ListView lvLastEtapeMed;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}