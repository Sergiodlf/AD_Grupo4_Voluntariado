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
    public partial class Match : Form
    {
        public Gestion gestion;
        public Match()
        {
            InitializeComponent();
            gestion = Program.gestion;

            cboActividad.DataSource = gestion.Actividades();
            cboActividad.DisplayMember = "NOMBRE";
            cboActividad.ValueMember = "CODACTIVIDAD";

            cboVoluntario.DataSource = gestion.Voluntarios();
            cboVoluntario.DisplayMember = "NOMBRE";
            cboVoluntario.ValueMember = "DNI";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearMatch_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ACTIVIDADE actividadSeleccionada = cboActividad.SelectedItem as ACTIVIDADE;
 
            lblNombreOrg.Text = actividadSeleccionada.ORGANIZACIONE?.NOMBRE ?? "N/A";
            lblNombreActividad.Text = actividadSeleccionada.NOMBRE;
            lblDireccionActividad.Text = actividadSeleccionada.DIRECCION;
            lblMaxParticipantes.Text = actividadSeleccionada.MAX_PARTICIPANTES.ToString();
            lblFechaInicio.Text = actividadSeleccionada.FECHA_INICIO.ToShortDateString();
            lblFechaFin.Text = actividadSeleccionada.FECHA_FIN.ToShortDateString();
            lblSector.Text = actividadSeleccionada.SECTOR;
            txtDescripcion.Text = actividadSeleccionada.DESCRIPCION;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cboVoluntario_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDNI.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.DNI ?? "N/A";
            lblNombreVol.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.NOMBRE ?? "N/A";
            lblApellido1.Text = $"{(cboVoluntario.SelectedItem as VOLUNTARIO)?.APELLIDO1} {(cboVoluntario.SelectedItem as VOLUNTARIO)?.APELLIDO2}".Trim();
            lblCorreo.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.CORREO ?? "N/A";
            lblFechaNacVoluntario.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.FECHA_NACIMIENTO.ToShortDateString() ?? "N/A";
            lblZonaVoluntario.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.ZONA ?? "N/A";
            lblExperienciaVoluntario.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.EXPERIENCIA == true ? "Sí" : "No";
            lblDisponibilidad.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.DISPONIBILIDAD ?? "N/A";
            lblCocheVoluntario.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.COCHE == true ? "Sí" : "No";
            lblCiclo.Text = $"{(cboVoluntario.SelectedItem as VOLUNTARIO)?.CURSO_CICLOS} {(cboVoluntario.SelectedItem as VOLUNTARIO)?.NOMBRE_CICLOS}".Trim();
        }
    }
}
