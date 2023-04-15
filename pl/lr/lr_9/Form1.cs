namespace lr_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(a_in.Text);
            double b = double.Parse(b_in.Text);
            double c = double.Parse(c_in.Text);

            if ((Math.Pow(b, 2) - 4 * a * c) < 0) textBox1.Text = "Уравнение не имеет действительных корней";
            else textBox1.Text = "Уравнение имеет действительные корни";
        }
    }
}