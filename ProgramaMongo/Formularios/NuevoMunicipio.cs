using ProgramaMongo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaMongo.Formularios
{
    public partial class NuevoMunicipio : Form
    {
        public NuevoMunicipio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarListaDepartamentos()
        {
            ListaDepartamentos.DataSource = null;
            ListaDepartamentos.DataSource = AccesoDatos.ObtenerListaNombresDepartamentos();

            ListaDepartamentos.SelectedIndex = 0;
        }

        private void ActualizarListaMunicipios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtenerListaNombresMunicipios();

            ListaMunicipios.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Municipio nuevoMunicipio = new Municipio
            {
                Departamento = ListaDepartamentos.SelectedItem!.ToString(),
                Nombre_Municipio = txtNombreMunicipio.Text
            };

            string? mensajeInsercion;

            bool resultadoInsercion = AccesoDatos.InsertarMunicipio(nuevoMunicipio,
                                        out mensajeInsercion);

            if (resultadoInsercion)
            {
                MessageBox.Show(mensajeInsercion,
                    "Inserción Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Si la inserción fue exitosa, se puede cerrar el formulario
                this.Close();
            }
            else
            {
                MessageBox.Show(mensajeInsercion,
                "Inserción Fallida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ActualizarListaDepartamentos();
        }

        private void NuevoMunicipio_Load(object sender, EventArgs e)
        {
            ActualizarListaDepartamentos();
            ActualizarListaMunicipios();
        }
    }
}
