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
            cmbCategorias.Text = "";
            lstContactos.Items.Clear();
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
    }
}
