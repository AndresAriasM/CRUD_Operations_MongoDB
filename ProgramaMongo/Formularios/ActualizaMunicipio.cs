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
    public partial class ActualizaMunicipio : Form
    {
        public ActualizaMunicipio()
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
        private void ActualizarListaDepartamentos()
        {
            ListaDepartamentos.DataSource = null;
            ListaDepartamentos.DataSource = AccesoDatos.ObtenerListaNombresDepartamentos();

            ListaDepartamentos.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizaMunicipio_Load(object sender, EventArgs e)
        {
            ActualizarListaMunicipios();
            ActualizarListaDepartamentos();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var client = new MongoClient(configDB.ConnectionString);
            var database = client.GetDatabase(configDB.DatabaseName);
            var municipiosCollection = database.GetCollection<Municipio>(configDB.MunicipiosCollectionName);
            var beneficiariosCollection = database.GetCollection<Beneficiario>(configDB.BeneficiariosCollectionName);

            var filter = Builders<Municipio>.Filter.Eq(m => m.Id,txtCodigo.Text);
            
            var update = Builders<Municipio>.Update.Set(m => m.Nombre_Municipio, txtNombreMunicipio.Text)
                                                    .Set(m => m.Departamento, ListaDepartamentos.SelectedItem.ToString());
            
            //var result = await municipiosCollection.UpdateOneAsync(filter, update);
           
            string[] datosMunicipi = ListaMunicipios.SelectedItem.ToString().Split('-');
            var var1 = datosMunicipi[0].Trim();
            var filter1 = Builders<Beneficiario>.Filter.Eq(m => m.Municipio, var1);
            var update1 = Builders<Beneficiario>.Update.Set(m => m.Municipio, txtNombreMunicipio.Text);
            //var result1 = await beneficiariosCollection.UpdateOneAsync(filter1, update1);

            var filterExist = Builders<Municipio>.Filter.And(
            Builders<Municipio>.Filter.Eq(m => m.Nombre_Municipio, txtNombreMunicipio.Text),
            Builders<Municipio>.Filter.Eq(m => m.Departamento, ListaDepartamentos.SelectedItem.ToString()));

            var count = await municipiosCollection.CountDocumentsAsync(filterExist);

            if (count > 0)
            {
                MessageBox.Show("Ya existe un registro idéntico en la tabla Municipios.");
            }
            else
            {
                var result = await municipiosCollection.UpdateOneAsync(filter, update);

                if (result.ModifiedCount == 1)
                {
                    var result1 = await beneficiariosCollection.UpdateOneAsync(filter1, update1);
                    MessageBox.Show("Municipio actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el municipio.");
                }
            }

        }

        private void ListaMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaMunicipios.SelectedItem != null)
            {
                string[] datosMunicipio = ListaMunicipios.SelectedItem.ToString().Split('-');
                var txtCod = datosMunicipio[0].Trim();
                //txtNombreMunicipio.Text = datosMunicipio[0].Trim();

                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.MunicipiosCollectionName;

                var filter = Builders<Municipio>.Filter.Eq("Nombre_Municipio", txtCod);
                var municipio = miDB.GetCollection<Municipio>(coleccionMunicipios).Find(filter).FirstOrDefault();

                if (municipio != null)
                {
                    txtCodigo.Text = municipio.Id.ToString();
                }
            }
        }
    }
}


