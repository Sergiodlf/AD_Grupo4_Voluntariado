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

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        public Gestion gestion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestion = Program.gestion;
            lsbODS.Items.AddRange(gestion.Ods().Select(ods => new { ods.id, ods.nombre }).ToArray());
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            lblInformacion.Text = "Todos los voluntarios";
            dgv.DataSource = null;
            dgv.DataSource = gestion.Voluntarios();
        }

        private void btnOrganizaciones_Click(object sender, EventArgs e)
        {
            lblInformacion.Text = "Todos los voluntarios";
            dgv.DataSource = null;
            dgv.DataSource = gestion.Organizaciones();
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            lblInformacion.Text = "Todas las actividades";
            dgv.DataSource = null;
            dgv.DataSource= gestion.Actividades();
        }
    }
}
