namespace Proyecto
{
    partial class frmAitbnt
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
            lblAirbnt = new Label();
            btnAnadiDepartamento = new Button();
            dgvDepartamento = new DataGridView();
            btnMasInformacion = new Button();
            lblInstrucciones = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamento).BeginInit();
            SuspendLayout();
            // 
            // lblAirbnt
            // 
            lblAirbnt.AutoSize = true;
            lblAirbnt.BackColor = Color.Transparent;
            lblAirbnt.Font = new Font("Sylfaen", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAirbnt.ForeColor = Color.DarkOrange;
            lblAirbnt.Location = new Point(334, 19);
            lblAirbnt.Margin = new Padding(4, 0, 4, 0);
            lblAirbnt.Name = "lblAirbnt";
            lblAirbnt.Size = new Size(1506, 166);
            lblAirbnt.TabIndex = 0;
            lblAirbnt.Text = "Sistema de Departamentos";
            // 
            // btnAnadiDepartamento
            // 
            btnAnadiDepartamento.BackColor = Color.Orange;
            btnAnadiDepartamento.FlatStyle = FlatStyle.Popup;
            btnAnadiDepartamento.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAnadiDepartamento.ForeColor = Color.SeaShell;
            btnAnadiDepartamento.Location = new Point(1588, 1152);
            btnAnadiDepartamento.Margin = new Padding(4, 2, 4, 2);
            btnAnadiDepartamento.Name = "btnAnadiDepartamento";
            btnAnadiDepartamento.Size = new Size(384, 64);
            btnAnadiDepartamento.TabIndex = 1;
            btnAnadiDepartamento.Text = "Añadir un departamento";
            btnAnadiDepartamento.UseVisualStyleBackColor = false;
            btnAnadiDepartamento.Click += btnAnadiDepartamento_Click;
            // 
            // dgvDepartamento
            // 
            dgvDepartamento.BackgroundColor = Color.SeaShell;
            dgvDepartamento.BorderStyle = BorderStyle.None;
            dgvDepartamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamento.Location = new Point(22, 318);
            dgvDepartamento.Margin = new Padding(6, 6, 6, 6);
            dgvDepartamento.Name = "dgvDepartamento";
            dgvDepartamento.RowHeadersWidth = 82;
            dgvDepartamento.RowTemplate.Height = 25;
            dgvDepartamento.Size = new Size(1356, 1003);
            dgvDepartamento.TabIndex = 2;
            dgvDepartamento.DataBindingComplete += dgvDepartamento_DataBindingComplete;
            // 
            // btnMasInformacion
            // 
            btnMasInformacion.BackColor = Color.Orange;
            btnMasInformacion.FlatStyle = FlatStyle.Popup;
            btnMasInformacion.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMasInformacion.ForeColor = Color.SeaShell;
            btnMasInformacion.Location = new Point(1588, 1257);
            btnMasInformacion.Margin = new Padding(6, 6, 6, 6);
            btnMasInformacion.Name = "btnMasInformacion";
            btnMasInformacion.Size = new Size(384, 64);
            btnMasInformacion.TabIndex = 3;
            btnMasInformacion.Text = "Ver más información";
            btnMasInformacion.UseVisualStyleBackColor = false;
            btnMasInformacion.Click += btnMasInformacion_Click;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.BackColor = Color.Transparent;
            lblInstrucciones.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInstrucciones.ForeColor = Color.Orange;
            lblInstrucciones.Location = new Point(1502, 318);
            lblInstrucciones.Margin = new Padding(6, 0, 6, 0);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(470, 55);
            lblInstrucciones.TabIndex = 4;
            lblInstrucciones.Text = "Pasos a tomar en cuenta";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.ForeColor = Color.SeaShell;
            lbl1.Location = new Point(1404, 467);
            lbl1.Margin = new Padding(6, 0, 6, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(670, 70);
            lbl1.TabIndex = 5;
            lbl1.Text = "- En caso de agregar un departamento, por favo introducir \r\nvalores reales.";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.ForeColor = Color.SeaShell;
            lbl2.Location = new Point(1404, 621);
            lbl2.Margin = new Padding(6, 0, 6, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(656, 70);
            lbl2.TabIndex = 6;
            lbl2.Text = "- Si desea visualizar un departamento seleccionelo, luego \r\ndirigase al boton que está en la esquina inferior derecha.\r\n";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.ForeColor = Color.SeaShell;
            lbl3.Location = new Point(1404, 775);
            lbl3.Margin = new Padding(6, 0, 6, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(648, 70);
            lbl3.TabIndex = 7;
            lbl3.Text = "- Utilice el sistema para lo que es y con el proposito que \r\ntiene brindarle a los estudiantes.\r\n";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.Transparent;
            lbl4.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4.ForeColor = Color.SeaShell;
            lbl4.Location = new Point(1404, 934);
            lbl4.Margin = new Padding(6, 0, 6, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(712, 70);
            lbl4.TabIndex = 8;
            lbl4.Text = "- Para agregar un departamento nuevo debe de dirigirse a la \r\nparte inferior izquierda en el botón \"Añadir un departamento\".";
            // 
            // frmAitbnt
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 208, 183);
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2112, 1380);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblInstrucciones);
            Controls.Add(btnMasInformacion);
            Controls.Add(dgvDepartamento);
            Controls.Add(btnAnadiDepartamento);
            Controls.Add(lblAirbnt);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmAitbnt";
            Text = "Airbnt";
            ((System.ComponentModel.ISupportInitialize)dgvDepartamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAirbnt;
        private Button btnAnadiDepartamento;
        private DataGridView dgvDepartamento;
        private Button btnMasInformacion;
        private Label lblInstrucciones;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
    }
}