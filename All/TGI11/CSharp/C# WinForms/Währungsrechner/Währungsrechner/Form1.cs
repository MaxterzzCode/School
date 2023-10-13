using System;
using System.Windows.Forms;

namespace Währungsrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Euro, Dollar, sumDollar, sumEuro;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void B_ende_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_run_Click(object sender, EventArgs e)
        {
            double kurs = Convert.ToDouble(TB_Kurs.Text);
            TB_Kurs.Text = Convert.ToString(kurs);

            if (TB_Euro.Text != "")
            {
                Euro = Convert.ToDouble(TB_Euro.Text);
            }
            if (TB_Dollar.Text != "")
            {
                Dollar = Convert.ToDouble(TB_Dollar.Text);
            }
            sumDollar = kurs * Euro;
            sumEuro = Dollar / kurs;

            TB_Euro.Text = Convert.ToString(sumEuro);
            TB_Dollar.Text = Convert.ToString(sumDollar);
        }


    }
}
