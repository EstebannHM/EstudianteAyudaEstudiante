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
    public partial class frmCambiarContrasenna : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";

        public frmCambiarContrasenna()
        {
            InitializeComponent();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string NuevaContrasenna = txtNuevaContrasenna.Text;
            string ConfirmarContrasenna = txtConfirmarContrasenna.Text;
            string Contrasenna = DatosUsuarioIniciado.Contrasenna;
            string Id = DatosUsuarioIniciado.Id.ToString();

            //Se crea un array con todos los textbox dentro
            TextBox[] textBoxFormulario = { txtConfirmarContrasenna, txtContrasennaActual, txtNuevaContrasenna};
            //Creamos la condicional para que el usuario tenga que si o si agregar algo en todos los espacios
            //Esto fue creado con ayuda de internet ya que no sabiamos como hacerlo
            if (textBoxFormulario.Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)))
            {
                MessageBox.Show("Todos los campos deben de ser llenados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Contrasenna == txtContrasennaActual.Text)
                {

                    if (NuevaContrasenna != ConfirmarContrasenna)
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                        return;
                    }

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "UPDATE Usuario SET Contrasenna = @NuevaContrasenna WHERE Id = @Id";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@NuevaContrasenna", NuevaContrasenna);
                                command.Parameters.AddWithValue("@Id", Id);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Contraseña cambiada exitosamente");
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún usuario con el PIN proporcionado");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cambiar la contraseña: {ex.Message}");
                    }
                }
            }
        }
    }
}
