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
    public partial class frmEditarPerfil : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        public frmEditarPerfil()
        {
            InitializeComponent();
            CargarDatosTextBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();

            //Esto es un array pra juntar todos los text box de el forms
            TextBox[] textBoxFormulario = { txtNombre, txtSegundoApellido, txtPrimerApellido, txtCorreoElectronico };
            //Condicional para verificar si hay textbox vacios, de lo contrario con que halla uno con texto, los cambios se habran guardado por que el metodo que hay abajo se habra ejecutado
            if (textBoxFormulario.All(textBox => string.IsNullOrWhiteSpace(textBox.Text)))
            {
                MessageBox.Show("Error al actualizar sus datos, campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Los cambios se han guardado con éxito");
            }

        }
        //Creamos un metodo para actualizar los datos, el cual recorre uno por uno todos los textbox, de esta manera haciendo la consulta textbox por textbox
        private void ActualizarDatos()
        {
            if (txtNombre.Text != string.Empty)
            {

                string Nombre = txtNombre.Text;
                string Id = DatosUsuarioIniciado.Id.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Usuario SET Nombre = @Nombre WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Id", Id);
                    DatosUsuarioIniciado.Nombre = Nombre;   

                    command.ExecuteNonQuery();
                }
            }

            if (txtPrimerApellido.Text != string.Empty)
            {

                string PrimerApellido = txtPrimerApellido.Text;
                string Id = DatosUsuarioIniciado.Id.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Usuario SET Apellido1 = @PrimerApellido WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                    command.Parameters.AddWithValue("@Id", Id);
                    DatosUsuarioIniciado.Apellido1 = PrimerApellido;

                    command.ExecuteNonQuery();
                }
            }

            if (txtSegundoApellido.Text != string.Empty)
            {

                string SegundoApellido = txtSegundoApellido.Text;
                string Id = DatosUsuarioIniciado.Id.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Usuario SET Apellido2 = @SegundoApellido WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                    command.Parameters.AddWithValue("@Id", Id);
                    DatosUsuarioIniciado.Apellido2 = SegundoApellido;

                    command.ExecuteNonQuery();
                }
            }

            if (txtCorreoElectronico.Text != string.Empty)
            {

                if (VerificacionCorreoExistente(txtCorreoElectronico.Text))
                {
                    MessageBox.Show("El correo electrónico ya está en uso", "Correo electrónico en uso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };

                string CorreoElectronico = txtCorreoElectronico.Text;
                string Id = DatosUsuarioIniciado.Id.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Usuario SET CorreoElectronico = @CorreoElectronico WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                    command.Parameters.AddWithValue("@Id", Id);
                    DatosUsuarioIniciado.CorreoElectronico = CorreoElectronico;

                    command.ExecuteNonQuery();
                }
            }
        }

        //Usamos la propiedad placeholder para ponerle al usuario los datos actuales que el tiene
        private void CargarDatosTextBox()
        {
            txtNombre.PlaceholderText = DatosUsuarioIniciado.Nombre;
            txtPrimerApellido.PlaceholderText = DatosUsuarioIniciado.Apellido1;
            txtSegundoApellido.PlaceholderText = DatosUsuarioIniciado.Apellido2;
            txtCorreoElectronico.PlaceholderText = DatosUsuarioIniciado.CorreoElectronico;
        }

        private bool VerificacionCorreoExistente(string correoElectronico)
        {
            string query = "SELECT COUNT(*) FROM Usuario WHERE CorreoElectronico = @CorreoElectronico";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);

                connection.Open();
                int conteo = (int)command.ExecuteScalar();

                return conteo > 0;
            }
        }

    }
}
