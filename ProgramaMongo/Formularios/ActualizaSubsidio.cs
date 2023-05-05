using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using ProgramaMongo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaMongo.Formularios
{
    public partial class ActualizaSubsidio : Form
    {
        public ActualizaSubsidio()
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

        private void ActualizarListaSubsidio()
        {
            ListaSubsidio.DataSource = null;
            ListaSubsidio.DataSource = AccesoDatos.ObtenerListaNombresSubsidios();

            ListaSubsidio.SelectedIndex = 0;
        }
        private void ActualizarListaBeneficiarios()
        {
            ListaBeneficiario.DataSource = null;
            ListaBeneficiario.DataSource = AccesoDatos.ObtenerListaNombresBeneficiarios();

            ListaBeneficiario.SelectedIndex = 0;
        }
        private void ActualizarListaPrograma()
        {
            ListaPrograma.DataSource = null;
            ListaPrograma.DataSource = AccesoDatos.ObtenerListaNombresProgramas1();

            ListaPrograma.SelectedIndex = 0;
        }

        private void ActualizaSubsidio_Load(object sender, EventArgs e)
        {
            ActualizarListaBeneficiarios();
            ActualizarListaPrograma();
            ActualizarListaSubsidio();
        }

        private void ListaSubsidio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaSubsidio.SelectedItem != null)
            {
                string[] datosMunicipio = ListaSubsidio.SelectedItem.ToString().Split('~');
                var txtBeneficiario = datosMunicipio[0].Trim();
                var txtPrograma = datosMunicipio[1].Trim();
                var txtFecha = datosMunicipio[2];
                //txtNombreMunicipio.Text = datosMunicipio[0].Trim();

                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.SubsidiosCollectionName;

                txtCodigo.Text = txtFecha;
                /*var filter = Builders<Subsidio>.Filter.And(
                Builders<Subsidio>.Filter.Eq(m => m.Beneficiario, txtBeneficiario),
                Builders<Subsidio>.Filter.Eq(m => m.Programa, txtPrograma),
                Builders<Subsidio>.Filter.Eq(m => m.Id, txtFecha));*/

                /*var filter = Builders<Subsidio>.Filter.Eq(m => m.Id, txtFecha);
   
                var municipio = miDB.GetCollection<Subsidio>(coleccionMunicipios).Find(filter).FirstOrDefault();

                if (municipio != null)
                {
                    txtCodigo.Text = municipio.Id.ToString();
                }*/
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string[] datosMunicipi = ListaSubsidio.SelectedItem.ToString().Split('~');
            string[] datosMunicipio = ListaBeneficiario.SelectedItem.ToString().Split('-');
            var var1 = datosMunicipi[2].Trim();
            var var2 = datosMunicipio[0].Trim();
            var client = new MongoClient(configDB.ConnectionString);
            var database = client.GetDatabase(configDB.DatabaseName);
            var subsidiosCollection = database.GetCollection<Subsidio>(configDB.SubsidiosCollectionName);
            var filter = Builders<Subsidio>.Filter.Eq(m => m.ID_Subsidio, var1);
            var update = Builders<Subsidio>.Update.Set(m => m.Beneficiario, var2)
                                                  .Set(m => m.Programa, ListaPrograma.SelectedItem.ToString())
                                                  .Set(m => m.Fecha, dateTimePicker1.Value);

            var result = await subsidiosCollection.UpdateOneAsync(filter, update);

            if (result.ModifiedCount == 1)
            {
                MessageBox.Show("Subsidio actualizado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el subsidio.");
            }
        }
    }
}
