using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CapaDatosProducto
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";        
        //Generar el id del producto
        public int CrearIdProducto()
        {
            int Id = 1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Id) FROM Producto";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        Id = Convert.ToInt32(result);
                        Id++;
                    }
                }
            }
            return Id;
        }
        //Para llenar el control de usario
        public void LlenarMarketplace(FlowLayoutPanel Contenedor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                Producto producto = new Producto();

                connection.Open();

                string query = "SELECT Id, Nombre, Descripcion, Precio, Contacto, Imagen FROM Producto";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Se leen todos los atributos del producto
                    producto.Id = Convert.ToInt32(reader[0]);
                    producto.Nombre = reader[1].ToString();
                    producto.Descripcion = reader[2].ToString();
                    producto.Precio = reader[3].ToString();
                    producto.Contacto = reader[4].ToString();
                    producto.Imagen = (byte[])reader[5];

                    //Se le asignan los atributos que se leyeron arriba a las propiedades del control de usuario
                    csMarketplace Marketplace = new csMarketplace();
                    Marketplace.Id = producto.Id;
                    Marketplace.NombreProducto = producto.Nombre;
                    Marketplace.PrecioProducto = producto.Precio;
                    Marketplace.DescripcionProducto = producto.Descripcion;
                    Marketplace.ContactoProducto = producto.Contacto;

                    using (MemoryStream ms = new MemoryStream(producto.Imagen))
                    {
                        Image imagen = Image.FromStream(ms);
                        Marketplace.ImagenProducto = imagen; // Asignar la imagen al PictureBox
                    }
                    //Por ultimo se le agregan al control de usuario
                    Contenedor.Controls.Add(Marketplace);

                    //El while se va a repetir y se va a llenar el control de usuario cuando termine de leer
                }
                connection.Close();
            }
        }
    }
}
