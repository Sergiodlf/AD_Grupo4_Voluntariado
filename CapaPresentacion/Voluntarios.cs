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
    public partial class Voluntarios : Form
    {
        public Gestion gestion;
        private List<VOLUNTARIO> voluntarios = null;
        public Voluntarios()
        {
            InitializeComponent();
            gestion = Program.gestion;
            lblInformacion.Text = "Todos los voluntarios";
            voluntarios = gestion.Voluntarios();
            dgvVoluntarios.DataSource = voluntarios.Select(v => new
            {
                DNI = v.DNI,
                Nombre = v.NOMBRE,
                Apellidos = $"{v.APELLIDO1} {v.APELLIDO2}",
                Correo = v.CORREO,
                Zona = v.ZONA,
                Experiencia = v.EXPERIENCIA
            }).ToList();
        }

        private void txtNombreOrg_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreVoluntario.Text == "")
                lblInformacion.Text = "Todos los voluntarios";
            else
                lblInformacion.Text = "Voluntarios que su nombre comienza por: "+ txtNombreVoluntario.Text;
            voluntarios = gestion.VoluntariosPorTrozoDeNombre(txtNombreVoluntario.Text);
            dgvVoluntarios.DataSource = voluntarios.Select(v => new
            {
                DNI = v.DNI,
                Nombre = v.NOMBRE,
                Apellidos = $"{v.APELLIDO1} {v.APELLIDO2}",
                Correo = v.CORREO,
                Zona = v.ZONA,
                Experiencia = v.EXPERIENCIA
            }).ToList();
        }

        private void dgvVoluntarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VOLUNTARIO voluntario = voluntarios[e.RowIndex];
            lblVoluntario.Text = "Actividades del voluntario: " + voluntario.NOMBRE;
            dgvActividades.DataSource = gestion.ActividadesDeVoluntario(voluntario);
        }
    }
}
