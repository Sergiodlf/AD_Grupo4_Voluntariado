using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
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
            gestion = new Gestion();

            cboOrg.DataSource = gestion.Organizaciones();
            cboOrg.DisplayMember = "NOMBRE";
            cboOrg.ValueMember = "CIF";
            cboOrg.SelectedIndex = 0;
            cboSector.SelectedIndex = 0;
        }

        private void btnCrearOrg_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }
            if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("La dirección es obligatoria");
                return;
            }
            if (!short.TryParse(txtPlazas.Text, out var plazas) || plazas <= 0)
            {
                MessageBox.Show("Las plazas tiene que ser un número entero mayor que 0");
                return;
            }
            if (dtpInicio.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("La fecha inicio tiene que ser posterior a hoy");
                return;
            }
            if (dtpFechaFin.Value.Date < dtpInicio.Value.Date)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio");
                return;
            }
            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripción es obligatoria");
                return;
            }

            ORGANIZACIONE org = cboOrg.SelectedItem as ORGANIZACIONE;

            bool resultado = gestion.CrearActividad(txtNombre.Text, txtDireccion.Text, dtpInicio.Value.Date, dtpFechaFin.Value.Date, plazas, org.CIF, cboSector.Text, txtDescripcion.Text);
            if (resultado)
                MessageBox.Show("Se ha creado la nueva actividad correctamente");
            else
                MessageBox.Show("Ha habido algún error al intentar crear la nueva actividad");
        }
    }
}
