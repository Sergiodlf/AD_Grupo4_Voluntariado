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
            gestion = new Gestion();

            cboActividad.DataSource = gestion.Actividades();
            cboActividad.DisplayMember = "NOMBRE";
            cboActividad.ValueMember = "CODACTIVIDAD";

            cboVoluntario.DataSource = gestion.Voluntarios();
            cboVoluntario.DisplayMember = "NombreCompleto";
            cboVoluntario.ValueMember = "DNI";
        }
        
        private void btnCrearMatch_Click(object sender, EventArgs e)
        {
            // 1. Obtener los objetos seleccionados de los ComboBox
            VOLUNTARIO vol = cboVoluntario.SelectedItem as VOLUNTARIO;
            ACTIVIDADE act = cboActividad.SelectedItem as ACTIVIDADE;

            // 2. Validación: ¿Se ha seleccionado un voluntario y una actividad?
            if (vol == null || act == null)
            {
                MessageBox.Show("Por favor, selecciona tanto un voluntario como una actividad.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validación: ¿Ya existe esta inscripción en la base de datos?
            if (gestion.ExisteInscripcion(vol.DNI, act.CODACTIVIDAD))
            {
                MessageBox.Show($"El voluntario {vol.NOMBRE} ya está inscrito en la actividad '{act.NOMBRE}'.", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 4. Validación: ¿Hay plazas disponibles (Aforo)?
            int inscritosActuales = gestion.ContarInscritos(act.CODACTIVIDAD, out string mensajeError);

            if (inscritosActuales == -1)
            {
                MessageBox.Show(mensajeError, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inscritosActuales >= act.MAX_PARTICIPANTES)
            {
                MessageBox.Show($"Lo sentimos, la actividad '{act.NOMBRE}' ya está llena ({inscritosActuales}/{act.MAX_PARTICIPANTES} plazas).", "Aforo Completo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 5. Confirmación final del usuario
            DialogResult respuesta = MessageBox.Show($"¿Deseas inscribir a {vol.NOMBRE} en la actividad {act.NOMBRE}?", "Confirmar Match", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // 6. Intentar crear el Match
                if (gestion.CrearMatch(vol.DNI, act.CODACTIVIDAD, out string mensajeResultado))
                {
                    MessageBox.Show(mensajeResultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboActividad.SelectedIndex = 0;
                    cboVoluntario.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(mensajeResultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            lblDescripcion.Text = actividadSeleccionada.DESCRIPCION;
        }

        private void cboVoluntario_SelectedIndexChanged(object sender, EventArgs e)
        {
            VOLUNTARIO vol = cboVoluntario.SelectedItem as VOLUNTARIO;
            if (vol != null)
            {
                lblDNI.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.DNI ?? "N/A";
                lblNombreVol.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.NOMBRE ?? "N/A";
                lblApellido1.Text = $"{(cboVoluntario.SelectedItem as VOLUNTARIO)?.APELLIDO1} {(cboVoluntario.SelectedItem as VOLUNTARIO)?.APELLIDO2}".Trim();
                lblCorreo.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.CORREO ?? "N/A";
                lblFechaNacVoluntario.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.FECHA_NACIMIENTO.ToShortDateString() ?? "N/A";
                lblZonaVoluntario.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.ZONA ?? "N/A";
                lblExperienciaVoluntario.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.EXPERIENCIA  ?? "N/A";
                lblDisponibilidad.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.DISPONIBILIDAD ?? "N/A";
                lblCocheVoluntario.Text = (cboVoluntario.SelectedItem as VOLUNTARIO)?.COCHE == true ? "Sí" : "No";
                lblCiclo.Text = $"{(cboVoluntario.SelectedItem as VOLUNTARIO)?.CURSO_CICLOS} {(cboVoluntario.SelectedItem as VOLUNTARIO)?.NOMBRE_CICLOS}".Trim();

                lstIdiomas.Items.Clear();
                if (!string.IsNullOrEmpty(vol.IDIOMAS)) lstIdiomas.Items.Add(vol.IDIOMAS);
            }
        }
    }
}
