namespace Proyecto
{
    partial class frmInicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            lblCorreoElectronico = new Label();
            txtCorreoElectronico = new TextBox();
            txtContrasenna = new TextBox();
            lblContrasenna = new Label();
            lblNoTengoCuenta = new Label();
            pbxFotoEstudianteInicio = new PictureBox();
            lblEstudiante = new Label();
            lklOlvidarContrasenna = new LinkLabel();
            lklRegistrar = new LinkLabel();
            pbxMostrar = new PictureBox();
            pbxOcultar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxFotoEstudianteInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxOcultar).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Orange;
            btnIniciarSesion.FlatStyle = FlatStyle.Popup;
            btnIniciarSesion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.SeaShell;
            btnIniciarSesion.Location = new Point(278, 379);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(274, 23);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.BackColor = Color.Transparent;
            lblCorreoElectronico.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreoElectronico.ForeColor = Color.SeaShell;
            lblCorreoElectronico.Location = new Point(278, 193);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(125, 19);
            lblCorreoElectronico.TabIndex = 4;
            lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(278, 223);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(274, 23);
            txtCorreoElectronico.TabIndex = 5;
            // 
            // txtContrasenna
            // 
            txtContrasenna.Location = new Point(278, 292);
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.PasswordChar = '*';
            txtContrasenna.Size = new Size(274, 23);
            txtContrasenna.TabIndex = 6;
            // 
            // lblContrasenna
            // 
            lblContrasenna.AutoSize = true;
            lblContrasenna.BackColor = Color.Transparent;
            lblContrasenna.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenna.ForeColor = Color.SeaShell;
            lblContrasenna.Location = new Point(278, 265);
            lblContrasenna.Name = "lblContrasenna";
            lblContrasenna.Size = new Size(78, 19);
            lblContrasenna.TabIndex = 7;
            lblContrasenna.Text = "Contraseña";
            // 
            // lblNoTengoCuenta
            // 
            lblNoTengoCuenta.AutoSize = true;
            lblNoTengoCuenta.BackColor = Color.Transparent;
            lblNoTengoCuenta.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoTengoCuenta.ForeColor = Color.SeaShell;
            lblNoTengoCuenta.Location = new Point(278, 157);
            lblNoTengoCuenta.Name = "lblNoTengoCuenta";
            lblNoTengoCuenta.Size = new Size(193, 19);
            lblNoTengoCuenta.TabIndex = 8;
            lblNoTengoCuenta.Text = "¿Eres nuevo como estudiante?";
            // 
            // pbxFotoEstudianteInicio
            // 
            pbxFotoEstudianteInicio.BackColor = Color.Transparent;
            pbxFotoEstudianteInicio.Image = Properties.Resources.fotoEstudiante;
            pbxFotoEstudianteInicio.Location = new Point(377, 66);
            pbxFotoEstudianteInicio.Name = "pbxFotoEstudianteInicio";
            pbxFotoEstudianteInicio.Size = new Size(76, 58);
            pbxFotoEstudianteInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFotoEstudianteInicio.TabIndex = 9;
            pbxFotoEstudianteInicio.TabStop = false;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.BackColor = Color.Transparent;
            lblEstudiante.Font = new Font("Sylfaen", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblEstudiante.ForeColor = Color.Orange;
            lblEstudiante.Location = new Point(334, 18);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(164, 35);
            lblEstudiante.TabIndex = 10;
            lblEstudiante.Text = "Iniciar sesión";
            // 
            // lklOlvidarContrasenna
            // 
            lklOlvidarContrasenna.AutoSize = true;
            lklOlvidarContrasenna.BackColor = Color.Transparent;
            lklOlvidarContrasenna.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lklOlvidarContrasenna.ForeColor = Color.Linen;
            lklOlvidarContrasenna.LinkColor = Color.DarkOrange;
            lklOlvidarContrasenna.Location = new Point(278, 327);
            lklOlvidarContrasenna.Name = "lklOlvidarContrasenna";
            lklOlvidarContrasenna.Size = new Size(188, 19);
            lklOlvidarContrasenna.TabIndex = 11;
            lklOlvidarContrasenna.TabStop = true;
            lklOlvidarContrasenna.Text = "¿Olvidaste la contraseña?";
            lklOlvidarContrasenna.LinkClicked += lklOlvidarContrasenna_LinkClicked;
            // 
            // lklRegistrar
            // 
            lklRegistrar.AutoSize = true;
            lklRegistrar.BackColor = Color.Transparent;
            lklRegistrar.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lklRegistrar.LinkColor = Color.DarkOrange;
            lklRegistrar.Location = new Point(477, 157);
            lklRegistrar.Name = "lklRegistrar";
            lklRegistrar.Size = new Size(82, 19);
            lklRegistrar.TabIndex = 12;
            lklRegistrar.TabStop = true;
            lklRegistrar.Text = "Registrarme";
            lklRegistrar.LinkClicked += lklRegistrar_LinkClicked;
            // 
            // pbxMostrar
            // 
            pbxMostrar.Image = Properties.Resources.fotoVerContra;
            pbxMostrar.Location = new Point(558, 292);
            pbxMostrar.Name = "pbxMostrar";
            pbxMostrar.Size = new Size(29, 22);
            pbxMostrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMostrar.TabIndex = 13;
            pbxMostrar.TabStop = false;
            pbxMostrar.Click += pbxMostrar_Click;
            // 
            // pbxOcultar
            // 
            pbxOcultar.Image = Properties.Resources.fotoOcultarContra;
            pbxOcultar.Location = new Point(558, 292);
            pbxOcultar.Name = "pbxOcultar";
            pbxOcultar.Size = new Size(29, 22);
            pbxOcultar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxOcultar.TabIndex = 14;
            pbxOcultar.TabStop = false;
            pbxOcultar.Click += pbxOcultar_Click;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(803, 480);
            Controls.Add(pbxMostrar);
            Controls.Add(pbxOcultar);
            Controls.Add(lklRegistrar);
            Controls.Add(lklOlvidarContrasenna);
            Controls.Add(lblEstudiante);
            Controls.Add(pbxFotoEstudianteInicio);
            Controls.Add(lblNoTengoCuenta);
            Controls.Add(lblContrasenna);
            Controls.Add(txtContrasenna);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(btnIniciarSesion);
            DoubleBuffered = true;
            Name = "frmInicioSesion";
            Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)pbxFotoEstudianteInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxOcultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private Label lblCorreoElectronico;
        private TextBox txtCorreoElectronico;
        private TextBox txtContrasenna;
        private Label lblContrasenna;
        private Label lblNoTengoCuenta;
        private PictureBox pbxFotoEstudianteInicio;
        private Label lblEstudiante;
        private LinkLabel lklOlvidarContrasenna;
        private LinkLabel lklRegistrar;
        private PictureBox pbxMostrar;
        private PictureBox pbxOcultar;
    }
}