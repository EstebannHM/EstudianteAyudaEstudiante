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
    public partial class frmMarketplace : Form
    {

        public frmMarketplace()
        {
            InitializeComponent();
            MostrarProductos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAgregarProducto ventanaAgregarProducto = new frmAgregarProducto();
            ventanaAgregarProducto.Show();
        }

        private void MostrarProductos()
        {
            //Llamamos a la capa de datos para poder utilizar el metodo que hay en el
            CapaDatosProducto cdProducto = new CapaDatosProducto();
            //Llamamos al metodo llenar marketplace y le damos el parametro "flpMarketplace" el cual es donde va a ir el control de usuario
            cdProducto.LlenarMarketplace(flpMarketplace);
        }
    }
}
