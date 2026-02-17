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
    public partial class Alta_Voluntario : Form
    {
        public Gestion gestion;
        public Alta_Voluntario()
        {

            InitializeComponent();
            gestion = Program.gestion;
            cboCiclo.SelectedIndex = 0;

            cboCiclo.DataSource = gestion.Ciclos();
            cboCiclo.DisplayMember = "nombre";
            cboCiclo.ValueMember = "nombre";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboCoche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
