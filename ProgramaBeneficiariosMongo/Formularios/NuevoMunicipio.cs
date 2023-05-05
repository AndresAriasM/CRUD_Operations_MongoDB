using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaBeneficiariosMongo
{
    public partial class NuevoMunicipio : Form
    {
        public NuevoMunicipio()
        {
            InitializeComponent();

        }

        private void NuevoMunicipio_Load(object sender, EventArgs e)
        {
            InicializaListaMunicipios();
            InicializaListaDepartamentos();
        }
        public void InicializaListaMunicipios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtieneNombresMunicipios();
            ListaMunicipios.DisplayMember = "Nombre_Municipio";

            //Seleccionamos el primer municipio de la lista
            ListaMunicipios.SelectedIndex = 0;

        }

        public void InicializaListaDepartamentos()
        {
            ListaDepartamentos.DataSource = null;
            ListaDepartamentos.DataSource = AccesoDatos.ObtieneNombresDepartamentos();
            ListaDepartamentos.DisplayMember = "Nombre_Departamento";

            //Seleccionamos el primer municipio de la lista
            ListaDepartamentos.SelectedIndex = 0;

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string? nombreDepartamento = ListaDepartamentos.SelectedItem!.ToString();
            string? nombreMunicipio = txtNombre_Municipio.Text;
            string? mensajeInsercion;
            bool resultadoInsercion = AccesoDatos.InsertarNuevoMunicipio(nombreMunicipio,
                                        nombreDepartamento!,
                                        out mensajeInsercion);
            if (resultadoInsercion)
            {
                MessageBox.Show(mensajeInsercion,
                    "Se logró guardar el nuevo municipio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNombre_Municipio.Text = string.Empty;
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