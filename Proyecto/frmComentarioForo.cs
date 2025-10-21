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
    public partial class frmComentarioForo : Form
    {
        public static int IdPregunta;

        public frmComentarioForo()
        {
            InitializeComponent();
            this.CenterToScreen();
            MostrarRespuestas();
        }
        //Se crea el metodo de mostrar respuestas para mostrarlas
        private void MostrarRespuestas()
        {
            CapaDatosForo cdForo = new CapaDatosForo();
            //Se llama al metodo desde el objeto creado y se le da el parametro "flpRespuestas" el cual es donde el control de usuario va a cargarse
            cdForo.LlenarRespuestas(flpRespuestas);
        }
        private void btnAnadirRespuesta_Click(object sender, EventArgs e)
        {
            frmAnadirRespuesta ventanaAnadirRespuesta = new frmAnadirRespuesta();
            ventanaAnadirRespuesta.Show();
        }
    }
}
