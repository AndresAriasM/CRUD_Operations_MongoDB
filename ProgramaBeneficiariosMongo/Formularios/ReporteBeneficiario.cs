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
    public partial class ReporteBeneficiario : Form
    {
        public ReporteBeneficiario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados por el usuario en los ListBox
            string beneficiario = ListaBeneficiarios.SelectedItem.ToString();
            string programa = ListaProgramas.SelectedItem.ToString();

            // Crear la consulta SQL con los valores seleccionados
            string query = $"SELECT SUM(Valor), COUNT(*), Año, Mes FROM Subsidios JOIN Beneficiarios ON Subsidios.Beneficiario = Beneficiarios.ID_Beneficiario JOIN Programas ON Subsidios.Programa = Programas.ID_Programa WHERE Beneficiarios.Nombre_Beneficiario = '{beneficiario}' AND Programas.Nombre_Programa = '{programa}' GROUP BY Año, Mes";

            // Ejecutar la consulta SQL y obtener los resultados
            using (SQLiteConnection conexion = new SQLiteConnection("Data Source=.\\Beneficiarios_DB.sqlite;Version=3;"))
            {
                conexion.Open();

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        // Verificar si hay resultados y asignarlos a los TextBox correspondientes
                        if (reader.HasRows)
                        {
                            reader.Read();
                            txtValorTotal.Text = reader.GetDouble(0).ToString();
                            //txtNumeroTotal.Text = reader.GetInt32(1).ToString();
                            txtAño.Text = reader.GetInt32(2).ToString();
                            txtMes.Text = reader.GetInt32(3).ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron resultados para los valores seleccionados.");
                        }
                    }
                }
            }
        }

        private void ReporteBeneficiario_Load(object sender, EventArgs e)
        {
            InicializaListaBeneficiarios();
            InicializaListaProgramas();
        }

        public void InicializaListaBeneficiarios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtieneNombresBeneficiarios();
            ListaBeneficiarios.DisplayMember = "Nombre_Programa";

            //Seleccionamos el primer municipio de la lista
            ListaBeneficiarios.SelectedIndex = 0;

        }

        public void InicializaListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtieneNombresProgramas();
            ListaProgramas.DisplayMember = "Nombre_Programas";

            //Seleccionamos el primer municipio de la lista
            ListaProgramas.SelectedIndex = 0;

        }

        private void ListaBeneficiarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
