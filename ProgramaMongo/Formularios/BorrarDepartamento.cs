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
    public partial class BorrarDepartamento : Form
    {
        public BorrarDepartamento()
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

        private void ActualizarListaDepartamentos()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtenerListaNombresDepartamentos();

            ListaMunicipios.SelectedIndex = 0;
        }

        private void ListaMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaMunicipios.SelectedItem != null)
            {
                string[] datosMunicipio = ListaMunicipios.SelectedItem.ToString().Split('-');
                //textCodigo.Text = datosMunicipio[1].Trim();
                txtNombreMunicipio.Text = datosMunicipio[0].Trim();

                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.DepartamentosCollectionName;

                var filter = Builders<Departamento>.Filter.Eq("Nombre_Departamento", txtNombreMunicipio.Text);
                var municipio = miDB.GetCollection<Departamento>(coleccionMunicipios).Find(filter).FirstOrDefault();

                if (municipio != null)
                {
                    textBox1.Text = municipio.Id.ToString();
                }
            }
        }

        private void BorrarDepartamento_Load(object sender, EventArgs e)
        {
            ActualizarListaDepartamentos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.DepartamentosCollectionName;

            var coleccionBeneficiarios = configDB.MunicipiosCollectionName;
            var filtroBeneficiarios = Builders<Municipio>.Filter.Eq(b => b.Departamento, txtNombreMunicipio.Text);

            if (miDB.GetCollection<Municipio>(coleccionBeneficiarios).Find(filtroBeneficiarios).Any())
            {
                MessageBox.Show("No se puede eliminar el Departamento porque hay Municipios asociados a él.");
            }
            else
            {
                var filtro = Builders<Departamento>.Filter.Eq(m => m.Nombre_Departamento, txtNombreMunicipio.Text);

                var resultado = miDB.GetCollection<Departamento>(coleccionMunicipios).DeleteOne(filtro);

                if (resultado.DeletedCount == 1)
                {
                    MessageBox.Show("El Departamento fue eliminado correctamente.");
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
