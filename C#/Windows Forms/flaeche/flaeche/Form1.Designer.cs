namespace flaeche
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
            this.L_laenge = new System.Windows.Forms.Label();
            this.T_laengewer = new System.Windows.Forms.TextBox();
            this.T_breitewert = new System.Windows.Forms.TextBox();
            this.L_breite = new System.Windows.Forms.Label();
            this.T_flacheninhalt = new System.Windows.Forms.TextBox();
            this.L_flaecheninhalt = new System.Windows.Forms.Label();
            this.B_rehnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_laenge
            // 
            this.L_laenge.AutoSize = true;
            this.L_laenge.Location = new System.Drawing.Point(55, 112);
            this.L_laenge.Name = "L_laenge";
            this.L_laenge.Size = new System.Drawing.Size(37, 13);
            this.L_laenge.TabIndex = 0;
            this.L_laenge.Text = "Länge";
            // 
            // T_laengewer
            // 
            this.T_laengewer.Location = new System.Drawing.Point(98, 109);
            this.T_laengewer.Name = "T_laengewer";
            this.T_laengewer.Size = new System.Drawing.Size(100, 20);
            this.T_laengewer.TabIndex = 1;
            this.T_laengewer.TextChanged += new System.EventHandler(this.T_laengewer_TextChanged);
            // 
            // T_breitewert
            // 
            this.T_breitewert.Location = new System.Drawing.Point(98, 135);
            this.T_breitewert.Name = "T_breitewert";
            this.T_breitewert.Size = new System.Drawing.Size(100, 20);
            this.T_breitewert.TabIndex = 3;
            this.T_breitewert.TextChanged += new System.EventHandler(this.T_breitewert_TextChanged);
            // 
            // L_breite
            // 
            this.L_breite.AutoSize = true;
            this.L_breite.Location = new System.Drawing.Point(55, 138);
            this.L_breite.Name = "L_breite";
            this.L_breite.Size = new System.Drawing.Size(34, 13);
            this.L_breite.TabIndex = 2;
            this.L_breite.Text = "Breite";
            // 
            // T_flacheninhalt
            // 
            this.T_flacheninhalt.Location = new System.Drawing.Point(98, 200);
            this.T_flacheninhalt.Name = "T_flacheninhalt";
            this.T_flacheninhalt.Size = new System.Drawing.Size(100, 20);
            this.T_flacheninhalt.TabIndex = 5;
            // 
            // L_flaecheninhalt
            // 
            this.L_flaecheninhalt.AutoSize = true;
            this.L_flaecheninhalt.Location = new System.Drawing.Point(20, 205);
            this.L_flaecheninhalt.Name = "L_flaecheninhalt";
            this.L_flaecheninhalt.Size = new System.Drawing.Size(70, 13);
            this.L_flaecheninhalt.TabIndex = 4;
            this.L_flaecheninhalt.Text = "Flächeninhalt";
            // 
            // B_rehnen
            // 
            this.B_rehnen.Location = new System.Drawing.Point(98, 171);
            this.B_rehnen.Name = "B_rehnen";
            this.B_rehnen.Size = new System.Drawing.Size(75, 23);
            this.B_rehnen.TabIndex = 6;
            this.B_rehnen.Text = "berechne";
            this.B_rehnen.UseVisualStyleBackColor = true;
            this.B_rehnen.Click += new System.EventHandler(this.B_rehnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_rehnen);
            this.Controls.Add(this.T_flacheninhalt);
            this.Controls.Add(this.L_flaecheninhalt);
            this.Controls.Add(this.T_breitewert);
            this.Controls.Add(this.L_breite);
            this.Controls.Add(this.T_laengewer);
            this.Controls.Add(this.L_laenge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_laenge;
        private System.Windows.Forms.TextBox T_laengewer;
        private System.Windows.Forms.TextBox T_breitewert;
        private System.Windows.Forms.Label L_breite;
        private System.Windows.Forms.TextBox T_flacheninhalt;
        private System.Windows.Forms.Label L_flaecheninhalt;
        private System.Windows.Forms.Button B_rehnen;
    }
}

