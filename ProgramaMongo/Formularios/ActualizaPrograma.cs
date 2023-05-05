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
    public partial class ActualizaPrograma : Form
    {
        public ActualizaPrograma()
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
        private void ActualizarListaProgramas()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtenerListaNombresProgramas();

            ListaMunicipios.SelectedIndex = 0;
        }

        private void ActualizaPrograma_Load(object sender, EventArgs e)
        {
            ActualizarListaProgramas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

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
                var coleccionMunicipios = configDB.ProgramasCollectionName;

                var filter = Builders<Programa>.Filter.Eq("Nombre_Programa", txtCod);
                var municipio = miDB.GetCollection<Programa>(coleccionMunicipios).Find(filter).FirstOrDefault();

                if (municipio != null)
                {
                    txtCodigo.Text = municipio.Id.ToString();
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string[] datosMunicipi = ListaMunicipios.SelectedItem.ToString().Split('-');
            var var1 = datosMunicipi[0].Trim();

            var client = new MongoClient(configDB.ConnectionString);
            var database = client.GetDatabase(configDB.DatabaseName);
            var programasCollection = database.GetCollection<Programa>(configDB.ProgramasCollectionName);
            var subsidiosCollection = database.GetCollection<Subsidio>(configDB.SubsidiosCollectionName);

            var filter = Builders<Programa>.Filter.Eq(m => m.Id, txtCodigo.Text);

            var update = Builders<Programa>.Update.Set(m => m.Nombre_Programa, txtNombrePrograma.Text)
                                                  .Set(m => m.Valor, Int32.Parse(txtValor.Text));

            // Actualizar el atributo "Programa" en la colección "Subsidios"
            var filter1 = Builders<Subsidio>.Filter.Eq(m => m.Programa, datosMunicipi[0].Trim());
            var update1 = Builders<Subsidio>.Update.Set(m => m.Programa, txtNombrePrograma.Text);

            var filterExist = Builders<Programa>.Filter.And(Builders<Programa>.Filter.Eq(m => m.Nombre_Programa, txtNombrePrograma.Text));

            var count = await programasCollection.CountDocumentsAsync(filterExist);

            if (count > 0)
            {
                MessageBox.Show("Ya existe un programa idéntico en los registros.");
            }
            else
            {
                var result = await programasCollection.UpdateOneAsync(filter, update);

                if (result.ModifiedCount == 1)
                {
                    // Actualizar el atributo "Programa" en la colección "Subsidios"
                    var result1 = await subsidiosCollection.UpdateManyAsync(filter1, update1);
                    MessageBox.Show("Programa actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el programa.");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
