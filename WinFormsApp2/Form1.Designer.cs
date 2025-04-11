namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Carnet = new TextBox();
            Buscar = new Button();
            textBoxNombre = new TextBox();
            textBoxSeccion = new TextBox();
            textBoxNota1 = new TextBox();
            textBoxNota2 = new TextBox();
            textBoxNota3 = new TextBox();
            textBoxNota4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CrearNuevoRegistro = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Carnet
            // 
            Carnet.Location = new Point(290, 22);
            Carnet.Name = "Carnet";
            Carnet.Size = new Size(93, 23);
            Carnet.TabIndex = 0;
            Carnet.TextAlign = HorizontalAlignment.Center;
            Carnet.TextChanged += Carnet_TextChanged;
            // 
            // Buscar
            // 
            Buscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscar.Location = new Point(287, 62);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(69, 28);
            Buscar.TabIndex = 1;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += Buscar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(138, 137);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(245, 23);
            textBoxNombre.TabIndex = 2;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSeccion
            // 
            textBoxSeccion.Location = new Point(497, 137);
            textBoxSeccion.Name = "textBoxSeccion";
            textBoxSeccion.Size = new Size(90, 23);
            textBoxSeccion.TabIndex = 3;
            textBoxSeccion.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new Point(129, 233);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new Size(44, 23);
            textBoxNota1.TabIndex = 4;
            textBoxNota1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNota2
            // 
            textBoxNota2.Location = new Point(258, 233);
            textBoxNota2.Name = "textBoxNota2";
            textBoxNota2.Size = new Size(45, 23);
            textBoxNota2.TabIndex = 5;
            textBoxNota2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNota3
            // 
            textBoxNota3.Location = new Point(389, 233);
            textBoxNota3.Name = "textBoxNota3";
            textBoxNota3.Size = new Size(49, 23);
            textBoxNota3.TabIndex = 6;
            textBoxNota3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNota4
            // 
            textBoxNota4.Location = new Point(538, 233);
            textBoxNota4.Name = "textBoxNota4";
            textBoxNota4.Size = new Size(49, 23);
            textBoxNota4.TabIndex = 7;
            textBoxNota4.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 25);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 8;
            label1.Text = "Carnet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 140);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(439, 140);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "Seccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 236);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Nota 1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(206, 236);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 12;
            label5.Text = "Nota 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(337, 236);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 13;
            label6.Text = "Nota 3:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(486, 236);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 14;
            label7.Text = "Nota 4:";
            // 
            // CrearNuevoRegistro
            // 
            CrearNuevoRegistro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrearNuevoRegistro.Location = new Point(258, 361);
            CrearNuevoRegistro.Name = "CrearNuevoRegistro";
            CrearNuevoRegistro.Size = new Size(69, 28);
            CrearNuevoRegistro.TabIndex = 15;
            CrearNuevoRegistro.Text = "Crear";
            CrearNuevoRegistro.UseVisualStyleBackColor = true;
            CrearNuevoRegistro.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(333, 361);
            button3.Name = "button3";
            button3.Size = new Size(76, 28);
            button3.TabIndex = 17;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(379, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 204);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(CrearNuevoRegistro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNota4);
            Controls.Add(textBoxNota3);
            Controls.Add(textBoxNota2);
            Controls.Add(textBoxNota1);
            Controls.Add(textBoxSeccion);
            Controls.Add(textBoxNombre);
            Controls.Add(Buscar);
            Controls.Add(Carnet);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "UMG";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Carnet;
        private Button Buscar;
        private TextBox textBoxNombre;
        private TextBox textBoxSeccion;
        private TextBox textBoxNota1;
        private TextBox textBoxNota2;
        private TextBox textBoxNota3;
        private TextBox textBoxNota4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button CrearNuevoRegistro;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
