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
    public partial class BorrarBeneficiario : Form
    {
        public BorrarBeneficiario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void InicializaListaBeneficiarios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtieneBeneficiariosCompletos();
            ListaBeneficiarios.DisplayMember = "Nombre_Programa";

            //Seleccionamos el primer municipio de la lista
            ListaBeneficiarios.SelectedIndex = 0;
        }
        private void BorrarBeneficiario_Load(object sender, EventArgs e)
        {
            InicializaListaBeneficiarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultadoDialogo = MessageBox.Show(
                $"Está seguro que quiere borrar el beneficiario {ListaBeneficiarios.Text}?",
                $"Borrar municipio {ListaBeneficiarios.Text}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultadoDialogo == DialogResult.Yes)
            {
                try
                {
                    string mensajeEliminacion;
                    string?[] infoMunicipio = ListaBeneficiarios.SelectedItem!.ToString()!.Split('-');

                    Beneficiario unBeneficiario = new Beneficiario
                    {
                        ID_Beneficiario = int.Parse(txtCodigoBeneficiario.Text),
                        Nombre_Beneficiario = infoMunicipio[1]!.Trim()
                    };

                    bool resultadoEliminacion = AccesoDatos.EliminarBeneficiario(unBeneficiario!, out mensajeEliminacion);

                    if (resultadoEliminacion)
                    {
                        MessageBox.Show("El beneficiario se eliminó correctamente",
                        "Borrado exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        //Si la eliminación fue exitosa, se puede cerrar el formulario
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensajeEliminacion,
                        "Fallo en el borrado del beneficiario",
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

        private void txtCodigoBeneficiario_TextChanged(object sender, EventArgs e)
        {
            if (ListaBeneficiarios.DataSource != null)
            {
                //Obtenemos el código del municipio
                string?[] infoMunicipio = ListaBeneficiarios.SelectedItem!.ToString()!.Split('-');
                int codigoMunicipio = int.Parse(infoMunicipio[1]!.Trim());
                txtCodigoBeneficiario.Text = codigoMunicipio.ToString();

                //txtNombreBeneficiario.Text = infoMunicipio[1]!.Trim();
            }
        }

        private void ListaBeneficiarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaBeneficiarios.DataSource != null)
            {
                //Obtenemos el código del municipio
                string?[] infoMunicipio = ListaBeneficiarios.SelectedItem!.ToString()!.Split('-');
                int codigoMunicipio = int.Parse(infoMunicipio[1]!.Trim());
                txtCodigoBeneficiario.Text = codigoMunicipio.ToString();
                string? NomBeneficiario = (infoMunicipio[0]!.Trim());
                txtNombreBeneficiario.Text = NomBeneficiario;
                string? NomMunicipio = (infoMunicipio[2]!.Trim());
                txtMunicipio.Text = NomMunicipio;


                ListaBeneficiarios.Text = infoMunicipio[1]!.Trim();
            }
        }

        private void txtNombreBeneficiario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
