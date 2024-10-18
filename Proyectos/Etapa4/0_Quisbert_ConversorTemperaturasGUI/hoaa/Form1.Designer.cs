namespace hoaa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.Anunciado = new System.Windows.Forms.Label();
            this.textF = new System.Windows.Forms.Label();
            this.textK = new System.Windows.Forms.Label();
            this.valorF = new System.Windows.Forms.Label();
            this.valorK = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.BotonRojo = new System.Windows.Forms.Button();
            this.mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoEllipsis = true;
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Titulo.Location = new System.Drawing.Point(68, 40);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(331, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Conversor de Temperatura";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Anunciado
            // 
            this.Anunciado.AutoSize = true;
            this.Anunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anunciado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Anunciado.Location = new System.Drawing.Point(191, 70);
            this.Anunciado.Name = "Anunciado";
            this.Anunciado.Size = new System.Drawing.Size(91, 13);
            this.Anunciado.TabIndex = 1;
            this.Anunciado.Text = "Convertir estos C°";
            this.Anunciado.Click += new System.EventHandler(this.label2_Click);
            // 
            // textF
            // 
            this.textF.AutoSize = true;
            this.textF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textF.Location = new System.Drawing.Point(71, 126);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(67, 13);
            this.textF.TabIndex = 2;
            this.textF.Text = "En Farenheit";
            this.textF.Click += new System.EventHandler(this.label3_Click);
            // 
            // textK
            // 
            this.textK.AutoSize = true;
            this.textK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textK.Location = new System.Drawing.Point(347, 126);
            this.textK.Name = "textK";
            this.textK.Size = new System.Drawing.Size(52, 13);
            this.textK.TabIndex = 3;
            this.textK.Text = "En Kelvin";
            // 
            // valorF
            // 
            this.valorF.AutoSize = true;
            this.valorF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.valorF.Location = new System.Drawing.Point(90, 139);
            this.valorF.Name = "valorF";
            this.valorF.Size = new System.Drawing.Size(26, 13);
            this.valorF.TabIndex = 4;
            this.valorF.Text = "0° F";
            // 
            // valorK
            // 
            this.valorK.AutoSize = true;
            this.valorK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.valorK.Location = new System.Drawing.Point(359, 139);
            this.valorK.Name = "valorK";
            this.valorK.Size = new System.Drawing.Size(23, 13);
            this.valorK.TabIndex = 5;
            this.valorK.Text = "0 K";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(73, 86);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(326, 20);
            this.TextBox.TabIndex = 6;
            this.TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BotonRojo
            // 
            this.BotonRojo.BackColor = System.Drawing.Color.IndianRed;
            this.BotonRojo.ForeColor = System.Drawing.Color.Black;
            this.BotonRojo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonRojo.Location = new System.Drawing.Point(194, 112);
            this.BotonRojo.Name = "BotonRojo";
            this.BotonRojo.Size = new System.Drawing.Size(88, 23);
            this.BotonRojo.TabIndex = 7;
            this.BotonRojo.Text = "Boton Rojo";
            this.BotonRojo.UseVisualStyleBackColor = false;
            this.BotonRojo.Click += new System.EventHandler(this.button1_Click);
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.BackColor = System.Drawing.Color.Black;
            this.mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.Location = new System.Drawing.Point(191, 138);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(94, 13);
            this.mensaje.TabIndex = 8;
            this.mensaje.Text = "Hola  Mundo :d";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(468, 213);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.BotonRojo);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.valorK);
            this.Controls.Add(this.valorF);
            this.Controls.Add(this.textK);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.Anunciado);
            this.Controls.Add(this.Titulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Conversor de Temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Anunciado;
        private System.Windows.Forms.Label textF;
        private System.Windows.Forms.Label textK;
        private System.Windows.Forms.Label valorF;
        private System.Windows.Forms.Label valorK;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button BotonRojo;
        private System.Windows.Forms.Label mensaje;
    }
}

