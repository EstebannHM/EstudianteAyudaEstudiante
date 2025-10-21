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
    public partial class csMarketplace : UserControl
    {

        private int id = 0;

        public csMarketplace()
        {
            InitializeComponent();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //Se realizan tos los get y set para luego en la capa de datos poder asignarlos
        public Image ImagenProducto
        {
            get { return pbxImagen.Image; }
            set { pbxImagen.Image = value; }
        }

        public string NombreProducto
        {
            get { return lblNombre.Text;}
            set { lblNombre.Text = value;}
        }

        public string PrecioProducto
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }
        }

        public string DescripcionProducto
        {
            get { return rtbDescripcion.Text; }
            set { rtbDescripcion.Text = value; }
        }

        public string ContactoProducto
        {
            get { return lblContacto.Text; } 
            set { lblContacto.Text = value;}
        }
    }
}
