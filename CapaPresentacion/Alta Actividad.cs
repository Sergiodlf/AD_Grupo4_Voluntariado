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
    public partial class Alta_Actividad : Form
    {
        public Gestion gestion;
        public Alta_Actividad()
        {
            InitializeComponent();
            gestion = Program.gestion;

            cboCIFOrg.DataSource = gestion.Organizaciones();
            cboCIFOrg.DisplayMember = "NOMBRE";
            cboCIFOrg.ValueMember = "CIF";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
