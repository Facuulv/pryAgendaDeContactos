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
    public partial class frmAgregarCategorias : Form
    {
        public frmAgregarCategorias()
        {
            InitializeComponent();
        }
        clsConexionBD ObjCategorias = new clsConexionBD();
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != "")
            {
                string cate = txtCategoria.Text;
                if (!ObjCategorias.VerificarCate(cate))
                {
                    ObjCategorias.AgregarCategorias(cate);
                    ObjCategorias.ListarCategorias(lstCategorias);
                    txtCategoria.Text = "";
                    txtCategoria.Select();
                    btnQuitar.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"La categoría {cate} ya existe.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtCategoria.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Error, debe rellenar el campo", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void frmAgregarCategorias_Load(object sender, EventArgs e)
        {
            ObjCategorias.ListarCategorias(lstCategorias);
            btnQuitar.Enabled = false;
        }

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnQuitar.Enabled = lstCategorias.SelectedIndex >= 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedItem != null)
            {
                string categoriaSelec = lstCategorias.SelectedItem.ToString();
                var result = MessageBox.Show($"¿Estás seguro de que deseas eliminar la categoría '{categoriaSelec}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ObjCategorias.EliminarCategorias(categoriaSelec);
                    ObjCategorias.ListarCategorias(lstCategorias);
                    btnQuitar.Enabled = false;
                    txtCategoria.Select();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna categoría para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
