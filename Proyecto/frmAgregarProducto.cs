using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmAgregarProducto : Form
    {

        CapaDatosProducto cdProducto = new CapaDatosProducto();

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";

        public frmAgregarProducto()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            //Este condicional es para que el usuario deba de agregar la imagen obligatoriamente
            if (pbxFotoProducto.Image != null)
            {

                //Esto es un array pra juntar todos los text box de el forms
                TextBox[] textBoxFormulario = { txtNombre, txtContacto, txtDescripcion, txtDescripcion };
                //Este condicional es para que el usuario tenga que introducir informacion en todos los textbox
                //Esto fue realizado con ayuda de internet ya que no sabiamos como hacerlo
                if (textBoxFormulario.Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)))
                {
                    MessageBox.Show("Todos los campos deben de ser llenados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Utilizamos el memorystream para poder guardar y la imagen en base de datos
                    MemoryStream ms = new MemoryStream();
                    pbxFotoProducto.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();

                    Producto producto = new Producto
                    {
                        Id = cdProducto.CrearIdProducto(),
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        Precio = txtPrecio.Text,
                        Contacto = txtContacto.Text,
                    };

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        connection.Open();

                        string queryProducto = "INSERT INTO Producto (Nombre, Descripcion, Precio, Id, Contacto, Imagen) VALUES (@Nombre, @Descripcion, @Precio, @Id , @Contacto, @Imagen);";

                        SqlCommand comandoProducto = new SqlCommand(queryProducto, connection);

                        comandoProducto.Parameters.AddWithValue("Id", producto.Id);
                        comandoProducto.Parameters.AddWithValue("Nombre", producto.Nombre);
                        comandoProducto.Parameters.AddWithValue("Descripcion", producto.Descripcion);
                        comandoProducto.Parameters.AddWithValue("Precio", producto.Precio);
                        comandoProducto.Parameters.AddWithValue("Contacto", producto.Contacto);
                        comandoProducto.Parameters.AddWithValue("Imagen", aByte);

                        comandoProducto.ExecuteNonQuery();

                    }

                    MessageBox.Show("Producto agregado correctamene", "Producto agregado");
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una imagen obligatoriamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void btnImagen_Click(object sender, EventArgs e)
        {
            //Esto es el dialogo que se abre para que el usuario pueda seleccionar su imagen
            OpenFileDialog dialogo = new OpenFileDialog();

            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                pbxFotoProducto.Image = new Bitmap(dialogo.FileName);

            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            pbxFotoProducto.Image = null;
        }
    }
}
