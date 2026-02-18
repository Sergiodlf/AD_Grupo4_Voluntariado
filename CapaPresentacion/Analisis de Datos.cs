using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Analisis_de_Datos : Form
    {
        public Analisis_de_Datos()
        {
            InitializeComponent();
            lblNumActividadesAbiertas.Text =  new Gestion().Actividades().Count(a => a.ESTADO == "ABIERTA").ToString();
            lblNumActividadesTerminadas.Text =  new Gestion().Actividades().Count(a => a.ESTADO == "TERMINADA").ToString();
            lblNumMatches.Text = new Gestion().Matches().Count().ToString();
            lblNumOrganizaciones.Text =  new Gestion().Organizaciones().Count().ToString();
            lblNumVoluntarios.Text =  new Gestion().Voluntarios().Count().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Analisis_de_Datos_Load(object sender, EventArgs e)
        {

        }
    }
}
