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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal Principal = new frmVentanaPrincipal();
            Principal.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
