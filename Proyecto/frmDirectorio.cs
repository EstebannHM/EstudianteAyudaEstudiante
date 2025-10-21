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
    public partial class frmDirectorio : Form
    {

        CapaDatosOficina datosOficina = new CapaDatosOficina();
        List<Oficina> listaOficina = new List<Oficina>();

        public frmDirectorio()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            this.CenterToScreen(); //Centrar la ventana
            //Se ingresan los datos a el DGV
            listaOficina = datosOficina.ObtenerOficina(); //LLama la lista de productos
            dgvOficina.DataSource = listaOficina; //Colocar la lista en el dgv
            ConfigurarEstiloDataGridView();
        }

        private void ConfigurarEstiloDataGridView()
        {
            dgvOficina.ReadOnly = true;  //Solo lectura
            dgvOficina.MultiSelect = false; //Para no seleccionar varias cosas, *Como cuando uno le da clic drecho y selecciona todo

            foreach (DataGridViewColumn columna in dgvOficina.Columns) //Esto hace que el data grid view se ajuste a el tamano de la ventana
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            dgvOficina.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Esto selecciona toda la fila, a la hora de darle click.
        }
    }
}
