using ProgramaBeneficiariosMongo.Modelos;
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
    public partial class BorrarMunicipio : Form
    {
        public BorrarMunicipio()
        {
            InitializeComponent();
        }

        public void InicializaListaMunicipios()
        {
            txtNombreMunicipio.DataSource = null;
            txtNombreMunicipio.DataSource = AccesoDatos.ObtieneMunicipiosCompletos();
            //ListaMunicipios.DisplayMember = "Nombre_Municipio";

            //Seleccionamos el primer municipio de la lista
            txtNombreMunicipio.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ListaMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNombreMunicipio.DataSource != null)
            {
                //Obtenemos el código del municipio
                string?[] infoMunicipio = txtNombreMunicipio.SelectedItem!.ToString()!.Split('-');
                int codigoMunicipio = int.Parse(infoMunicipio[1]!.Trim());
                txtCodigoMunicipio.Text = codigoMunicipio.ToString();
                string? NomMunicipio = (infoMunicipio[0]!.Trim());
                NombreMuncipio.Text = NomMunicipio;

                txtNombreMunicipio.Text = infoMunicipio[1]!.Trim();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrarMunicipio_Load(object sender, EventArgs e)
        {
            InicializaListaMunicipios();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var resultadoDialogo = MessageBox.Show(
                $"Está seguro que quiere borrar el municipio {txtNombreMunicipio.Text}?",
                $"Borrar municipio {txtNombreMunicipio.Text}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultadoDialogo == DialogResult.Yes)
            {
                try
                {
                    string mensajeEliminacion;
                    string?[] infoMunicipio = txtNombreMunicipio.SelectedItem!.ToString()!.Split('-');

                    Municipio unMunicipio = new Municipio
                    {
                        ID_Municipio = int.Parse(txtCodigoMunicipio.Text),
                        Nombre_Municipio = infoMunicipio[1]!.Trim()
                    };

                    bool resultadoEliminacion = AccesoDatos.EliminarMunicipio(unMunicipio, out mensajeEliminacion);

                    if (resultadoEliminacion)
                    {
                        MessageBox.Show("El municipio se eliminó correctamente",
                        "Borrado exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        //Si la eliminación fue exitosa, se puede cerrar el formulario
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensajeEliminacion,
                        "Fallo en el borrado del municipio",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

                }
                catch (FormatException unErrorFormato)
                {
                    MessageBox.Show($"Datos numéricos no tienen el formato Esperado. {unErrorFormato.Message}");
                }
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreMunicipio.DataSource != null)
            {
                //Obtenemos el código del municipio
                string?[] infoMunicipio = txtNombreMunicipio.SelectedItem!.ToString()!.Split('-');
                int codigoMunicipio = int.Parse(infoMunicipio[1]!.Trim());
                txtCodigoMunicipio.Text = codigoMunicipio.ToString();

                txtNombreMunicipio.Text = infoMunicipio[1]!.Trim();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
