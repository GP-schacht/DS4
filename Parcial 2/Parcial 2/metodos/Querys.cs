using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;

namespace Parcial_2.metodos
{
    internal class Querys
    {

        public void CargarMedicamentos(ComboBox cbMed)
        {
            {

                using (var cnx = new Conexion())
                {
                    try
                    {
                        var conexion = cnx.Conectar();
                        string query = "SELECT nombre FROM medicamentos"; // Cambia 'medicamentos' según tu tabla

                        using (var command = new NpgsqlCommand(query, conexion))
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar el nombre del medicamento al ComboBox
                                cbMed.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar medicamentos: {ex.Message}");
                    }
                }
            }
        }

        public void Stock(DataGridView dgv)
        {
            using (var cnx = new Conexion())
            {
                try
                {
                    var conexion = cnx.Conectar();
                    string query = "SELECT * FROM medicamentos"; // Cambia 'medicamentos' según tu tabla

                    using (var command = new NpgsqlCommand(query, conexion))
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgv.DataSource = dataTable; // Asigna el DataTable como fuente de datos
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar medicamentos: {ex.Message}");
                }

            }
        }

        public void Add(string nombre, int cantidad, double precio)
        {
            using (var cnx = new Conexion())
            {
                try
                {
                    string query;
                    var conexion = cnx.Conectar();
                 
                         query = "INSERT INTO medicamentos (nombre, cantidad, precio) VALUES (@Nombre, @Cantidad, @Precio)";
                    
                 
                    using (var command = new NpgsqlCommand(query, conexion))
                    {
                        // Agregar parámetros a la consulta
                       
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@Precio", precio);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar medicamento: {ex.Message}");
                }

            }
        }

        public void Mod(string nombre1, string nombre2, int cantidad, double precio)
        {
            using (var cnx = new Conexion())
            {
                try
                {

                    var conexion = cnx.Conectar();

                    string query = "UPDATE medicamentos SET nombre = @NuevoNombre, cantidad = @Cantidad, precio = @Precio WHERE nombre = @NombreOriginal";

                    using (var command = new NpgsqlCommand(query, conexion))
                    {
                        // Agregar parámetros a la consulta
                        command.Parameters.AddWithValue("@NuevoNombre", nombre2);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@NombreOriginal", nombre1);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar medicamento: {ex.Message}");
                }

            }
        }
        public void Transact(string nombre, int cantidad, int stock, int fn)
        {
            using (var cnx = new Conexion())
            {
                try
                {
                    var conexion = cnx.Conectar();
                    
                    cantidad = fn == 0 ? stock + cantidad : stock - cantidad;

                    string query = "UPDATE medicamentos SET cantidad = @Cantidad WHERE nombre = @Nombre"; 

                    using (var command = new NpgsqlCommand(query, conexion))
                    {
                        
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Transaccionar medicamento: {ex.Message}");
                }
            }
        }


        public void GetCantidad(ComboBox cbox, out int? cantidad)
        {
            using (var DB = new Conexion())
            {
                try
                {
                    string query = "SELECT cantidad FROM medicamentos WHERE nombre = @Nombre";
                    var conexion = DB.Conectar();
                    cantidad = null;

                    using (var cmd = new NpgsqlCommand(query, conexion))
                    {
                        // Agregar parámetros a la consulta
                        cmd.Parameters.AddWithValue("@Nombre", cbox.SelectedItem.ToString());
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            cantidad = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el medicamento.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    cantidad = null;
                    MessageBox.Show($"Error al consultar stock: {ex.Message}");
                }
            }
        }


    }
}
