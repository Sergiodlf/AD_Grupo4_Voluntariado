using CapaDatos;
using Entidades;
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
    public partial class Voluntariados : Form
    {
        public Gestion gestion;
        private List<ACTIVIDADE> actividades = null;
        public Voluntariados()
        {
            InitializeComponent();
            gestion = Program.gestion;
            actividades = gestion.Actividades();
            lblActividades.Text = "Todas las actividades";
            dgvActividades.DataSource = actividades.Select(a => new
            {
                Nombre = a.NOMBRE,
                Estado = a.ESTADO,
                Sector = a.SECTOR,
                Dirección = a.DIRECCION,
                Inicio = a.FECHA_INICIO,
                Fin = a.FECHA_FIN,
                Descripción = a.DESCRIPCION
            }).ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
