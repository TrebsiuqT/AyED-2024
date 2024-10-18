using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoaa
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Boton
            string centigrados_str = TextBox.Text;
            double centigrados = 0;
            try
            {
                centigrados = double.Parse(centigrados_str);
                double f = centigrados * 9 / 5 + 32;
                double k = centigrados + 273.15;
                valorF.Text = f.ToString();
                valorK.Text = k.ToString();
                mensaje.Text = "Hola Mundos!";
            }
            catch
            {
                valorF.Text = "Error";
                valorK.Text = "Error";
                mensaje.Text = "Nada de letras \n solo numeros";
            }
        }   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
