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
    public partial class ActualizaBeneficiarios : Form
    {
        public ActualizaBeneficiarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InicializaListaBeneficiarios()
        {
            ListaBeneficiarios.DataSource = null;
            ListaBeneficiarios.DataSource = AccesoDatos.ObtieneNombresBeneficiarios();
            ListaBeneficiarios.DisplayMember = "Nombre_Programa";

            //Seleccionamos el primer municipio de la lista
            ListaBeneficiarios.SelectedIndex = 0;
        }
        private void ActualizaBeneficiarios_Load(object sender, EventArgs e)
        {
            InicializaListaBeneficiarios();
        }
    }
}
