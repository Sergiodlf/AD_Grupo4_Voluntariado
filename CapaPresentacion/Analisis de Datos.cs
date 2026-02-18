using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CapaPresentacion
{
    public partial class Analisis_de_Datos : Form
    {
        public Gestion gestion;
        public Analisis_de_Datos()
        {
            InitializeComponent();
            gestion = new Gestion();
            lblNumActividadesAbiertas.Text = gestion.Actividades().Count(a => a.ESTADO == "ABIERTA").ToString();
            lblNumActividadesTerminadas.Text = gestion.Actividades().Count(a => a.ESTADO == "TERMINADA").ToString();
            lblNumMatches.Text = gestion.Matches().Count().ToString();
            lblNumOrganizaciones.Text =  gestion.Organizaciones().Count().ToString();
            lblNumVoluntarios.Text = gestion.Voluntarios().Count().ToString();
        }
    }
}
