using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class csForoRespuestas : UserControl
    {
        public csForoRespuestas()
        {
            InitializeComponent();
        }
        //Se realiza el get y set para luego en la capa de datos poder asignarlos
        //En este caso solamente hay uno ya que solo vamos a agregar informacion en un campo
        public string RespuestaForo
        {
            get { return rtbRespuesta.Text; }
            set { rtbRespuesta.Text = value; }
        }

    }
}
