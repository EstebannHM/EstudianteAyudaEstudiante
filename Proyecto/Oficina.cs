using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Oficina
    {
        public string Universidad { get; set; }
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public string CorreoContacto { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }

        public Oficina()
        {
        }

        public Oficina(string universidad, string nombre, string horario, string correoContacto, string ubicacion, string telefono)
        {
            Universidad = universidad;
            Nombre = nombre;
            Horario = horario;
            CorreoContacto = correoContacto;
            Ubicacion = ubicacion;
            Telefono = telefono;
        }
    }
}
