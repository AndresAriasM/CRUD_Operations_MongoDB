using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using ProgramaMongo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramaMongo.Formularios
{
    public partial class ReportesPrograma : Form
    {
        public ReportesPrograma()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static ProgramaBeneficiariosDatabaseSettings configDB = ObtenerDBSettings();

        public static ProgramaBeneficiariosDatabaseSettings ObtenerDBSettings()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration miConfiguracion = builder.Build();

            ProgramaBeneficiariosDatabaseSettings miConfigDB = new ProgramaBeneficiariosDatabaseSettings()
            {
                ConnectionString = miConfiguracion["ProgramaBeneficiariosDatabase:ConnectionString"]!,
                DatabaseName = miConfiguracion["ProgramaBeneficiariosDatabase:DatabaseName"]!,
                DepartamentosCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:DepartamentosCollectionName"]!,
                MunicipiosCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:MunicipiosCollectionName"]!,
                ProgramasCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:ProgramasCollectionName"]!,
                BeneficiariosCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:BeneficiariosCollectionName"]!,
                SubsidiosCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:SubsidiosCollectionName"]!
            };

            return miConfigDB;
        }

        private void ActualizarListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtenerListaNombresProgramas1();

            ListaProgramas.SelectedIndex = 0;
        }

        private void ReportesPrograma_Load(object sender, EventArgs e)
        {
            ActualizarListaProgramas();
        }

        private void ListaProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var programa = miDB.GetCollection<Programa>("Programas");

            string programaSeleccionado = ListaProgramas.SelectedItem.ToString();
            /*int valorTotal = programa.Find(p => p.Nombre_Programa == programaSeleccionado).ToList().Sum(p => p.Valor);
            txtValor.Text = valorTotal.ToString();*/

            // Buscar subsidios asociados a los beneficiarios encontrados
            var subsidios1 = miDB.GetCollection<Subsidio>("Subsidios").Find(m => m.Programa == programaSeleccionado).ToList();

            // Buscar programas asociados a los subsidios encontrados y calcular el valor total
            var valorTotal = miDB.GetCollection<Programa>("Programas").Find(p => subsidios1.Select(s => s.Programa).Contains(p.Nombre_Programa)).ToList().Sum(p => p.Valor);

            // Mostrar el valor total en el TextBox correspondiente
            textBox1.Text = valorTotal.ToString();

            var subsidios = miDB.GetCollection<Subsidio>("Subsidios");

            var resultados = subsidios.Aggregate()
            .Lookup("Programas", "Programa", "Nombre_Programa", "Programa")
            .Unwind("Programa")
            .Match(Builders<BsonDocument>.Filter.Eq("Programa.Nombre_Programa", programaSeleccionado))
            .Group(new BsonDocument {
                { "_id", "null" },
                { "ValorTotal", new BsonDocument("$sum", "$Programa.Valor") }
                })
            .Project<BsonDocument>(Builders<BsonDocument>.Projection.Exclude("_id"))
            .FirstOrDefault();

            if (resultados != null)
            {
                txtValor.Text = resultados.GetValue("ValorTotal").ToString();
            }
            else
            {
                txtValor.Text = "0";
            }
            var subsidiosDelPrograma = subsidios.Find(s => s.Programa == programaSeleccionado).ToList();

            // Crear una lista para almacenar los departamentos donde está presente el programa
            List<string> departamentosDelPrograma = new List<string>();
            List<string> municipiosDelBeneficiario = new List<string>();

            // Recorrer los subsidios del programa y obtener el nombre del departamento de cada uno
            foreach (var subsidio in subsidiosDelPrograma)
            {
                // Obtener el nombre del beneficiario del subsidio
                string nombreBeneficiario = subsidio.Beneficiario;

                // Obtener el municipio del beneficiario
                var beneficiario = miDB.GetCollection<Beneficiario>("Beneficiarios").Find(b => b.Nombre_Beneficiario == nombreBeneficiario).FirstOrDefault();
                string nombreMunicipio = beneficiario.Municipio;
                municipiosDelBeneficiario .Add(nombreBeneficiario);

                // Obtener el departamento del municipio
                var municipio = miDB.GetCollection<Municipio>("Municipios").Find(m => m.Nombre_Municipio == nombreMunicipio).FirstOrDefault();
                string nombreDepartamento = municipio.Departamento;

                // Agregar el nombre del departamento a la lista de departamentos del programa
                departamentosDelPrograma.Add(nombreDepartamento);
            }

            var anos = new List<int>();
            foreach (var subsidio in subsidiosDelPrograma)
            {
                int ano = subsidio.Fecha.Year;
                if (!anos.Contains(ano))
                {
                    anos.Add(ano);
                }
            }

            // Obtener la lista de departamentos únicos y asignarla a la ListBox correspondiente
            listBox1.DataSource = departamentosDelPrograma.Distinct().ToList();
            listBox2.DataSource = municipiosDelBeneficiario.Distinct().ToList();
            listBox3.DataSource = anos.Distinct().ToList();

        }
    }
}
