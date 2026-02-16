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
    public partial class Organizaciones : Form
    {
        public Gestion gestion;
        private List<ORGANIZACIONE> organizaciones = null;
        public Organizaciones()
        {
            InitializeComponent();
            gestion = Program.gestion;
            lblOrganizaciones.Text = "Todas las organizaciones: ";
            organizaciones = gestion.Organizaciones();
            dgvOrganizacion.DataSource = organizaciones.Select(o => new
            {
                CIF = o.CIF,
                Nombre = o.NOMBRE,
                Email = o.EMAIL,
                Sector = o.SECTOR,
                Dirección = o.DIRECCION,
                Localidad = o.LOCALIDAD,
                Contacto = o.CONTACTO
            }).ToList();
        }

        private void txtNombreOrg_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreOrg.Text == "")
            lblOrganizaciones.Text = "Todas las organizaciones: ";
            else
                lblOrganizaciones.Text = "Organizaciones que su nombre comienza por: " + txtNombreOrg.Text;
            organizaciones = gestion.OrganizacionesPorTrozoDeNombre(txtNombreOrg.Text);
            dgvOrganizacion.DataSource = organizaciones.Select(o => new
            {
                CIF = o.CIF,
                Nombre = o.NOMBRE,
                Email = o.EMAIL,
                Sector = o.SECTOR,
                Dirección = o.DIRECCION,
                Localidad = o.LOCALIDAD,
                Contacto = o.CONTACTO
            }).ToList();
        }

        private void dgvOrganizacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex < 0 ) return;
            ORGANIZACIONE organizacion = organizaciones[e.RowIndex];
            lblActividades.Text = "Número de actividades organizadas por " + organizacion.NOMBRE + ": " + organizacion.ACTIVIDADES.Count;
            dgvActividades.DataSource = organizacion.ACTIVIDADES.Select(a => new
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
    }
}
