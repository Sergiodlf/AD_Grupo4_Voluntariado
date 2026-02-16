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
            lblVoluntarios.Text = "Todos los voluntarios";
            voluntarios = gestion.Voluntarios();
            dgvVoluntarios.DataSource = voluntarios.Select(v => new
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

        private void txtNombreOrg_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreVoluntario.Text == "")
                lblVoluntarios.Text = "Todos los voluntarios";
            else
                lblVoluntarios.Text = "Voluntarios que su nombre comienza por: "+ txtNombreVoluntario.Text;
            voluntarios = gestion.VoluntariosPorTrozoDeNombre(txtNombreVoluntario.Text);
            dgvVoluntarios.DataSource = voluntarios.Select(v => new
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

        private void dgvVoluntarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            VOLUNTARIO voluntario = voluntarios[e.RowIndex];
            lblActividades.Text = "Actividades en las que se ha inscrito: " + voluntario.NOMBRE + " "+ voluntario.APELLIDO1 + " "+ voluntario.APELLIDO2;
            dgvActividades.DataSource = voluntario.INSCRIPCIONES.Select(i => i.ACTIVIDADE).Select(a => new
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
