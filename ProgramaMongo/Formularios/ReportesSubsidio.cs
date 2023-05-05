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
    public partial class ReportesSubsidio : Form
    {
        public ReportesSubsidio()
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

        private void ActualizarListaSubsidios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtenerListaNombresSubsidios();

            ListaBeneficiarios.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void ReportesSubsidio_Load(object sender, EventArgs e)
        {
            ActualizarListaSubsidios();
        }

        private void ListaBeneficiarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);

            //string[] datosMunicipio = ListaBeneficiarios.SelectedItem.ToString().Split('~');
            //var ID = datosMunicipio[2].Trim();

            string[] datosMunicipio = ListaBeneficiarios.SelectedItem.ToString().Split('~');
            var idSubsidio = datosMunicipio[2].Trim();
            string Prog = datosMunicipio[1].Trim();

            var subsidios = miDB.GetCollection<Subsidio>("Subsidios");
            Subsidio subsidio = subsidios.Find(s => s.ID_Subsidio == idSubsidio).FirstOrDefault();

            textBox3.Text = subsidio.Beneficiario;
            textBox2.Text = subsidio.Programa;
            textBox6.Text = subsidio.Fecha.ToShortDateString();
            textBox4.Text = idSubsidio;

            var programas = miDB.GetCollection<Programa>("Programas");
            Programa programaEncontrado = programas.Find(p => p.Nombre_Programa == Prog).FirstOrDefault();

            txtValor.Text = programaEncontrado.Valor.ToString();

            Subsidio subsidioEncontrado = subsidios.Find(s => s.ID_Subsidio == idSubsidio).FirstOrDefault();

            string nombreBeneficiario = subsidioEncontrado.Beneficiario;

            var beneficiarios = miDB.GetCollection<Beneficiario>("Beneficiarios");
            Beneficiario beneficiarioEncontrado = beneficiarios.Find(b => b.Nombre_Beneficiario == nombreBeneficiario).FirstOrDefault();

            string nombreMunicipio = beneficiarioEncontrado.Municipio;

            var municipios = miDB.GetCollection<Municipio>("Municipios");
            Municipio municipioEncontrado = municipios.Find(m => m.Nombre_Municipio == nombreMunicipio).FirstOrDefault()    ;

            string nombreDepartamento = municipioEncontrado.Departamento;

            textBox5.Text = nombreMunicipio;
            textBox1.Text = nombreDepartamento;

        }
    }
}
