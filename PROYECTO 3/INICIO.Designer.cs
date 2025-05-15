namespace PROYECTO_3
{
    partial class INICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            BOTON_ESTUDIANTE = new Button();
            BOTON_MAESTRO = new Button();
            BOTON_SALIR_INICIO = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(491, 52);
            label1.TabIndex = 0;
            label1.Text = "Implementación de tecnologías digitales para aprender \r\n                en las sedes Educativas Públicas.";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(219, 247);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "INICIAR COMO:";
            // 
            // BOTON_ESTUDIANTE
            // 
            BOTON_ESTUDIANTE.BackColor = Color.FromArgb(192, 255, 192);
            BOTON_ESTUDIANTE.Location = new Point(113, 276);
            BOTON_ESTUDIANTE.Name = "BOTON_ESTUDIANTE";
            BOTON_ESTUDIANTE.Size = new Size(86, 23);
            BOTON_ESTUDIANTE.TabIndex = 3;
            BOTON_ESTUDIANTE.Text = "ESTUDIANTE";
            BOTON_ESTUDIANTE.UseVisualStyleBackColor = false;
            BOTON_ESTUDIANTE.Click += BOTON_ESTUDIANTE_Click;
            // 
            // BOTON_MAESTRO
            // 
            BOTON_MAESTRO.BackColor = Color.FromArgb(255, 255, 192);
            BOTON_MAESTRO.Location = new Point(310, 276);
            BOTON_MAESTRO.Name = "BOTON_MAESTRO";
            BOTON_MAESTRO.Size = new Size(75, 23);
            BOTON_MAESTRO.TabIndex = 4;
            BOTON_MAESTRO.Text = "MAESTRO";
            BOTON_MAESTRO.UseVisualStyleBackColor = false;
            BOTON_MAESTRO.Click += BOTON_MAESTRO_Click;
            // 
            // BOTON_SALIR_INICIO
            // 
            BOTON_SALIR_INICIO.BackColor = Color.LightCoral;
            BOTON_SALIR_INICIO.Location = new Point(436, 323);
            BOTON_SALIR_INICIO.Name = "BOTON_SALIR_INICIO";
            BOTON_SALIR_INICIO.Size = new Size(75, 23);
            BOTON_SALIR_INICIO.TabIndex = 5;
            BOTON_SALIR_INICIO.Text = "SALIR";
            BOTON_SALIR_INICIO.UseVisualStyleBackColor = false;
            BOTON_SALIR_INICIO.Click += BOTON_SALIR_INICIO_Click;
            // 
            // INICIO
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(523, 358);
            Controls.Add(BOTON_SALIR_INICIO);
            Controls.Add(BOTON_MAESTRO);
            Controls.Add(BOTON_ESTUDIANTE);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "INICIO";
            Text = "INICIO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button BOTON_ESTUDIANTE;
        private Button BOTON_MAESTRO;
        private Button BOTON_SALIR_INICIO;
    }
}
