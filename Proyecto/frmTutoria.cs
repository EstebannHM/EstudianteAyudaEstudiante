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
    public partial class frmTutoria : Form
    {

        CapaDatosTutoria cdTutoria = new CapaDatosTutoria();
        List<Tutoria> listaTutorias = new List<Tutoria>();

        public frmTutoria()
        {
            InitializeComponent();
            CargarTutoriaDGV();
        }

        private void btnPublicarTutoria_Click(object sender, EventArgs e)
        {
            frmCrearTutoria ventanaCrearTutoria = new frmCrearTutoria();
            ventanaCrearTutoria.Show();
        }

        private void CargarTutoriaDGV()
        {
            listaTutorias = cdTutoria.GetTutorias();
            dgvTutoria.DataSource = listaTutorias;
            ConfigurarEstiloDataGridView();
        }

        private void ConfigurarEstiloDataGridView()
        {
            dgvTutoria.ReadOnly = true;
            dgvTutoria.MultiSelect = false;
            foreach (DataGridViewColumn col in dgvTutoria.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Establece las columnas al tamano de el DGV, de este modo no habra ninguna esquina vacia y todas las
                                                                        //Columnas tendran el mismo ancho
            }
            dgvTutoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //En vez de seleccionar cuadro por cuadro, a la hora de seleccionar un campo
                                                                                //Selecciona toda la fila
        }

        public Tutoria tutoriaSeleccionada; // Variable para almacenar el departamento seleccionado

        public void Seleccion()
        {
            if (dgvTutoria.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTutoria.SelectedRows[0].Index;

                tutoriaSeleccionada = new Tutoria()
                {
                    //Esto es para leer la informacion de la fila que el usuario halla seleccionado

                    Id = Convert.ToInt32(dgvTutoria.Rows[selectedIndex].Cells["Id"].Value.ToString()),
                    Materia = dgvTutoria.Rows[selectedIndex].Cells["Materia"].Value.ToString(),
                    Fecha = dgvTutoria.Rows[selectedIndex].Cells["Fecha"].Value.ToString(),
                    Tutor = dgvTutoria.Rows[selectedIndex].Cells["Tutor"].Value.ToString(),
                    Contacto = dgvTutoria.Rows[selectedIndex].Cells["Contacto"].Value.ToString(),
                    Descripcion = dgvTutoria.Rows[selectedIndex].Cells["Descripcion"].Value.ToString(),

                };

                frmVerDatosTutoria ventanaVerDatosTutodia = new frmVerDatosTutoria();
                ventanaVerDatosTutodia.MostrarTutoria(tutoriaSeleccionada);
                ventanaVerDatosTutodia.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Limpiar()
        {
            dgvTutoria.ClearSelection(); //Deja el DGV en blanco, con nada seleccionado
        }

        private void dgvTutoria_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Limpiar();
        }

        private void btnMasInformacion_Click(object sender, EventArgs e)
        {
            Seleccion();
        }
    }
}
