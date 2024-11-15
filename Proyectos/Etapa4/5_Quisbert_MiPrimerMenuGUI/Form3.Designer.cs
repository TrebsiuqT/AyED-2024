namespace _5_Quisbert_MiPrimerMenuGUI
{
    partial class iam_sad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            i_am_sadnes = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // i_am_sadnes
            // 
            i_am_sadnes.BackColor = Color.Fuchsia;
            i_am_sadnes.Location = new Point(677, 409);
            i_am_sadnes.Name = "i_am_sadnes";
            i_am_sadnes.Size = new Size(94, 29);
            i_am_sadnes.TabIndex = 1;
            i_am_sadnes.Text = "Back";
            i_am_sadnes.UseVisualStyleBackColor = false;
            i_am_sadnes.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2024_11_14_210754;
            pictureBox1.Location = new Point(267, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 172);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 259);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 3;
            label1.Text = "pues sigue asi";
            label1.Click += label1_Click;
            // 
            // iam_sad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(i_am_sadnes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "iam_sad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iam_sad";
            Load += iam_sad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button i_am_sadnes;
        private PictureBox pictureBox1;
        private Label label1;
    }
}