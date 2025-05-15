namespace PROYECTO_3
{
    partial class MAESTRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAESTRO));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(770, 48);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(147, 116);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 1;
            button1.Text = "ASISTENSIA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 182);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 2;
            button2.Text = "MONITOREO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(147, 243);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 3;
            button3.Text = "TEMPORIZADOR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(148, 303);
            button4.Name = "button4";
            button4.Size = new Size(121, 44);
            button4.TabIndex = 4;
            button4.Text = "AGENDA PERSONAL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(148, 388);
            button5.Name = "button5";
            button5.Size = new Size(121, 23);
            button5.TabIndex = 5;
            button5.Text = "SUGERENCIAS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MAESTRO
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 480);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MAESTRO";
            Text = "MAESTRO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
    }
}