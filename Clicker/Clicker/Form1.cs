namespace Clicker
{
    public partial class Form1 : Form
    {
        int puntos = 0;

        //upusgradus

        int up50 = 0;
        int up250 = 0;
        int up1000 = 0;

        //timer
        int timerCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            puntos++;
            label_pointlabel.Text = puntos.ToString() + " Cookies";

        }

        private void up1_Click(object sender, EventArgs e)
        {
            if (puntos >= 0)
            {
                up50++;
                puntos -= 50;
                label_pointlabel.Text = puntos.ToString() + " Cookies";
            }
            else
            {
                MessageBox.Show("broke mf");
            }
        }

        private void up2_Click(object sender, EventArgs e)
        {
            if (puntos >= 250)
            {
                up250++;
                puntos -= 250;
                label_pointlabel.Text = puntos.ToString() + " Cookies";
            }
            else
            {
                MessageBox.Show("broke mf");
            }
        }

        private void up3_Click(object sender, EventArgs e)
        {
            if (puntos >= 1000)
            {
                up1000++;
                puntos -= 1000;
                label_pointlabel.Text = puntos.ToString() + " Cookies";
            }
            else
            {
                MessageBox.Show("broke mf");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount++;
            puntos += up1000;
            if (timerCount % 4 == 0)
            {
                puntos += up250;
            }
            if (timerCount % 20 == 0)
            {
                puntos += up50;
            }
            label_pointlabel.Text = puntos.ToString() + " Cookies";




        }
    }
}