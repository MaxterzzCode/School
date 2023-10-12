using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flächenberechnung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double laenge, breite, summe;

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            breite = Convert.ToDouble(textBox2.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            summe = laenge * breite;
            textBox3.Text = Convert.ToString(summe);

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            laenge = Convert.ToDouble(textBox1.Text);
        }
    }
}
