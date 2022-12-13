namespace wert_in_einem_Arrays_suchen
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
            this.B_zufall = new System.Windows.Forms.Button();
            this.LB_werte = new System.Windows.Forms.ListBox();
            this.L_suchwert = new System.Windows.Forms.Label();
            this.T_wertdenmansucht = new System.Windows.Forms.TextBox();
            this.B_wertsuchen = new System.Windows.Forms.Button();
            this.B_ausgabe = new System.Windows.Forms.Button();
            this.L_ausgabetext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_zufall
            // 
            this.B_zufall.Location = new System.Drawing.Point(12, 15);
            this.B_zufall.Name = "B_zufall";
            this.B_zufall.Size = new System.Drawing.Size(150, 23);
            this.B_zufall.TabIndex = 0;
            this.B_zufall.Text = "Initialisieren mit Zufallszahlen";
            this.B_zufall.UseVisualStyleBackColor = true;
            this.B_zufall.Click += new System.EventHandler(this.B_zufall_Click);
            // 
            // LB_werte
            // 
            this.LB_werte.FormattingEnabled = true;
            this.LB_werte.Location = new System.Drawing.Point(12, 45);
            this.LB_werte.Name = "LB_werte";
            this.LB_werte.Size = new System.Drawing.Size(150, 95);
            this.LB_werte.TabIndex = 1;
            // 
            // L_suchwert
            // 
            this.L_suchwert.AutoSize = true;
            this.L_suchwert.Location = new System.Drawing.Point(9, 152);
            this.L_suchwert.Name = "L_suchwert";
            this.L_suchwert.Size = new System.Drawing.Size(55, 13);
            this.L_suchwert.TabIndex = 2;
            this.L_suchwert.Text = "Suchwert:";
            // 
            // T_wertdenmansucht
            // 
            this.T_wertdenmansucht.Location = new System.Drawing.Point(70, 149);
            this.T_wertdenmansucht.Name = "T_wertdenmansucht";
            this.T_wertdenmansucht.Size = new System.Drawing.Size(29, 20);
            this.T_wertdenmansucht.TabIndex = 3;
            // 
            // B_wertsuchen
            // 
            this.B_wertsuchen.Location = new System.Drawing.Point(12, 185);
            this.B_wertsuchen.Name = "B_wertsuchen";
            this.B_wertsuchen.Size = new System.Drawing.Size(87, 23);
            this.B_wertsuchen.TabIndex = 4;
            this.B_wertsuchen.Text = "Wert suchen";
            this.B_wertsuchen.UseVisualStyleBackColor = true;
            // 
            // B_ausgabe
            // 
            this.B_ausgabe.Location = new System.Drawing.Point(105, 185);
            this.B_ausgabe.Name = "B_ausgabe";
            this.B_ausgabe.Size = new System.Drawing.Size(57, 23);
            this.B_ausgabe.TabIndex = 5;
            this.B_ausgabe.Text = "Ausgabe";
            this.B_ausgabe.UseVisualStyleBackColor = true;
            // 
            // L_ausgabetext
            // 
            this.L_ausgabetext.AutoSize = true;
            this.L_ausgabetext.Location = new System.Drawing.Point(12, 232);
            this.L_ausgabetext.Name = "L_ausgabetext";
            this.L_ausgabetext.Size = new System.Drawing.Size(0, 13);
            this.L_ausgabetext.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 301);
            this.Controls.Add(this.L_ausgabetext);
            this.Controls.Add(this.B_ausgabe);
            this.Controls.Add(this.B_wertsuchen);
            this.Controls.Add(this.T_wertdenmansucht);
            this.Controls.Add(this.L_suchwert);
            this.Controls.Add(this.LB_werte);
            this.Controls.Add(this.B_zufall);
            this.Name = "Form1";
            this.Text = "Suchwert:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_zufall;
        private System.Windows.Forms.ListBox LB_werte;
        private System.Windows.Forms.Label L_suchwert;
        private System.Windows.Forms.TextBox T_wertdenmansucht;
        private System.Windows.Forms.Button B_wertsuchen;
        private System.Windows.Forms.Button B_ausgabe;
        private System.Windows.Forms.Label L_ausgabetext;
    }
}

