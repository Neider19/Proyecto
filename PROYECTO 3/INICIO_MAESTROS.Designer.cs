namespace PROYECTO_3
{
    partial class INICIO_MAESTROS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO_MAESTROS));
            label1 = new Label();
            NOMBREMAESTRO = new TextBox();
            IDENTIFICACIONMAESTRO = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            INICIARMAESTRO = new Button();
            REGRESARMAESTRO = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(124, 9);
            label1.Name = "label1";
            label1.Size = new Size(606, 50);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // NOMBREMAESTRO
            // 
            NOMBREMAESTRO.Location = new Point(65, 127);
            NOMBREMAESTRO.Name = "NOMBREMAESTRO";
            NOMBREMAESTRO.Size = new Size(148, 23);
            NOMBREMAESTRO.TabIndex = 1;
            // 
            // IDENTIFICACIONMAESTRO
            // 
            IDENTIFICACIONMAESTRO.Location = new Point(65, 198);
            IDENTIFICACIONMAESTRO.Name = "IDENTIFICACIONMAESTRO";
            IDENTIFICACIONMAESTRO.Size = new Size(148, 23);
            IDENTIFICACIONMAESTRO.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "CLASE A", "CLASE B", "CLASE C" });
            listBox1.Location = new Point(65, 266);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 49);
            listBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 97);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 168);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "IDENTIFICACION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 237);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "CLASE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // INICIARMAESTRO
            // 
            INICIARMAESTRO.Location = new Point(47, 357);
            INICIARMAESTRO.Name = "INICIARMAESTRO";
            INICIARMAESTRO.Size = new Size(75, 23);
            INICIARMAESTRO.TabIndex = 8;
            INICIARMAESTRO.Text = "INICIAR";
            INICIARMAESTRO.UseVisualStyleBackColor = true;
            INICIARMAESTRO.Click += INICIARMAESTRO_Click;
            // 
            // REGRESARMAESTRO
            // 
            REGRESARMAESTRO.Location = new Point(153, 358);
            REGRESARMAESTRO.Name = "REGRESARMAESTRO";
            REGRESARMAESTRO.Size = new Size(75, 23);
            REGRESARMAESTRO.TabIndex = 9;
            REGRESARMAESTRO.Text = "button1";
            REGRESARMAESTRO.UseVisualStyleBackColor = true;
            REGRESARMAESTRO.Click += REGRESARMAESTRO_Click;
            // 
            // INICIO_MAESTROS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(REGRESARMAESTRO);
            Controls.Add(INICIARMAESTRO);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(IDENTIFICACIONMAESTRO);
            Controls.Add(NOMBREMAESTRO);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "INICIO_MAESTROS";
            Text = "INICIO_MAESTROS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NOMBREMAESTRO;
        private TextBox IDENTIFICACIONMAESTRO;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button INICIARMAESTRO;
        private Button REGRESARMAESTRO;
    }
}