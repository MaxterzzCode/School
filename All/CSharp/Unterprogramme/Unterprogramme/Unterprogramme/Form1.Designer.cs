namespace Unterprogramme
{
    partial class Unterprogramm
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
            this.B_Bart = new System.Windows.Forms.Button();
            this.LB_TextBox = new System.Windows.Forms.ListBox();
            this.B_TafelWischen = new System.Windows.Forms.Button();
            this.B_Krusty = new System.Windows.Forms.Button();
            this.B_Milhouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Bart
            // 
            this.B_Bart.Location = new System.Drawing.Point(19, 26);
            this.B_Bart.Name = "B_Bart";
            this.B_Bart.Size = new System.Drawing.Size(210, 40);
            this.B_Bart.TabIndex = 0;
            this.B_Bart.Text = "Bart muss Strafarbeit machen";
            this.B_Bart.UseVisualStyleBackColor = true;
            this.B_Bart.Click += new System.EventHandler(this.B_Bart_Click);
            // 
            // LB_TextBox
            // 
            this.LB_TextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.LB_TextBox.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_TextBox.FormattingEnabled = true;
            this.LB_TextBox.ItemHeight = 14;
            this.LB_TextBox.Location = new System.Drawing.Point(19, 161);
            this.LB_TextBox.Name = "LB_TextBox";
            this.LB_TextBox.Size = new System.Drawing.Size(210, 214);
            this.LB_TextBox.TabIndex = 4;
            // 
            // B_TafelWischen
            // 
            this.B_TafelWischen.Location = new System.Drawing.Point(21, 401);
            this.B_TafelWischen.Name = "B_TafelWischen";
            this.B_TafelWischen.Size = new System.Drawing.Size(210, 37);
            this.B_TafelWischen.TabIndex = 3;
            this.B_TafelWischen.Text = "Tafel wischen";
            this.B_TafelWischen.UseVisualStyleBackColor = true;
            this.B_TafelWischen.Click += new System.EventHandler(this.B_TafelWischen_Click);
            // 
            // B_Krusty
            // 
            this.B_Krusty.Location = new System.Drawing.Point(19, 119);
            this.B_Krusty.Name = "B_Krusty";
            this.B_Krusty.Size = new System.Drawing.Size(210, 36);
            this.B_Krusty.TabIndex = 2;
            this.B_Krusty.Text = "Krusty muss Strafarbeit machen";
            this.B_Krusty.UseVisualStyleBackColor = true;
            this.B_Krusty.Click += new System.EventHandler(this.B_Krusty_Click);
            // 
            // B_Milhouse
            // 
            this.B_Milhouse.Location = new System.Drawing.Point(19, 72);
            this.B_Milhouse.Name = "B_Milhouse";
            this.B_Milhouse.Size = new System.Drawing.Size(210, 41);
            this.B_Milhouse.TabIndex = 1;
            this.B_Milhouse.Text = "Milhouse muss Strafarbeit machen";
            this.B_Milhouse.UseVisualStyleBackColor = true;
            this.B_Milhouse.Click += new System.EventHandler(this.B_Milhouse_Click);
            // 
            // Unterprogramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 450);
            this.Controls.Add(this.LB_TextBox);
            this.Controls.Add(this.B_TafelWischen);
            this.Controls.Add(this.B_Krusty);
            this.Controls.Add(this.B_Milhouse);
            this.Controls.Add(this.B_Bart);
            this.Name = "Unterprogramm";
            this.Text = "Unterprogramme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Bart;
        private System.Windows.Forms.ListBox LB_TextBox;
        private System.Windows.Forms.Button B_TafelWischen;
        private System.Windows.Forms.Button B_Krusty;
        private System.Windows.Forms.Button B_Milhouse;
    }
}

