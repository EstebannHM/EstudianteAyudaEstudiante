namespace Proyecto
{
    partial class frmAgregarProducto
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
            btnGuardarProducto = new Button();
            lblAgregarNuevoProducto = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblFotoProducto = new Label();
            pbxFotoProducto = new PictureBox();
            btnImagen = new Button();
            lblContacto = new Label();
            txtContacto = new TextBox();
            btnEliminarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxFotoProducto).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.Orange;
            btnGuardarProducto.FlatStyle = FlatStyle.Popup;
            btnGuardarProducto.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardarProducto.ForeColor = Color.SeaShell;
            btnGuardarProducto.Location = new Point(73, 415);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(382, 23);
            btnGuardarProducto.TabIndex = 0;
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // lblAgregarNuevoProducto
            // 
            lblAgregarNuevoProducto.AutoSize = true;
            lblAgregarNuevoProducto.BackColor = Color.Transparent;
            lblAgregarNuevoProducto.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarNuevoProducto.ForeColor = Color.DarkOrange;
            lblAgregarNuevoProducto.Location = new Point(73, 34);
            lblAgregarNuevoProducto.Name = "lblAgregarNuevoProducto";
            lblAgregarNuevoProducto.Size = new Size(229, 25);
            lblAgregarNuevoProducto.TabIndex = 1;
            lblAgregarNuevoProducto.Text = "Agregar nuevo producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(285, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(285, 201);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(170, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(285, 285);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(170, 23);
            txtPrecio.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(73, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(141, 19);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre del producto";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = SystemColors.Control;
            lblDescripcion.Location = new Point(73, 205);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(120, 19);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripcion breve";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = SystemColors.Control;
            lblPrecio.Location = new Point(73, 289);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(48, 19);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // lblFotoProducto
            // 
            lblFotoProducto.AutoSize = true;
            lblFotoProducto.BackColor = Color.Transparent;
            lblFotoProducto.Font = new Font("Sylfaen", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblFotoProducto.ForeColor = Color.Orange;
            lblFotoProducto.Location = new Point(522, 48);
            lblFotoProducto.Name = "lblFotoProducto";
            lblFotoProducto.Size = new Size(253, 25);
            lblFotoProducto.TabIndex = 8;
            lblFotoProducto.Text = "Agregar una foto del producto";
            // 
            // pbxFotoProducto
            // 
            pbxFotoProducto.Location = new Point(541, 86);
            pbxFotoProducto.Name = "pbxFotoProducto";
            pbxFotoProducto.Size = new Size(217, 201);
            pbxFotoProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFotoProducto.TabIndex = 9;
            pbxFotoProducto.TabStop = false;
            // 
            // btnImagen
            // 
            btnImagen.BackColor = Color.Orange;
            btnImagen.FlatStyle = FlatStyle.Popup;
            btnImagen.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnImagen.ForeColor = Color.SeaShell;
            btnImagen.Location = new Point(506, 302);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(143, 23);
            btnImagen.TabIndex = 10;
            btnImagen.Text = "Añadir imagen";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.BackColor = Color.Transparent;
            lblContacto.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContacto.ForeColor = SystemColors.Control;
            lblContacto.Location = new Point(73, 364);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(66, 19);
            lblContacto.TabIndex = 12;
            lblContacto.Text = "Contacto";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(285, 360);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(170, 23);
            txtContacto.TabIndex = 11;
            // 
            // btnEliminarImagen
            // 
            btnEliminarImagen.BackColor = Color.Orange;
            btnEliminarImagen.FlatStyle = FlatStyle.Popup;
            btnEliminarImagen.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminarImagen.ForeColor = Color.SeaShell;
            btnEliminarImagen.Location = new Point(655, 302);
            btnEliminarImagen.Name = "btnEliminarImagen";
            btnEliminarImagen.Size = new Size(143, 23);
            btnEliminarImagen.TabIndex = 13;
            btnEliminarImagen.Text = "Eliminar Imagen";
            btnEliminarImagen.UseVisualStyleBackColor = false;
            btnEliminarImagen.Click += btnEliminarImagen_Click;
            // 
            // frmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarImagen);
            Controls.Add(lblContacto);
            Controls.Add(txtContacto);
            Controls.Add(btnImagen);
            Controls.Add(pbxFotoProducto);
            Controls.Add(lblFotoProducto);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblAgregarNuevoProducto);
            Controls.Add(btnGuardarProducto);
            DoubleBuffered = true;
            Name = "frmAgregarProducto";
            Text = "Agregar Prodcuto Nuevo";
            ((System.ComponentModel.ISupportInitialize)pbxFotoProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarProducto;
        private Label lblAgregarNuevoProducto;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblFotoProducto;
        private PictureBox pbxFotoProducto;
        private Button btnImagen;
        private Label lblContacto;
        private TextBox txtContacto;
        private Button btnEliminarImagen;
    }
}