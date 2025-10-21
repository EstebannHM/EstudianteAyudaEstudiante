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
    public partial class frmAitbnt : Form
    {

        private static string nombreServidor = "DESKTOP-BOAB5D0\\SQLEXPRESS"; //Aquí colocan el nombre de la instalación SQL de la computadora donde están corriendo este programa
        private static string nombreBaseDatos = "BDRae";
        private static string usuarioBaseDatos = ""; //Si no hay usuario puede quedar en blanco
        private static string contrasennaBaseDatos = ""; //Si no hay usuario tampoco habrá contraseña entonces quedará en blanco
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};User ID={usuarioBaseDatos};Password={contrasennaBaseDatos};Integrated Security=True;";
        public frmAitbnt()
        {
            InitializeComponent();
            CargarDepartamentoDGV();
        }

        private void btnAnadiDepartamento_Click(object sender, EventArgs e)
        {
            frmAnadirDepartamento ventanaAnadirDepartamento = new frmAnadirDepartamento();
            ventanaAnadirDepartamento.Show();
        }

        private void dgvDepartamento_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //Se realiza este evento el cual es encargado de 
                                                                                                                //que cuando se carguen todos los datos respectivos de el DGV, se realice el metodo que esa dentro de el codigo
        {
            Limpiar();
        }

        private void btnMasInformacion_Click(object sender, EventArgs e)
        {
            Seleccion();
        }

        private void CargarDepartamentoDGV()
        {
            //Este if para crear las columnas en el DGV, siempre se va a ejecturar por que el conteo de las columnas siempre va a ser 0 ya que no las tenemos creadas manualmente
            if (dgvDepartamento.ColumnCount == 0)
            {
                //El primer parametro sera el nombre "interno" de la columna, es el que utilizamos a la hora de asignar los reader
                //El segundo parametro es el que es visible al usuario, por eso lleva tildes y la letra eñe
                dgvDepartamento.Columns.Add("Codigo", "Código");
                dgvDepartamento.Columns.Add("Ubicacion", "Ubicación");
                dgvDepartamento.Columns.Add("Cuarto", "Cuartos");
                dgvDepartamento.Columns.Add("Banno", "Baños");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Realizamos la consulta haciendo el select de todo en la tabla Departamento
                string query = "SELECT Codigo, Ubicacion, Cuarto, Banno FROM Departamento";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                dgvDepartamento.Rows.Clear();

                while (reader.Read())
                {
                    //Leemos y agregamos en las columnas
                    dgvDepartamento.Rows.Add(reader["Codigo"], reader["Ubicacion"], reader["Cuarto"], reader["Banno"]);
                }
                reader.Close();

            }
            ConfigurarEstiloDataGridView();
        }


        private void ConfigurarEstiloDataGridView()
        {
            dgvDepartamento.ReadOnly = true;
            dgvDepartamento.MultiSelect = false;
            foreach (DataGridViewColumn col in dgvDepartamento.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Establece las columnas al tamano de el DGV, de este modo no habra ninguna esquina vacia y todas las
                //Columnas tendran el mismo ancho
            }
            dgvDepartamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //En vez de seleccionar cuadro por cuadro, a la hora de seleccionar un campo
            //Selecciona toda la fila
        }

        public void Seleccion()
        {
            if (dgvDepartamento.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvDepartamento.SelectedRows[0].Index;
                //Creamos la variable codigoDepartamento para almacenarlo segun sea el que el usuario selecciono
                int codigoDepartamento = Convert.ToInt32(dgvDepartamento.Rows[selectedIndex].Cells["Codigo"].Value);
                //Le asignamos el codigo mediante la variable que creamos en la anterior linea y se lo asignamos a la variable estatica creada en el form correspondiente
                frmVerDatosApartamento.CodigoDepartamentoSeleccionado = codigoDepartamento;
                frmVerDatosApartamento ventanaVerDatosApartamentos = new frmVerDatosApartamento();
                ventanaVerDatosApartamentos.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Limpiar()
        {
            dgvDepartamento.ClearSelection(); //Deja el DGV en blanco, con nada seleccionado
        }

    }
}
