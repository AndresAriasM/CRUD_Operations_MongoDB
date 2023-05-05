using ProgramaBeneficiariosMongo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaBeneficiariosMongo.Formularios
{
    public partial class BorrarSubsidio : Form
    {
        public BorrarSubsidio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaSubsidios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaSubsidios.DataSource != null)
            {
                try
                {
                    //Obtenemos el código del municipio
                    string?[] infoMunicipio = ListaSubsidios.SelectedItem!.ToString()!.Split('-');
                    int codigoMunicipio = int.Parse(infoMunicipio[0]!.Trim());
                    txtCodigoBeneficiario.Text = codigoMunicipio.ToString();
                    string? NomBeneficiario = (infoMunicipio[1]!.Trim());
                    textBox1.Text = NomBeneficiario;
                    //int NomBeneficiario = int.Parse(infoMunicipio[1]!.Trim());
                    string? NomMunicipio = (infoMunicipio[2]!.Trim());
                    textBox2.Text = NomMunicipio;
                    int año = int.Parse(infoMunicipio[3]!.Trim());
                    Año.Text = año.ToString();
                    int mes = int.Parse(infoMunicipio[4]!.Trim());
                    Mes.Text = mes.ToString();
                }
                catch { }

                //ListaSubsidios.Text = infoMunicipio[1]!.Trim();
            }
        }
        public void InicializaListaSubsidios()
        {
            ListaSubsidios.DataSource = null;
            ListaSubsidios.DataSource = AccesoDatos.ObtieneNombresSubsidios();
            ListaSubsidios.DisplayMember = "Nombre_Subsidio";

            //Seleccionamos el primer municipio de la lista
            ListaSubsidios.SelectedIndex = 0;

        }

        private void BorrarSubsidio_Load(object sender, EventArgs e)
        {
            InicializaListaSubsidios();
            //ActualizarListBox();
        }
        private void ActualizarListBox()
        {
            string consulta = "SELECT ID_Subsidio, Nombre_Beneficiario, Nombre_Programa, Año, Mes FROM Subsidios " +
                              "INNER JOIN Beneficiarios ON Subsidios.Beneficiario = Beneficiarios.ID_Beneficiario " +
                              "INNER JOIN Programas ON Subsidios.Programa = Programas.ID_Programa " +
                              "ORDER BY Año DESC, Mes DESC";

            using (SQLiteConnection conexion = new SQLiteConnection("Data Source=.\\Beneficiarios_DB.sqlite;Version=3;"))
            using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(consulta, conexion))
            {
                DataTable tablaSubsidios = new DataTable();
                adaptador.Fill(tablaSubsidios);
                ListaSubsidios.DataSource = tablaSubsidios;
                ListaSubsidios.DisplayMember = "Nombre";
                ListaSubsidios.ValueMember = "ID_Subsidio";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (ListaSubsidios.DataSource != null)
            {
                //Obtenemos el código del municipio
                string?[] infoMunicipio = ListaSubsidios.SelectedItem!.ToString()!.Split('-');
                int codigoMunicipio = int.Parse(infoMunicipio[0]!.Trim());
                txtCodigoBeneficiario.Text = codigoMunicipio.ToString();
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea borrar el subsidio seleccionado?\n" , "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (ListaSubsidios.SelectedItem != null)
                {
                    string?[] infoMunicipio = ListaSubsidios.SelectedItem!.ToString()!.Split('-');
                    int codigoMunicipio = int.Parse(infoMunicipio[0]!.Trim());
                    // Obtener el ID del subsidio seleccionado
                    int idSubsidio = codigoMunicipio;

                    // Eliminar el subsidio de la base de datos
                    string consulta = "DELETE FROM Subsidios WHERE ID_Subsidio = @idSubsidio";

                    using (SQLiteConnection conexion = new SQLiteConnection("Data Source=.\\Beneficiarios_DB.sqlite;Version=3;"))
                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        conexion.Open();
                        comando.Parameters.AddWithValue("@idSubsidio", idSubsidio);
                        comando.ExecuteNonQuery();
                    }

                    // Actualizar el ListBox y mostrar un mensaje de éxito
                    ActualizarListBox();
                    MessageBox.Show("Subsidio eliminado correctamente.");
                    MessageBox.Show("Reinicie esta página para ver cambios.");
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un subsidio para eliminar.");
                }
            }
                

        }
    }
}
