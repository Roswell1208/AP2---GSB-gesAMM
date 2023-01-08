namespace GSB___gesAMM
{
    partial class frmAuthentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthentication));
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(229, 237);
            this.tbIdentifiant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(215, 30);
            this.tbIdentifiant.TabIndex = 0;
            this.tbIdentifiant.TextChanged += new System.EventHandler(this.tbIdentifiant_TextChanged);
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(229, 308);
            this.tbMotDePasse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.PasswordChar = '•';
            this.tbMotDePasse.Size = new System.Drawing.Size(215, 30);
            this.tbMotDePasse.TabIndex = 1;
            this.tbMotDePasse.TextChanged += new System.EventHandler(this.tbMotDePasse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(46, 385);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(210, 64);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(304, 385);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(210, 64);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(137)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(561, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.tbIdentifiant);
            this.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'authentification";
            this.Load += new System.EventHandler(this.frmAuthentication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbIdentifiant;
        private TextBox tbMotDePasse;
        private Label label1;
        private Label label2;
        private Button btnValider;
        private Button btnQuitter;
        private PictureBox pictureBox1;
    }
}