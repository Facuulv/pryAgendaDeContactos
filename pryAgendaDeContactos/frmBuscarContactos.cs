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
    public partial class frmBuscarContactos : Form
    {
        public frmBuscarContactos()
        {
            InitializeComponent();
        }
        clsConexionBD ObjBusqueda = new clsConexionBD();
        private void btnListar_Click(object sender, EventArgs e)
        {
            ObjBusqueda.ListarContactos2(dgvContactos);
            AjustarCol();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = null;
            dgvContactos.Rows.Clear();
            optNombre.Select();
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }

        private void frmBuscarContactos_Load(object sender, EventArgs e)
        {
            optNombre.Select();            
        }
        public void BotonesOpcion()
        {
            gbNombre.Enabled = false;
            gbTelefono.Enabled = false;
            gbCorreo.Enabled = false;

            if (optNombre.Checked)
            {
                gbNombre.Enabled = true;
                txtTelefono.Text = "";
                txtCorreo.Text = "";
            }
            else if (optTelefono.Checked)
            {
                gbTelefono.Enabled = true;
                txtNombre.Text = "";
                txtCorreo.Text = "";
            }
            else if (optCorreo.Checked)
            {
                gbCorreo.Enabled = true;
                txtNombre.Text = "";
                txtTelefono.Text = "";
            }
        }
        public void AjustarCol()
        {
            dgvContactos.Columns[0].Width = 50;
            dgvContactos.Columns[0].HeaderText = "ID";
            dgvContactos.Columns[5].Width = 80;
            dgvContactos.Columns[5].HeaderText = "Categoría";
            dgvContactos.Columns[3].Width = 80;
        }

        private void optNombre_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }

        private void optTelefono_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }

        private void optCorreo_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                string nombre = txtNombre.Text;
                ObjBusqueda.BuscarContacto(dgvContactos, nombre);
                AjustarCol();
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text != "")
            {
                string tel = txtTelefono.Text;
                ObjBusqueda.BuscarContacto(dgvContactos, tel);
                AjustarCol();
            }
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "")
            {
                string correo = txtCorreo.Text;
                ObjBusqueda.BuscarContacto(dgvContactos, correo);
                AjustarCol();
            }
        }
    }
}
