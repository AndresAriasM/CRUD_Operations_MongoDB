using Microsoft.Extensions.Configuration;
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

namespace ProgramaMongo.Formularios
{
    public partial class ReportesMunicipio : Form
    {
        public ReportesMunicipio()
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

        private void ActualizarListaMunicipios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtenerListaNombresMunicipios();

            ListaMunicipios.SelectedIndex = 0;
        }

        private void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var departamentoSeleccionado = ListaMunicipios.SelectedItem.ToString().Split('-'); ;
            var MunSel = departamentoSeleccionado[0].Trim();

            // Buscar municipios asociados al departamento seleccionado
            //var municipios3 = miDB.GetCollection<Municipio>("Municipios").Find(m => m.Departamento == departamentoSeleccionado).ToList();

            // Buscar beneficiarios asociados a los municipios encontrados
            var beneficiarios2 = miDB.GetCollection<Beneficiario>("Beneficiarios").Find(b => b.Municipio == MunSel).ToList();

            // Buscar subsidios asociados a los beneficiarios encontrados
            var subsidios1 = miDB.GetCollection<Subsidio>("Subsidios").Find(s => beneficiarios2.Select(b => b.Nombre_Beneficiario).Contains(s.Beneficiario)).ToList();

            // Buscar programas asociados a los subsidios encontrados y calcular el valor total
            var valorTotal = miDB.GetCollection<Programa>("Programas").Find(p => subsidios1.Select(s => s.Programa).Contains(p.Nombre_Programa)).ToList().Sum(p => p.Valor);

            // Mostrar el valor total en el TextBox correspondiente
            txtValor.Text = valorTotal.ToString();

            var anos = new List<int>();
            foreach (var subsidio in subsidios1)
            {
                int ano = subsidio.Fecha.Year;
                if (!anos.Contains(ano))
                {
                    anos.Add(ano);
                }
            }

            // Mostrar la lista de años en el ListBox de años
            listBox3.DataSource = anos;


            var coleccionMunicipios = configDB.BeneficiariosCollectionName;

            var filtro = Builders<Beneficiario>.Filter.Eq(mun => mun.Municipio, MunSel);
            var municipios = miDB.GetCollection<Beneficiario>(coleccionMunicipios).Find(filtro).ToList();

            listBox2.Items.Clear();
            foreach (var municipio in municipios)
            {
                listBox2.Items.Add(municipio.Nombre_Beneficiario);
            }

            var programas = miDB.GetCollection<Programa>("Programas").Find(p => subsidios1.Select(s => s.Programa).Contains(p.Nombre_Programa)).ToList();
            listBox1.Items.Clear();
            foreach (var programa in programas)
            {
                listBox1.Items.Add(programa.Nombre_Programa);
            }
        }

        private void ReportesMunicipio_Load(object sender, EventArgs e)
        {
            ActualizarListaMunicipios();
        }
    }
}
