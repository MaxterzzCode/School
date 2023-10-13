using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterprogramme
{
    public partial class Unterprogramm : Form
    {
        public Unterprogramm()
        {
            InitializeComponent();
        }

        public void MacheStrafarbeit()
        {
            for (int i = 0; i < 10; i++)
            {
                LB_TextBox.Items.Add("I WILL NOT SCREAM FOR ICE CREAM");
            }
        }

        private void B_Bart_Click(object sender, EventArgs e)
        {
            MacheStrafarbeit();
        }

        private void B_Milhouse_Click(object sender, EventArgs e)
        {
            MacheStrafarbeit();
        }

        private void B_Krusty_Click(object sender, EventArgs e)
        {
            MacheStrafarbeit();
        }

        private void B_TafelWischen_Click(object sender, EventArgs e)
        {
            LB_TextBox.Items.Clear();
        }
    }
}
