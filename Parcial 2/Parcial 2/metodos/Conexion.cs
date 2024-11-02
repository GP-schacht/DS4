using Npgsql;
using System;
using System.Windows.Forms;

namespace Parcial_2.metodos
{
    internal class Conexion : IDisposable
    {
        private NpgsqlConnection conexion;
        private bool disposedValue; // Para detectar llamadas redundantes

        private string cdnConexion = "Host=localhost;Port=5432;Username=postgres;Password=HPprint12;Database=FarmaciaDB;";

        public Conexion()
        {
            conexion = new NpgsqlConnection(cdnConexion);
        }

        public NpgsqlConnection Conectar()
        {
            try
            {
                conexion.Open();
                return conexion; // Devolver la conexión abierta
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
                return null;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Liberar recursos administrados
                    if (conexion != null)
                    {
                        conexion.Close();
                        conexion.Dispose();
                    }
                }
                // Liberar recursos no administrados (si los hay)

                disposedValue = true;
            }
        }
    }
}
