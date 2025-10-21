using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CapaDatosEstudiante
    {
        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        public void CrearEstudiante(Estudiante estudiante)
        {
            CapaDatosUsuario cdUsuario = new CapaDatosUsuario();
            cdUsuario.CrearUsuario(estudiante);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryEstudiante = "INSERT INTO Estudiante (Id, Activo) VALUES (@Id, @Activo)";

                using (SqlCommand command = new SqlCommand(queryEstudiante, connection))
                {
                    command.Parameters.AddWithValue("@Id", estudiante.Id);
                    command.Parameters.AddWithValue("@Activo", estudiante.Activo);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }

        public int ConsultarIdNuevoEstudiante()
        {
            CapaDatosUsuario cdUsuario = new CapaDatosUsuario();
            return cdUsuario.ConsultarIdNuevoUsuario();
        }


    }
}
