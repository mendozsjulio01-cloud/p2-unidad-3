namespace practica_n_1_al_10
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton sumarnumeros
            textBox2.Text = Total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton a�adir
            listBox1.Items.Add(textBox1.Text);
            f_num = float.Parse(textBox1.Text);
            Total += f_num;
            textBox1.Text = "";
            textBox1.Focus();
            

        }
    }
}
