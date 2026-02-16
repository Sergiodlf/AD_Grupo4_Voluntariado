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
    public partial class ODS : Form
    {

        public Gestion gestion;
        public ODS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestion = Program.gestion;
            lsbODS.DataSource = gestion.Ods().ToList();
            lsbODS.DisplayMember = "nombre";
            lsbODS.ValueMember = "id";
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

                dgv.DataSource = null;
                dgv.DataSource = listaLimpia;

                var nombreOds = gestion.NombreOdsPorId(idsSeleccionados);

                lblInformacion.Text = "Voluntarios con actividades con las ODS: " + string.Join(", ", nombreOds);
            }
            else
            {
                MessageBox.Show("Selecciona al menos un ODS de la lista.");
            }
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
                    Organización = a.ORGANIZACIONE.NOMBRE,
                    Estado = a.ESTADO,
                    Sector = a.SECTOR,
                    Dirección = a.DIRECCION,
                    Inicio = a.FECHA_INICIO,
                    Fin = a.FECHA_FIN,
                    Descripción = a.DESCRIPCION,
                    MaxParticipantes = a.MAX_PARTICIPANTES
                }).ToList();

                dgv.DataSource = null;
                dgv.DataSource = listaLimpia;

                var nombreOds = gestion.NombreOdsPorId(idsSeleccionados);

                lblInformacion.Text = "Actividades con las ODS: " + string.Join(", ", nombreOds);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos un ODS.");
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
                    CIF = o.CIF,
                    Nombre = o.NOMBRE,
                    Email = o.EMAIL,
                    Sector = o.SECTOR,
                    Dirección = o.DIRECCION,
                    Localidad = o.LOCALIDAD,
                    Contacto = o.CONTACTO
                }).ToList();

                dgv.DataSource = null;
                dgv.DataSource = listaLimpia;

                var nombreOds = gestion.NombreOdsPorId(idsSeleccionados);

                lblInformacion.Text = "Organizaciones con actividades con las ODS: " + string.Join(", ", nombreOds);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos un ODS.");
            }
        }
    }
}
