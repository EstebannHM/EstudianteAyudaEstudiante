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
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmInicioSesion ventanaInicioSesion = new frmInicioSesion();
            ventanaInicioSesion.Show();
            this.Hide();
            MessageBox.Show("Ha cerrado sesion con exito");
        }

        private void pbxInicio_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmFuncionalidadesInicio());
        }

        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            //Llamamos al siguiente evento, para que cuando el evento "load" de la pantalla principal se ejecute, se ejecute en seguida el evento click
            //De esta manera, llamamos todo lo que haya en ese click
            pbxInicio_Click(null, e);
        }

        //Metodo realizado con ayuda de internet para realizar los foros
        public void AbrirForm(object AbrirForm)
        {

            //Verifica que el panel este vacio, si contiene algo lo que hace es vaciarlo
            if (this.pnPrincipal.Controls.Count > 0)
                this.pnPrincipal.Controls.RemoveAt(0);


            //Se crea un formulario para igualarlo al objeto
            Form fh = AbrirForm as Form; //Y se convierte en un form al decir "as Form"

            //Se le indica que no es uno form primario, si no que es secundario
            fh.TopLevel = false;

            //Esto es para que se acople a el panel en nuestro caso al "pnPrincipal"
            fh.Dock = DockStyle.Fill;

            //Se agregar al panel
            this.pnPrincipal.Controls.Add(fh);

            //Preguntarle bien al profe*************
            this.pnPrincipal.Tag = fh;

            //Se muestra
            fh.Show();


        }

        private void btnAirbnt_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAitbnt());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            pnConfiguraciones.Visible = true;
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            pnConfiguraciones.Visible = false;
            AbrirForm(new frmEditarPerfil());
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            pnConfiguraciones.Visible = false;
            AbrirForm(new frmCambiarContrasenna());
        }

        private void pnMenuLateral_Click(object sender, EventArgs e)
        {
            pnConfiguraciones.Visible = false;
        }

        private void btnMarketplace_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmMarketplace());
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmDirectorio());
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmForo());
        }

        private void btnTutoria_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmTutoria());
        }
    }
}
