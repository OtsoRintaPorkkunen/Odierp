using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string defaultNameText = "[Elokuvan Nimi]";
        string defaultReviewText = "[Kirjoita arvio tähän]";
        int defaultLenght = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.Year.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ujuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tämän sovelluksen on tehnyt Otso Rinta-Porkkunen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("0");
            textBox2.Text = ("[Syötä elokuvan nimi]");
            textBox3.Text = DateTime.Now.Year.ToString();
            textBox4.Text = ("0");
            textBox5.Text = ("[Kirjoita arvio tähän]");
            numericUpDown2.Value = 5;
            numericUpDown1.Value = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == DateTime.Now.Year.ToString())
            {
                textBox3.Clear();
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "[Syötä elokuvan nimi]")
            {
                textBox2.Clear();
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "[Syötä elokuvan nimi]";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.Text = DateTime.Now.Year.ToString();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                textBox4.Text = "0";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "0")
            {
                textBox4.Clear();
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "[Kirjoita arvio tähän]")
            {
                textBox5.Clear();
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                textBox5.Text = "[Kirjoita arvio tähän]";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Et ole syöttänyt mitään julkaisu-vuosi kenttään!");
            }
            else if (!int.TryParse(textBox3.Text, out num))
            {
                MessageBox.Show("Julkaisuvuosi ei ole numeroita!");
            }
            else if (textBox4.Text == string.Empty || textBox4.Text == defaultLenght.ToString())
            {
                MessageBox.Show("Et ole syöttänyt mitään kesto kenttään!");
            }
            else if (!int.TryParse(textBox4.Text, out num))
            {
                MessageBox.Show("Kesto ei ole vain numeroita!");
            }
            else if (textBox2.Text == "[Syötä elokuvan nimi]")
            {
                MessageBox.Show("Et ole syöttänyt mitään Nimi kenttään!");
            }
            else
            {
                MessageBox.Show("Check OK!");
            }
        }
    }
}