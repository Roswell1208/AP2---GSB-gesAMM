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
            this.SuspendLayout();
            // 
            // cbListMed
            // 
            this.cbListMed.FormattingEnabled = true;
            this.cbListMed.Location = new System.Drawing.Point(149, 79);
            this.cbListMed.Name = "cbListMed";
            this.cbListMed.Size = new System.Drawing.Size(219, 28);
            this.cbListMed.TabIndex = 0;
            // 
            // frmSaisieEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbListMed);
            this.Name = "frmSaisieEtape";
            this.Text = "frmSaisieEtape";
            this.Load += new System.EventHandler(this.frmSaisieEtape_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbListMed;
    }
}