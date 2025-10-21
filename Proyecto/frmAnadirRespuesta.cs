using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmAnadirRespuesta : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";

        public static int IdPregunta;

        public frmAnadirRespuesta()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAnadirRespuesta_Click(object sender, EventArgs e)
        {
            if (rtbRespuesta.Text == string.Empty)
            {
                MessageBox.Show("Debe de agregar una respuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();

                string respuesta = rtbRespuesta.Text;
                int IdRespuesta = GenerarIdRespuesta();

                GuardarRespuesta(respuesta, IdRespuesta);
                GuardarRelacionPreguntaRespuesta(IdRespuesta);
            }
        }

        //Esto es para poder relacionar las preguntas segun la respuesta, de esta manera una pregunta puede tener muchas respuestas
        private void GuardarRelacionPreguntaRespuesta(int IdRespuesta)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO RespuestaxPregunta (IdPregunta, IdRespuesta) VALUES (@IdPregunta, @IdRespuesta)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdPregunta", IdPregunta);
                command.Parameters.AddWithValue("@IdRespuesta", IdRespuesta);

                command.ExecuteNonQuery();
            }
        }

        private void GuardarRespuesta(string respuesta, int IdRespuesta)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                string queryForoPregunta = "INSERT INTO ForoRespuesta (IdRespuesta, Respuesta) VALUES (@IdRespuesta, @Respuesta);";

                SqlCommand comandoPregunta = new SqlCommand(queryForoPregunta, connection);

                comandoPregunta.Parameters.AddWithValue("@IdRespuesta", IdRespuesta);
                comandoPregunta.Parameters.AddWithValue("@Respuesta", respuesta);
                comandoPregunta.ExecuteNonQuery();

            }
        }

        public int GenerarIdRespuesta()
        {
            int IdRespuesta = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(IdRespuesta) FROM ForoRespuesta";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IdRespuesta = Convert.ToInt32(result);
                        IdRespuesta++;
                    }
                }
            }
            return IdRespuesta;
        }

    }
}
