namespace _5_Quisbert_MiPrimerMenuGUI
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
            button1 = new Button();
            thia = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(136, 327);
            button1.Name = "button1";
            button1.Size = new Size(103, 56);
            button1.TabIndex = 0;
            button1.Text = "angry";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // thia
            // 
            thia.BackColor = Color.Lime;
            thia.Location = new Point(634, 343);
            thia.Name = "thia";
            thia.Size = new Size(103, 56);
            thia.TabIndex = 1;
            thia.Text = "aim happy";
            thia.UseVisualStyleBackColor = false;
            thia.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.Location = new Point(343, 343);
            button3.Name = "button3";
            button3.Size = new Size(103, 56);
            button3.TabIndex = 2;
            button3.Text = "Sad";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 218);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 3;
            label1.Text = "Welcome to my menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 238);
            label2.Name = "label2";
            label2.Size = new Size(196, 38);
            label2.TabIndex = 4;
            label2.Text = "Are you okey?";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(thia);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button thia;
        private Button button3;
        private Label label1;
        private Label label2;
    }
}
