using System;

namespace Lotto_Giotto
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        bool[] lotto = new bool[50];


        private void B_Init_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lotto.Length; i++) {
                lotto[i] = false;
            }
        }

        private void B_AusgabeListBox_Click(object sender, EventArgs e)
        {
            LB_Spielfeld.Items.Clear();
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == false)
                {
                    LB_Spielfeld.Items.Add("lotto[" + i + "]: " + "O");
                }
                else
                {
                    LB_Spielfeld.Items.Add("lotto[" + i + "]: " + "X");
                }
                
            }
        }

        private void B_TestZahlen_Click(object sender, EventArgs e)
        {
            lotto[1] = true;
            lotto[3] = true;
            lotto[5] = true;
            lotto[7] = true;
            lotto[9] = true;
            lotto[11] = true;
        }

        private void B_AusgabeLottoZahlen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == true)
                {
                    LB_Zahlen.Items.Add(i);
                }
            }
        }

        private void B_Spielen_Click(object sender, EventArgs e)
        {

            LB_Zahlen.Items.Clear();
            int anzahl = 0;
            int zufallszahl = 0;
            Random rand = new Random();

            while (anzahl < 6)
            {
                zufallszahl = rand.Next(1, 50);
                if (lotto[zufallszahl] == false)
                {
                    lotto[zufallszahl] = true;
                    anzahl++;
                }
            }
            

        }
    }
}
