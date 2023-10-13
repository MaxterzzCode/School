using System;
using System.Windows.Forms;

namespace Array_Initialisieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int[] z = new int[10];
        int suchwert, position;

        private void B_Initialisieren_Click(object sender, EventArgs e)
        {
            var rand = new Random();


            for (int i = 0; i < 10; i++)
            {
                z[i] = rand.Next(1, 100);
            }
            for (int i = 0; i < 10; i++)
            {
                LB_ausgabe.Items.Add("z[" + i + "]: " + z[i].ToString());
            }
        }

        private void B_Ausgabe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                LB_ausgabe.Items.Add("z[" + i + "]: " + z[i].ToString());
            }
        }

        private void B_WertSuchen_Click(object sender, EventArgs e)
        {
            suchwert = Convert.ToInt32(T_suchbox.Text);
            position = -1;

            for (int i = 0; i < 9; i++)
            {
                if (z[i] == suchwert)
                {
                    position = i;
                }

            }
            if (position != -1)
            {
                L_ausgabe.Text = ("Der Wert " + Convert.ToString(suchwert) + " ist im Element z[" + Convert.ToString(position) + "]");
            }
            else
            {
                L_ausgabe.Text = ("Wert nicht vorhanden.");
            }
        }
    }
}