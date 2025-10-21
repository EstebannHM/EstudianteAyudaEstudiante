using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CapaDatosUsuario
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        public void CrearUsuario (Estudiante estudiante)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                string queryUsuario = "INSERT INTO Usuario (Id, Nombre, Apellido1, Apellido2, CorreoElectronico, Pin, Contrasenna) VALUES (@Id, @Nombre, @Apellido1, @Apellido2, @CorreoElectronico, @Pin, @Contrasenna);";

                SqlCommand comandoUsuario = new SqlCommand(queryUsuario, connection);

                comandoUsuario.Parameters.AddWithValue("@Id", estudiante.Id);
                comandoUsuario.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                comandoUsuario.Parameters.AddWithValue("@Apellido1", estudiante.Apellido1);
                comandoUsuario.Parameters.AddWithValue("@Apellido2", estudiante.Apellido2);
                comandoUsuario.Parameters.AddWithValue("@CorreoElectronico", estudiante.CorreoElectronico);
                comandoUsuario.Parameters.AddWithValue("@Contrasenna", estudiante.Contrasenna);
                comandoUsuario.Parameters.AddWithValue("@Pin", estudiante.Pin);

                comandoUsuario.ExecuteNonQuery();

            }
        }


        public int ConsultarIdNuevoUsuario()
        {
            int Id = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Id) FROM Usuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        Id = Convert.ToInt32(result);
                        Id++;
                    }
                }
            }
            return Id;
        }

    }
}
