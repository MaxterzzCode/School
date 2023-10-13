namespace Array_Initialisieren
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
            this.LB_ausgabe = new System.Windows.Forms.ListBox();
            this.B_Ausgabe = new System.Windows.Forms.Button();
            this.B_Initialisieren = new System.Windows.Forms.Button();
            this.L_Suchwert = new System.Windows.Forms.Label();
            this.T_suchbox = new System.Windows.Forms.TextBox();
            this.B_WertSuchen = new System.Windows.Forms.Button();
            this.L_ausgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_ausgabe
            // 
            this.LB_ausgabe.FormattingEnabled = true;
            this.LB_ausgabe.Location = new System.Drawing.Point(12, 35);
            this.LB_ausgabe.Name = "LB_ausgabe";
            this.LB_ausgabe.Size = new System.Drawing.Size(137, 134);
            this.LB_ausgabe.TabIndex = 0;
            // 
            // B_Ausgabe
            // 
            this.B_Ausgabe.Location = new System.Drawing.Point(12, 175);
            this.B_Ausgabe.Name = "B_Ausgabe";
            this.B_Ausgabe.Size = new System.Drawing.Size(137, 23);
            this.B_Ausgabe.TabIndex = 1;
            this.B_Ausgabe.Text = "Ausgabe";
            this.B_Ausgabe.UseVisualStyleBackColor = true;
            this.B_Ausgabe.Click += new System.EventHandler(this.B_Ausgabe_Click);
            // 
            // B_Initialisieren
            // 
            this.B_Initialisieren.Location = new System.Drawing.Point(12, 6);
            this.B_Initialisieren.Name = "B_Initialisieren";
            this.B_Initialisieren.Size = new System.Drawing.Size(137, 23);
            this.B_Initialisieren.TabIndex = 2;
            this.B_Initialisieren.Text = "Initialisieren";
            this.B_Initialisieren.UseVisualStyleBackColor = true;
            this.B_Initialisieren.Click += new System.EventHandler(this.B_Initialisieren_Click);
            // 
            // L_Suchwert
            // 
            this.L_Suchwert.AutoSize = true;
            this.L_Suchwert.Location = new System.Drawing.Point(13, 205);
            this.L_Suchwert.Name = "L_Suchwert";
            this.L_Suchwert.Size = new System.Drawing.Size(58, 13);
            this.L_Suchwert.TabIndex = 3;
            this.L_Suchwert.Text = "Suchwert: ";
            // 
            // T_suchbox
            // 
            this.T_suchbox.Location = new System.Drawing.Point(68, 202);
            this.T_suchbox.Name = "T_suchbox";
            this.T_suchbox.Size = new System.Drawing.Size(59, 20);
            this.T_suchbox.TabIndex = 4;
            // 
            // B_WertSuchen
            // 
            this.B_WertSuchen.Location = new System.Drawing.Point(16, 228);
            this.B_WertSuchen.Name = "B_WertSuchen";
            this.B_WertSuchen.Size = new System.Drawing.Size(133, 23);
            this.B_WertSuchen.TabIndex = 5;
            this.B_WertSuchen.Text = "Wert Suchen";
            this.B_WertSuchen.UseVisualStyleBackColor = true;
            this.B_WertSuchen.Click += new System.EventHandler(this.B_WertSuchen_Click);
            // 
            // L_ausgabe
            // 
            this.L_ausgabe.AutoSize = true;
            this.L_ausgabe.Location = new System.Drawing.Point(16, 258);
            this.L_ausgabe.Name = "L_ausgabe";
            this.L_ausgabe.Size = new System.Drawing.Size(0, 13);
            this.L_ausgabe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 290);
            this.Controls.Add(this.L_ausgabe);
            this.Controls.Add(this.B_WertSuchen);
            this.Controls.Add(this.T_suchbox);
            this.Controls.Add(this.L_Suchwert);
            this.Controls.Add(this.B_Initialisieren);
            this.Controls.Add(this.B_Ausgabe);
            this.Controls.Add(this.LB_ausgabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_ausgabe;
        private System.Windows.Forms.Button B_Ausgabe;
        private System.Windows.Forms.Button B_Initialisieren;
        private System.Windows.Forms.Label L_Suchwert;
        private System.Windows.Forms.TextBox T_suchbox;
        private System.Windows.Forms.Button B_WertSuchen;
        private System.Windows.Forms.Label L_ausgabe;
    }
}

