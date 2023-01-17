namespace minimum_maximum_array
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
            this.LB_Ausgabe = new System.Windows.Forms.ListBox();
            this.B_Max = new System.Windows.Forms.Button();
            this.B_min = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Ausgabe
            // 
            this.LB_Ausgabe.FormattingEnabled = true;
            this.LB_Ausgabe.Location = new System.Drawing.Point(183, 97);
            this.LB_Ausgabe.Name = "LB_Ausgabe";
            this.LB_Ausgabe.Size = new System.Drawing.Size(165, 277);
            this.LB_Ausgabe.TabIndex = 0;
            // 
            // B_Max
            // 
            this.B_Max.Location = new System.Drawing.Point(51, 97);
            this.B_Max.Name = "B_Max";
            this.B_Max.Size = new System.Drawing.Size(75, 23);
            this.B_Max.TabIndex = 1;
            this.B_Max.Text = "Maximum";
            this.B_Max.UseVisualStyleBackColor = true;
            this.B_Max.Click += new System.EventHandler(this.B_Max_Click);
            // 
            // B_min
            // 
            this.B_min.Location = new System.Drawing.Point(51, 144);
            this.B_min.Name = "B_min";
            this.B_min.Size = new System.Drawing.Size(75, 23);
            this.B_min.TabIndex = 2;
            this.B_min.Text = "Minimum";
            this.B_min.UseVisualStyleBackColor = true;
            this.B_min.Click += new System.EventHandler(this.B_min_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 404);
            this.Controls.Add(this.B_min);
            this.Controls.Add(this.B_Max);
            this.Controls.Add(this.LB_Ausgabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Ausgabe;
        private System.Windows.Forms.Button B_Max;
        private System.Windows.Forms.Button B_min;
    }
}

