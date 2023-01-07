namespace GSB___gesAMM
{
    partial class frmNewMedicament
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
            this.cbListFam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbListFam
            // 
            this.cbListFam.FormattingEnabled = true;
            this.cbListFam.Location = new System.Drawing.Point(194, 94);
            this.cbListFam.Name = "cbListFam";
            this.cbListFam.Size = new System.Drawing.Size(267, 28);
            this.cbListFam.TabIndex = 0;
            // 
            // frmNewMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbListFam);
            this.Name = "frmNewMedicament";
            this.Text = "frmNewMedicament";
            this.Load += new System.EventHandler(this.frmNewMedicament_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbListFam;
    }
}