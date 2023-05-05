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
    public partial class BorrarBeneficiario : Form
    {
        public BorrarBeneficiario()
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

        private void BorrarBeneficiario_Load(object sender, EventArgs e)
        {
            ActualizarListaBeneficiarios();
        }

        private void ListaMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaMunicipios.SelectedItem != null)
            {
                string[] datosMunicipio = ListaMunicipios.SelectedItem.ToString().Split('-');
                txtNombreMunicipio.Text = datosMunicipio[0].Trim();
                textCodigo.Text = datosMunicipio[1].Trim();

                var clienteDB = new MongoClient(configDB.ConnectionString);
                var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
                var coleccionMunicipios = configDB.BeneficiariosCollectionName;

                var filter = Builders<Beneficiario>.Filter.Eq("Nombre_Beneficiario", txtNombreMunicipio.Text);
                var municipio = miDB.GetCollection<Beneficiario>(coleccionMunicipios).Find(filter).FirstOrDefault();

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
            var coleccionProgramas = configDB.BeneficiariosCollectionName;

            var subsidiosConPrograma = miDB.GetCollection<Subsidio>(configDB.SubsidiosCollectionName)
                                            .Find(s => s.Beneficiario == txtNombreMunicipio.Text).Any();

            if (subsidiosConPrograma)
            {
                MessageBox.Show("No se puede eliminar el beneficiario porque tiene subsidios asociados.");
            }
            else
            {
                var filtro = Builders<Beneficiario>.Filter.Eq(m => m.Nombre_Beneficiario, txtNombreMunicipio.Text);
                var resultado = miDB.GetCollection<Beneficiario>(coleccionProgramas).DeleteOne(filtro);

                if (resultado.DeletedCount == 1)
                {
                    MessageBox.Show("El beneficiario fue eliminado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró el registro.");
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
