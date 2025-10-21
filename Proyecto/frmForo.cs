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
    public partial class frmForo : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";

        public frmForo()
        {
            InitializeComponent();
            CargarPregunta();
        }
        private void btnAnadirPregunta_Click(object sender, EventArgs e)
        {
            frmAnadirPregunta ventanaPregunta = new frmAnadirPregunta();
            ventanaPregunta.Show();
        }

        private void btnVerComentarios_Click(object sender, EventArgs e)
        {
            Seleccion();
        }

        private void dgvPreguntas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Limpiar();
        }

        private void dgvPreguntas_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void CargarPregunta()
        {
            //Agremamos las columnas de forma con codigo
            if (dgvPreguntas.ColumnCount == 0)
            {
                //El primer parametro sera el nombre "interno" de la columna, es el que utilizamos a la hora de asignar los reader
                //El segundo parametro es el que es visible al usuario, por eso lleva tildes y la letra eñe
                dgvPreguntas.Columns.Add("IdPregunta", "Numero de pregunta");
                dgvPreguntas.Columns.Add("Titulo", "Título");
                dgvPreguntas.Columns.Add("Pregunta", "Pregunta");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdPregunta, Titulo, Pregunta FROM ForoPregunta";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                dgvPreguntas.Rows.Clear();

                while (reader.Read())
                {
                    dgvPreguntas.Rows.Add(reader["IdPregunta"], reader["Titulo"], reader["Pregunta"]);
                }
                reader.Close();

            }
            ConfigurarEstiloDataGridView();
        }

        public void Seleccion()
        {
            if (dgvPreguntas.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvPreguntas.SelectedRows[0].Index;
                int idPregunta = Convert.ToInt32(dgvPreguntas.Rows[selectedIndex].Cells["IdPregunta"].Value);
                //Le mandamos el idPregunta a el foro y el capa datos donde se guardaran en una variable static creada alli
                frmAnadirRespuesta.IdPregunta = idPregunta;
                CapaDatosForo.IdPregunta = idPregunta;
                frmComentarioForo ventanaComentarioForo = new frmComentarioForo();
                ventanaComentarioForo.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigurarEstiloDataGridView()
        {
            dgvPreguntas.ReadOnly = true;
            dgvPreguntas.MultiSelect = false;
            foreach (DataGridViewColumn col in dgvPreguntas.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Establece las columnas al tamano de el DGV, de este modo no habra ninguna esquina vacia y todas las
                //Columnas tendran el mismo ancho
            }
            dgvPreguntas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //En vez de seleccionar cuadro por cuadro, a la hora de seleccionar un campo
            //Selecciona toda la fila
        }

        private void Limpiar()
        {
            dgvPreguntas.ClearSelection(); //Deja el DGV en blanco, con nada seleccionado
        }

    }
}
