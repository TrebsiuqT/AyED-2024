namespace _1_Quisbert_CobrarBecaGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox1 = new TextBox();
            Label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            Boton2 = new Button();
            ComboBox1 = new ComboBox();
            Label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.BackColor = SystemColors.ButtonHighlight;
            TextBox1.Location = new Point(149, 129);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(190, 27);
            TextBox1.TabIndex = 0;
            TextBox1.TextChanged += textBox1_TextChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(180, 97);
            Label1.Name = "Label1";
            Label1.Size = new Size(116, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Ingrese su edad:";
            Label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(190, 172);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(Boton2);
            panel1.Controls.Add(ComboBox1);
            panel1.Controls.Add(Label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 314);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // Boton2
            // 
            Boton2.BackColor = Color.LightCoral;
            Boton2.Location = new Point(180, 137);
            Boton2.Name = "Boton2";
            Boton2.Size = new Size(94, 29);
            Boton2.TabIndex = 2;
            Boton2.Text = "Touch me";
            Boton2.UseVisualStyleBackColor = false;
            Boton2.Click += Boton2_Click;
            // 
            // ComboBox1
            // 
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "Entre 0 - 50,000", "50,001 - 100,000", "100,001 - 200,000", "Más de 200,000" });
            ComboBox1.Location = new Point(149, 94);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(151, 28);
            ComboBox1.TabIndex = 0;
            ComboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(125, 67);
            Label2.Name = "Label2";
            Label2.Size = new Size(214, 20);
            Label2.TabIndex = 1;
            Label2.Text = "Caules son tus ingresos anules?";
            Label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(471, 314);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(Label1);
            Controls.Add(TextBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox1;
        private Label Label1;
        private Button button1;
        private Panel panel1;
        private Label Label2;
        private ComboBox ComboBox1;
        private Button Boton2;
    }
}
