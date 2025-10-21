using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CapaDatosTutoria
    {
        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        //Creamos una lista para agregar todas las tutorias aun DGV
        public List<Tutoria> GetTutorias()
        {
            List<Tutoria> Tutorias = new List<Tutoria>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryTutorias = "SELECT Id, Materia, Fecha, Descripcion, Tutor, Contacto FROM Tutoria";

                using (SqlCommand command = new SqlCommand(queryTutorias, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Usamos el objeto creado arriba "reader" para poder leer todas las columnas en la base de datos
                        while (reader.Read())
                        {
                            Tutorias.Add(new Tutoria
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Materia = reader["Materia"].ToString(),
                                Fecha = reader["Fecha"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Tutor = reader["Tutor"].ToString(),
                                Contacto = reader["Contacto"].ToString(),
                            });
                        }
                    }
                }
            }

            return Tutorias;
        }

        public int CrearIdTutoria()
        {
            int Id = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Id) FROM Tutoria";

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
