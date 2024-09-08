using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace pryAgendaDeContactos
{
    public class clsExportarContactos
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsExportarContactos()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BaseDatos/Contactos.accdb;";
        }
        public DataTable ObtenerContactos()
        {
            DataTable tablaContactos = new DataTable();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT Nombre, Apellido, Telefono, Correo FROM Contactos";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    conexion.Open();
                    adaptador.Fill(tablaContactos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tablaContactos;
        }
        public void ExportarCsv(DataTable tablaContactos)
        {
            try
            {
                // Obtiene la ruta de la carpeta del proyecto (bin/Debug o bin/Release)
                string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;

                // Ruta y nombre de archivo
                string rutaArchivo = Path.Combine(rutaProyecto, "Contactos.csv");

                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    // Escribe los encabezados de las columnas y luego agrega comas
                    foreach (DataColumn columna in tablaContactos.Columns)
                    {
                        writer.Write(columna.ColumnName + ",");
                    }
                    writer.WriteLine();

                    // Rellena con los datos
                    foreach (DataRow fila in tablaContactos.Rows)
                    {
                        for (int i = 0; i < tablaContactos.Columns.Count; i++)
                        {
                            writer.Write(fila[i].ToString() + ",");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show($"Archivo exportado exitosamente en: {rutaArchivo}", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar el archivo CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExportarVCard(DataTable tablaContactos)
        {
            try
            {
                string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;
                string rutaArchivo = Path.Combine(rutaProyecto, "ContactosVCard.vcf");
                StringBuilder archivoVCard = new StringBuilder();

                foreach (DataRow fila in tablaContactos.Rows)
                {
                    archivoVCard.AppendLine("BEGIN:VCARD");
                    archivoVCard.AppendLine("VERSION:3.0");
                    archivoVCard.AppendLine($"FN:{fila["Nombre"]} {fila["Apellido"]}");
                    archivoVCard.AppendLine($"TEL:{fila["Telefono"]}");
                    archivoVCard.AppendLine($"EMAIL:{fila["Correo"]}");
                    archivoVCard.AppendLine("END:VCARD");
                    archivoVCard.AppendLine();  // Espacio entre vCards
                }

                // Guarda el archivo
                File.WriteAllText(rutaArchivo, archivoVCard.ToString());
                MessageBox.Show($"Archivo exportado exitosamente en: {rutaArchivo}", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a vCard: " + ex.Message);
            }
        }
    }   
}
