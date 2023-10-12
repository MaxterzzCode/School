using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterprogramme_mit_Parameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Strafarbeit_Click(object sender, EventArgs e)
        {
            string name = TB_Name.Text;
            string text = TB_Straftext.Text;
            int anzahl = Convert.ToInt16(TB_Anzahl.Text);
            MacheStrafarbeit(name, text, anzahl);
            output("output.txt", anzahl, text, name);
        }

        public void MacheStrafarbeit(string pName, string pStraftext, int pAnzahl)
        {
            LB_Tafel.Items.Add("Ich bin " + pName);
            for (int i = 0; i < pAnzahl; i++)
            {
                LB_Tafel.Items.Add(pStraftext);
            }
        }

        public void output(string pFilename, int pAnzahl, string pStraftext, string pName)
        {
            StreamWriter datei = new StreamWriter(pFilename);
            datei.WriteLine("Strafarbeit von " + pName);
            for (int i = 0; i < pAnzahl; i++)
            {
                datei.WriteLine(pStraftext);
            }
            datei.Close();
        }
    }
}
