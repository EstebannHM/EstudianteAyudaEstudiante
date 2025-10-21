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
    public partial class frmVerDatosTutoria : Form
    {
        public frmVerDatosTutoria()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        //Mostramos en los textbox l tutoria que arrastramso mediante el objeto tutoria
        public void MostrarTutoria(Tutoria tutoria)
        {
            txtMateria.Text = tutoria.Materia;
            txtFecha.Text = tutoria.Fecha;
            txtTutor.Text = tutoria.Tutor;
            txtContacto.Text = tutoria.Contacto;
            rtbDescripcion.Text = tutoria.Descripcion;
        }

    }
}
