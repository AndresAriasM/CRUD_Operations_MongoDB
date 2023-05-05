using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaBeneficiariosMongo.Formularios
{
    public partial class ReporteMunicipios : Form
    {
        public ReporteMunicipios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaSubsidios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReporteMunicipios_Load(object sender, EventArgs e)
        {
            InicializaListaMunicipios();
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
        public void InicializaListaMunicipios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtieneNombresMunicipios();
            ListaMunicipios.DisplayMember = "Nombre_Municipio";

            //Seleccionamos el primer municipio de la lista
            ListaMunicipios.SelectedIndex = 0;

        }



        private void ListaProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (ListaProgramas.DataSource != null)
            {
                string nombreMunicipio = ListaMunicipios.SelectedItem!.ToString()!;
                string nombrePrograma = ListaProgramas.SelectedItem!.ToString()!;
                int codigoMunicipio = AccesoDatos.ObtenerCodigoPrograma(nombrePrograma, nombreMunicipio);
                txtCodigoMunicipio.Text = codigoMunicipio.ToString();

                //Actualizamos el dataSource del DataGridView de actividades asociadas al municipio
                dgvActividades.DataSource = null;
                int totalActividadesMunicipio = AccesoDatos.ObtenerCantidadActividadesPorMunicipio(codigoMunicipio);

                if (totalActividadesMunicipio == 0)
                    gbxActividades.Visible = false;
                else
                {
                    dgvActividades.DataSource = AccesoDatos.ObtenerTablaActividadesPorMunicipio(codigoMunicipio);
                    txtTotalActividades.Text = totalActividadesMunicipio.ToString();
                    gbxActividades.Visible = true;

        



                }*/
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string municipio = ListaMunicipios.SelectedItem.ToString();
            string programa = ListaProgramas.SelectedItem.ToString();

            string connectionString = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            string sql = "SELECT SUM(p.Valor) as 'Valor total', COUNT(DISTINCT s.Beneficiario) as 'Número de beneficiarios', s.Año, s.Mes " +
                         "FROM Subsidios s " +
                         "JOIN Beneficiarios b ON s.Beneficiario = b.ID_Beneficiario " +
                         "JOIN Programas p ON s.Programa = p.ID_Programa " +
                         "JOIN Municipios m ON b.Municipio = m.ID_Municipio " +
                         "WHERE m.Nombre_Municipio = @Municipio AND p.Nombre_Programa = @Programa " +
                         "GROUP BY s.Año, s.Mes;";

            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@Municipio", municipio);
            command.Parameters.AddWithValue("@Programa", programa);

            connection.Open();
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtValorTotal.Text = reader["Valor total"].ToString();
                txtNumBeneficiarios.Text = reader["Número de beneficiarios"].ToString();
                //txtAño.Text = reader["Año"].ToString();
                //txtMes.Text = reader["Mes"].ToString();
            }

            _ = connection;

            reader.Close();



        }

        private List<int> ObtenerAños(int idDepartamento)
        {
            List<int> años = new List<int>();

            string conn = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";
            using (SQLiteConnection conexion = new SQLiteConnection(conn))
            {
                conexion.Open();

                string consulta = @"SELECT DISTINCT Año
                            FROM Subsidios
                            WHERE Beneficiario IN (
                                SELECT ID_Beneficiario
                                FROM Beneficiarios
                                WHERE Municipio IN (
                                    SELECT ID_Municipio
                                    FROM Municipios
                                    WHERE Departamento = @idDepartamento
                                )
                            )";
                using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int anio = Convert.ToInt32(reader["Año"]);
                            años.Add(anio);
                        }
                    }
                }
            }

            return años;
        }

        private List<int> ObtenerMeses(int idDepartamento)
        {
            List<int> meses = new List<int>();

            string conn = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(conn);
            using (SQLiteConnection conexion = new SQLiteConnection(conn))
            {
                conexion.Open();

                string consulta = @"SELECT DISTINCT Año FROM Subsidios INNER JOIN Programas ON Subsidios.Programa = Programas.ID_Programa WHERE Programas.Nombre_Programa = @idDepartamento;)";
                using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mes = Convert.ToInt32(reader["Mes"]);
                            meses.Add(mes);
                        }
                    }
                }
            }

            return meses;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
