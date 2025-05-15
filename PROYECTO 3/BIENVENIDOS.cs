using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_3
{
    public partial class BIENVENIDOS : Form
    {
        public BIENVENIDOS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BOTONMATEMATICAS_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void BOTONARTE_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void BOTONCIENCIA_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void BOTONTECNOLOGIA_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void BOTONINGENIERIA_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void SUGERENCIAS_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }
    }
}
