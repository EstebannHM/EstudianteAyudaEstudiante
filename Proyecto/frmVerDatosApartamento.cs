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
    public partial class frmVerDatosApartamento : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";

        public static int CodigoDepartamentoSeleccionado;

        public frmVerDatosApartamento()
        {
            InitializeComponent();
            CargarDatosDepartamento();
            this.CenterToScreen();
        }

        private void CargarDatosDepartamento()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Hacemos el query pidiendo la informacion a base de datos
                string queryInfoDepartamento = "SELECT Ubicacion, Informacion, Precio, Cuarto, Banno, MetroCuadrado, NumeroContacto, Imagen FROM Departamento WHERE Codigo = @Codigo";
                SqlCommand command = new SqlCommand(queryInfoDepartamento, connection);

                //Le damos el parametro basandonos en el codigo del departamento seleccionado el cual es una variable estatica que creamos y se la pasamos en el form anterior a este
                command.Parameters.AddWithValue("@Codigo", CodigoDepartamentoSeleccionado);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //Leemos todas las columnas
                    string ubicacion = reader["Ubicacion"].ToString();
                    string informacion = reader["Informacion"].ToString();
                    string precio = reader["Precio"].ToString();
                    string cuarto = reader["Cuarto"].ToString();
                    string banno = reader["Banno"].ToString();
                    string metroCuadrado = reader["MetroCuadrado"].ToString();
                    string numeroContacto = reader["NumeroContacto"].ToString();
                    byte[] imagenBD = (byte[])reader["Imagen"];

                    //Asignamos los valores a las columunas
                    txtUbicacion.Text = ubicacion;
                    txtInformacion.Text = informacion;
                    txtPrecio.Text = precio;
                    txtCuarto.Text = cuarto;
                    txtBanno.Text = banno;
                    txtMetroCuadrado.Text = metroCuadrado;
                    txtNumeroContacto.Text = numeroContacto;

                    using (MemoryStream ms = new MemoryStream(imagenBD))
                    {
                        Image imagen = Image.FromStream(ms);
                        pbxImagenDepartamento.Image = imagen; // Asignar la imagen al PictureBox
                    }

                } reader.Close();
            }
        }
    }
}
