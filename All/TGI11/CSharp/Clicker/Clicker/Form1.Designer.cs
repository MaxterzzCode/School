namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_pointlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grouping = new System.Windows.Forms.GroupBox();
            this.up3 = new System.Windows.Forms.Button();
            this.up2 = new System.Windows.Forms.Button();
            this.up1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grouping.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_pointlabel
            // 
            this.label_pointlabel.AutoSize = true;
            this.label_pointlabel.BackColor = System.Drawing.Color.IndianRed;
            this.label_pointlabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_pointlabel.Location = new System.Drawing.Point(18, 27);
            this.label_pointlabel.Name = "label_pointlabel";
            this.label_pointlabel.Size = new System.Drawing.Size(245, 65);
            this.label_pointlabel.TabIndex = 0;
            this.label_pointlabel.Text = "0 Cookies";
            this.label_pointlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(364, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cookie Baker 69";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grouping
            // 
            this.grouping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grouping.Controls.Add(this.up3);
            this.grouping.Controls.Add(this.up2);
            this.grouping.Controls.Add(this.up1);
            this.grouping.Location = new System.Drawing.Point(18, 126);
            this.grouping.Name = "grouping";
            this.grouping.Size = new System.Drawing.Size(613, 300);
            this.grouping.TabIndex = 2;
            this.grouping.TabStop = false;
            this.grouping.Text = "Upgrades";
            this.grouping.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // up3
            // 
            this.up3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.up3.Location = new System.Drawing.Point(54, 189);
            this.up3.Name = "up3";
            this.up3.Size = new System.Drawing.Size(529, 72);
            this.up3.TabIndex = 2;
            this.up3.Text = "1000 Cookies";
            this.up3.UseVisualStyleBackColor = true;
            this.up3.Click += new System.EventHandler(this.up3_Click);
            // 
            // up2
            // 
            this.up2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.up2.Location = new System.Drawing.Point(54, 111);
            this.up2.Name = "up2";
            this.up2.Size = new System.Drawing.Size(529, 72);
            this.up2.TabIndex = 1;
            this.up2.Text = "250 Cookies";
            this.up2.UseVisualStyleBackColor = true;
            this.up2.Click += new System.EventHandler(this.up2_Click);
            // 
            // up1
            // 
            this.up1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.up1.Location = new System.Drawing.Point(54, 36);
            this.up1.Name = "up1";
            this.up1.Size = new System.Drawing.Size(529, 69);
            this.up1.TabIndex = 0;
            this.up1.Text = "50 Cookies";
            this.up1.UseVisualStyleBackColor = true;
            this.up1.Click += new System.EventHandler(this.up1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.grouping);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_pointlabel);
            this.Name = "Form1";
            this.Text = "eatin a burger with no honey mustard";
            this.grouping.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_pointlabel;
        private Button button1;
        private GroupBox grouping;
        private Button up3;
        private Button up2;
        private Button up1;
        private System.Windows.Forms.Timer timer1;
    }
}