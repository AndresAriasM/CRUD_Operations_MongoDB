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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramaMongo.Formularios
{
    public partial class ReportesBeneficiario : Form
    {
        public ReportesBeneficiario()
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

        private void ActualizarListaBeneficiarios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtenerListaNombreBeneficiarios1();

            ListaBeneficiarios.SelectedIndex = 0;
        }

        private void ListaProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            //var subsidios = miDB.GetCollection<Subsidio>("Subsidios");

            string nombreBeneficiario = ListaBeneficiarios.SelectedItem.ToString();

            var subsidios = miDB.GetCollection<Subsidio>("Subsidios").AsQueryable()
                             .Where(s => s.Beneficiario == nombreBeneficiario).ToList();

            var detallesSubsidios = new List<string>();

            foreach (var subsidio in subsidios)
            {
                string detalleSubsidio = string.Format("{1} - {2:d}", subsidio.ID_Subsidio, subsidio.Programa, subsidio.Fecha);
                detallesSubsidios.Add(detalleSubsidio);
            }

            listBox1.DataSource = detallesSubsidios;


            var beneficiario = miDB.GetCollection<Beneficiario>("Beneficiarios").Find(b => b.Nombre_Beneficiario == nombreBeneficiario).FirstOrDefault();
            string nombreMunicipio = beneficiario.Municipio;
            var municipio = miDB.GetCollection<Municipio>("Municipios").Find(m => m.Nombre_Municipio == nombreMunicipio).FirstOrDefault();
            string nombreDepartamento = municipio.Departamento;
            textBox1.Text = nombreDepartamento;


            var subsidiosDelBeneficiario = subsidios.FindAll(s => s.Beneficiario == nombreBeneficiario);

            
            int valorTotal = 0;
            var programas = miDB.GetCollection<Programa>("Programas");
            
            foreach (var subsidio in subsidiosDelBeneficiario)
            {
                var programa = programas.Find(p => p.Nombre_Programa == subsidio.Programa).FirstOrDefault();

                valorTotal += programa?.Valor ?? 0;
            }
            txtValor.Text = valorTotal.ToString();



            var subsidiosDelBeneficiarios = miDB.GetCollection<Subsidio>("Subsidios").Find(s => s.Beneficiario == nombreBeneficiario).ToList();

            // Crear una lista para almacenar los años de los subsidios
            List<int> aniosSubsidios = new List<int>();

            // Verificar que la lista de subsidios no está vacía antes de iterar sobre ella
            if (subsidiosDelBeneficiarios.Any())
            {
                // Recorrer todos los subsidios del beneficiario y extraer el año de la fecha de otorgamiento
                foreach (var subsidio in subsidiosDelBeneficiarios)
                {
                    int anioSubsidio = subsidio.Fecha.Year;

                    // Agregar el año a la lista si no está ya presente
                    if (!aniosSubsidios.Contains(anioSubsidio))
                    {
                        aniosSubsidios.Add(anioSubsidio);
                    }
                }
            }

            // Mostrar los años de los subsidios en el ListBox correspondiente
            listBox3.Items.Clear();
            foreach (var anio in aniosSubsidios)
            {
                listBox3.Items.Add(anio.ToString());
            }


        }

        private void ResportesBeneficiario_Load(object sender, EventArgs e)
        {
            ActualizarListaBeneficiarios();
        }
    }
}
