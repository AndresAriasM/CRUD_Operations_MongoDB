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
    public partial class ReporteDepartamento : Form
    {
        public ReporteDepartamento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InicializaListaDepartamentos()
        {
            ListaDepartamentos.DataSource = null;
            ListaDepartamentos.DataSource = AccesoDatos.ObtieneNombresDepartamentos();
            ListaDepartamentos.DisplayMember = "Nombre_Departamento";

            //Seleccionamos el primer municipio de la lista
            ListaDepartamentos.SelectedIndex = 0;

        }

        private void ReporteDepartamento_Load(object sender, EventArgs e)
        {
            InicializaListaDepartamentos();
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

                string consulta = @"SELECT DISTINCT Mes
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
                            int mes = Convert.ToInt32(reader["Mes"]);
                            meses.Add(mes);
                        }
                    }
                }
            }

            return meses;
        }

        private void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el departamento seleccionado
            string departamentoSeleccionado = ListaDepartamentos.SelectedItem.ToString();

            // Obtener el ID del departamento seleccionado
            int idDepartamento = ObtenerIDDepartamento(departamentoSeleccionado);
            //int idDepartamento = ObtenerIDDepartamento(ListaDepartamentos.SelectedItem.ToString());

            string consulta = "SELECT SUM(p.Valor) " +
                      "FROM Subsidios s " +
                      "INNER JOIN Programas p ON s.Programa = p.ID_Programa " +
                      "INNER JOIN Beneficiarios b ON s.Beneficiario = b.ID_Beneficiario " +
                      "INNER JOIN Municipios m ON b.Municipio = m.ID_Municipio " +
                      "WHERE m.Departamento = @idDepartamento";

            double valorTotal = 0.0;

            // Obtener los años y meses asociados al departamento seleccionado
            List<int> anios = ObtenerAños(idDepartamento);
            List<int> meses = ObtenerMeses(idDepartamento);

            // Mostrar los años y meses en las listas correspondientes
            Año.Items.Clear();
            Mes.Items.Clear();
            foreach (int anio in anios)
            {
                Año.Items.Add(anio);
            }
            foreach (int mes in meses)
            {
                Mes.Items.Add(mes);
            }
            List<int> anos = new List<int>();
            List<int> mese = new List<int>();

            // Consultar la base de datos para obtener los municipios asociados al departamento seleccionado
            string connectionString = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";
            List<string> municipios = new List<string>();
            string consulta1 = "SELECT SUM(valor) FROM Beneficiarios WHERE programa=@programa";
            string query = "SELECT Nombre_Municipio FROM Municipios INNER JOIN Departamentos ON Municipios.Departamento = Departamentos.ID_Departamento WHERE Departamentos.Nombre_Departamento = @departamento";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();


                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@departamento", departamentoSeleccionado);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            municipios.Add(reader.GetString(0));
                        }
                    }
                }

                using (SQLiteCommand cmd = new SQLiteCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        valorTotal = Convert.ToDouble(resultado);
                    }
                }

                // Mostrar el valor total en el TextBox correspondiente
                txtValorTotal.Text = valorTotal.ToString();

                string sqlBeneficiarios = "SELECT b.Nombre_Beneficiario FROM Beneficiarios b " +
                                          "INNER JOIN Municipios m ON b.Municipio = m.ID_Municipio " +
                                          "INNER JOIN Departamentos d ON m.Departamento = d.ID_Departamento " +
                                          "WHERE d.Nombre_Departamento = @departamento;";
                SQLiteCommand cmdBeneficiarios = new SQLiteCommand(sqlBeneficiarios, conn);
                cmdBeneficiarios.Parameters.AddWithValue("@departamento", departamentoSeleccionado);
                SQLiteDataReader readerBeneficiarios = cmdBeneficiarios.ExecuteReader();
                ListaBeneficiarios.Items.Clear();
                while (readerBeneficiarios.Read())
                {
                    string nombreBeneficiario = readerBeneficiarios.GetString(0);
                    ListaBeneficiarios.Items.Add(nombreBeneficiario);
                }
                readerBeneficiarios.Close();



            }

            ListaMunicipios.Items.Clear();
            ListaMunicipios.Items.AddRange(municipios.ToArray());

        }

        private int ObtenerIDDepartamento(string nombreDepartamento)
        {
            int idDepartamento = 0;
            string conn = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";
            using (SQLiteConnection conexion = new SQLiteConnection(conn))
            {
                conexion.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT ID_Departamento FROM Departamentos WHERE Nombre_Departamento = @nombreDepartamento", conexion))
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
