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
    public partial class NuevoBeneficiario : Form
    {
        public NuevoBeneficiario()
        {
            InitializeComponent();
        }
        private void ActualizarListaMunicipios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtenerListaNombresMunicipios();

            ListaMunicipios.SelectedIndex = 0;
        }

        private void ActualizarListaBeneficiarios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtenerListaNombresBeneficiarios();

            ListaBeneficiarios.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoBeneficiario_Load(object sender, EventArgs e)
        {
            ActualizarListaMunicipios();
            ActualizarListaBeneficiarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] datosMunicipi = ListaMunicipios.SelectedItem.ToString().Split('-');
            var var1 = datosMunicipi[0].Trim();

            Beneficiario nuevoMunicipio = new Beneficiario
            {
                Municipio = datosMunicipi[0].Trim(),
                Nombre_Beneficiario = txtNombreMunicipio.Text
            };

            string? mensajeInsercion;

            bool resultadoInsercion = AccesoDatos.InsertarBeneficiario(nuevoMunicipio,
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
    }
}
