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
    public partial class NuevoPrograma : Form
    {
        public NuevoPrograma()
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

        private void NuevoPrograma_Load(object sender, EventArgs e)
        {
            InicializaListaProgramas();
        }

        public void InicializaListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtieneNombresProgramas();
            ListaProgramas.DisplayMember = "Nombre_Programas";

            //Seleccionamos el primer municipio de la lista
            ListaProgramas.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float valor = float.Parse(txtValor.Text);
            string? nombrePrograma = txtNombrePrograma.Text;
            string? mensajeInsercion;
            bool resultadoInsercion = AccesoDatos.InsertarNuevoPrograma(nombrePrograma, valor!, out mensajeInsercion);
            if (resultadoInsercion)
            {
                MessageBox.Show(mensajeInsercion,
                    "Se logró guardar el nuevo programa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNombrePrograma.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(mensajeInsercion,
                    "Inserción fallida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ListaProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
