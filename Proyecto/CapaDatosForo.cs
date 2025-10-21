using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CapaDatosForo
    {
        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        //Guardamos en una variable estatica el Id de la pregunta que selecciono el usuario para asi poder cargar solo esas respuestas a la pregunta
        public static int IdPregunta;
        public void LlenarRespuestas(FlowLayoutPanel Contenedor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                ForoRespuesta respuesta = new ForoRespuesta();

                connection.Open();
                //Se realiza la consulta con la respectiva union de las tablas
                string query = "SELECT Respuesta FROM ForoRespuesta " +
                               "INNER JOIN RespuestaxPregunta ON ForoRespuesta.IdRespuesta = RespuestaxPregunta.IdRespuesta " +
                               "WHERE RespuestaxPregunta.IdPregunta = @IdPregunta";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdPregunta", IdPregunta);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    respuesta.Respuesta = reader[0].ToString();

                    csForoRespuestas ForoRespuestas = new csForoRespuestas();
                    ForoRespuestas.RespuestaForo = respuesta.Respuesta;

                    //Por ultimo se le agregan al control de usuario
                    Contenedor.Controls.Add(ForoRespuestas);
                    //El while se va a repetir y se va a llenar el control de usuario cuando termine de leer
                }
                connection.Close();
            }
        }
    }
}