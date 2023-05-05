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
    public partial class NuevoBeneficiario : Form
    {
        public NuevoBeneficiario()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InicializaListaBeneficiarios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtieneNombresBeneficiarios();
            ListaBeneficiarios.DisplayMember = "Nombre_Programa";

            //Seleccionamos el primer municipio de la lista
            ListaBeneficiarios.SelectedIndex = 0;

        }

        private void NuevoBeneficiario_Load(object sender, EventArgs e)
        {
            InicializaListaBeneficiarios();
            InicializaListaMunicipios();
        }

        public void InicializaListaMunicipios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtieneNombresMunicipios();
            ListaMunicipios.DisplayMember = "Nombre_Municipio";

            //Seleccionamos el primer municipio de la lista
            ListaMunicipios.SelectedIndex = 0;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListaMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string? nombreMunicipio = ListaMunicipios.SelectedItem!.ToString();
            string? nombreBeneficiario = txtNombre_Beneficiario.Text;
            string? mensajeInsercion;
            bool resultadoInsercion = AccesoDatos.InsertarNuevoBeneficiario(nombreBeneficiario!,
                                        nombreMunicipio!,
                                        out mensajeInsercion);
            if (resultadoInsercion)
            {
                MessageBox.Show(mensajeInsercion,
                    "Se logró guardar el nuevo beneficiario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNombre_Beneficiario.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(mensajeInsercion,
                    "Inserción fallida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
