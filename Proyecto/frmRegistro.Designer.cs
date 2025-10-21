namespace Proyecto
{
    partial class frmRegistro
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
            lblNombre = new Label();
            pictureBox1 = new PictureBox();
            lblPrimerApellido = new Label();
            lblCorreoElectronico = new Label();
            lblContrasenna = new Label();
            lblConfirmeSuContrasenna = new Label();
            btnRegistrarme = new Button();
            lklIniciarSesion = new LinkLabel();
            txtNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtCorreoElectronico = new TextBox();
            txtContrasenna = new TextBox();
            txtConfirmeSuContrasenna = new TextBox();
            lblYaEresUsuario = new Label();
            lblPin = new Label();
            txtPin = new TextBox();
            lklTerminosCondiciones = new LinkLabel();
            ckbAcepto = new CheckBox();
            lblSegundoApellido = new Label();
            txtSegundoApellido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.SeaShell;
            lblNombre.Location = new Point(300, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fotoRegistro;
            pictureBox1.Location = new Point(398, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.BackColor = Color.Transparent;
            lblPrimerApellido.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerApellido.ForeColor = Color.SeaShell;
            lblPrimerApellido.Location = new Point(300, 147);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(100, 19);
            lblPrimerApellido.TabIndex = 2;
            lblPrimerApellido.Text = "PrimerApellido";
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.BackColor = Color.Transparent;
            lblCorreoElectronico.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreoElectronico.ForeColor = Color.SeaShell;
            lblCorreoElectronico.Location = new Point(300, 263);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(125, 19);
            lblCorreoElectronico.TabIndex = 3;
            lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // lblContrasenna
            // 
            lblContrasenna.AutoSize = true;
            lblContrasenna.BackColor = Color.Transparent;
            lblContrasenna.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenna.ForeColor = Color.SeaShell;
            lblContrasenna.Location = new Point(300, 320);
            lblContrasenna.Name = "lblContrasenna";
            lblContrasenna.Size = new Size(78, 19);
            lblContrasenna.TabIndex = 4;
            lblContrasenna.Text = "Contraseña";
            // 
            // lblConfirmeSuContrasenna
            // 
            lblConfirmeSuContrasenna.AutoSize = true;
            lblConfirmeSuContrasenna.BackColor = Color.Transparent;
            lblConfirmeSuContrasenna.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmeSuContrasenna.ForeColor = Color.SeaShell;
            lblConfirmeSuContrasenna.Location = new Point(300, 379);
            lblConfirmeSuContrasenna.Name = "lblConfirmeSuContrasenna";
            lblConfirmeSuContrasenna.Size = new Size(153, 19);
            lblConfirmeSuContrasenna.TabIndex = 5;
            lblConfirmeSuContrasenna.Text = "Confirme su contraseña";
            // 
            // btnRegistrarme
            // 
            btnRegistrarme.BackColor = Color.Orange;
            btnRegistrarme.FlatStyle = FlatStyle.Popup;
            btnRegistrarme.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistrarme.ForeColor = Color.SeaShell;
            btnRegistrarme.Location = new Point(300, 530);
            btnRegistrarme.Name = "btnRegistrarme";
            btnRegistrarme.Size = new Size(274, 25);
            btnRegistrarme.TabIndex = 6;
            btnRegistrarme.Text = "Registrarme";
            btnRegistrarme.UseVisualStyleBackColor = false;
            btnRegistrarme.Click += btnRegistrarme_Click;
            // 
            // lklIniciarSesion
            // 
            lklIniciarSesion.AutoSize = true;
            lklIniciarSesion.BackColor = Color.Transparent;
            lklIniciarSesion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lklIniciarSesion.LinkColor = Color.DarkOrange;
            lklIniciarSesion.Location = new Point(122, 534);
            lklIniciarSesion.Name = "lklIniciarSesion";
            lklIniciarSesion.Size = new Size(88, 19);
            lklIniciarSesion.TabIndex = 7;
            lklIniciarSesion.TabStop = true;
            lklIniciarSesion.Text = "Iniciar Sesión";
            lklIniciarSesion.LinkClicked += lklIniciarSesion_LinkClicked;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(300, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(274, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(300, 169);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(274, 23);
            txtPrimerApellido.TabIndex = 9;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(300, 285);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(274, 23);
            txtCorreoElectronico.TabIndex = 10;
            // 
            // txtContrasenna
            // 
            txtContrasenna.Location = new Point(300, 342);
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.Size = new Size(274, 23);
            txtContrasenna.TabIndex = 11;
            // 
            // txtConfirmeSuContrasenna
            // 
            txtConfirmeSuContrasenna.Location = new Point(300, 401);
            txtConfirmeSuContrasenna.Name = "txtConfirmeSuContrasenna";
            txtConfirmeSuContrasenna.Size = new Size(274, 23);
            txtConfirmeSuContrasenna.TabIndex = 12;
            // 
            // lblYaEresUsuario
            // 
            lblYaEresUsuario.AutoSize = true;
            lblYaEresUsuario.BackColor = Color.Transparent;
            lblYaEresUsuario.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblYaEresUsuario.ForeColor = Color.SeaShell;
            lblYaEresUsuario.Location = new Point(10, 534);
            lblYaEresUsuario.Name = "lblYaEresUsuario";
            lblYaEresUsuario.Size = new Size(113, 19);
            lblYaEresUsuario.TabIndex = 13;
            lblYaEresUsuario.Text = "¿Ya eres usuario?";
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.BackColor = Color.Transparent;
            lblPin.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPin.ForeColor = Color.SeaShell;
            lblPin.Location = new Point(300, 437);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(68, 19);
            lblPin.TabIndex = 14;
            lblPin.Text = "Pin Unico";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(300, 459);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(274, 23);
            txtPin.TabIndex = 15;
            // 
            // lklTerminosCondiciones
            // 
            lklTerminosCondiciones.AutoSize = true;
            lklTerminosCondiciones.BackColor = Color.Transparent;
            lklTerminosCondiciones.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lklTerminosCondiciones.LinkColor = Color.DarkOrange;
            lklTerminosCondiciones.Location = new Point(398, 502);
            lklTerminosCondiciones.Name = "lklTerminosCondiciones";
            lklTerminosCondiciones.Size = new Size(155, 19);
            lklTerminosCondiciones.TabIndex = 16;
            lklTerminosCondiciones.TabStop = true;
            lklTerminosCondiciones.Text = "Terminos y Condiciones";
            lklTerminosCondiciones.LinkClicked += lklTerminosCondiciones_LinkClicked;
            // 
            // ckbAcepto
            // 
            ckbAcepto.AutoSize = true;
            ckbAcepto.BackColor = Color.Transparent;
            ckbAcepto.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ckbAcepto.ForeColor = Color.DarkOrange;
            ckbAcepto.Location = new Point(300, 501);
            ckbAcepto.Name = "ckbAcepto";
            ckbAcepto.Size = new Size(95, 23);
            ckbAcepto.TabIndex = 17;
            ckbAcepto.Text = "Acepto los";
            ckbAcepto.UseVisualStyleBackColor = false;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.BackColor = Color.Transparent;
            lblSegundoApellido.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoApellido.ForeColor = Color.SeaShell;
            lblSegundoApellido.Location = new Point(300, 205);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(115, 19);
            lblSegundoApellido.TabIndex = 18;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(300, 227);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(274, 23);
            txtSegundoApellido.TabIndex = 19;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(866, 575);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(ckbAcepto);
            Controls.Add(lklTerminosCondiciones);
            Controls.Add(txtPin);
            Controls.Add(lblPin);
            Controls.Add(lblYaEresUsuario);
            Controls.Add(txtConfirmeSuContrasenna);
            Controls.Add(txtContrasenna);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtNombre);
            Controls.Add(lklIniciarSesion);
            Controls.Add(btnRegistrarme);
            Controls.Add(lblConfirmeSuContrasenna);
            Controls.Add(lblContrasenna);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(lblPrimerApellido);
            Controls.Add(pictureBox1);
            Controls.Add(lblNombre);
            DoubleBuffered = true;
            Name = "frmRegistro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private PictureBox pictureBox1;
        private Label lblPrimerApellido;
        private Label lblCorreoElectronico;
        private Label lblContrasenna;
        private Label lblConfirmeSuContrasenna;
        private Button btnRegistrarme;
        private LinkLabel lklIniciarSesion;
        private TextBox txtNombre;
        private TextBox txtPrimerApellido;
        private TextBox txtCorreoElectronico;
        private TextBox txtContrasenna;
        private TextBox txtConfirmeSuContrasenna;
        private Label lblYaEresUsuario;
        private Label lblPin;
        private TextBox txtPin;
        private LinkLabel lklTerminosCondiciones;
        private CheckBox ckbAcepto;
        private Label lblSegundoApellido;
        private TextBox txtSegundoApellido;
    }
}