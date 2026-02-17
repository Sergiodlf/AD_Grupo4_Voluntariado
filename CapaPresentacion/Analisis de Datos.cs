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
            lblNumActividadesAbiertas.Text =  Program.gestion.Actividades().Count(a => a.ESTADO == "ABIERTA").ToString();
            lblNumActividadesTerminadas.Text =  Program.gestion.Actividades().Count(a => a.ESTADO == "TERMINADA").ToString();
            //lblNumMatches.Text = Program.gestion.Matches().Count().ToString();
            lblNumOrganizaciones.Text =  Program.gestion.Organizaciones().Count().ToString();
            lblNumVoluntarios.Text =  Program.gestion.Voluntarios().Count().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
