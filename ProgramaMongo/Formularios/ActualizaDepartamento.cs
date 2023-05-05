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
    public partial class ActualizaDepartamento : Form
    {
        public ActualizaDepartamento()
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

        private void ListaDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ActualizarListaDepartamentos()
        {
            ListaDepartamentos.DataSource = null;
            ListaDepartamentos.DataSource = AccesoDatos.ObtenerListaNombresDepartamentos();

            ListaDepartamentos.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizaDepartamento_Load(object sender, EventArgs e)
        {
            ActualizarListaDepartamentos();
        }

        private void ListaDepartamentos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ListaDepartamentos.SelectedItem != null)
            {
                //string[] datosMunicipio = ListaDepartamentos.SelectedItem.ToString().Split('-');
                var txtCod = ListaDepartamentos.SelectedItem;
                //txtNombreMunicipio.Text = datosMunicipio[0].Trim();

                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.DepartamentosCollectionName;

                var filter = Builders<Departamento>.Filter.Eq("Nombre_Departamento", txtCod);
                var municipio = miDB.GetCollection<Departamento>(coleccionMunicipios).Find(filter).FirstOrDefault();

                if (municipio != null)
                {
                    txtCodigo.Text = municipio.Id.ToString();
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string nuevoNombreDepartamento = txtNombreMunicipio.Text;
            string idDepartamento = txtCodigo.Text;

            // Actualizar el nombre del departamento en la tabla Departamento
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.DepartamentosCollectionName;
            var filtro = Builders<Departamento>.Filter.Eq(d => d.Id, idDepartamento);
            var actualizacion = Builders<Departamento>.Update.Set(d => d.Nombre_Departamento, nuevoNombreDepartamento);
            var resultado = miDB.GetCollection<Departamento>(coleccionDepartamentos).UpdateOne(filtro, actualizacion);

            if (resultado.ModifiedCount == 1)
            {
                // Actualizar el nombre del departamento en la tabla Municipios
                var coleccionMunicipios = configDB.MunicipiosCollectionName;
                var filtroMunicipios = Builders<Municipio>.Filter.Eq(m => m.Departamento, ListaDepartamentos.SelectedItem);
                var actualizacionMunicipios = Builders<Municipio>.Update.Set(m => m.Departamento, nuevoNombreDepartamento);
                var resultadoMunicipios = miDB.GetCollection<Municipio>(coleccionMunicipios).UpdateMany(filtroMunicipios, actualizacionMunicipios);

                if (resultadoMunicipios.ModifiedCount > 0)
                {
                    MessageBox.Show("Departamento y municipios actualizados correctamente.");
                }
                else
                {
                    MessageBox.Show("Departamento actualizado correctamente, pero no se encontraron municipios para actualizar.");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el departamento a actualizar.");
            }
        }
    }
}
