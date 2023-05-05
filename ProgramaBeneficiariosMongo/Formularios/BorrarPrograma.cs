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
    public partial class BorrarPrograma : Form
    {
        public BorrarPrograma()
        {
            InitializeComponent();
        }
        public void InicializaListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtieneProgramasCompletos();
            ListaProgramas.DisplayMember = "Nombre_Programa";

            //Seleccionamos el primer municipio de la lista
            ListaProgramas.SelectedIndex = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrarPrograma_Load(object sender, EventArgs e)
        {
            InicializaListaProgramas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultadoDialogo = MessageBox.Show(
                $"Está seguro que quiere borrar el programa {ListaProgramas.Text}?",
                $"Borrar municipio {ListaProgramas.Text}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultadoDialogo == DialogResult.Yes)
            {
                try
                {
                    string mensajeEliminacion;
                    string?[] infoMunicipio = ListaProgramas.SelectedItem!.ToString()!.Split('-');

                    Programa unMunicipio = new Programa
                    {
                        ID_Programa = int.Parse(txtCodigoBeneficiario.Text),
                        Nombre_Programa = infoMunicipio[1]!.Trim(),
                        Valor = float.Parse(txtMunicipio.Text),
                    };

                    bool resultadoEliminacion = AccesoDatos.EliminarPrograma(unMunicipio, out mensajeEliminacion);

                    if (resultadoEliminacion)
                    {
                        MessageBox.Show("El programa se eliminó correctamente",
                        "Borrado exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        //Si la eliminación fue exitosa, se puede cerrar el formulario
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensajeEliminacion,
                        "Fallo en el borrado del programa",
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
            if (ListaProgramas.DataSource != null)
            {
                //Obtenemos el código del municipio
                string?[] infoMunicipio = ListaProgramas.SelectedItem!.ToString()!.Split('-');
                int codigoMunicipio = int.Parse(infoMunicipio[0]!.Trim());
                txtCodigoBeneficiario.Text = codigoMunicipio.ToString();

                txtNombreBeneficiario.Text = infoMunicipio[1]!.Trim();
            }
        }

        private void ListaProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaProgramas.DataSource != null)
            {
                //Obtenemos el código del municipio
                string?[] infoMunicipio = ListaProgramas.SelectedItem!.ToString()!.Split('-');
                int codigoMunicipio = int.Parse(infoMunicipio[0]!.Trim());
                txtCodigoBeneficiario.Text = codigoMunicipio.ToString();
                string? NomBeneficiario = (infoMunicipio[1]!.Trim());
                txtNombreBeneficiario.Text = NomBeneficiario;
                string? NomMunicipio = (infoMunicipio[2]!.Trim());
                txtMunicipio.Text = NomMunicipio;

                ListaProgramas.Text = infoMunicipio[1]!.Trim();
            }
        }
    }
}
