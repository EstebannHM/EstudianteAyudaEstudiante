using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Estudiante : Usuario
    {

        public bool Activo { get; set; }

        public Estudiante()
        {

        }


        public Estudiante(string nombre, string apellido1, string apellido2, string correoElectronico, string pin, string contrasenna, string confirmarContrasenna, int id)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            CorreoElectronico = correoElectronico;
            Pin = pin;
            Contrasenna = contrasenna;
            Id = id;
        }

    }
}