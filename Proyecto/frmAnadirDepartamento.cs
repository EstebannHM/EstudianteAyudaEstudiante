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
using System.IO;
using System.Drawing.Imaging;

namespace Proyecto
{
    public partial class frmAnadirDepartamento : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        public frmAnadirDepartamento()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //Creamos la condicional que el usuario ingrese si o si una imagen
            if (pbxImagenDepartamento.Image != null)
            {
                //Se crea un array con todos los textbox dentro
                TextBox[] textBoxFormulario = { txtBanos, txtCuartos, txtInformacion, txtlNumeroContacto, txtMetrosCuadrados, txtPrecio, txtUbicacion };
                //Creamos la condicional para que el usuario tenga que si o si agregar algo en todos los espacios
                //Esto fue creado con ayuda de internet ya que no sabiamos como hacerlo
                if (textBoxFormulario.Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)))
                {
                    MessageBox.Show("Todos los campos deben de ser llenados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Usamos el memory stream para guardar la imagen que este en memoria en ese momento
                    MemoryStream ms = new MemoryStream();
                    pbxImagenDepartamento.Image.Save(ms, ImageFormat.Jpeg);
                    //Esto devuelve todo en un arreglo de bytes para poder almacenarlo
                    byte[] aByte = ms.ToArray();

                    Departamento departamento = new Departamento
                    {

                        Codigo = CodigoDepartamento(),
                        Ubicacion = txtUbicacion.Text,
                        Informacion = txtInformacion.Text,
                        Precio = txtPrecio.Text,
                        Cuarto = txtCuartos.Text,
                        Banno = txtBanos.Text,
                        MetroCuadrado = txtMetrosCuadrados.Text,
                        NumeroContacto = txtlNumeroContacto.Text,

                    };

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        connection.Open();

                        string queryDepartamento = "INSERT INTO Departamento (Codigo, Ubicacion, Informacion, Precio, Cuarto, Banno, MetroCuadrado, NumeroContacto, Imagen) VALUES (@Codigo, @Ubicacion, @Informacion, @Precio, @Cuarto, @Banno, @MetroCuadrado, @NumeroContacto, @Imagen);";

                        SqlCommand comandoUsuario = new SqlCommand(queryDepartamento, connection);

                        comandoUsuario.Parameters.AddWithValue("@Codigo", departamento.Codigo);
                        comandoUsuario.Parameters.AddWithValue("@Ubicacion", departamento.Ubicacion);
                        comandoUsuario.Parameters.AddWithValue("@Informacion", departamento.Informacion);
                        comandoUsuario.Parameters.AddWithValue("@Precio", departamento.Precio);
                        comandoUsuario.Parameters.AddWithValue("@Cuarto", departamento.Cuarto);
                        comandoUsuario.Parameters.AddWithValue("@Banno", departamento.Banno);
                        comandoUsuario.Parameters.AddWithValue("@MetroCuadrado", departamento.MetroCuadrado);
                        comandoUsuario.Parameters.AddWithValue("@NumeroContacto", departamento.NumeroContacto);
                        comandoUsuario.Parameters.AddWithValue("@Imagen", aByte);

                        comandoUsuario.ExecuteNonQuery();

                    }

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una imagen obligatoriamente");
            }

        }

        private void btnCargarImgen_Click(object sender, EventArgs e)
        {
            //Cuadro de dialogo para agregar la imagen
            OpenFileDialog dialogo = new OpenFileDialog();

            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                pbxImagenDepartamento.Image = Image.FromFile(dialogo.FileName);
            }

        }


        public int CodigoDepartamento()
        {
            int Codigo = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Codigo) FROM Departamento";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        Codigo = Convert.ToInt32(result);
                        Codigo++;
                    }
                }
            }
            return Codigo;
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            pbxImagenDepartamento.Image = null;
        }
    }
}
