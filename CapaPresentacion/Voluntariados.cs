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
            gestion = new Gestion();
            actividades = gestion.Actividades();

            lblActividades.Text = "Todas las actividades";
            CargarTodasLasActividades();
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
            lblOrganizacion.Text = $"Organización responsable de: {actividad.NOMBRE}";
            lblVoluntarios.Text = $"Voluntarios inscritos en: {actividad.NOMBRE}";

            dgvVoluntarios.DataSource = actividad.INSCRIPCIONES.Select(i => i.VOLUNTARIO).Select(v => new
            {
                DNI = v.DNI,
                Nombre = v.NOMBRE,
                Apellidos = $"{v.APELLIDO1} {v.APELLIDO2}",
                Correo = v.CORREO,
                Zona = v.ZONA,
                FechaNacimiento = v.FECHA_NACIMIENTO,
                Experiencia = v.EXPERIENCIA,
                Coche = v.COCHE == true ? "Sí" : "No",
                Ciclo = $"{v.CURSO_CICLOS} {v.NOMBRE_CICLOS}"
            }).ToList();
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
                Nombre = a.NOMBRE,
                Organización = a.ORGANIZACIONE.NOMBRE,
                Estado = a.ESTADO,
                Sector = a.SECTOR,
                Dirección = a.DIRECCION,
                Inicio = a.FECHA_INICIO,
                Fin = a.FECHA_FIN,
                Descripción = a.DESCRIPCION,
                MaxParticipantes = a.MAX_PARTICIPANTES
            }).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
