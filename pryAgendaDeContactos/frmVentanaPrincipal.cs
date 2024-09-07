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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();            
        }
        clsConexionBD ObjPrincipal = new clsConexionBD();

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarContactos Agregar = new frmAgregarContactos();
            Agregar.Show();
        }

        private void frmVentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsbMyE_Click(object sender, EventArgs e)
        {
            frmMyEContactos MyEContactos = new frmMyEContactos();
            MyEContactos.Show();
        }

        private void agregarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCategorias Categorias = new frmAgregarCategorias();
            Categorias.Show();
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            ObjPrincipal.ListarContactos(tvContactos);
        }
    }
}
