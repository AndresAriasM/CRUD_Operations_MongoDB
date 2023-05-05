using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaBeneficiariosMongo.Formularios
{
    public partial class NuevoSubsidio : Form
    {
        public NuevoSubsidio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NuevoSubsidio_Load(object sender, EventArgs e)
        {
            InicializaListaSubsidios();
            InicializaListaProgramas();
            InicializaListaBeneficiarios();
        }
        public void InicializaListaBeneficiarios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtieneNombresBeneficiarios();
            ListaBeneficiarios.DisplayMember = "Nombre_Departamento";

            //Seleccionamos el primer municipio de la lista
            ListaBeneficiarios.SelectedIndex = 0;

        }

        public void InicializaListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtieneNombresProgramas();
            ListaProgramas.DisplayMember = "Nombre_Departamento";

            //Seleccionamos el primer municipio de la lista
            ListaProgramas.SelectedIndex = 0;

        }
        public void InicializaListaSubsidios()
        {
            ListaSubsidios.DataSource = null;
            ListaSubsidios.DataSource = AccesoDatos.ObtieneNombresSubsidios();
            ListaSubsidios.DisplayMember = "Nombre_Municipio";

            //Seleccionamos el primer municipio de la lista
            ListaSubsidios.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string? nombrePrograma = ListaProgramas.SelectedItem!.ToString();
            string? nombreBeneficiario = ListaBeneficiarios.SelectedItem!.ToString();
            int año = int.Parse(Año.Text);
            int mes = int.Parse(Mes.Text);
            string? mensajeInsercion;
            bool resultadoInsercion = AccesoDatos.InsertarNuevoSubsidio(nombreBeneficiario!,
                                        nombrePrograma!, año!, mes!,
                                        out mensajeInsercion);
            if (resultadoInsercion)
            {
                MessageBox.Show(mensajeInsercion,
                    "Se logró guardar el nuevo municipio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Año.Text = string.Empty;
                Mes.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(mensajeInsercion,
                    "Inserción fallida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ListaSubsidios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
