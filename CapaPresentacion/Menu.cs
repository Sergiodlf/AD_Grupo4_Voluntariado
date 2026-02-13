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

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
