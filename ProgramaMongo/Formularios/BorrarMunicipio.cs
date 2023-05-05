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
    public partial class BorrarMunicipio : Form
    {
        public BorrarMunicipio()
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActualizarListaMunicipios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtenerListaNombresMunicipios();

            ListaMunicipios.SelectedIndex = 0;
        }

        private void BorrarMunicipio_Load(object sender, EventArgs e)
        {
            ActualizarListaMunicipios();

        }

        private void ListaMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaMunicipios.SelectedItem != null)
            {
                string[] datosMunicipio = ListaMunicipios.SelectedItem.ToString().Split('-');
                textCodigo.Text = datosMunicipio[1].Trim();
                txtNombreMunicipio.Text = datosMunicipio[0].Trim();

                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.MunicipiosCollectionName;

                var filter = Builders<Municipio>.Filter.Eq("Nombre_Municipio", txtNombreMunicipio.Text);
                var municipio = miDB.GetCollection<Municipio>(coleccionMunicipios).Find(filter).FirstOrDefault();

                if (municipio != null)
                {
                    textBox1.Text = municipio.Id.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.MunicipiosCollectionName;

            var coleccionBeneficiarios = configDB.BeneficiariosCollectionName;
            var filtroBeneficiarios = Builders<Beneficiario>.Filter.Eq(b => b.Municipio, txtNombreMunicipio.Text);

            if (miDB.GetCollection<Beneficiario>(coleccionBeneficiarios).Find(filtroBeneficiarios).Any())
            {
                MessageBox.Show("No se puede eliminar el Municipio porque hay Beneficiarios asociados a él.");
            }
            else
            {
                var filtro = Builders<Municipio>.Filter.Eq(m => m.Nombre_Municipio, txtNombreMunicipio.Text);

                var resultado = miDB.GetCollection<Municipio>(coleccionMunicipios).DeleteOne(filtro);

                if (resultado.DeletedCount == 1)
                {
                    MessageBox.Show("El registro fue eliminado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró el registro.");
                }
            }
        }
    }
}
