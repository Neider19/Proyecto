namespace PROYECTO_3
{
    partial class MANTENIMIENTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MANTENIMIENTO));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BOTONVOLVERINICIO = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 21);
            label1.Name = "label1";
            label1.Size = new Size(402, 16);
            label1.TabIndex = 0;
            label1.Text = "!UPS, PARECE QUE ESTAMOS TODAVIA EN MANTENIMIENTO¡";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(212, 50);
            label2.Name = "label2";
            label2.Size = new Size(330, 16);
            label2.TabIndex = 1;
            label2.Text = "VUELVAN PRONTO, LES PROMETEMOS MEJORAS :)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // BOTONVOLVERINICIO
            // 
            BOTONVOLVERINICIO.Location = new Point(368, 405);
            BOTONVOLVERINICIO.Name = "BOTONVOLVERINICIO";
            BOTONVOLVERINICIO.Size = new Size(75, 23);
            BOTONVOLVERINICIO.TabIndex = 3;
            BOTONVOLVERINICIO.Text = "INICIO";
            BOTONVOLVERINICIO.UseVisualStyleBackColor = true;
            BOTONVOLVERINICIO.Click += BOTONVOLVERINICIO_Click;
            // 
            // MANTENIMIENTO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BOTONVOLVERINICIO);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MANTENIMIENTO";
            Text = "MANTENIMIENTO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button BOTONVOLVERINICIO;
    }
}