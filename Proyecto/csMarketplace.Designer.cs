namespace Proyecto
{
    partial class csMarketplace
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnControlUsuario = new Panel();
            label2 = new Label();
            rtbDescripcion = new RichTextBox();
            label1 = new Label();
            lblContacto = new Label();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            pbxImagen = new PictureBox();
            pnControlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // pnControlUsuario
            // 
            pnControlUsuario.BackgroundImage = Properties.Resources.fotoBackground2;
            pnControlUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            pnControlUsuario.Controls.Add(label2);
            pnControlUsuario.Controls.Add(rtbDescripcion);
            pnControlUsuario.Controls.Add(label1);
            pnControlUsuario.Controls.Add(lblContacto);
            pnControlUsuario.Controls.Add(lblPrecio);
            pnControlUsuario.Controls.Add(lblDescripcion);
            pnControlUsuario.Controls.Add(lblNombre);
            pnControlUsuario.Controls.Add(pbxImagen);
            pnControlUsuario.Location = new Point(0, 0);
            pnControlUsuario.Margin = new Padding(6, 6, 6, 6);
            pnControlUsuario.Name = "pnControlUsuario";
            pnControlUsuario.Size = new Size(761, 482);
            pnControlUsuario.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaShell;
            label2.Location = new Point(422, 395);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 39);
            label2.TabIndex = 7;
            label2.Text = "Contacto: ";
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDescripcion.Location = new Point(422, 149);
            rtbDescripcion.Margin = new Padding(6, 6, 6, 6);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.ReadOnly = true;
            rtbDescripcion.Size = new Size(258, 119);
            rtbDescripcion.TabIndex = 6;
            rtbDescripcion.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(422, 309);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 39);
            label1.TabIndex = 5;
            label1.Text = "Precio:";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContacto.ForeColor = Color.SeaShell;
            lblContacto.Location = new Point(561, 395);
            lblContacto.Margin = new Padding(6, 0, 6, 0);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(129, 39);
            lblContacto.TabIndex = 4;
            lblContacto.Text = "Contacto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.SeaShell;
            lblPrecio.Location = new Point(529, 309);
            lblPrecio.Margin = new Padding(6, 0, 6, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(97, 39);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = Color.SeaShell;
            lblDescripcion.Location = new Point(422, 102);
            lblDescripcion.Margin = new Padding(6, 0, 6, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(288, 39);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion producto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.SeaShell;
            lblNombre.Location = new Point(422, 26);
            lblNombre.Margin = new Padding(6, 0, 6, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(259, 42);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Producto";
            // 
            // pbxImagen
            // 
            pbxImagen.Location = new Point(22, 26);
            pbxImagen.Margin = new Padding(6, 6, 6, 6);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(368, 429);
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.TabIndex = 0;
            pbxImagen.TabStop = false;
            // 
            // csMarketplace
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnControlUsuario);
            Margin = new Padding(6, 6, 6, 6);
            Name = "csMarketplace";
            Size = new Size(761, 482);
            pnControlUsuario.ResumeLayout(false);
            pnControlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnControlUsuario;
        private PictureBox pbxImagen;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblNombre;
        private Label label1;
        private Label lblContacto;
        private Label label2;
        private RichTextBox rtbDescripcion;
    }
}
