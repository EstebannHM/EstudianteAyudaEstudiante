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
    public partial class frmInicioSesion : Form
    {
        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        public frmInicioSesion()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void lklRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro ventanaRegistro = new frmRegistro();
            ventanaRegistro.Show();
            this.Hide();
        }

        private void lklOlvidarContrasenna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOlvidarContraseña ventanaOlvidarContrasenna = new frmOlvidarContraseña();
            ventanaOlvidarContrasenna.Show();
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            AutenticarUsuario();
        }

        private void pbxMostrar_Click(object sender, EventArgs e)
        {
            pbxOcultar.BringToFront();
            txtContrasenna.PasswordChar = '\0';
        }

        private void pbxOcultar_Click(object sender, EventArgs e)
        {
            pbxMostrar.BringToFront();
            txtContrasenna.PasswordChar= '*';
        }

        private void AutenticarUsuario()
        {
            string CorreoElectronico = txtCorreoElectronico.Text;
            string Contrasenna = txtContrasenna.Text;

            string queryUsuario = "SELECT COUNT(*) FROM Usuario WHERE CorreoElectronico = @CorreoElectronico AND Contrasenna = @Contrasenna";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryUsuario, connection);
                command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                command.Parameters.AddWithValue("@Contrasenna", Contrasenna);

                connection.Open();

                int conteo = (int)command.ExecuteScalar();

                if (conteo > 0)
                {

                    string queryInfoUsuario = "SELECT Pin, Nombre, Apellido1, Apellido2, Id FROM Usuario WHERE CorreoElectronico = @CorreoElectronico AND Contrasenna = @Contrasenna";

                    command = new SqlCommand(queryInfoUsuario, connection);
                    command.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico);
                    command.Parameters.AddWithValue("@Contrasenna", Contrasenna);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        string Pin = reader.GetString(0);
                        string Nombre = reader.GetString(1);
                        string Apellido1 = reader.GetString(2);
                        string Apellido2 = reader.GetString(3);
                        int Id = reader.GetInt32(4);

                        //Almacenamos los datos del usuario en la clase estatica que tenemos creada, para asi poder almanacenar en memoria los datos del usuario iniciado
                        DatosUsuarioIniciado.Nombre = Nombre;
                        DatosUsuarioIniciado.Apellido1 = Apellido1;
                        DatosUsuarioIniciado.Apellido2 = Apellido2;
                        DatosUsuarioIniciado.Pin = Pin;
                        DatosUsuarioIniciado.CorreoElectronico = CorreoElectronico;
                        DatosUsuarioIniciado.Contrasenna = Contrasenna;
                        DatosUsuarioIniciado.Id = Id;

                        
                        frmPantallaPrincipal ventanaPantallaPrincipal = new frmPantallaPrincipal();
                        ventanaPantallaPrincipal.Show();
                        this.Hide();
                        MessageBox.Show("Has iniciado sesión");
                    }
                }
                else
                {
                    MessageBox.Show("El correo electrónico o la contraseña ingresados son incorrectos.");
                }

                connection.Close();
            }
        }
    }
}
