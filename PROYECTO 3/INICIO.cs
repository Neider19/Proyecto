namespace PROYECTO_3
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BOTON_SALIR_INICIO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOTON_ESTUDIANTE_Click(object sender, EventArgs e)
        {
            ESTUDIANTES eSTUDIANTES = new ESTUDIANTES();
            eSTUDIANTES.Show();
            this.Hide();
        }

        private void BOTON_MAESTRO_Click(object sender, EventArgs e)
        {
            INICIO_MAESTROS iNICIO_MAESTROS = new INICIO_MAESTROS();
            iNICIO_MAESTROS.Show();
            this.Hide();
        }
    }
}
