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
    public partial class frmRegistro : Form
    {

        CapaDatosEstudiante cdEstudiate = new CapaDatosEstudiante();

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        public frmRegistro()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtContrasenna.PlaceholderText = "Entre 8 y 16 caractaretes";
        }


        private void lklIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInicioSesion ventanaInicioSesion = new frmInicioSesion();
            ventanaInicioSesion.Show();
            this.Hide();
        }


        private void lklTerminosCondiciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTerminosYCondiciones ventanaTerminosYCondiciones = new frmTerminosYCondiciones();
            ventanaTerminosYCondiciones.Show();
        }


        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            AgregarEstudiante();
        }


        private void AgregarEstudiante()
        {
            //Esto es un array pra juntar todos los text box de el forms
            TextBox[] textBoxFormulario = { txtNombre, txtSegundoApellido, txtPrimerApellido, txtPin, txtCorreoElectronico, txtContrasenna, txtConfirmeSuContrasenna };
            //Todos los campos tienen qe estar llenos si o si para poder continuar
            //Esto fue hecho con ayuda de internet ya que no sabiamso como hacerlo
            if (textBoxFormulario.Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)))
            {
                MessageBox.Show("Todos los campos deben de ser llenados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Que la contrasena tenga entre 8 y 16 caracteres
                if (txtContrasenna.Text.Length >= 8 && txtContrasenna.Text.Length <= 16)
                {
                    //Si el campo de contrasena y confirmarcontrasena no coinciden
                    if (txtContrasenna.Text != txtConfirmeSuContrasenna.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Aceptar los terminos
                    else if (ckbAcepto.Checked)
                    {
                        //Metodo de verificar el correo electronico si ya existe no lo dejara registrarlo
                        if (VerificacionCorreoExistente(txtCorreoElectronico.Text))
                        {
                            MessageBox.Show("El correo electrónico ya está registrado", "Correo electrónico duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        };

                        frmInicioSesion ventanaInicioSesion = new frmInicioSesion();
                        ventanaInicioSesion.Show();
                        this.Hide();
                        MessageBox.Show("¡Te has registrado con exito!", "Registro");

                        Estudiante nuevoEstudiante = new Estudiante
                        {
                            Id = cdEstudiate.ConsultarIdNuevoEstudiante(),
                            Nombre = txtNombre.Text,
                            Apellido1 = txtPrimerApellido.Text,
                            Apellido2 = txtSegundoApellido.Text,
                            CorreoElectronico = txtCorreoElectronico.Text,
                            Contrasenna = txtContrasenna.Text,
                            Pin = txtPin.Text,
                            Activo = true,
                        };

                        cdEstudiate.CrearEstudiante(nuevoEstudiante);

                    }
                    else
                    {
                        MessageBox.Show("Usted debe de aceptar los terminos y condiciones antes de continuar", "Terminos y condiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe tener entre 8 y 16 caracteres", "Longitud de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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