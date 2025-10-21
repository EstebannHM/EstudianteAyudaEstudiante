namespace Proyecto
{
    partial class frmCambiarContrasenna
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
            lblCambiarContrasenna = new Label();
            btnGuardarCambios = new Button();
            lblContrasennaActual = new Label();
            lblNuevaContrasenna = new Label();
            lblConfirmarContrasenna = new Label();
            txtContrasennaActual = new TextBox();
            txtNuevaContrasenna = new TextBox();
            txtConfirmarContrasenna = new TextBox();
            SuspendLayout();
            // 
            // lblCambiarContrasenna
            // 
            lblCambiarContrasenna.AutoSize = true;
            lblCambiarContrasenna.BackColor = Color.Transparent;
            lblCambiarContrasenna.Font = new Font("Sylfaen", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCambiarContrasenna.ForeColor = Color.DarkOrange;
            lblCambiarContrasenna.Location = new Point(247, 22);
            lblCambiarContrasenna.Name = "lblCambiarContrasenna";
            lblCambiarContrasenna.Size = new Size(680, 84);
            lblCambiarContrasenna.TabIndex = 0;
            lblCambiarContrasenna.Text = "Cambiar mi Contraseña";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.Orange;
            btnGuardarCambios.FlatStyle = FlatStyle.Popup;
            btnGuardarCambios.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardarCambios.ForeColor = Color.SeaShell;
            btnGuardarCambios.Location = new Point(409, 537);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(361, 33);
            btnGuardarCambios.TabIndex = 1;
            btnGuardarCambios.Text = "Guardar mi nueva contraseña";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // lblContrasennaActual
            // 
            lblContrasennaActual.AutoSize = true;
            lblContrasennaActual.BackColor = Color.Transparent;
            lblContrasennaActual.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasennaActual.ForeColor = Color.SeaShell;
            lblContrasennaActual.Location = new Point(321, 180);
            lblContrasennaActual.Name = "lblContrasennaActual";
            lblContrasennaActual.Size = new Size(170, 25);
            lblContrasennaActual.TabIndex = 2;
            lblContrasennaActual.Text = "Contraseña actual";
            // 
            // lblNuevaContrasenna
            // 
            lblNuevaContrasenna.AutoSize = true;
            lblNuevaContrasenna.BackColor = Color.Transparent;
            lblNuevaContrasenna.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNuevaContrasenna.ForeColor = Color.SeaShell;
            lblNuevaContrasenna.Location = new Point(321, 292);
            lblNuevaContrasenna.Name = "lblNuevaContrasenna";
            lblNuevaContrasenna.Size = new Size(174, 25);
            lblNuevaContrasenna.TabIndex = 3;
            lblNuevaContrasenna.Text = "Nueva Contraseña";
            // 
            // lblConfirmarContrasenna
            // 
            lblConfirmarContrasenna.AutoSize = true;
            lblConfirmarContrasenna.BackColor = Color.Transparent;
            lblConfirmarContrasenna.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmarContrasenna.ForeColor = Color.SeaShell;
            lblConfirmarContrasenna.Location = new Point(321, 406);
            lblConfirmarContrasenna.Name = "lblConfirmarContrasenna";
            lblConfirmarContrasenna.Size = new Size(208, 25);
            lblConfirmarContrasenna.TabIndex = 4;
            lblConfirmarContrasenna.Text = "Confirmar Contraseña";
            // 
            // txtContrasennaActual
            // 
            txtContrasennaActual.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasennaActual.Location = new Point(595, 177);
            txtContrasennaActual.Name = "txtContrasennaActual";
            txtContrasennaActual.Size = new Size(301, 33);
            txtContrasennaActual.TabIndex = 5;
            // 
            // txtNuevaContrasenna
            // 
            txtNuevaContrasenna.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNuevaContrasenna.Location = new Point(595, 284);
            txtNuevaContrasenna.Name = "txtNuevaContrasenna";
            txtNuevaContrasenna.Size = new Size(301, 33);
            txtNuevaContrasenna.TabIndex = 6;
            // 
            // txtConfirmarContrasenna
            // 
            txtConfirmarContrasenna.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarContrasenna.Location = new Point(595, 398);
            txtConfirmarContrasenna.Name = "txtConfirmarContrasenna";
            txtConfirmarContrasenna.Size = new Size(301, 33);
            txtConfirmarContrasenna.TabIndex = 7;
            // 
            // frmCambiarContrasenna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 208, 183);
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1137, 647);
            Controls.Add(txtConfirmarContrasenna);
            Controls.Add(txtNuevaContrasenna);
            Controls.Add(txtContrasennaActual);
            Controls.Add(lblConfirmarContrasenna);
            Controls.Add(lblNuevaContrasenna);
            Controls.Add(lblContrasennaActual);
            Controls.Add(btnGuardarCambios);
            Controls.Add(lblCambiarContrasenna);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCambiarContrasenna";
            Text = "Cambiar Contrasenna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCambiarContrasenna;
        private Button btnGuardarCambios;
        private Label lblContrasennaActual;
        private Label lblNuevaContrasenna;
        private Label lblConfirmarContrasenna;
        private TextBox txtContrasennaActual;
        private TextBox txtNuevaContrasenna;
        private TextBox txtConfirmarContrasenna;
    }
}