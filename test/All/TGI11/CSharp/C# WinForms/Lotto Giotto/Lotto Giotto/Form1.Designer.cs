namespace Lotto_Giotto
{
    partial class Form
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
            this.B_Init = new System.Windows.Forms.Button();
            this.B_Spielen = new System.Windows.Forms.Button();
            this.B_AusgabeListBox = new System.Windows.Forms.Button();
            this.B_AusgabeLottoZahlen = new System.Windows.Forms.Button();
            this.B_TestZahlen = new System.Windows.Forms.Button();
            this.L_Hinweis = new System.Windows.Forms.Label();
            this.L_Spielfeld = new System.Windows.Forms.Label();
            this.LB_Spielfeld = new System.Windows.Forms.ListBox();
            this.L_Zahlen = new System.Windows.Forms.Label();
            this.LB_Zahlen = new System.Windows.Forms.ListBox();
            this.L_TestZahlen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Init
            // 
            this.B_Init.Location = new System.Drawing.Point(28, 32);
            this.B_Init.Name = "B_Init";
            this.B_Init.Size = new System.Drawing.Size(197, 23);
            this.B_Init.TabIndex = 0;
            this.B_Init.Text = "Spielfeld Initialisieren";
            this.B_Init.UseVisualStyleBackColor = true;
            this.B_Init.Click += new System.EventHandler(this.B_Init_Click);
            // 
            // B_Spielen
            // 
            this.B_Spielen.Location = new System.Drawing.Point(28, 61);
            this.B_Spielen.Name = "B_Spielen";
            this.B_Spielen.Size = new System.Drawing.Size(197, 23);
            this.B_Spielen.TabIndex = 1;
            this.B_Spielen.Text = "Lotto Spielen";
            this.B_Spielen.UseVisualStyleBackColor = true;
            this.B_Spielen.Click += new System.EventHandler(this.B_Spielen_Click);
            // 
            // B_AusgabeListBox
            // 
            this.B_AusgabeListBox.Location = new System.Drawing.Point(28, 132);
            this.B_AusgabeListBox.Name = "B_AusgabeListBox";
            this.B_AusgabeListBox.Size = new System.Drawing.Size(197, 23);
            this.B_AusgabeListBox.TabIndex = 2;
            this.B_AusgabeListBox.Text = "Ausgabe Spielfeld in Listbox";
            this.B_AusgabeListBox.UseVisualStyleBackColor = true;
            this.B_AusgabeListBox.Click += new System.EventHandler(this.B_AusgabeListBox_Click);
            // 
            // B_AusgabeLottoZahlen
            // 
            this.B_AusgabeLottoZahlen.Location = new System.Drawing.Point(28, 162);
            this.B_AusgabeLottoZahlen.Name = "B_AusgabeLottoZahlen";
            this.B_AusgabeLottoZahlen.Size = new System.Drawing.Size(197, 23);
            this.B_AusgabeLottoZahlen.TabIndex = 3;
            this.B_AusgabeLottoZahlen.Text = "Ausgabe der 6 Lottozahlen";
            this.B_AusgabeLottoZahlen.UseVisualStyleBackColor = true;
            this.B_AusgabeLottoZahlen.Click += new System.EventHandler(this.B_AusgabeLottoZahlen_Click);
            // 
            // B_TestZahlen
            // 
            this.B_TestZahlen.Location = new System.Drawing.Point(28, 259);
            this.B_TestZahlen.Name = "B_TestZahlen";
            this.B_TestZahlen.Size = new System.Drawing.Size(197, 23);
            this.B_TestZahlen.TabIndex = 4;
            this.B_TestZahlen.Text = "6 fixe Testzahlen eintragen";
            this.B_TestZahlen.UseVisualStyleBackColor = true;
            this.B_TestZahlen.Click += new System.EventHandler(this.B_TestZahlen_Click);
            // 
            // L_Hinweis
            // 
            this.L_Hinweis.AutoSize = true;
            this.L_Hinweis.Location = new System.Drawing.Point(28, 358);
            this.L_Hinweis.Name = "L_Hinweis";
            this.L_Hinweis.Size = new System.Drawing.Size(329, 13);
            this.L_Hinweis.TabIndex = 5;
            this.L_Hinweis.Text = "Hinweis: Glücksspiel kann süchtig machen. Teilnahme ab 18 Jahren";
            // 
            // L_Spielfeld
            // 
            this.L_Spielfeld.AutoSize = true;
            this.L_Spielfeld.Location = new System.Drawing.Point(270, 9);
            this.L_Spielfeld.Name = "L_Spielfeld";
            this.L_Spielfeld.Size = new System.Drawing.Size(47, 13);
            this.L_Spielfeld.TabIndex = 6;
            this.L_Spielfeld.Text = "Spielfeld";
            // 
            // LB_Spielfeld
            // 
            this.LB_Spielfeld.FormattingEnabled = true;
            this.LB_Spielfeld.Location = new System.Drawing.Point(273, 32);
            this.LB_Spielfeld.Name = "LB_Spielfeld";
            this.LB_Spielfeld.Size = new System.Drawing.Size(138, 251);
            this.LB_Spielfeld.TabIndex = 7;
            // 
            // L_Zahlen
            // 
            this.L_Zahlen.AutoSize = true;
            this.L_Zahlen.Location = new System.Drawing.Point(453, 9);
            this.L_Zahlen.Name = "L_Zahlen";
            this.L_Zahlen.Size = new System.Drawing.Size(62, 13);
            this.L_Zahlen.TabIndex = 8;
            this.L_Zahlen.Text = "Lottozahlen";
            // 
            // LB_Zahlen
            // 
            this.LB_Zahlen.FormattingEnabled = true;
            this.LB_Zahlen.Location = new System.Drawing.Point(456, 32);
            this.LB_Zahlen.Name = "LB_Zahlen";
            this.LB_Zahlen.Size = new System.Drawing.Size(136, 134);
            this.LB_Zahlen.TabIndex = 9;
            // 
            // L_TestZahlen
            // 
            this.L_TestZahlen.AutoSize = true;
            this.L_TestZahlen.Location = new System.Drawing.Point(31, 289);
            this.L_TestZahlen.Name = "L_TestZahlen";
            this.L_TestZahlen.Size = new System.Drawing.Size(137, 13);
            this.L_TestZahlen.TabIndex = 10;
            this.L_TestZahlen.Text = "Testzahlen: 1, 3, 5, 7, 9, 11";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(632, 430);
            this.Controls.Add(this.L_TestZahlen);
            this.Controls.Add(this.LB_Zahlen);
            this.Controls.Add(this.L_Zahlen);
            this.Controls.Add(this.LB_Spielfeld);
            this.Controls.Add(this.L_Spielfeld);
            this.Controls.Add(this.L_Hinweis);
            this.Controls.Add(this.B_TestZahlen);
            this.Controls.Add(this.B_AusgabeLottoZahlen);
            this.Controls.Add(this.B_AusgabeListBox);
            this.Controls.Add(this.B_Spielen);
            this.Controls.Add(this.B_Init);
            this.Name = "Form";
            this.Text = "Lottozahlengenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Init;
        private System.Windows.Forms.Button B_Spielen;
        private System.Windows.Forms.Button B_AusgabeListBox;
        private System.Windows.Forms.Button B_AusgabeLottoZahlen;
        private System.Windows.Forms.Button B_TestZahlen;
        private System.Windows.Forms.Label L_Hinweis;
        private System.Windows.Forms.Label L_Spielfeld;
        private System.Windows.Forms.ListBox LB_Spielfeld;
        private System.Windows.Forms.Label L_Zahlen;
        private System.Windows.Forms.ListBox LB_Zahlen;
        private System.Windows.Forms.Label L_TestZahlen;
    }
}

