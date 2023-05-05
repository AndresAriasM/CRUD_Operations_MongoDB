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
    public partial class BorrarSubsidio : Form
    {
        public BorrarSubsidio()
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
        private void ActualizarListaSubsidios()
        {
            ListaMunicipios.DataSource = null;
            ListaMunicipios.DataSource = AccesoDatos.ObtenerListaNombresSubsidios();
            ListaMunicipios.SelectedIndex = 0;
        }

        private void BorrarSubsidio_Load(object sender, EventArgs e)
        {
            ActualizarListaSubsidios();
        }

        private void ListaMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaMunicipios.SelectedItem != null)
            {
                string[] datosMunicipio = ListaMunicipios.SelectedItem.ToString().Split('~');
                textCodigo.Text = datosMunicipio[0].Trim();
                txtNombreMunicipio.Text = datosMunicipio[1].Trim();
                textBox1.Text = datosMunicipio[2].Trim();

                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.SubsidiosCollectionName;

                var filter = Builders<Subsidio>.Filter.Eq("ID_Subsidio", textBox1.Text);
                var municipio = miDB.GetCollection<Subsidio>(coleccionMunicipios).Find(filter).FirstOrDefault();

                if (municipio != null)
                {
                    textBox1.Text = municipio.ID_Subsidio.ToString();
                    textBox2.Text = municipio.Fecha.ToString();
                }
            }
        }

        private void txtNombreMunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.SubsidiosCollectionName;

            string[] datosMunicipio = ListaMunicipios.SelectedItem.ToString().Split('~');
            var txtBeneficiario = datosMunicipio[0].Trim();
            var txtPrograma = datosMunicipio[1].Trim();
            var txtFecha = datosMunicipio[2].Trim();

            var filtro = Builders<Subsidio>.Filter.Eq(m => m.ID_Subsidio, textBox1.Text);

            var resultado = miDB.GetCollection<Subsidio>(coleccionMunicipios).DeleteOne(filtro);

            if (resultado.DeletedCount == 1)
            {
                MessageBox.Show("El subsidio fue eliminado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró el registro.");
            }
        }
    }
}
