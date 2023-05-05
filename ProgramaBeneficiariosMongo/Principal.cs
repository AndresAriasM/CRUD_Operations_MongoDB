using ProgramaBeneficiariosMongo.Formularios;

namespace ProgramaBeneficiariosMongo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(9, 210, 2);
            p.Size = new Size(166, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 47);
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevoPrograma();
            formulario.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
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

        private void Municipios_Click_1(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new NuevoMunicipio();
            formulario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ActualizaMunicipio();
            formulario.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.BorrarMunicipio();
            formulario.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.BorrarPrograma();
            formulario.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ActualizaPrograma();
            formulario.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.NuevoBeneficiario();
            formulario.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ActualizaBeneficiarios();
            formulario.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.BorrarSubsidio();
            formulario.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.BorrarBeneficiario();
            formulario.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.NuevoSubsidio();
            formulario.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ActualizaSubsidio();
            formulario.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ReporteMunicipios();
            formulario.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ReporteBeneficiario();
            formulario.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ReportePrograma();
            formulario.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ReporteSubsidio();
            formulario.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {

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

        private void button22_Click(object sender, EventArgs e)
        {
            Form formulario = new Formularios.ReporteDepartamento();
            formulario.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pProgramas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}