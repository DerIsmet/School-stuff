namespace hintergrundfarbe_des_Formulars_aendern
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
            this.B_rot = new System.Windows.Forms.Button();
            this.B_gruen = new System.Windows.Forms.Button();
            this.B_blau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_rot
            // 
            this.B_rot.Location = new System.Drawing.Point(61, 45);
            this.B_rot.Name = "B_rot";
            this.B_rot.Size = new System.Drawing.Size(75, 23);
            this.B_rot.TabIndex = 0;
            this.B_rot.Text = "Rot";
            this.B_rot.UseVisualStyleBackColor = true;
            this.B_rot.Click += new System.EventHandler(this.B_rot_Click);
            // 
            // B_gruen
            // 
            this.B_gruen.Location = new System.Drawing.Point(182, 45);
            this.B_gruen.Name = "B_gruen";
            this.B_gruen.Size = new System.Drawing.Size(75, 23);
            this.B_gruen.TabIndex = 1;
            this.B_gruen.Text = "Grün";
            this.B_gruen.UseVisualStyleBackColor = true;
            this.B_gruen.Click += new System.EventHandler(this.Button2_Click);
            // 
            // B_blau
            // 
            this.B_blau.Location = new System.Drawing.Point(304, 45);
            this.B_blau.Name = "B_blau";
            this.B_blau.Size = new System.Drawing.Size(75, 23);
            this.B_blau.TabIndex = 2;
            this.B_blau.Text = "Blau";
            this.B_blau.UseVisualStyleBackColor = true;
            this.B_blau.Click += new System.EventHandler(this.B_blau_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 108);
            this.Controls.Add(this.B_blau);
            this.Controls.Add(this.B_gruen);
            this.Controls.Add(this.B_rot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_rot;
        private System.Windows.Forms.Button B_gruen;
        private System.Windows.Forms.Button B_blau;
    }
}

