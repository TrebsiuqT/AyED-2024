using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Quisbert_MiPrimerMenuGUI
{

    public partial class i_am_red : Form
    {
        private Form1 form1;
        public i_am_red(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
            {
                MessageBox.Show("FELICIDADes", "capo");
                linkLabel1.Text = "no touch";
            }
            else
            {
                MessageBox.Show("Wong", "u are bad");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://music.youtube.com/watch?v=IzPQ_jA00bk&si=1KNHb1LF8bBiDmnK") { UseShellExecute = true });
        }
    }
}
