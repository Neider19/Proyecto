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
    public partial class INICIO_MAESTROS : Form
    {
        public INICIO_MAESTROS()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void REGRESARMAESTRO_Click(object sender, EventArgs e)
        {
            INICIO iNICIO = new INICIO();
            iNICIO.Show();
            this.Hide();
        }

        private void INICIARMAESTRO_Click(object sender, EventArgs e)
        {
            MAESTRO MAISTRO = new MAESTRO();
            MAISTRO.Show();
            this.Hide();
        }
    }
}
