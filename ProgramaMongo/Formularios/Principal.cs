using ProgramaMongo.Formularios;

namespace ProgramaMongo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Municipios_Click(object sender, EventArgs e)
        {
            // Verificar si el menú está actualmente abierto
            bool menuAbierto = pMunicipios.Visible;

            // Cerrar cualquier menú abierto antes de abrir el menú actual
            if (pProgramas.Visible) pProgramas.Visible = false;
            if (pBeneficiarios.Visible) pBeneficiarios.Visible = false;
            if (pSubsidios.Visible) pSubsidios.Visible = false;
            if (pDepartamento.Visible) pDepartamento.Visible = false;
            if (menuAbierto) pMunicipios.Visible = false;
            else pMunicipios.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si el menú está actualmente abierto
            bool menuAbierto = pProgramas.Visible;

            // Cerrar cualquier menú abierto antes de abrir el menú actual
            if (pMunicipios.Visible) pMunicipios.Visible = false;
            if (pBeneficiarios.Visible) pBeneficiarios.Visible = false;
            if (pSubsidios.Visible) pSubsidios.Visible = false;
            if (pDepartamento.Visible) pDepartamento.Visible = false;
            if (menuAbierto) pProgramas.Visible = false;
            else pProgramas.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si el menú está actualmente abierto
            bool menuAbierto = pBeneficiarios.Visible;

            // Cerrar cualquier menú abierto antes de abrir el menú actual
            if (pProgramas.Visible) pProgramas.Visible = false;
            if (pMunicipios.Visible) pMunicipios.Visible = false;
            if (pSubsidios.Visible) pSubsidios.Visible = false;
            if (pDepartamento.Visible) pDepartamento.Visible = false;
            if (menuAbierto) pBeneficiarios.Visible = false;
            else pBeneficiarios.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar si el menú está actualmente abierto
            bool menuAbierto = pSubsidios.Visible;

            // Cerrar cualquier menú abierto antes de abrir el menú actual
            if (pProgramas.Visible) pProgramas.Visible = false;
            if (pMunicipios.Visible) pMunicipios.Visible = false;
            if (pBeneficiarios.Visible) pBeneficiarios.Visible = false;
            if (pDepartamento.Visible) pDepartamento.Visible = false;
            if (menuAbierto) pSubsidios.Visible = false;
            else pSubsidios.Visible = true;
        }

        private void Departamentos_Click(object sender, EventArgs e)
        {
            // Verificar si el menú está actualmente abierto
            bool menuAbierto = pDepartamento.Visible;

            // Cerrar cualquier menú abierto antes de abrir el menú actual
            if (pProgramas.Visible) pProgramas.Visible = false;
            if (pMunicipios.Visible) pMunicipios.Visible = false;
            if (pBeneficiarios.Visible) pBeneficiarios.Visible = false;
            if (pSubsidios.Visible) pSubsidios.Visible = false;
            if (menuAbierto) pDepartamento.Visible = false;
            else pDepartamento.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevoMunicipio();
            formulario.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevoPrograma();
            formulario.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevoBeneficiario();
            formulario.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevoSubsidio();
            formulario.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario = new BorrarMunicipio();
            formulario.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new BorrarPrograma();
            formulario.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formulario = new BorrarBeneficiario();
            formulario.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form formulario = new BorrarSubsidio();
            formulario.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form formulario = new ReportesDepartamento();
            formulario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new ReportesMunicipio();
            formulario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new ActualizaMunicipio();
            formulario.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario = new ActualizaPrograma();
            formulario.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form formulario = new ActualizaBeneficiario();
            formulario.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form formulario = new ActualizaSubsidio();
            formulario.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario = new ReportesPrograma();
            formulario.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form formulario = new ReportesBeneficiario();
            formulario.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form formulario = new ReportesSubsidio();
            formulario.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevoDepartamento();
            formulario.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form formulario = new BorrarDepartamento();
            formulario.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form formulario = new ActualizaDepartamento();
            formulario.ShowDialog();
        }
    }
}