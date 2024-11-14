using System.DirectoryServices;

namespace _4_Quisbert_CreadorPersonajeRol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] data = new string[]
        {
            "¿Sabías que el primer error en un programa se le llamó \"bug\" \nporque encontraron una polilla dentro de una de las primeras computadoras? \n¡Así es! Un pequeño insecto fue el culpable de que una máquina se comportara de manera extraña.",
            "https://music.youtube.com/watch?v=MbuwCYAjHlE&si=PvUVXCboHGRvtVdO"
        };

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> Skills = new List<string>();
            if (checkBox1.Checked) { Skills.Add(checkBox1.Text); }
            if (checkBox2.Checked) { Skills.Add(checkBox2.Text); }
            if (checkBox3.Checked) { Skills.Add(checkBox3.Text); }
            if (checkBox4.Checked) { Skills.Add(checkBox4.Text); }
            if (checkBox5.Checked) { Skills.Add(checkBox5.Text); }
            if (checkBox6.Checked) { Skills.Add(checkBox6.Text); }
            if (checkBox7.Checked) { Skills.Add(checkBox7.Text); }
            if (checkBox8.Checked) { Skills.Add(checkBox8.Text); }
            if (checkBox9.Checked) { Skills.Add(checkBox9.Text); }
            if (checkBox10.Checked) { Skills.Add(checkBox10.Text); }

            int vida; bool pass = false;
            pass = int.TryParse(textBox2.Text, out vida);
            if (!pass) { label6.Text = "Aviso: Llenar correctamente los datos"; return; }
            
            if (vida > 100 || vida < 1)
            {
                label6.Text = "Aviso: debe 1 < HP < 100";
                return;
            }

            if (comboBox1.Text != "Humano" && comboBox1.Text != "Hobbit" && comboBox1.Text != "Enano")
            {
                label6.Text = "Aviso: Eliga una raza";
                return;
            }
            Class2 personaje = new Class2(textBox1.Text, vida, comboBox1.Text, Skills);
            
            Form2 form2 = new Form2(personaje.Nombre, personaje.Vida, personaje.Raza, Skills, this);
            this.Hide(); // Oculta Form1 en lugar de cerrarlo
            form2.ShowDialog(); // Abre Form2 como ventana modal
            this.Show(); // Vuelve a mostrar Form1 cuando se cierra Form2
            



            
            

        }
        
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox2.Text) >= 1 && int.Parse(textBox2.Text) <= 100)
                {
                    label6.Text = data[0];
                }
                else { label6.Text = "Aviso: Ingrese un numero entre 1 y 100"; }
            }
            catch (Exception) { label6.Text = "Error: Ingrese solo numeros"; } 
        }
    }
}
