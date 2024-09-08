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
            dgvContactos.Columns[0].Width = 50;
            dgvContactos.Columns[0].HeaderText = "ID";
            dgvContactos.Columns[5].Width = 80;
            dgvContactos.Columns[5].HeaderText = "Categorías";
            dgvContactos.Columns[3].Width = 80;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = null;
            dgvContactos.Rows.Clear();
        }

        private void frmBuscarContactos_Load(object sender, EventArgs e)
        {          
        }
    }
}
