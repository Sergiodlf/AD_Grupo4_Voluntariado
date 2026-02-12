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
    public partial class FrmAnaliticasVoluntariado : Form
    {

        public Gestion gestion;
        public FrmAnaliticasVoluntariado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestion = Program.gestion;
            lsbODS.DataSource = gestion.Ods().Select(ods => new { ods.id, ods.nombre }).ToList();
            lsbODS.DisplayMember = "nombre";
            lsbODS.ValueMember = "id";
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            lblInformacion.Text = "Todos los voluntarios";
            dgv.DataSource = null;
            dgv.DataSource = gestion.Voluntarios();
        }

        private void btnOrganizaciones_Click(object sender, EventArgs e)
        {
            lblInformacion.Text = "Todos los voluntarios";
            dgv.DataSource = null;
            dgv.DataSource = gestion.Organizaciones();
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            lblInformacion.Text = "Todas las actividades";
            dgv.DataSource = null;
            dgv.DataSource= gestion.Actividades();
        }

        private void btnActividadesODS_Click(object sender, EventArgs e)
        {
            var idsSeleccionados = lsbODS.SelectedItems
                .Cast<dynamic>()
                .Select(x => (int)x.id)
                .ToList();

            if (idsSeleccionados.Any())
            {
                var todasLasActividades = gestion.ActividadesPorOds(idsSeleccionados);

                var listaLimpia = todasLasActividades.Select(a => new
                {
                    Nombre = a.NOMBRE,
                    Estado = a.ESTADO,
                    Dirección = a.DIRECCION,
                    Inicio = a.FECHA_INICIO,
                    Fin = a.FECHA_FIN,
                    Sector = a.SECTOR,
                    Descripción = a.DESCRIPCION
                }).ToList();

                dgv.DataSource = null;
                dgv.DataSource = listaLimpia;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos un ODS.");
            }
        }

        private void btnVoluntariosODS_Click(object sender, EventArgs e)
        {
            var idsSeleccionados = lsbODS.SelectedItems
                .Cast<dynamic>()
                .Select(x => (int)x.id)
                .ToList();

            if (idsSeleccionados.Any())
            {
                var voluntarios = gestion.VoluntariosPorOds(idsSeleccionados);

                var listaLimpia = voluntarios.Select(v => new
                {
                    Nombre = v.NOMBRE,
                    Apellido = v.APELLIDO1,
                    SegundoApellido = v.APELLIDO2,
                    Correo = v.CORREO,
                    Zona = v.ZONA,
                    Experiencia = v.EXPERIENCIA
                }).ToList();

                dgv.DataSource = null;
                dgv.DataSource = listaLimpia;
            }
            else
            {
                MessageBox.Show("Selecciona al menos un ODS de la lista.");
            }
        }

        private void btnOrganizacionesODS_Click(object sender, EventArgs e)
        {
            var idsSeleccionados = lsbODS.SelectedItems
                .Cast<dynamic>()
                .Select(x => (int)x.id)
                .ToList();

            if (idsSeleccionados.Any())
            {
                var organizaciones = gestion.OrganizacionesPorOds(idsSeleccionados);

                var listaLimpia = organizaciones.Select(o => new
                {
                    Nombre = o.NOMBRE,
                    Sector = o.SECTOR,
                    Dirección = o.DIRECCION,
                    Localidad = o.LOCALIDAD,
                    Contacto = o.CONTACTO,
                    Estado = o.ESTADO
                }).ToList();

                dgv.DataSource = null;
                dgv.DataSource = listaLimpia;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos un ODS.");
            }
        }
    }
}
