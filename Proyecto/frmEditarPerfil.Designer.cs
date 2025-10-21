namespace Proyecto
{
    partial class frmEditarPerfil
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
            btnGuardar = new Button();
            lblNombre = new Label();
            lblPrimerApellido = new Label();
            lblSegundoApellido = new Label();
            lblCorreoElectronico = new Label();
            txtNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            txtCorreoElectronico = new TextBox();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Orange;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.SeaShell;
            btnGuardar.Location = new Point(417, 528);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(333, 33);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.SeaShell;
            lblNombre.Location = new Point(336, 156);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(84, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.BackColor = Color.Transparent;
            lblPrimerApellido.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerApellido.ForeColor = Color.SeaShell;
            lblPrimerApellido.Location = new Point(336, 250);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(164, 25);
            lblPrimerApellido.TabIndex = 2;
            lblPrimerApellido.Text = "Primer Apellido ";
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.BackColor = Color.Transparent;
            lblSegundoApellido.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoApellido.ForeColor = Color.SeaShell;
            lblSegundoApellido.Location = new Point(336, 343);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(178, 25);
            lblSegundoApellido.TabIndex = 3;
            lblSegundoApellido.Text = "Segundo Apellido ";
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.BackColor = Color.Transparent;
            lblCorreoElectronico.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreoElectronico.ForeColor = Color.SeaShell;
            lblCorreoElectronico.Location = new Point(336, 429);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(182, 25);
            lblCorreoElectronico.TabIndex = 4;
            lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(576, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 33);
            txtNombre.TabIndex = 5;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerApellido.Location = new Point(576, 250);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(253, 33);
            txtPrimerApellido.TabIndex = 6;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoApellido.Location = new Point(576, 340);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(253, 33);
            txtSegundoApellido.TabIndex = 7;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreoElectronico.Location = new Point(576, 429);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(253, 33);
            txtCorreoElectronico.TabIndex = 8;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Sylfaen", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl1.ForeColor = Color.DarkOrange;
            lbl1.Location = new Point(356, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(453, 84);
            lbl1.TabIndex = 9;
            lbl1.Text = "Editar mi perfil";
            // 
            // frmEditarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 208, 183);
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 608);
            Controls.Add(lbl1);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(lblSegundoApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarPerfil";
            Text = "Editar Perfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label lblNombre;
        private Label lblPrimerApellido;
        private Label lblSegundoApellido;
        private Label lblCorreoElectronico;
        private TextBox txtNombre;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoApellido;
        private TextBox txtCorreoElectronico;
        private Label lbl1;
    }
}