namespace Proyecto
{
    partial class frmAnadirDepartamento
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
            btnAnadir = new Button();
            lblUbicacion = new Label();
            txtUbicacion = new TextBox();
            lblPrecio = new Label();
            lblMetrosCuadrados = new Label();
            lblNumeroContacto = new Label();
            lblCuartos = new Label();
            lblBanos = new Label();
            txtPrecio = new TextBox();
            txtMetrosCuadrados = new TextBox();
            txtlNumeroContacto = new TextBox();
            txtCuartos = new TextBox();
            txtBanos = new TextBox();
            lblInformacion = new Label();
            txtInformacion = new TextBox();
            pbxImagenDepartamento = new PictureBox();
            btnCargarImgen = new Button();
            lblImagen = new Label();
            btnEliminarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxImagenDepartamento).BeginInit();
            SuspendLayout();
            // 
            // btnAnadir
            // 
            btnAnadir.BackColor = Color.Orange;
            btnAnadir.FlatStyle = FlatStyle.Popup;
            btnAnadir.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAnadir.ForeColor = Color.SeaShell;
            btnAnadir.Location = new Point(419, 459);
            btnAnadir.Margin = new Padding(2, 1, 2, 1);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(442, 28);
            btnAnadir.TabIndex = 0;
            btnAnadir.Text = "Añadir departamento";
            btnAnadir.UseVisualStyleBackColor = false;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.BackColor = Color.Transparent;
            lblUbicacion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUbicacion.ForeColor = Color.SeaShell;
            lblUbicacion.Location = new Point(421, 14);
            lblUbicacion.Margin = new Padding(2, 0, 2, 0);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(70, 19);
            lblUbicacion.TabIndex = 1;
            lblUbicacion.Text = "Ubicación";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(593, 14);
            txtUbicacion.Margin = new Padding(2, 1, 2, 1);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(269, 23);
            txtUbicacion.TabIndex = 2;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.SeaShell;
            lblPrecio.Location = new Point(421, 127);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(48, 19);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblMetrosCuadrados
            // 
            lblMetrosCuadrados.AutoSize = true;
            lblMetrosCuadrados.BackColor = Color.Transparent;
            lblMetrosCuadrados.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetrosCuadrados.ForeColor = Color.SeaShell;
            lblMetrosCuadrados.Location = new Point(419, 318);
            lblMetrosCuadrados.Margin = new Padding(2, 0, 2, 0);
            lblMetrosCuadrados.Name = "lblMetrosCuadrados";
            lblMetrosCuadrados.Size = new Size(120, 19);
            lblMetrosCuadrados.TabIndex = 4;
            lblMetrosCuadrados.Text = "Metros cuadrados";
            // 
            // lblNumeroContacto
            // 
            lblNumeroContacto.AutoSize = true;
            lblNumeroContacto.BackColor = Color.Transparent;
            lblNumeroContacto.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroContacto.ForeColor = Color.SeaShell;
            lblNumeroContacto.Location = new Point(419, 389);
            lblNumeroContacto.Margin = new Padding(2, 0, 2, 0);
            lblNumeroContacto.Name = "lblNumeroContacto";
            lblNumeroContacto.Size = new Size(135, 19);
            lblNumeroContacto.TabIndex = 5;
            lblNumeroContacto.Text = "Numero de contacto";
            // 
            // lblCuartos
            // 
            lblCuartos.AutoSize = true;
            lblCuartos.BackColor = Color.Transparent;
            lblCuartos.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuartos.ForeColor = Color.SeaShell;
            lblCuartos.Location = new Point(419, 189);
            lblCuartos.Margin = new Padding(2, 0, 2, 0);
            lblCuartos.Name = "lblCuartos";
            lblCuartos.Size = new Size(57, 19);
            lblCuartos.TabIndex = 6;
            lblCuartos.Text = "Cuartos";
            // 
            // lblBanos
            // 
            lblBanos.AutoSize = true;
            lblBanos.BackColor = Color.Transparent;
            lblBanos.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanos.ForeColor = Color.SeaShell;
            lblBanos.Location = new Point(419, 251);
            lblBanos.Margin = new Padding(2, 0, 2, 0);
            lblBanos.Name = "lblBanos";
            lblBanos.Size = new Size(46, 19);
            lblBanos.TabIndex = 7;
            lblBanos.Text = "Baños";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(593, 123);
            txtPrecio.Margin = new Padding(2, 1, 2, 1);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(269, 23);
            txtPrecio.TabIndex = 9;
            // 
            // txtMetrosCuadrados
            // 
            txtMetrosCuadrados.Location = new Point(593, 314);
            txtMetrosCuadrados.Margin = new Padding(2, 1, 2, 1);
            txtMetrosCuadrados.Name = "txtMetrosCuadrados";
            txtMetrosCuadrados.Size = new Size(269, 23);
            txtMetrosCuadrados.TabIndex = 10;
            // 
            // txtlNumeroContacto
            // 
            txtlNumeroContacto.Location = new Point(593, 385);
            txtlNumeroContacto.Margin = new Padding(2, 1, 2, 1);
            txtlNumeroContacto.Name = "txtlNumeroContacto";
            txtlNumeroContacto.Size = new Size(269, 23);
            txtlNumeroContacto.TabIndex = 11;
            // 
            // txtCuartos
            // 
            txtCuartos.Location = new Point(593, 188);
            txtCuartos.Margin = new Padding(2, 1, 2, 1);
            txtCuartos.Name = "txtCuartos";
            txtCuartos.Size = new Size(269, 23);
            txtCuartos.TabIndex = 12;
            // 
            // txtBanos
            // 
            txtBanos.Location = new Point(593, 251);
            txtBanos.Margin = new Padding(2, 1, 2, 1);
            txtBanos.Name = "txtBanos";
            txtBanos.Size = new Size(269, 23);
            txtBanos.TabIndex = 13;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.BackColor = Color.Transparent;
            lblInformacion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacion.ForeColor = Color.SeaShell;
            lblInformacion.Location = new Point(419, 77);
            lblInformacion.Margin = new Padding(2, 0, 2, 0);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(82, 19);
            lblInformacion.TabIndex = 14;
            lblInformacion.Text = "Información";
            // 
            // txtInformacion
            // 
            txtInformacion.Location = new Point(593, 73);
            txtInformacion.Margin = new Padding(2, 1, 2, 1);
            txtInformacion.Name = "txtInformacion";
            txtInformacion.Size = new Size(269, 23);
            txtInformacion.TabIndex = 15;
            // 
            // pbxImagenDepartamento
            // 
            pbxImagenDepartamento.BorderStyle = BorderStyle.Fixed3D;
            pbxImagenDepartamento.Location = new Point(27, 88);
            pbxImagenDepartamento.Name = "pbxImagenDepartamento";
            pbxImagenDepartamento.Size = new Size(292, 241);
            pbxImagenDepartamento.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagenDepartamento.TabIndex = 16;
            pbxImagenDepartamento.TabStop = false;
            // 
            // btnCargarImgen
            // 
            btnCargarImgen.BackColor = Color.Orange;
            btnCargarImgen.FlatStyle = FlatStyle.Popup;
            btnCargarImgen.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCargarImgen.ForeColor = Color.SeaShell;
            btnCargarImgen.Location = new Point(186, 373);
            btnCargarImgen.Name = "btnCargarImgen";
            btnCargarImgen.Size = new Size(133, 27);
            btnCargarImgen.TabIndex = 17;
            btnCargarImgen.Text = "Cargar Imagen";
            btnCargarImgen.UseVisualStyleBackColor = false;
            btnCargarImgen.Click += btnCargarImgen_Click;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.BackColor = Color.Transparent;
            lblImagen.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblImagen.ForeColor = Color.Orange;
            lblImagen.Location = new Point(64, 43);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(214, 27);
            lblImagen.TabIndex = 18;
            lblImagen.Text = "Imagen Departamento";
            // 
            // btnEliminarImagen
            // 
            btnEliminarImagen.BackColor = Color.Orange;
            btnEliminarImagen.FlatStyle = FlatStyle.Popup;
            btnEliminarImagen.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminarImagen.ForeColor = Color.SeaShell;
            btnEliminarImagen.Location = new Point(27, 373);
            btnEliminarImagen.Name = "btnEliminarImagen";
            btnEliminarImagen.Size = new Size(133, 27);
            btnEliminarImagen.TabIndex = 19;
            btnEliminarImagen.Text = "Eliminar imagen";
            btnEliminarImagen.UseVisualStyleBackColor = false;
            btnEliminarImagen.Click += btnEliminarImagen_Click;
            // 
            // frmAnadirDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fotoBackground2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(930, 497);
            Controls.Add(btnEliminarImagen);
            Controls.Add(lblImagen);
            Controls.Add(btnCargarImgen);
            Controls.Add(pbxImagenDepartamento);
            Controls.Add(txtInformacion);
            Controls.Add(lblInformacion);
            Controls.Add(txtBanos);
            Controls.Add(txtCuartos);
            Controls.Add(txtlNumeroContacto);
            Controls.Add(txtMetrosCuadrados);
            Controls.Add(txtPrecio);
            Controls.Add(lblBanos);
            Controls.Add(lblCuartos);
            Controls.Add(lblNumeroContacto);
            Controls.Add(lblMetrosCuadrados);
            Controls.Add(lblPrecio);
            Controls.Add(txtUbicacion);
            Controls.Add(lblUbicacion);
            Controls.Add(btnAnadir);
            DoubleBuffered = true;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmAnadirDepartamento";
            Text = "Agregar un departamento nuevo";
            ((System.ComponentModel.ISupportInitialize)pbxImagenDepartamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnadir;
        private Label lblUbicacion;
        private TextBox txtUbicacion;
        private Label lblPrecio;
        private Label lblMetrosCuadrados;
        private Label lblNumeroContacto;
        private Label lblCuartos;
        private Label lblBanos;
        private TextBox txtPrecio;
        private TextBox txtMetrosCuadrados;
        private TextBox txtlNumeroContacto;
        private TextBox txtCuartos;
        private TextBox txtBanos;
        private Label lblInformacion;
        private TextBox txtInformacion;
        private PictureBox pbxImagenDepartamento;
        private Button btnCargarImgen;
        private Label lblImagen;
        private Button btnEliminarImagen;
    }
}