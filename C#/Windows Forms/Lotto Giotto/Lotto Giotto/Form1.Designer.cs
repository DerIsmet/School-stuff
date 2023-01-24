namespace Lotto_Giotto
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_spielfeldini = new System.Windows.Forms.Button();
            this.B_lottospielen = new System.Windows.Forms.Button();
            this.B_ausgabespielfeld = new System.Windows.Forms.Button();
            this.B_ausgabederlottozahlen = new System.Windows.Forms.Button();
            this.B_fixetestzahlen = new System.Windows.Forms.Button();
            this.LB_spielefeld = new System.Windows.Forms.ListBox();
            this.LB_lottozahlen = new System.Windows.Forms.ListBox();
            this.L_testzahlen = new System.Windows.Forms.Label();
            this.L_hinweis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_spielfeldini
            // 
            this.B_spielfeldini.Location = new System.Drawing.Point(25, 49);
            this.B_spielfeldini.Name = "B_spielfeldini";
            this.B_spielfeldini.Size = new System.Drawing.Size(154, 23);
            this.B_spielfeldini.TabIndex = 0;
            this.B_spielfeldini.Text = "Spielfeld initialisieren";
            this.B_spielfeldini.UseVisualStyleBackColor = true;
            this.B_spielfeldini.Click += new System.EventHandler(this.B_spielfeldini_Click);
            // 
            // B_lottospielen
            // 
            this.B_lottospielen.Location = new System.Drawing.Point(25, 78);
            this.B_lottospielen.Name = "B_lottospielen";
            this.B_lottospielen.Size = new System.Drawing.Size(154, 23);
            this.B_lottospielen.TabIndex = 1;
            this.B_lottospielen.Text = "Lotto spielen";
            this.B_lottospielen.UseVisualStyleBackColor = true;
            this.B_lottospielen.Click += new System.EventHandler(this.B_lottospielen_Click);
            // 
            // B_ausgabespielfeld
            // 
            this.B_ausgabespielfeld.Location = new System.Drawing.Point(25, 141);
            this.B_ausgabespielfeld.Name = "B_ausgabespielfeld";
            this.B_ausgabespielfeld.Size = new System.Drawing.Size(154, 23);
            this.B_ausgabespielfeld.TabIndex = 2;
            this.B_ausgabespielfeld.Text = "Ausgabe Spielfeld in Listbox";
            this.B_ausgabespielfeld.UseVisualStyleBackColor = true;
            this.B_ausgabespielfeld.Click += new System.EventHandler(this.B_ausgabespielfeld_Click);
            // 
            // B_ausgabederlottozahlen
            // 
            this.B_ausgabederlottozahlen.Location = new System.Drawing.Point(25, 171);
            this.B_ausgabederlottozahlen.Name = "B_ausgabederlottozahlen";
            this.B_ausgabederlottozahlen.Size = new System.Drawing.Size(154, 23);
            this.B_ausgabederlottozahlen.TabIndex = 3;
            this.B_ausgabederlottozahlen.Text = "Ausgabe der 6 Lottozahlen";
            this.B_ausgabederlottozahlen.UseVisualStyleBackColor = true;
            this.B_ausgabederlottozahlen.Click += new System.EventHandler(this.B_ausgabederlottozahlen_Click);
            // 
            // B_fixetestzahlen
            // 
            this.B_fixetestzahlen.Location = new System.Drawing.Point(25, 238);
            this.B_fixetestzahlen.Name = "B_fixetestzahlen";
            this.B_fixetestzahlen.Size = new System.Drawing.Size(154, 23);
            this.B_fixetestzahlen.TabIndex = 4;
            this.B_fixetestzahlen.Text = "6 fixe Testzahlen eintragen";
            this.B_fixetestzahlen.UseVisualStyleBackColor = true;
            this.B_fixetestzahlen.Click += new System.EventHandler(this.B_fixetestzahlen_Click);
            // 
            // LB_spielefeld
            // 
            this.LB_spielefeld.FormattingEnabled = true;
            this.LB_spielefeld.Location = new System.Drawing.Point(202, 49);
            this.LB_spielefeld.Name = "LB_spielefeld";
            this.LB_spielefeld.Size = new System.Drawing.Size(170, 212);
            this.LB_spielefeld.TabIndex = 5;
            // 
            // LB_lottozahlen
            // 
            this.LB_lottozahlen.FormattingEnabled = true;
            this.LB_lottozahlen.Location = new System.Drawing.Point(423, 49);
            this.LB_lottozahlen.Name = "LB_lottozahlen";
            this.LB_lottozahlen.Size = new System.Drawing.Size(169, 134);
            this.LB_lottozahlen.TabIndex = 6;
            // 
            // L_testzahlen
            // 
            this.L_testzahlen.AutoSize = true;
            this.L_testzahlen.Location = new System.Drawing.Point(25, 268);
            this.L_testzahlen.Name = "L_testzahlen";
            this.L_testzahlen.Size = new System.Drawing.Size(131, 13);
            this.L_testzahlen.TabIndex = 7;
            this.L_testzahlen.Text = "Testzahlen 1, 3 , 5 , 7, 11 ";
            // 
            // L_hinweis
            // 
            this.L_hinweis.AutoSize = true;
            this.L_hinweis.Location = new System.Drawing.Point(25, 309);
            this.L_hinweis.Name = "L_hinweis";
            this.L_hinweis.Size = new System.Drawing.Size(321, 13);
            this.L_hinweis.TabIndex = 8;
            this.L_hinweis.Text = "Hinweis: Glückspiel kann süchtig machen. Teilnahme ab 18 Jahre.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 372);
            this.Controls.Add(this.L_hinweis);
            this.Controls.Add(this.L_testzahlen);
            this.Controls.Add(this.LB_lottozahlen);
            this.Controls.Add(this.LB_spielefeld);
            this.Controls.Add(this.B_fixetestzahlen);
            this.Controls.Add(this.B_ausgabederlottozahlen);
            this.Controls.Add(this.B_ausgabespielfeld);
            this.Controls.Add(this.B_lottospielen);
            this.Controls.Add(this.B_spielfeldini);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_spielfeldini;
        private System.Windows.Forms.Button B_lottospielen;
        private System.Windows.Forms.Button B_ausgabespielfeld;
        private System.Windows.Forms.Button B_ausgabederlottozahlen;
        private System.Windows.Forms.Button B_fixetestzahlen;
        private System.Windows.Forms.ListBox LB_spielefeld;
        private System.Windows.Forms.ListBox LB_lottozahlen;
        private System.Windows.Forms.Label L_testzahlen;
        private System.Windows.Forms.Label L_hinweis;
    }
}

