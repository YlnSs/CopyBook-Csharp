namespace CopyBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = textBox1.Text;
            label12.Text = textBox2.Text;
            label14.Text = textBox3.Text;
            label15.Text = textBox4.Text;

            label13.Text = comboBox1.Text;
        }
    }
}