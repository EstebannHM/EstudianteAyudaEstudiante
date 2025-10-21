using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public static class DatosUsuarioIniciado
    {
        //Creamos una variable estatica con el fin de guardar toda la informacion del usuario que inicio sesion y pdoer mantener en memoria las credenciales del mismo
        public static int Id { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido1 { get; set; }
        public static string Apellido2 { get; set; }
        public static string CorreoElectronico { get; set; }
        public static string Pin { get; set; }
        public static string Contrasenna { get; set; }
    }
}
