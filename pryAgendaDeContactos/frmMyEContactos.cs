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
    public partial class frmMyEContactos : Form
    {
        public frmMyEContactos()
        {
            InitializeComponent();
        }
        clsConexionBD ObjModificar = new clsConexionBD();
        private void frmMyEContactos_Load(object sender, EventArgs e)
        {
            ObjModificar.CargarCategorias(cmbCategorias);
            ObjModificar.CargarCategorias(cmbCategoria);
            ObjModificar.ListarContactos(dgvContactos);
            Limpiar();
            Controles();
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpiar();
            if (cmbCategorias.SelectedItem != null)
            {
                // Como SelectedValue/Index no funcionaban en la funcion de cargar los combos se rellena en un dataTable
                // Por eso aca buscamos la fila seleccionada mediante el item q selecciona en el combo. Si seleccionó entra al if
                DataRowView filaSelec = cmbCategorias.SelectedItem as DataRowView;
                if (filaSelec != null)
                {
                    int cod = Convert.ToInt32(filaSelec["id_Categoria"]);
                    ObjModificar.ContactosPorCat(lstContactos, cod);
                }
            }
        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContactos.SelectedItem != null)
            {
                string contactoSelec = lstContactos.SelectedItem.ToString();
                // Guardo los datos en una tabla virtualizada
                DataTable datosContacto = ObjModificar.DatosContacto(contactoSelec);
                if (datosContacto.Rows.Count > 0)
                {
                    //Encontró los datos del contacto
                    DataRow fila = datosContacto.Rows[0];
                    txtNombre.Text = fila["Nombre"].ToString();
                    txtApellido.Text = fila["Apellido"].ToString();
                    txtTelefono.Text = fila["Telefono"].ToString();
                    txtCorreo.Text = fila["Correo"].ToString();
                    cmbCategoria.Text = fila["Categoria"].ToString();
                    lblIdContacto.Text = fila["id_Contacto"].ToString();
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
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
                int cod = Convert.ToInt32(lblIdContacto.Text);

                ObjModificar.ModificarContacto(nombre, ape, tel, correo, cate, cod);
                Limpiar();
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cmbCategoria.Text = "";
            lblIdContacto.Text = "";
        }
        private void Controles()
        {
            cmbCategorias.Text = "";
            lstContactos.Items.Clear();
            dgvContactos.Columns[0].HeaderText = "ID";
            dgvContactos.Columns[5].HeaderText = "Categoría";
            dgvContactos.Columns[0].Width = 50;
            dgvContactos.Columns[5].Width = 80;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count > 0)
            {                
                DataGridViewRow filaSelec = dgvContactos.SelectedRows[0];
                int idContacto = Convert.ToInt32(filaSelec.Cells["id_Contacto"].Value);

                // Mensaje para eliminacion, si confirma o no
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este contacto?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                // Si elige si se elimina
                if (resultado == DialogResult.Yes)
                {
                    ObjModificar.EliminarContacto(idContacto);
                    ObjModificar.ListarContactos(dgvContactos);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un contacto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
