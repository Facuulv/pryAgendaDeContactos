using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace pryAgendaDeContactos
{
    internal class clsConexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsConexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BaseDatos/Contactos.accdb;";
        }
        public void ListarContactos(TreeView tvContactos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Nombre FROM Contactos";
                conexion.Open();

                //Ejecuta la consulta y devuelve el datareader con los resultados
                OleDbDataReader reader = comando.ExecuteReader();
                tvContactos.Nodes.Clear();
                // Mientras lea cada registro
                while (reader.Read())
                {
                    string contacto = reader["Nombre"].ToString();
                    tvContactos.Nodes.Add(contacto);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarContactos(DataGridView dgvContactos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Contactos ORDER BY id_Contacto";

                DataTable tablaContactos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaContactos);

                dgvContactos.DataSource = tablaContactos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AgregarContacto(string nom, string ape, string telefono, string correo, int cate)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, id_Categoria) VALUES (?, ?, ?, ?, ?)";

                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Apellido", ape);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@id_Categoria", cate);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el contacto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificarContacto(string nom, string ape, string tel, string correo, int cate, int cod)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Contactos SET Nombre = ?, Apellido = ?, Telefono = ?, Correo = ?, id_Categoria = ? WHERE id_Contacto = ?";

                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Apellido", ape);
                comando.Parameters.AddWithValue("@Telefono", tel);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@id_Categoria", cate);
                comando.Parameters.AddWithValue("@id_Contacto", cod);

                conexion.Open();
                //Ejecuta la consulta, si es mayor a 0 es porque encontró y modifico sino sale x el else
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Se ha modificado el contacto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EliminarContacto(int cod)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM Contactos WHERE id_Contacto = ?";

                comando.Parameters.AddWithValue("@id_Contacto", cod);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el contacto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool VerificarContacto(string nombre, string ape)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM Contactos WHERE Nombre = @Nombre AND Apellido = @Apellido";
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", ape);

                conexion.Open();
                int contador = (int)comando.ExecuteScalar();
                return contador > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return false;
            }
        }
        public void AgregarCategorias(string cate)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Categorias (Categoria) VALUES (?)";

                comando.Parameters.AddWithValue("@Nombre", cate);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado la categoría", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool VerificarCate(string cate)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM Categorias WHERE Categoria = @Categoria";
                comando.Parameters.AddWithValue("@Categoria", cate);

                conexion.Open();
                int contador = (int)comando.ExecuteScalar();
                return contador > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return false;
            }
        }
        public void CargarCategorias(ComboBox cmbCategorias)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT id_Categoria, Categoria FROM Categorias";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbCategorias.DataSource = dt;
                            cmbCategorias.DisplayMember = "Categoria";
                            cmbCategorias.ValueMember = "id_Categoria";
                            //cmbCategorias.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ContactosPorCat(ListBox lstContactos, int cod)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Nombre FROM Contactos WHERE id_Categoria = @id_Categoria";
                comando.Parameters.AddWithValue("@id_Categoria", cod);
                conexion.Open();

                //Ejecuta la consulta y devuelve el datareader con los resultados
                OleDbDataReader reader = comando.ExecuteReader();
                lstContactos.Items.Clear();
                // Mientras lea cada registro
                while (reader.Read())
                {
                    string contacto = reader["Nombre"].ToString();
                    lstContactos.Items.Add(contacto);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable DatosContacto(string nombre)
        {
            DataTable tablaContacto = new DataTable();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT id_Contacto, Nombre, Apellido, Telefono, Correo, id_Categoria FROM Contactos WHERE Nombre = @Nombre";
                comando.Parameters.AddWithValue("@Nombre", nombre);
                conexion.Open();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaContacto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del contacto: " + ex.Message);
            }
            return tablaContacto;
        }
    }
}
