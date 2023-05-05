using Dapper;
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
    public partial class ReportePrograma : Form
    {
        public ReportePrograma()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void InicializaListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtieneNombresProgramas();
            ListaProgramas.DisplayMember = "Nombre_Programas";

            //Seleccionamos el primer municipio de la lista
            ListaProgramas.SelectedIndex = 0;

        }

        private void ReportePrograma_Load(object sender, EventArgs e)
        {
            InicializaListaProgramas();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*// Conectarse a la base de datos SQLite
            string connectionString = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            // Crear un objeto SQLiteCommand con la consulta SQL
            string programaSeleccionado = ListaProgramas.SelectedItem.ToString();
            string consulta = "SELECT Mes, Año, Departamento, COUNT(Beneficiario) as Cantidad, SUM(Valor) as ValorTotal " +
                              "FROM Subsidios " +
                              "INNER JOIN Beneficiarios ON Subsidios.Beneficiario = Beneficiarios.ID_Beneficiario " +
                              "INNER JOIN Municipios ON Beneficiarios.Municipio = Municipios.ID_Municipio " +
                              "INNER JOIN Departamentos ON Municipios.Departamento = Departamentos.ID_Departamento " +
                              "INNER JOIN Programas ON Subsidios.Programa = Programas.ID_Programa " +
                              "WHERE Programas.Nombre_Programa = ? " +
                              "GROUP BY Mes, Año, Departamento";
            SQLiteCommand command = new SQLiteCommand(consulta, connection);
            command.Parameters.AddWithValue("Nombre_Programa", programaSeleccionado);

            // Ejecutar la consulta y leer los resultados
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Asignar los valores a los textBox correspondientes
                txtMes.Text = reader["Mes"].ToString();
                txtAño.Text = reader["Año"].ToString();
                textBox2.Text = reader["Departamento"].ToString();
                textBox1.Text = reader["Cantidad"].ToString();
                txtValorTotal.Text = reader["ValorTotal"].ToString();
            }

            // Cerrar la conexión
            connection.Close();*/
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private int ObtenerIDPrograma(string nombreDepartamento)
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


        private void ListaProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID del programa seleccionado
            string departamentoSeleccionado = ListaProgramas.SelectedItem.ToString();
            int idPrograma = ObtenerIDPrograma(departamentoSeleccionado);

            string query = "SELECT DISTINCT Departamentos.Nombre_Departamento " +
                           "FROM Departamentos " +
                           "INNER JOIN Municipios ON Departamentos.ID_Departamento = Municipios.Departamento " +
                           "INNER JOIN Beneficiarios ON Municipios.ID_Municipio = Beneficiarios.Municipio " +
                           "INNER JOIN Subsidios ON Beneficiarios.ID_Beneficiario = Subsidios.Beneficiario " +
                           "INNER JOIN Programas ON Subsidios.Programa = Programas.ID_Programa " +
                           "WHERE Programas.ID_Programa = @idPrograma";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=.\\Beneficiarios_DB.sqlite;Version=3;"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@idPrograma", idPrograma);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    ListaDepartamentos.Items.Clear();
                    while (reader.Read())
                    {
                        ListaDepartamentos.Items.Add(reader.GetString(0));
                    }
                }
            }

            string programaSeleccionado = ListaProgramas.SelectedItem.ToString();

            string consulta = "SELECT DISTINCT Año FROM Subsidios INNER JOIN Programas ON Subsidios.Programa = Programas.ID_Programa WHERE Programas.Nombre_Programa = @programa";         
            string connectio = "Data Source=.\\Beneficiarios_DB.sqlite;Version=3;";
            SQLiteConnection conexion = new SQLiteConnection(connectio);
            using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@programa", programaSeleccionado);


                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando))
                {
                    DataSet datos = new DataSet();

                    adaptador.Fill(datos);

                    Año.Items.Clear();

                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        Año.Items.Add(fila["Año"].ToString());
                    }
                }
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=.\\Beneficiarios_DB.sqlite;Version=3;"))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand($"SELECT DISTINCT Mes FROM Subsidios JOIN Programas ON Subsidios.Programa = Programas.ID_Programa WHERE Programas.Nombre_Programa = '{programaSeleccionado}'", conn))
                    {
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            Mes.Items.Clear();
                            while (dr.Read())
                            {
                                Mes.Items.Add(dr["Mes"]);
                            }
                        }

                    }


                }

                List<string> beneficiarios = new List<string>();
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=.\\Beneficiarios_DB.sqlite;Version=3;"))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT Nombre_Beneficiario FROM Beneficiarios " +
                        "WHERE ID_Beneficiario IN (SELECT Beneficiario FROM Subsidios " +
                        "WHERE Programa = (SELECT ID_Programa FROM Programas WHERE Nombre_Programa = @programa))", conn))
                    {
                        cmd.Parameters.AddWithValue("@programa", programaSeleccionado);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                beneficiarios.Add(reader.GetString(0));
                            }
                        }
                    }
                }

                ListaBeneficiarios.Items.Clear();
                foreach (string beneficiario in beneficiarios)
                {
                    ListaBeneficiarios.Items.Add(beneficiario);
                }

            }

            

        }
   
        
    }
}
