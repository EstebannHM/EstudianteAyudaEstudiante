using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class CapaDatosOficina
    {
        public List<Oficina> ObtenerOficina()
        {
            List<Oficina> listaOficina = new List<Oficina>
            {
             new Oficina("Universidad de Costa Rica", "Archivo Universitario" ,"L-V/8 am-5pm","aurol@ucr.ac.cr","Carretera a Sabanilla, de la entrada de las Instalaciones Deportivas de la Universidad, 100 m. Este, 600 m. Norte y 50 m. Oeste", "2511-2990"),
             new Oficina("Universidad de Costa Rica","Oficinas de Administracion Financiera","L-V/8am-5pm","Correo", "Ubicacion", "2411-4511"),
             new Oficina("Universidad de Costa Rica","Oficina de Asuntos Internaciones y Cooperacion Externa","L-V/8am-5pm",": oaice.recepcion@ucr.ac.cr", "ubicacion", "2511-5081"),
             new Oficina("Universidad de Costa Rica","Oficina de Becas y Atencion Socioeconomica","L-V/8am-5pm",": becas@ucr.ac.cr.", "", "2511-0000"),
             new Oficina("Universidad de Costa Rica","Oficina de Bienestar y Salud","L-V/6:30am-5pm","administracion.obs@ucr.ac.cr", "Ciudad Universitaria Rodrigo Facio San Pedro de Montes de Oca", "2511-5369"),
             new Oficina("Universidad de Costa Rica","Centro de Evaluacion Academica","L-V/8am-5pm","cea@ucr.ac.cr", "Edificio Administrativo B, Segundo piso.", "2511-1220"),
             new Oficina("Universidad de Costa Rica","Centro de Informatica","L-V/7:30am-5pm","CI5000@UCR.AC.CR", "Ubicacion", "2511-5000"),
             new Oficina("Universidad de Costa Rica","Oficina de Contraloria","L-V/7:30am-4:30pm","contraloria.universitaria@ucr.ac.cr", "Ubicacion", "2511-1433/2511-1418"),
             new Oficina("Universidad de Costa Rica","Oficina de Comunicacion Institucional","L-V/8am-5pm","odi.secretaria@ucr.ac.cr", "Sede Rodrigo Facio Brenes, Montes de Oca, San José, Costa Rica Del Office Depot en San Pedro, 100 metros al norte, casa esquinera.", "2511-1213"),
             new Oficina("Universidad de Costa Rica","Oficina Juridica","L-V/8am-5pm","recepcion.juridica@ucr.ac.cr", ": De la Fundación de la Universidad de Costa Rica para la Investigación, FUNDEVI, 50 metros al Sur y 100 metros al Este, a mano derecha, San Pedro de Montes de Oca, San José, Costa Rica.", "2511-8865"),
             new Oficina("Universidad de Costa Rica","Oficina de Planificacion Universitaria","L-V/8am-5pm","recepcion.oplau@ucr.ac.cr", "Ubicacion", "2511-1155"),
             new Oficina("Universidad de Costa Rica","Oficina de Recuros Humanos","L-V/8am-5pm","orh.vra@ucr.ac.cr", "Ubicacion", "2511-1014"),
             new Oficina("Universidad de Costa Rica","Oficina de Registro e Informacion","L-V/8am-5pm",":  admision.ori@ucr.ac.cr", "Ubicacion", "2511-3652"),
             new Oficina("Universidad de Costa Rica","Oficina de Servicios Generales","L-V/8am-5pm","servicios.generales@ucr.ac.cr", "Ubicacion", "2511-3662"),
             new Oficina("Universidad de Costa Rica","Sistema de Bibliotecas, Documentación e Información (SIBDI)","L-S/7am-8:55pm","sibdi@ucr.ac.cr", "Ubicacion", "2511-8199"),

            };

            return listaOficina;

        }
    }
}
