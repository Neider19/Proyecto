namespace PROYECTO_3
{
    partial class ESTUDIANTES
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESTUDIANTES));
            label1 = new Label();
            label2 = new Label();
            NOMBRE_ESTUDIANTE = new TextBox();
            ID_ESTUDIANTE = new TextBox();
            INICIAR_E = new Button();
            VOLVER_INICIO1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 73);
            label1.Name = "label1";
            label1.Size = new Size(203, 15);
            label1.TabIndex = 0;
            label1.Text = "TU PRIMER NOMBRE (SOLO LETRAS):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 142);
            label2.Name = "label2";
            label2.Size = new Size(219, 15);
            label2.TabIndex = 1;
            label2.Text = "TU IDENTIFICACION (SOLO NUMEROS ):";
            label2.Click += label2_Click;
            // 
            // NOMBRE_ESTUDIANTE
            // 
            NOMBRE_ESTUDIANTE.BorderStyle = BorderStyle.FixedSingle;
            NOMBRE_ESTUDIANTE.Location = new Point(35, 100);
            NOMBRE_ESTUDIANTE.Name = "NOMBRE_ESTUDIANTE";
            NOMBRE_ESTUDIANTE.Size = new Size(175, 23);
            NOMBRE_ESTUDIANTE.TabIndex = 2;
            // 
            // ID_ESTUDIANTE
            // 
            ID_ESTUDIANTE.Location = new Point(35, 175);
            ID_ESTUDIANTE.Name = "ID_ESTUDIANTE";
            ID_ESTUDIANTE.Size = new Size(169, 23);
            ID_ESTUDIANTE.TabIndex = 3;
            // 
            // INICIAR_E
            // 
            INICIAR_E.Location = new Point(35, 269);
            INICIAR_E.Name = "INICIAR_E";
            INICIAR_E.RightToLeft = RightToLeft.No;
            INICIAR_E.Size = new Size(75, 23);
            INICIAR_E.TabIndex = 4;
            INICIAR_E.Text = "INICIAR";
            INICIAR_E.UseVisualStyleBackColor = true;
            INICIAR_E.Click += INICIAR_E_Click;
            // 
            // VOLVER_INICIO1
            // 
            VOLVER_INICIO1.Location = new Point(135, 269);
            VOLVER_INICIO1.Name = "VOLVER_INICIO1";
            VOLVER_INICIO1.Size = new Size(75, 23);
            VOLVER_INICIO1.TabIndex = 5;
            VOLVER_INICIO1.Text = "VOLVER";
            VOLVER_INICIO1.UseVisualStyleBackColor = true;
            VOLVER_INICIO1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(251, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(74, 9);
            label3.Name = "label3";
            label3.Size = new Size(375, 32);
            label3.TabIndex = 7;
            label3.Text = "                                  ¡BIENVENIDOS ESTUDIANTE!\r\nRECUERDEN PEDIR AYUDA A SUS TUTORES SI TIENEN ALGUNA DUDA.\r\n";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ESTUDIANTES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(527, 362);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(VOLVER_INICIO1);
            Controls.Add(INICIAR_E);
            Controls.Add(ID_ESTUDIANTE);
            Controls.Add(NOMBRE_ESTUDIANTE);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ESTUDIANTES";
            Text = "ESTUDIANTES";
            Load += ESTUDIANTES_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NOMBRE_ESTUDIANTE;
        private TextBox ID_ESTUDIANTE;
        private Button INICIAR_E;
        private Button VOLVER_INICIO1;
        private PictureBox pictureBox1;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}