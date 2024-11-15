namespace _5_Quisbert_MiPrimerMenuGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //red
            i_am_red form2 = new i_am_red(this);
            this.Hide();
            form2.ShowDialog(); // Muestra Form2 como ventana modal
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //blue
            iam_sad form3 = new iam_sad(this);
            this.Hide();
            form3.ShowDialog(); // Muestra Form2 como ventana modal
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //gren
            Form4 form4 = new Form4(this);
            this.Hide();
            form4.ShowDialog(); // Muestra Form2 como ventana modal
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
