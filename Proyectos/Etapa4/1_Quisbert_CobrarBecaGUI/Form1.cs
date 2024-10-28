using System.DirectoryServices;
using System.Linq.Expressions;

namespace _1_Quisbert_CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Boton rojo
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = int.Parse(TextBox1.Text);
                if (edad < 19)
                {
                    MessageBox.Show("no puedes tener la beca", "hola", MessageBoxButtons.OK);
                }
                else
                {
                    panel1.Visible = true;
                }
                

            }
            catch
            {
                MessageBox.Show("nada de letras, solo n > 0", "hola", MessageBoxButtons.OK);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            if (ComboBox1.Text == "100,001 - 200,000" || ComboBox1.Text == "Más de 200,000")
            {
                MessageBox.Show("enhorabuena tienes beca", "titulo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("requisito incumplido", "titulo", MessageBoxButtons.OK); 
            }
        }
    }
}
