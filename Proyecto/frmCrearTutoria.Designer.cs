namespace Proyecto
{
    partial class frmCrearTutoria
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
            rtbDescripcion = new RichTextBox();
            txtContacto = new TextBox();
            txtTutor = new TextBox();
            txtFecha = new TextBox();
            txtMateria = new TextBox();
            btnPublicar = new Button();
            lblDescripcion = new Label();
            lblContacto = new Label();
            lblTutor = new Label();
            lblFecha = new Label();
            lblMateria = new Label();
            lblTutoriaNueva = new Label();
            SuspendLayout();
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(357, 362);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(230, 96);
            rtbDescripcion.TabIndex = 19;
            rtbDescripcion.Text = "";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(357, 295);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(230, 23);
            txtContacto.TabIndex = 18;
            // 
            // txtTutor
            // 
            txtTutor.Location = new Point(357, 229);
            txtTutor.Name = "txtTutor";
            txtTutor.Size = new Size(230, 23);
            txtTutor.TabIndex = 17;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(357, 163);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(230, 23);
            txtFecha.TabIndex = 16;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(357, 93);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(230, 23);
            txtMateria.TabIndex = 15;
            // 
            // btnPublicar
            // 
            btnPublicar.BackColor = Color.Orange;
            btnPublicar.FlatStyle = FlatStyle.Popup;
            btnPublicar.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPublicar.ForeColor = Color.SeaShell;
            btnPublicar.Location = new Point(134, 497);
            btnPublicar.Name = "btnPublicar";
            btnPublicar.Size = new Size(453, 30);
            btnPublicar.TabIndex = 20;
            btnPublicar.Text = "Publicar mi nueva tutoria";
            btnPublicar.UseVisualStyleBackColor = false;
            btnPublicar.Click += btnPublicar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = Color.SeaShell;
            lblDescripcion.Location = new Point(134, 363);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(158, 19);
            lblDescripcion.TabIndex = 25;
            lblDescripcion.Text = "Descripción de la tutoria";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.BackColor = Color.Transparent;
            lblContacto.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContacto.ForeColor = Color.SeaShell;
            lblContacto.Location = new Point(134, 295);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(66, 19);
            lblContacto.TabIndex = 24;
            lblContacto.Text = "Contacto";
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.BackColor = Color.Transparent;
            lblTutor.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTutor.ForeColor = Color.SeaShell;
            lblTutor.Location = new Point(134, 229);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(43, 19);
            lblTutor.TabIndex = 23;
            lblTutor.Text = "Tutor";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.SeaShell;
            lblFecha.Location = new Point(134, 163);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(45, 19);
            lblFecha.TabIndex = 22;
            lblFecha.Text = "Fecha";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.BackColor = Color.Transparent;
            lblMateria.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateria.ForeColor = Color.SeaShell;
            lblMateria.Location = new Point(134, 93);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(56, 19);
            lblMateria.TabIndex = 21;
            lblMateria.Text = "Materia";
            // 
            // lblTutoriaNueva
            // 
            lblTutoriaNueva.AutoSize = true;
            lblTutoriaNueva.BackColor = Color.Transparent;
            lblTutoriaNueva.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTutoriaNueva.ForeColor = Color.Orange;
            lblTutoriaNueva.Location = new Point(276, 9);
            lblTutoriaNueva.Name = "lblTutoriaNueva";
            lblTutoriaNueva.Size = new Size(154, 27);
            lblTutoriaNueva.TabIndex = 26;
            lblTutoriaNueva.Text = "Añadir tutoria";
            // 
            // frmCrearTutoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fotoBackground2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 556);
            Controls.Add(lblTutoriaNueva);
            Controls.Add(lblDescripcion);
            Controls.Add(lblContacto);
            Controls.Add(lblTutor);
            Controls.Add(lblFecha);
            Controls.Add(lblMateria);
            Controls.Add(btnPublicar);
            Controls.Add(rtbDescripcion);
            Controls.Add(txtContacto);
            Controls.Add(txtTutor);
            Controls.Add(txtFecha);
            Controls.Add(txtMateria);
            DoubleBuffered = true;
            Name = "frmCrearTutoria";
            Text = "Añadir una nueva tutoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbDescripcion;
        private TextBox txtContacto;
        private TextBox txtTutor;
        private TextBox txtFecha;
        private TextBox txtMateria;
        private Button btnPublicar;
        private Label lblDescripcion;
        private Label lblContacto;
        private Label lblTutor;
        private Label lblFecha;
        private Label lblMateria;
        private Label lblTutoriaNueva;
    }
}