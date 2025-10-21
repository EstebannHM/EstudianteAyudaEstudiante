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
    public partial class frmCrearTutoria : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";

        CapaDatosTutoria cdTutoria = new CapaDatosTutoria();    

        public frmCrearTutoria()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            AgregarTutoria();
        }

        private void AgregarTutoria()
        {
            //Se crea un array con todos los textbox
            TextBox[] textBoxFormulario = { txtContacto, txtFecha, txtMateria, txtTutor };
            //Condicional para que el usuario tenga que si o si llenar todos los espacios
            if (textBoxFormulario.Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)))
            {
                MessageBox.Show("Todos los campos deben de ser llenados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Tutoria tutoria = new Tutoria
                {

                    Materia = txtMateria.Text,
                    Fecha = txtFecha.Text,
                    Tutor = txtTutor.Text,
                    Contacto = txtContacto.Text,
                    Descripcion = rtbDescripcion.Text,


                };

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    string queryTutoria = "INSERT INTO Tutoria (Materia, Fecha, Descripcion, Contacto, Tutor, Id) VALUES (@Materia, @Fecha, @Descripcion, @Contacto, @Tutor, @Id);";

                    SqlCommand comandoTutoria = new SqlCommand(queryTutoria, connection);

                    comandoTutoria.Parameters.AddWithValue("@Materia", tutoria.Materia);
                    comandoTutoria.Parameters.AddWithValue("@Fecha", tutoria.Fecha);
                    comandoTutoria.Parameters.AddWithValue("@Tutor", tutoria.Tutor);
                    comandoTutoria.Parameters.AddWithValue("@Descripcion", tutoria.Descripcion);
                    comandoTutoria.Parameters.AddWithValue("@Contacto", tutoria.Contacto);
                    comandoTutoria.Parameters.AddWithValue("@Id", cdTutoria.CrearIdTutoria());

                    comandoTutoria.ExecuteNonQuery();

                }
                MessageBox.Show("Se ha publicado tu tutoria." , "Publicación con éxito");
            }
        }
    }
}
