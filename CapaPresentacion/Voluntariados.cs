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
            CargarTodasLasActividades();

        }

        private void CargarTodasLasActividades()
        {
            actividades = gestion.Actividades();
            ActualizarGridActividades(actividades);
        }

        private void ActualizarGridActividades(List<ACTIVIDADE> lista)
        {
            dgvActividades.DataSource = lista.Select(a => new
            {
                ID = a.CODACTIVIDAD,
                Nombre = a.NOMBRE,
                Estado = a.ESTADO,
                Sector = a.SECTOR,
                Dirección = a.DIRECCION,
                Inicio = a.FECHA_INICIO,
                Fin = a.FECHA_FIN,
                Descripción = a.DESCRIPCION
            }).ToList();

            // Ocultar el ID si no quieres que el usuario lo vea
            if (dgvActividades.Columns["ID"] != null) dgvActividades.Columns["ID"].Visible = false;
        }

        // Evento cuando se hace click en una fila de actividades
        private void dgvActividades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActividades.SelectedRows.Count > 0)
            {
                // Obtenemos el ID de la actividad seleccionada
                int idSeleccionado = (int)dgvActividades.SelectedRows[0].Cells["ID"].Value;

                // Buscamos la actividad completa en nuestra lista local
                var act = actividades.FirstOrDefault(a => a.CODACTIVIDAD == idSeleccionado);

                if (act != null)
                {
                    // Llenar labels de la organización
                    lblCIF.Text = act.ORGANIZACIONE?.CIF ?? "N/A";
                    lblNombreOrg.Text = act.ORGANIZACIONE?.NOMBRE ?? "N/A";
                    lblEmailOrg.Text = act.ORGANIZACIONE?.EMAIL ?? "N/A";

                    // Llenar el DGV de voluntarios inscritos
                    dgvVoluntarios.DataSource = act.INSCRIPCIONES.Select(i => new
                    {
                        DNI = i.VOLUNTARIO.DNI,
                        Nombre = i.VOLUNTARIO.NOMBRE,
                        Apellidos = i.VOLUNTARIO.APELLIDO1 + " " + i.VOLUNTARIO.APELLIDO2,
                        Email = i.VOLUNTARIO.CORREO
                    }).ToList();
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            if (inicio > fin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            actividades = gestion.ActividadesPorRango(inicio, fin.AddDays(1));
            if(actividades.Count == 0)
            {
                lblActividades.Text = "No se encontraron actividades en el rango de fechas seleccionado.";
                dgvActividades.DataSource = null;
                return;
            }
            ActualizarGridActividades(actividades);
            lblActividades.Text = $"Actividades del {inicio.ToShortDateString()} al {fin.ToShortDateString()}";
        }

        private void dgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ACTIVIDADE actividad = actividades[e.RowIndex];
            lblCIF.Text = actividad.ORGANIZACIONE?.CIF ?? "N/A";
            lblNombreOrg.Text = actividad.ORGANIZACIONE?.NOMBRE ?? "N/A";
            lblEmailOrg.Text = actividad.ORGANIZACIONE?.EMAIL ?? "N/A";
            lblInformacionOrganizacion.Text = $"Organización responsable de: {actividad.NOMBRE}";
            lblVoluntarios.Text = $"Voluntarios inscritos en: {actividad.NOMBRE}";

            dgvVoluntarios.DataSource = actividad.INSCRIPCIONES.Select(i => new
            {
                DNI = i.VOLUNTARIO.DNI,
                Nombre = i.VOLUNTARIO.NOMBRE,
                Apellidos = i.VOLUNTARIO.APELLIDO1 + " " + i.VOLUNTARIO.APELLIDO2,
                Email = i.VOLUNTARIO.CORREO,
                Zona = i.VOLUNTARIO.ZONA,
                Experiencia = i.VOLUNTARIO.EXPERIENCIA
            }).ToList();

        }
    }
}
