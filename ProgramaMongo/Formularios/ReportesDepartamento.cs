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
    public partial class ReportesDepartamento : Form
    {
        public ReportesDepartamento()
        {
            InitializeComponent();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarListaDepartamentos()
        {
            ListaDepartamentos.DataSource = null;
            ListaDepartamentos.DataSource = AccesoDatos.ObtenerListaNombresDepartamentos();

            ListaDepartamentos.SelectedIndex = 0;
        }

        private void ReportesDepartamento_Load(object sender, EventArgs e)
        {
            ActualizarListaDepartamentos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDepartamento = ListaDepartamentos.SelectedItem.ToString();

            // Consultar la base de datos para obtener los municipios asociados a ese departamento
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.MunicipiosCollectionName;

            var filtro = Builders<Municipio>.Filter.Eq(mun => mun.Departamento, nombreDepartamento);
            var municipios = miDB.GetCollection<Municipio>(coleccionMunicipios).Find(filtro).ToList();

            listBox1.Items.Clear();
            foreach (var municipio in municipios)
            {
                listBox1.Items.Add(municipio.Nombre_Municipio);
            }

            string nombDepartamento = ListaDepartamentos.SelectedItem.ToString();

            // Obtener los municipios asociados al departamento seleccionado
            var coleccionMunicipio = miDB.GetCollection<Municipio>("Municipios");
            var municipi = coleccionMunicipio.Find(m => m.Departamento == nombDepartamento).ToList();

            // Verificar si se encontraron municipios y obtener beneficiarios asociados
            if (municipi.Any())
            {
                var coleccionBeneficiarios = miDB.GetCollection<Beneficiario>("Beneficiarios");
                var beneficiarios = coleccionBeneficiarios.Find(b => municipi.Any(m => m.Nombre_Municipio == b.Municipio)).ToList();

                // Mostrar los beneficiarios en el ListBox2
                listBox2.Items.Clear();
                foreach (var beneficiario in beneficiarios)
                {
                    listBox2.Items.Add(beneficiario.Nombre_Beneficiario);
                }
            }
            else
            {
                // No se encontraron municipios asociados al departamento seleccionado
                listBox2.Items.Clear();
                listBox2.Items.Add("No se encontraron beneficiarios asociados");
            }

            string departamento = ListaDepartamentos.SelectedItem.ToString();

            // Obtener los municipios que pertenecen al departamento
            var municipiosCollection = miDB.GetCollection<Municipio>("Municipios");
            var municipios1 = await municipiosCollection.Find(m => m.Departamento == departamento).ToListAsync();

            // Obtener los beneficiarios que pertenecen a los municipios
            var beneficiariosCollection = miDB.GetCollection<Beneficiario>("Beneficiarios");
            var beneficiarios1 = await beneficiariosCollection.Find(b => municipios1.Any(m => m.Nombre_Municipio == b.Municipio)).ToListAsync();

            // Obtener los subsidios que pertenecen a los beneficiarios
            var subsidiosCollection = miDB.GetCollection<Subsidio>("Subsidios");
            var subsidios = await subsidiosCollection.Find(s => beneficiarios1.Any(b => b.Nombre_Beneficiario == s.Beneficiario)).ToListAsync();

            // Filtrar los subsidios por año y agregarlos a una lista de años
            var anos = new List<int>();
            foreach (var subsidio in subsidios)
            {
                int ano = subsidio.Fecha.Year;
                if (!anos.Contains(ano))
                {
                    anos.Add(ano);
                }
            }

            // Mostrar la lista de años en el ListBox de años
            listBox3.DataSource = anos;



            var departamentoSeleccionado = ListaDepartamentos.SelectedItem.ToString();

            // Buscar municipios asociados al departamento seleccionado
            var municipios3 = miDB.GetCollection<Municipio>("Municipios").Find(m => m.Departamento == departamentoSeleccionado).ToList();

            // Buscar beneficiarios asociados a los municipios encontrados
            var beneficiarios2 = miDB.GetCollection<Beneficiario>("Beneficiarios").Find(b => municipios3.Select(m => m.Nombre_Municipio).Contains(b.Municipio)).ToList();

            // Buscar subsidios asociados a los beneficiarios encontrados
            var subsidios1 = miDB.GetCollection<Subsidio>("Subsidios").Find(s => beneficiarios2.Select(b => b.Nombre_Beneficiario).Contains(s.Beneficiario)).ToList();

            // Buscar programas asociados a los subsidios encontrados y calcular el valor total
            var valorTotal = miDB.GetCollection<Programa>("Programas").Find(p => subsidios1.Select(s => s.Programa).Contains(p.Nombre_Programa)).ToList().Sum(p => p.Valor);

            // Mostrar el valor total en el TextBox correspondiente
            txtValor.Text = valorTotal.ToString();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
