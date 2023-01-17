namespace PecIzveles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Hide();
        }

        class var{
            public static double x;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkBox1.Show();
            } else
            {
                checkBox1.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                var.x = (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text)) * 0.9;
            }
            else
            {
                var.x = (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text));
            }
            label1.Text = "Kopsumma: " + var.x;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}