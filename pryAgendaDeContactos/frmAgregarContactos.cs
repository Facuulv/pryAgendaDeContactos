using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgendaDeContactos
{
    public partial class frmAgregarContactos : Form
    {
        public frmAgregarContactos()
        {
            InitializeComponent();
        }
        clsConexionBD Agregar = new clsConexionBD();
        private void frmAgregarContactos_Load(object sender, EventArgs e)
        {
            Agregar.ListarContactos(dgvContactos);
            Agregar.CargarCategorias(cmbCategoria);
            dgvContactos.Columns[0].HeaderText = "Contacto";
            dgvContactos.Columns[5].HeaderText = "Categoría";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" &&
                txtTelefono.Text != null && txtCorreo.Text != "" &&
                cmbCategoria.SelectedValue != null)
            {
                string nombre = txtNombre.Text;
                string ape = txtApellido.Text;
                string tel = txtTelefono.Text;
                string correo = txtCorreo.Text;
                int cate = Convert.ToInt32(cmbCategoria.SelectedValue);
                Agregar.AgregarContacto(nombre, ape, tel, correo, cate);
                Limpiar();
                Agregar.ListarContactos(dgvContactos);
            }
            else
            {
                MessageBox.Show("Error, debe colocar datos en todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cmbCategoria.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
