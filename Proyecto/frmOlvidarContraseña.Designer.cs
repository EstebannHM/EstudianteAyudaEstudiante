namespace Proyecto
{
    partial class frmOlvidarContraseña
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
            lblOlvidoSuContrasenna = new Label();
            lblCorreoElectronico = new Label();
            txtCorreoElectronico = new TextBox();
            txtPinUnicoUsuario = new TextBox();
            txtNuevaContrasenna = new TextBox();
            txtConfirmeSuNuevaContraseña = new TextBox();
            lblPinUnicoUsuario = new Label();
            lblNuevaContrasenna = new Label();
            btnFlechaDevolverse = new Button();
            pckFotoOlvidarContrasenna = new PictureBox();
            lblConfirmeSuNuevaContraseña = new Label();
            btnCambiarContrasenna = new Button();
            ((System.ComponentModel.ISupportInitialize)pckFotoOlvidarContrasenna).BeginInit();
            SuspendLayout();
            // 
            // lblOlvidoSuContrasenna
            // 
            lblOlvidoSuContrasenna.AutoSize = true;
            lblOlvidoSuContrasenna.BackColor = Color.Transparent;
            lblOlvidoSuContrasenna.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOlvidoSuContrasenna.ForeColor = Color.Orange;
            lblOlvidoSuContrasenna.Location = new Point(260, 9);
            lblOlvidoSuContrasenna.Name = "lblOlvidoSuContrasenna";
            lblOlvidoSuContrasenna.Size = new Size(216, 27);
            lblOlvidoSuContrasenna.TabIndex = 0;
            lblOlvidoSuContrasenna.Text = "¿Olvidó su contraseña?";
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.BackColor = Color.Transparent;
            lblCorreoElectronico.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreoElectronico.ForeColor = Color.SeaShell;
            lblCorreoElectronico.Location = new Point(246, 129);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(125, 19);
            lblCorreoElectronico.TabIndex = 1;
            lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(246, 151);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(247, 23);
            txtCorreoElectronico.TabIndex = 2;
            // 
            // txtPinUnicoUsuario
            // 
            txtPinUnicoUsuario.Location = new Point(246, 214);
            txtPinUnicoUsuario.Name = "txtPinUnicoUsuario";
            txtPinUnicoUsuario.Size = new Size(247, 23);
            txtPinUnicoUsuario.TabIndex = 3;
            // 
            // txtNuevaContrasenna
            // 
            txtNuevaContrasenna.Location = new Point(246, 277);
            txtNuevaContrasenna.Name = "txtNuevaContrasenna";
            txtNuevaContrasenna.Size = new Size(247, 23);
            txtNuevaContrasenna.TabIndex = 4;
            // 
            // txtConfirmeSuNuevaContraseña
            // 
            txtConfirmeSuNuevaContraseña.Location = new Point(246, 341);
            txtConfirmeSuNuevaContraseña.Name = "txtConfirmeSuNuevaContraseña";
            txtConfirmeSuNuevaContraseña.Size = new Size(247, 23);
            txtConfirmeSuNuevaContraseña.TabIndex = 5;
            // 
            // lblPinUnicoUsuario
            // 
            lblPinUnicoUsuario.AutoSize = true;
            lblPinUnicoUsuario.BackColor = Color.Transparent;
            lblPinUnicoUsuario.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPinUnicoUsuario.ForeColor = Color.SeaShell;
            lblPinUnicoUsuario.Location = new Point(246, 192);
            lblPinUnicoUsuario.Name = "lblPinUnicoUsuario";
            lblPinUnicoUsuario.Size = new Size(138, 19);
            lblPinUnicoUsuario.TabIndex = 6;
            lblPinUnicoUsuario.Text = "Pin Unico de Usuario";
            // 
            // lblNuevaContrasenna
            // 
            lblNuevaContrasenna.AutoSize = true;
            lblNuevaContrasenna.BackColor = Color.Transparent;
            lblNuevaContrasenna.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNuevaContrasenna.ForeColor = Color.SeaShell;
            lblNuevaContrasenna.Location = new Point(246, 255);
            lblNuevaContrasenna.Name = "lblNuevaContrasenna";
            lblNuevaContrasenna.Size = new Size(122, 19);
            lblNuevaContrasenna.TabIndex = 7;
            lblNuevaContrasenna.Text = "Nueva Contraseña";
            // 
            // btnFlechaDevolverse
            // 
            btnFlechaDevolverse.BackColor = Color.SeaShell;
            btnFlechaDevolverse.FlatStyle = FlatStyle.Popup;
            btnFlechaDevolverse.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFlechaDevolverse.ForeColor = Color.DarkOrange;
            btnFlechaDevolverse.Image = Properties.Resources.fotoFlechaDevolverse;
            btnFlechaDevolverse.ImageAlign = ContentAlignment.MiddleLeft;
            btnFlechaDevolverse.Location = new Point(12, 12);
            btnFlechaDevolverse.Name = "btnFlechaDevolverse";
            btnFlechaDevolverse.Size = new Size(85, 30);
            btnFlechaDevolverse.TabIndex = 8;
            btnFlechaDevolverse.Text = "Atras";
            btnFlechaDevolverse.TextAlign = ContentAlignment.MiddleRight;
            btnFlechaDevolverse.UseVisualStyleBackColor = false;
            btnFlechaDevolverse.Click += btnFlechaDevolverse_Click;
            // 
            // pckFotoOlvidarContrasenna
            // 
            pckFotoOlvidarContrasenna.Image = Properties.Resources.fotoOlvidarContrasenna;
            pckFotoOlvidarContrasenna.Location = new Point(324, 49);
            pckFotoOlvidarContrasenna.Name = "pckFotoOlvidarContrasenna";
            pckFotoOlvidarContrasenna.Size = new Size(85, 60);
            pckFotoOlvidarContrasenna.SizeMode = PictureBoxSizeMode.StretchImage;
            pckFotoOlvidarContrasenna.TabIndex = 9;
            pckFotoOlvidarContrasenna.TabStop = false;
            // 
            // lblConfirmeSuNuevaContraseña
            // 
            lblConfirmeSuNuevaContraseña.AutoSize = true;
            lblConfirmeSuNuevaContraseña.BackColor = Color.Transparent;
            lblConfirmeSuNuevaContraseña.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmeSuNuevaContraseña.ForeColor = Color.SeaShell;
            lblConfirmeSuNuevaContraseña.Location = new Point(246, 319);
            lblConfirmeSuNuevaContraseña.Name = "lblConfirmeSuNuevaContraseña";
            lblConfirmeSuNuevaContraseña.Size = new Size(193, 19);
            lblConfirmeSuNuevaContraseña.TabIndex = 10;
            lblConfirmeSuNuevaContraseña.Text = "Confirme su nueva contraseña";
            // 
            // btnCambiarContrasenna
            // 
            btnCambiarContrasenna.BackColor = Color.Orange;
            btnCambiarContrasenna.FlatStyle = FlatStyle.Popup;
            btnCambiarContrasenna.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambiarContrasenna.ForeColor = Color.SeaShell;
            btnCambiarContrasenna.Location = new Point(246, 388);
            btnCambiarContrasenna.Name = "btnCambiarContrasenna";
            btnCambiarContrasenna.Size = new Size(247, 25);
            btnCambiarContrasenna.TabIndex = 11;
            btnCambiarContrasenna.Text = "Cambiar contraseña";
            btnCambiarContrasenna.UseVisualStyleBackColor = false;
            btnCambiarContrasenna.Click += btnCambiarContrasenna_Click;
            // 
            // frmOlvidarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 425);
            Controls.Add(btnCambiarContrasenna);
            Controls.Add(lblConfirmeSuNuevaContraseña);
            Controls.Add(pckFotoOlvidarContrasenna);
            Controls.Add(btnFlechaDevolverse);
            Controls.Add(lblNuevaContrasenna);
            Controls.Add(lblPinUnicoUsuario);
            Controls.Add(txtConfirmeSuNuevaContraseña);
            Controls.Add(txtNuevaContrasenna);
            Controls.Add(txtPinUnicoUsuario);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(lblOlvidoSuContrasenna);
            DoubleBuffered = true;
            Name = "frmOlvidarContraseña";
            Text = "Olvidar Contraseña";
            ((System.ComponentModel.ISupportInitialize)pckFotoOlvidarContrasenna).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOlvidoSuContrasenna;
        private Label lblCorreoElectronico;
        private TextBox txtCorreoElectronico;
        private TextBox txtPinUnicoUsuario;
        private TextBox txtNuevaContrasenna;
        private TextBox txtConfirmeSuNuevaContraseña;
        private Label lblPinUnicoUsuario;
        private Label lblNuevaContrasenna;
        private Button btnFlechaDevolverse;
        private PictureBox pckFotoOlvidarContrasenna;
        private Label lblConfirmeSuNuevaContraseña;
        private Button btnCambiarContrasenna;
    }
}