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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void filtrarPorODSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form odsForm = new ODS();
            odsForm.ShowDialog();
        }

        private void filtrarPorVoluntariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form voluntariosForm = new Voluntarios();
            voluntariosForm.ShowDialog();
        }

        private void organizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form organizacionesForm = new Organizaciones();
            organizacionesForm.ShowDialog();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form voluntariadosForm = new Voluntariados();
            voluntariadosForm.ShowDialog();
        }

        private void consultarVoluntariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form voluntariosForm = new Voluntarios();
            voluntariosForm.ShowDialog();
        }

        private void altaVoluntariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form altaVoluntariosForm = new Alta_Voluntario();
            altaVoluntariosForm.ShowDialog();
        }

        private void altaOrganizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form altaOrganizacionesForm = new Alta_Organizacion();
            altaOrganizacionesForm.ShowDialog();
        }

        private void consultarOrganizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form organizacionesForm = new Organizaciones();
            organizacionesForm.ShowDialog();
        }

        private void crearActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form altaActividadForm = new Alta_Actividad();
            altaActividadForm.ShowDialog();
        }

        private void crearMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nuevoMatchForm = new Match();
            nuevoMatchForm.ShowDialog();
        }
    }
}
