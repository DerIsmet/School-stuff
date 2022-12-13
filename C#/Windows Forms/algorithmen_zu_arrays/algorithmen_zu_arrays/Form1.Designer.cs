namespace algorithmen_zu_arrays
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
            this.B_initialisieren = new System.Windows.Forms.Button();
            this.LB_ergebnis = new System.Windows.Forms.ListBox();
            this.B_ausgabe = new System.Windows.Forms.Button();
            this.T_input = new System.Windows.Forms.TextBox();
            this.L_wert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_initialisieren
            // 
            this.B_initialisieren.Location = new System.Drawing.Point(158, 91);
            this.B_initialisieren.Name = "B_initialisieren";
            this.B_initialisieren.Size = new System.Drawing.Size(123, 35);
            this.B_initialisieren.TabIndex = 0;
            this.B_initialisieren.Text = "Initialisieren";
            this.B_initialisieren.UseVisualStyleBackColor = true;
            this.B_initialisieren.Click += new System.EventHandler(this.B_initialisieren_Click);
            // 
            // LB_ergebnis
            // 
            this.LB_ergebnis.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.LB_ergebnis.FormattingEnabled = true;
            this.LB_ergebnis.Location = new System.Drawing.Point(161, 143);
            this.LB_ergebnis.Name = "LB_ergebnis";
            this.LB_ergebnis.Size = new System.Drawing.Size(120, 95);
            this.LB_ergebnis.TabIndex = 1;
            // 
            // B_ausgabe
            // 
            this.B_ausgabe.Location = new System.Drawing.Point(158, 244);
            this.B_ausgabe.Name = "B_ausgabe";
            this.B_ausgabe.Size = new System.Drawing.Size(120, 23);
            this.B_ausgabe.TabIndex = 2;
            this.B_ausgabe.Text = "Ausgabe";
            this.B_ausgabe.UseVisualStyleBackColor = true;
            // 
            // T_input
            // 
            this.T_input.Location = new System.Drawing.Point(12, 106);
            this.T_input.Name = "T_input";
            this.T_input.Size = new System.Drawing.Size(100, 20);
            this.T_input.TabIndex = 3;
            // 
            // L_wert
            // 
            this.L_wert.AutoSize = true;
            this.L_wert.Location = new System.Drawing.Point(13, 87);
            this.L_wert.Name = "L_wert";
            this.L_wert.Size = new System.Drawing.Size(63, 13);
            this.L_wert.TabIndex = 4;
            this.L_wert.Text = "Gib wert ein";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 307);
            this.Controls.Add(this.L_wert);
            this.Controls.Add(this.T_input);
            this.Controls.Add(this.B_ausgabe);
            this.Controls.Add(this.LB_ergebnis);
            this.Controls.Add(this.B_initialisieren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_initialisieren;
        private System.Windows.Forms.ListBox LB_ergebnis;
        private System.Windows.Forms.Button B_ausgabe;
        private System.Windows.Forms.TextBox T_input;
        private System.Windows.Forms.Label L_wert;
    }
}

