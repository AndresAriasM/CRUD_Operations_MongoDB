using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaBeneficiariosMongo.Formularios
{
    public partial class ActualizaPrograma : Form
    {
        public ActualizaPrograma()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InicializaListaProgramas()
        {
            ListaProgramas.DataSource = null;
            ListaProgramas.DataSource = AccesoDatos.ObtieneNombresProgramas();
            ListaProgramas.DisplayMember = "Nombre_Programa";

            //Seleccionamos el primer municipio de la lista
            ListaProgramas.SelectedIndex = 0;

        }

        private void ActualizaPrograma_Load(object sender, EventArgs e)
        {
            InicializaListaProgramas();
        }
    }
}
