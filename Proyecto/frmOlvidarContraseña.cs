using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Proyecto
{
    public partial class frmOlvidarContraseña : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";

        public frmOlvidarContraseña()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnFlechaDevolverse_Click(object sender, EventArgs e)
        {
            frmInicioSesion ventanaInicioSesion = new frmInicioSesion();
            ventanaInicioSesion.Show();
            this.Hide();
        }

        private void btnCambiarContrasenna_Click(object sender, EventArgs e)
        {
            ActualizarContrasenna();
        }

        private bool VerificacionCredenciales()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string CorreoElectronico = txtCorreoElectronico.Text;
                string Pin = txtPinUnicoUsuario.Text;

                string query = "SELECT COUNT(*) FROM Usuario WHERE CorreoElectronico = @CorreoElectronico AND Pin = @Pin";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                command.Parameters.AddWithValue("@Pin", Pin);

                int conteo = (int)command.ExecuteScalar();

                return conteo > 0;

            }
        }

        private void ActualizarContrasenna()
        {

            if (VerificacionCredenciales())
            {

                if (txtNuevaContrasenna.Text == txtConfirmeSuNuevaContraseña.Text)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        string CorreoElectronico = txtCorreoElectronico.Text;
                        string NuevaContrasenna = txtNuevaContrasenna.Text;

                        string query = "UPDATE Usuario SET Contrasenna = @NuevaContrasenna WHERE CorreoElectronico = @CorreoElectronico";
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                        command.Parameters.AddWithValue("@NuevaContrasenna", NuevaContrasenna);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Su contrasena se ha restaurado");
                        frmInicioSesion ventanaInicioSesion = new frmInicioSesion();
                        ventanaInicioSesion.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Las contrasenas nuevas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Las credenciales proporcionadas son incorrectas.");
            }
        }

    }
}
