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
    public partial class Alta_Voluntario : Form
    {
        public Gestion gestion;
        public List<VOLUNTARIO> voluntarios;
        public Alta_Voluntario()
        {

            InitializeComponent();
            gestion = Program.gestion;
            voluntarios = gestion.Voluntarios();

            cboCiclo.DataSource = gestion.Ciclos();
            cboCiclo.DisplayMember = "nombre";
            cboCiclo.ValueMember = "nombre";
            cboCiclo.SelectedIndex = 0;
            cboCoche.SelectedIndex = 0;
            cboZona.SelectedIndex = 0;
            cboCurso.SelectedIndex = 0;
            cboExperiencia.SelectedIndex = 0;
        }

        private void btnCrearVol_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length != 9)
            {
                MessageBox.Show("El DNI debe tener 9 caracteres");
                return;
            }
            if (voluntarios.Any(v => v.DNI.ToUpper() == txtDNI.Text.ToUpper()))
            {
                MessageBox.Show("Ya existe un voluntario con ese DNI");
                return;
            }
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }
            if (txtApellido1.Text.Length == 0)
            {
                MessageBox.Show("El primer apellido es obligatorio");
                return;
            }
            if (dtpFechaNac.Value.Date > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("El voluntario tiene que ser mayor de edad");
                return;
            }
            if (txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("El correo es obligatorio");
                return;
            }
            if (voluntarios.Any(v => v.CORREO.ToUpper() == txtCorreo.Text.ToUpper()))
            {
                MessageBox.Show("Ya existe un voluntario con ese correo");
                return;
            }
            short.TryParse(cboCurso.Text, out short cursoShort);
            short? curso = cursoShort;
            bool resultado = gestion.CrearVoluntario(txtDNI.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCorreo.Text, cboZona.Text, dtpFechaNac.Value.Date, cboExperiencia.Text, cboCoche.Text.ToLower() == "si" ? true : false, curso, cboCiclo.Text);
            if (resultado)
                MessageBox.Show("Se ha creado el nuevo voluntario correctamente");
            else
                MessageBox.Show("Ha habido algún error al intentar crear el nuevo voluntario");
        }
    }
}
