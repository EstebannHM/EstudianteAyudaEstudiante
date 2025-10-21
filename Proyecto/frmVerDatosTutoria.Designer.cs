namespace Proyecto
{
    partial class frmVerDatosTutoria
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
            txtMateria = new TextBox();
            txtFecha = new TextBox();
            txtTutor = new TextBox();
            txtContacto = new TextBox();
            rtbDescripcion = new RichTextBox();
            lblDescripcion = new Label();
            lblContacto = new Label();
            lblTutor = new Label();
            lblFecha = new Label();
            lblMateria = new Label();
            SuspendLayout();
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(288, 34);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(230, 23);
            txtMateria.TabIndex = 5;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(288, 100);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(230, 23);
            txtFecha.TabIndex = 6;
            // 
            // txtTutor
            // 
            txtTutor.Location = new Point(288, 166);
            txtTutor.Name = "txtTutor";
            txtTutor.Size = new Size(230, 23);
            txtTutor.TabIndex = 7;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(288, 228);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(230, 23);
            txtContacto.TabIndex = 8;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(288, 299);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(230, 96);
            rtbDescripcion.TabIndex = 9;
            rtbDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = Color.SeaShell;
            lblDescripcion.Location = new Point(69, 299);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(158, 19);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción de la tutoria";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.BackColor = Color.Transparent;
            lblContacto.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContacto.ForeColor = Color.SeaShell;
            lblContacto.Location = new Point(69, 232);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(66, 19);
            lblContacto.TabIndex = 3;
            lblContacto.Text = "Contacto";
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.BackColor = Color.Transparent;
            lblTutor.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTutor.ForeColor = Color.SeaShell;
            lblTutor.Location = new Point(69, 166);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(43, 19);
            lblTutor.TabIndex = 2;
            lblTutor.Text = "Tutor";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.SeaShell;
            lblFecha.Location = new Point(69, 104);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(45, 19);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.BackColor = Color.Transparent;
            lblMateria.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMateria.ForeColor = Color.SeaShell;
            lblMateria.Location = new Point(69, 34);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(56, 19);
            lblMateria.TabIndex = 0;
            lblMateria.Text = "Materia";
            // 
            // frmVerDatosTutoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fotoBackground3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(597, 416);
            Controls.Add(rtbDescripcion);
            Controls.Add(txtContacto);
            Controls.Add(txtTutor);
            Controls.Add(txtFecha);
            Controls.Add(txtMateria);
            Controls.Add(lblDescripcion);
            Controls.Add(lblContacto);
            Controls.Add(lblTutor);
            Controls.Add(lblFecha);
            Controls.Add(lblMateria);
            DoubleBuffered = true;
            Name = "frmVerDatosTutoria";
            Text = "Visualizamiento de los datos de la tutoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMateria;
        private TextBox txtFecha;
        private TextBox txtTutor;
        private TextBox txtContacto;
        private RichTextBox rtbDescripcion;
        private Label lblDescripcion;
        private Label lblContacto;
        private Label lblTutor;
        private Label lblFecha;
        private Label lblMateria;
    }
}