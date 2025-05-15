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
    public partial class ESTUDIANTES : Form
    {
        public ESTUDIANTES()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            INICIO iNICIO = new INICIO();
            iNICIO.Show();
            this.Close();
        }

        private void ESTUDIANTES_Load(object sender, EventArgs e)
        {

        }

        private void INICIAR_E_Click(object sender, EventArgs e)
        {
            BIENVENIDOS bIENVENIDOS = new BIENVENIDOS();
            bIENVENIDOS.Show();
            this.Hide();
        }
    }
}
