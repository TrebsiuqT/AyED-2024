using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Quisbert_CreadorPersonajeRol
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public Form2(string nombre, int hp, string raza, List<string> Skills, Form1 form1)
        {
            InitializeComponent();
            label2.Text = "Nombre: " + nombre;
            label3.Text = "HP: " + hp.ToString();
            label4.Text = "Raza: " + raza;
            label5.Text = "Skills: ";
            foreach (string skill in Skills)
            {
                label5.Text += "\n\t" + skill;
            }
            this.form1 = form1;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
            
            
        }
    }
}
