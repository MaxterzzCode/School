namespace Währungsrechner
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
            this.L_Euro = new System.Windows.Forms.Label();
            this.L_Dollar = new System.Windows.Forms.Label();
            this.TB_Euro = new System.Windows.Forms.TextBox();
            this.TB_Dollar = new System.Windows.Forms.TextBox();
            this.B_run = new System.Windows.Forms.Button();
            this.B_ende = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Kurs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L_Euro
            // 
            this.L_Euro.AutoSize = true;
            this.L_Euro.Location = new System.Drawing.Point(12, 18);
            this.L_Euro.Name = "L_Euro";
            this.L_Euro.Size = new System.Drawing.Size(29, 13);
            this.L_Euro.TabIndex = 0;
            this.L_Euro.Text = "Euro";
            this.L_Euro.Click += new System.EventHandler(this.Label1_Click);
            // 
            // L_Dollar
            // 
            this.L_Dollar.AutoSize = true;
            this.L_Dollar.Location = new System.Drawing.Point(146, 18);
            this.L_Dollar.Name = "L_Dollar";
            this.L_Dollar.Size = new System.Drawing.Size(34, 13);
            this.L_Dollar.TabIndex = 1;
            this.L_Dollar.Text = "Dollar";
            // 
            // TB_Euro
            // 
            this.TB_Euro.Location = new System.Drawing.Point(12, 34);
            this.TB_Euro.Name = "TB_Euro";
            this.TB_Euro.Size = new System.Drawing.Size(100, 20);
            this.TB_Euro.TabIndex = 2;
            // 
            // TB_Dollar
            // 
            this.TB_Dollar.Location = new System.Drawing.Point(149, 34);
            this.TB_Dollar.Name = "TB_Dollar";
            this.TB_Dollar.Size = new System.Drawing.Size(100, 20);
            this.TB_Dollar.TabIndex = 3;
            // 
            // B_run
            // 
            this.B_run.Location = new System.Drawing.Point(12, 94);
            this.B_run.Name = "B_run";
            this.B_run.Size = new System.Drawing.Size(75, 23);
            this.B_run.TabIndex = 4;
            this.B_run.Text = "Ausführen";
            this.B_run.UseVisualStyleBackColor = true;
            this.B_run.Click += new System.EventHandler(this.B_run_Click);
            // 
            // B_ende
            // 
            this.B_ende.Location = new System.Drawing.Point(174, 94);
            this.B_ende.Name = "B_ende";
            this.B_ende.Size = new System.Drawing.Size(75, 23);
            this.B_ende.TabIndex = 5;
            this.B_ende.Text = "Ende";
            this.B_ende.UseVisualStyleBackColor = true;
            this.B_ende.Click += new System.EventHandler(this.B_ende_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "1€ in US-Dollar";
            // 
            // TB_Kurs
            // 
            this.TB_Kurs.Location = new System.Drawing.Point(149, 64);
            this.TB_Kurs.Name = "TB_Kurs";
            this.TB_Kurs.Size = new System.Drawing.Size(100, 20);
            this.TB_Kurs.TabIndex = 7;
            this.TB_Kurs.Text = "1,4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 129);
            this.Controls.Add(this.TB_Kurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_ende);
            this.Controls.Add(this.B_run);
            this.Controls.Add(this.TB_Dollar);
            this.Controls.Add(this.TB_Euro);
            this.Controls.Add(this.L_Dollar);
            this.Controls.Add(this.L_Euro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Euro;
        private System.Windows.Forms.Label L_Dollar;
        private System.Windows.Forms.TextBox TB_Euro;
        private System.Windows.Forms.TextBox TB_Dollar;
        private System.Windows.Forms.Button B_run;
        private System.Windows.Forms.Button B_ende;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Kurs;
    }
}

