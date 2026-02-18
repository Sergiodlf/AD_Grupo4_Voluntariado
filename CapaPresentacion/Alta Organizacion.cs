using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Entidades;

namespace CapaPresentacion
{
    public partial class Alta_Organizacion : Form
    {
        public Gestion gestion;
        List<ORGANIZACIONE> organizaciones;
        public Alta_Organizacion()
        {
            InitializeComponent();
            gestion = new Gestion();
            organizaciones = gestion.Organizaciones();
            cboSector.SelectedIndex = 0;
        }

        private void lblOrganizaciones_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbAcercaDeOrg_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrearOrg_Click(object sender, EventArgs e)
        {
            if (txtCIF.Text.Length != 9)
            {
                MessageBox.Show("El CIF tiene que tener 9 caracteres");
                return;
            }
            if (organizaciones.Any(o => o.CIF.ToUpper() == txtCIF.Text.ToUpper()))
            {
                MessageBox.Show("Ya hay una organización registrada con ese CIF");
                return;
            }
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }
            if (organizaciones.Any(o => o.NOMBRE.ToUpper() == txtNombre.Text.ToUpper()))
            {
                MessageBox.Show("Ya hay una organización registrada con ese nombre");
                return;
            }
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("El email es obligatorio");
                return;
            }
            if (txtTelf.Text.Length == 0)
            {
                MessageBox.Show("El teléfono es obligatorio");
                return;
            }
            if (!int.TryParse(txtTelf.Text, out int tlf))
            {
                MessageBox.Show("El teléfono deben ser números enteros");
                return;
            }
            if (txtCP.Text.Length != 5 || !int.TryParse(txtCP.Text, out int value))
            {
                MessageBox.Show("El Código postal debe ser 5 números enteros");
                return;
            }
            if (txtLocalidad.Text.Length == 0)
            {
                MessageBox.Show("La localidad es obligatoria");
                return;
            }
            if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("La dirección es obligatoria");
                return;
            }
            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripción es obligatoria");
                return;
            }
            bool resultado = gestion.CrearOrganizacion(txtCIF.Text, txtNombre.Text, txtEmail.Text, cboSector.Text, txtDireccion.Text, txtLocalidad.Text, txtCP.Text, txtDescripcion.Text, txtTelf.Text);

            if (resultado)
                MessageBox.Show("Se ha creado la nueva organización correctamente");
            else
                MessageBox.Show("Ha habido algún error al intentar crear la nueva organización");
        }
    }
}
