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
    public partial class ReporteSubsidio : Form
    {
        public ReporteSubsidio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InicializaListaSubsidios()
        {
            ListaSubsidios.DataSource = null;
            ListaSubsidios.DataSource = AccesoDatos.ObtieneNombresSubsidios();
            ListaSubsidios.DisplayMember = "Nombre_Municipio";

            //Seleccionamos el primer municipio de la lista
            ListaSubsidios.SelectedIndex = 0;

        }

        private void ListaSubsidios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtenemos el código del municipio
            string?[] infoMunicipio = ListaSubsidios.SelectedItem!.ToString()!.Split('-');
            int codigoMunicipio = int.Parse(infoMunicipio[0]!.Trim());
            //txtCodigoBeneficiario.Text = codigoMunicipio.ToString();
            string? NomBeneficiario = (infoMunicipio[1]!.Trim());
            textBox1.Text = NomBeneficiario;
            //int NomBeneficiario = int.Parse(infoMunicipio[1]!.Trim());
            string? NomMunicipio = (infoMunicipio[2]!.Trim());
            textBox2.Text = NomMunicipio;
            int año = int.Parse(infoMunicipio[3]!.Trim());
            txtAño.Text = año.ToString();
            int mes = int.Parse(infoMunicipio[4]!.Trim());
            txtMes.Text = mes.ToString();


            // Obtener el ID del subsidio seleccionado
            int idSubsidio = codigoMunicipio;

            // Establecer la cadena de conexión a la base de datos
            string connectionString = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";

            // Crear la consulta SQL para obtener el valor del subsidio seleccionado
            string sqlQuery = "SELECT Valor FROM Subsidios " +
                              "JOIN Programas ON Subsidios.Programa = Programas.ID_Programa " +
                              "WHERE ID_Subsidio = @idSubsidio";

            // Crear la conexión a la base de datos
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando SQL y agregar los parámetros
                using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idSubsidio", idSubsidio);

                    // Ejecutar el comando y obtener el resultado
                    object result = command.ExecuteScalar();

                    // Si el resultado no es nulo, actualizar el valor del textbox
                    if (result != null)
                    {
                        double valorSubsidio = Convert.ToDouble(result);
                        txtValorTotal.Text = valorSubsidio.ToString("C");
                    }
                }

                // Cerrar la conexión
                connection.Close();
            }

            string consulta1 = "SELECT Municipio FROM Beneficiarios WHERE ID_Beneficiario = (SELECT Beneficiario FROM Subsidios WHERE ID_Subsidio = @idSubsidio)";
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(consulta1, conexion))
                {
                    cmd.Parameters.AddWithValue("@idSubsidio", idSubsidio);
                    conexion.Open();
                    object idMunicipioObj = cmd.ExecuteScalar();
                    if (idMunicipioObj != null)
                    {
                        int idMunicipio = Convert.ToInt32(idMunicipioObj);

                        // Realizar la segunda consulta SQL para obtener el nombre del municipio a partir de su ID
                        string query2 = "SELECT Nombre_Municipio FROM Municipios WHERE ID_Municipio = @idMunicipio";
                        using (SQLiteCommand cmd2 = new SQLiteCommand(query2, conexion))
                        {
                            cmd2.Parameters.AddWithValue("@idMunicipio", idMunicipio);
                            object nombreMunicipioObj = cmd2.ExecuteScalar();
                            if (nombreMunicipioObj != null)
                            {
                                string nombreMunicipio = nombreMunicipioObj.ToString();

                                // Asignar el nombre del municipio obtenido al Textbox correspondiente
                                textBox3.Text = nombreMunicipio;
                            }
                        }
                    }
                    conexion.Close();
                }
            }


        }

        private void ReporteSubsidio_Load(object sender, EventArgs e)
        {
            InicializaListaSubsidios();
        }

        private int ObtenerIDDepartamento(string nombreDepartamento)
        {
            int idDepartamento = 0;
            string conn = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";
            using (SQLiteConnection conexion = new SQLiteConnection(conn))
            {
                conexion.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT ID_Programa FROM Programas WHERE Nombre_Programa = @nombreDepartamento", conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreDepartamento", nombreDepartamento);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idDepartamento = reader.GetInt32(0);
                        }
                    }
                }
            }
            return idDepartamento;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
