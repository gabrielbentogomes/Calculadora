namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "+";
            float n1 = float.Parse(textBox1.Text);
            float n2 = float.Parse(textBox2.Text);
            float soma = n1 + n2;
            label4.Text = soma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "x";
            float n1 = float.Parse(textBox1.Text);
            float n2 = float.Parse(textBox2.Text);
            float multiplicacao = n1 * n2;
            label4.Text = multiplicacao.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "/";
            float n1 = float.Parse(textBox1.Text);
            float n2 = float.Parse(textBox2.Text);
            float divisao = n1 / n2;
            label4.Text = divisao.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "-";
            float n1 = float.Parse(textBox1.Text);
            float n2 = float.Parse(textBox2.Text);
            float subtracao = n1 - n2;
            label4.Text = subtracao.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}