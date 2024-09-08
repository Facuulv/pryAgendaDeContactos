﻿using System;
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
            frmMyEContactos MyEContactos = new frmMyEContactos(this);
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

        private void tvContactos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string contactoSelec = e.Node.Text;
            // Si no esta vacio quiere decir que se selecciono un nodo (contacto)
            if (!string.IsNullOrEmpty(contactoSelec))
            {
                DataTable datosContacto = ObjPrincipal.DatosContacto(contactoSelec);

                if (datosContacto.Rows.Count > 0)
                {
                    // Esta es la fila donde tengo todos los datos del contacto selec.
                    DataRow fila = datosContacto.Rows[0];
                    lblNombre.Text = fila["Nombre"].ToString();
                    lblApellido.Text = fila["Apellido"].ToString();
                    lblTelefono.Text = fila["Telefono"].ToString();
                    lblCorreo.Text = fila["Correo"].ToString();
                    lblRelacion.Text = fila["Categoria"].ToString();
                }else
                {
                    MessageBox.Show("No se encontraron datos para el contacto seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void ActualizarContactos()
        {
            clsConexionBD conexionBD = new clsConexionBD();
            conexionBD.ListarContactos(tvContactos);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarContactos();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarContactos Buscar = new frmBuscarContactos();
            Buscar.ShowDialog();
        }
    }
}
