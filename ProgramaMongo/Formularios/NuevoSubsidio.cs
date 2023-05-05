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

namespace ProgramaMongo.Formularios
{
    public partial class NuevoSubsidio : Form
    {
        public NuevoSubsidio()
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

        /*private void ActualizarListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtenerListaNombreProgramas1();

            ListaProgramas.SelectedIndex = 0;
        }*/

        private void ActualizarListaBeneficiarios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtenerListaNombreBeneficiarios1();

            ListaBeneficiarios.SelectedIndex = 0;
        }

        private void NuevoSubsidio_Load(object sender, EventArgs e)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionSubsidios = configDB.SubsidiosCollectionName;

            var listaSubsidios = miDB.GetCollection<Subsidio>(coleccionSubsidios)
                .Find(new BsonDocument())
                .ToList();
       
            foreach (Subsidio unSubsidio in listaSubsidios)
            {
                string item = $"{unSubsidio.Beneficiario} - {unSubsidio.Programa} - {unSubsidio.Fecha.ToShortDateString()}";
                ListaSubsidios.Items.Add(item);
            }

            var coleccionProgramas = configDB.ProgramasCollectionName;
            var listaProgramas = miDB.GetCollection<Programa>(coleccionProgramas)
                .Find(new BsonDocument())
                .ToList();

            foreach (Programa unPrograma in listaProgramas)
            {
                ListaProgramas.Items.Add(unPrograma.Nombre_Programa);
            }

            var coleccionBeneficiarios = configDB.BeneficiariosCollectionName;
            var listaBeneficiarios = miDB.GetCollection<Beneficiario>(coleccionBeneficiarios)
                .Find(new BsonDocument())
                .ToList();

            foreach (Beneficiario unBeneficiario in listaBeneficiarios)
            {
                ListaBeneficiarios.Items.Add(unBeneficiario.Nombre_Beneficiario);
            }
        }
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id = GenerateRandomString(25);
            string nombrePrograma = ListaProgramas.SelectedItem.ToString();
            string nombreBeneficiario = ListaBeneficiarios.SelectedItem.ToString();
            DateTime fecha = dateTimePicker1.Value;

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var subsidios = miDB.GetCollection<Subsidio>("Subsidios");

            // Verificar si ya existe un subsidio para el beneficiario seleccionado en la fecha indicada
            var subsidioExistente = subsidios.Find(s => s.Beneficiario == nombreBeneficiario && s.Fecha.Year == fecha.Year && s.Fecha.Month == fecha.Month).FirstOrDefault();

            if (subsidioExistente != null)
            {
                // Mostrar mensaje de error y salir del método
                MessageBox.Show("Ya existe un subsidio para este beneficiario en el mes seleccionado.");
                MessageBox.Show("RECUERDE QUE UN BENEFICIARIO NO PUEDE TENER MAS DE UN SUBSIDIO POR MES");
                return;
            }

            Subsidio nuevoSubsidio = new Subsidio
            {
                Beneficiario = nombreBeneficiario,
                Programa = nombrePrograma,
                Fecha = fecha,
                ID_Subsidio = id,
            };

            var coleccionSubsidios = configDB.SubsidiosCollectionName;
            miDB.GetCollection<Subsidio>(coleccionSubsidios).InsertOne(nuevoSubsidio);

            MessageBox.Show("Subsidio guardado correctamente en la base de datos.");
            this.Close();


        }
    }
}
