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
    public partial class NuevoPrograma : Form
    {
        public NuevoPrograma()
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


        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            string nombrePrograma = txtNombrePrograma.Text;

           
            Programa nuevoPrograma = new Programa { Valor = valor, Nombre_Programa = nombrePrograma };      
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionProgramas = configDB.ProgramasCollectionName;

            miDB.GetCollection<Programa>(coleccionProgramas).InsertOne(nuevoPrograma);

            MessageBox.Show("Programa guardado correctamente en la base de datos.");
            this.Close();
        }

        private void ActualizarListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtenerListaNombresProgramas();

            ListaProgramas.SelectedIndex = 0;
        }

        private void NuevoPrograma_Load(object sender, EventArgs e)
        {
            ActualizarListaProgramas();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
