namespace Unterprogramme_mit_Parameter
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
            this.B_Strafarbeit = new System.Windows.Forms.Button();
            this.B_Clear = new System.Windows.Forms.Button();
            this.LB_Tafel = new System.Windows.Forms.ListBox();
            this.L_Infos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Straftext = new System.Windows.Forms.TextBox();
            this.TB_Anzahl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_Strafarbeit
            // 
            this.B_Strafarbeit.Location = new System.Drawing.Point(27, 30);
            this.B_Strafarbeit.Name = "B_Strafarbeit";
            this.B_Strafarbeit.Size = new System.Drawing.Size(245, 23);
            this.B_Strafarbeit.TabIndex = 0;
            this.B_Strafarbeit.Text = "Strafarbeit machen";
            this.B_Strafarbeit.UseVisualStyleBackColor = true;
            this.B_Strafarbeit.Click += new System.EventHandler(this.B_Strafarbeit_Click);
            // 
            // B_Clear
            // 
            this.B_Clear.Location = new System.Drawing.Point(27, 288);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(245, 23);
            this.B_Clear.TabIndex = 1;
            this.B_Clear.Text = "Tafel wischen";
            this.B_Clear.UseVisualStyleBackColor = true;
            // 
            // LB_Tafel
            // 
            this.LB_Tafel.BackColor = System.Drawing.SystemColors.InfoText;
            this.LB_Tafel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tafel.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_Tafel.FormattingEnabled = true;
            this.LB_Tafel.ItemHeight = 15;
            this.LB_Tafel.Location = new System.Drawing.Point(27, 59);
            this.LB_Tafel.Name = "LB_Tafel";
            this.LB_Tafel.Size = new System.Drawing.Size(245, 214);
            this.LB_Tafel.TabIndex = 2;
            // 
            // L_Infos
            // 
            this.L_Infos.AutoSize = true;
            this.L_Infos.Location = new System.Drawing.Point(24, 331);
            this.L_Infos.Name = "L_Infos";
            this.L_Infos.Size = new System.Drawing.Size(182, 13);
            this.L_Infos.TabIndex = 3;
            this.L_Infos.Text = "Bitte weitere Informationen eingeben:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Straftext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Anzahl";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(73, 353);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(133, 20);
            this.TB_Name.TabIndex = 7;
            // 
            // TB_Straftext
            // 
            this.TB_Straftext.Location = new System.Drawing.Point(73, 381);
            this.TB_Straftext.Name = "TB_Straftext";
            this.TB_Straftext.Size = new System.Drawing.Size(133, 20);
            this.TB_Straftext.TabIndex = 8;
            // 
            // TB_Anzahl
            // 
            this.TB_Anzahl.Location = new System.Drawing.Point(73, 407);
            this.TB_Anzahl.Name = "TB_Anzahl";
            this.TB_Anzahl.Size = new System.Drawing.Size(133, 20);
            this.TB_Anzahl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.TB_Anzahl);
            this.Controls.Add(this.TB_Straftext);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Infos);
            this.Controls.Add(this.LB_Tafel);
            this.Controls.Add(this.B_Clear);
            this.Controls.Add(this.B_Strafarbeit);
            this.Name = "Form1";
            this.Text = "Unterprogramme mit Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Strafarbeit;
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.ListBox LB_Tafel;
        private System.Windows.Forms.Label L_Infos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Straftext;
        private System.Windows.Forms.TextBox TB_Anzahl;
    }
}

