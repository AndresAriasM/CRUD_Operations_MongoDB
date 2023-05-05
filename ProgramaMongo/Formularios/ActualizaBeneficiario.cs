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
    public partial class ActualizaBeneficiario : Form
    {
        public ActualizaBeneficiario()
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
        private void ActualizarListaBeneficiarios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtenerListaNombresBeneficiarios();

            ListaMunicipios.SelectedIndex = 0;
        }
        private void ActualizarListaMunicipios()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = AccesoDatos.ObtenerListaNombresMunicipios();

            listBox1.SelectedIndex = 0;
        }
        private void ActualizaBeneficiario_Load(object sender, EventArgs e)
        {
            ActualizarListaBeneficiarios();
            ActualizarListaMunicipios();
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
                var coleccionMunicipios = configDB.BeneficiariosCollectionName;

                var filter = Builders<Beneficiario>.Filter.Eq("Nombre_Beneficiario", txtCod);
                var municipio = miDB.GetCollection<Beneficiario>(coleccionMunicipios).Find(filter).FirstOrDefault();

                if (municipio != null)
                {
                    txtCodigo.Text = municipio.Id.ToString();
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var client = new MongoClient(configDB.ConnectionString);
            var database = client.GetDatabase(configDB.DatabaseName);
            var beneficiariosCollection = database.GetCollection<Beneficiario>(configDB.BeneficiariosCollectionName);
            var subsidiosCollection = database.GetCollection<Subsidio>(configDB.SubsidiosCollectionName);

            string[] datosM = listBox1.SelectedItem.ToString().Split('-');
            var var2 = datosM[0].Trim();

            string[] datosN = ListaMunicipios.SelectedItem.ToString().Split('-');
            var var1 = datosN[0].Trim();
            //var var2 = ListaMunicipios.SelectedIndex.ToString();
            var filter = Builders<Beneficiario>.Filter.Eq(m => m.Id, txtCodigo.Text);

            var update = Builders<Beneficiario>.Update.Set(m => m.Nombre_Beneficiario, txtNombreBeneficiario.Text)
                                                    .Set(m => m.Municipio, var2);

            // Actualiza el campo "Beneficiario" en la tabla "Subsidios"
            var filter1 = Builders<Subsidio>.Filter.Eq(m => m.Beneficiario, var1);
            var update1 = Builders<Subsidio>.Update.Set(m => m.Beneficiario, txtNombreBeneficiario.Text);

            var filterExist = Builders<Beneficiario>.Filter.And(
                Builders<Beneficiario>.Filter.Eq(m => m.Nombre_Beneficiario, txtNombreBeneficiario.Text),
                Builders<Beneficiario>.Filter.Eq(m => m.Municipio, listBox1.SelectedItem.ToString()));

            var count = await beneficiariosCollection.CountDocumentsAsync(filterExist);

            if (count > 0)
            {
                MessageBox.Show("Ya existe un beneficiario con este nombre y registrado en ese departamento.");
            }
            else
            {
                var result = await beneficiariosCollection.UpdateOneAsync(filter, update);

                if (result.ModifiedCount == 1)
                {
                    var result1 = await subsidiosCollection.UpdateManyAsync(filter1, update1);
                    MessageBox.Show("Beneficiario actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el beneficiario.");
                }
            }
        }
    }
}
