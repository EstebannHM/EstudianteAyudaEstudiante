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
    public partial class frmAnadirPregunta : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";

        public frmAnadirPregunta()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAnadirPregunta_Click(object sender, EventArgs e)
        {

            //Esto es un array pra juntar todos los text box de el forms
            TextBox[] textBoxFormulario = { txtPregunta, txtTitulo };
            //Todos los campos tienen qe estar llenos si o si para poder continuar
            //Esto fue hecho con ayuda de internet ya que no sabiamso como hacerlo
            if (textBoxFormulario.Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)))
            {
                MessageBox.Show("Todos los campos deben de ser llenados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string pregunta = txtPregunta.Text;
                string titulo = txtTitulo.Text;
                int IdPregunta = GenerarIdPregunta();
                this.Hide();

                GuardarPregunta(pregunta, titulo, IdPregunta);
            }

        }

        private void GuardarPregunta(string pregunta, string titulo, int IdPregunta)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                string queryForoPregunta = "INSERT INTO ForoPregunta (IdPregunta, Titulo, Pregunta) VALUES (@IdPregunta, @Titulo, @Pregunta);";

                SqlCommand comandoPregunta = new SqlCommand(queryForoPregunta, connection);

                comandoPregunta.Parameters.AddWithValue("@IdPregunta", IdPregunta);
                comandoPregunta.Parameters.AddWithValue("@Titulo", titulo);
                comandoPregunta.Parameters.AddWithValue("@Pregunta", pregunta);
                comandoPregunta.ExecuteNonQuery();

            }
        }

        public int GenerarIdPregunta()
        {
            int IdPregunta = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(IdPregunta) FROM ForoPregunta";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        IdPregunta = Convert.ToInt32(result);
                        IdPregunta++;
                    }
                }
            }
            return IdPregunta;
        }

    }
}
