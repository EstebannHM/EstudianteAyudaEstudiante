namespace Proyecto
{
    partial class frmForo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForo));
            lblForo = new Label();
            btnAnadirPregunta = new Button();
            dgvPreguntas = new DataGridView();
            btnVerComentarios = new Button();
            lblInstrucciones = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).BeginInit();
            SuspendLayout();
            // 
            // lblForo
            // 
            lblForo.AutoSize = true;
            lblForo.BackColor = Color.Transparent;
            lblForo.Font = new Font("Sylfaen", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblForo.ForeColor = Color.DarkOrange;
            lblForo.Location = new Point(451, 64);
            lblForo.Margin = new Padding(4, 0, 4, 0);
            lblForo.Name = "lblForo";
            lblForo.Size = new Size(702, 126);
            lblForo.TabIndex = 0;
            lblForo.Text = "Foro estudiantil";
            // 
            // btnAnadirPregunta
            // 
            btnAnadirPregunta.BackColor = Color.Orange;
            btnAnadirPregunta.FlatStyle = FlatStyle.Popup;
            btnAnadirPregunta.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAnadirPregunta.ForeColor = Color.SeaShell;
            btnAnadirPregunta.Location = new Point(1616, 1118);
            btnAnadirPregunta.Margin = new Padding(4, 2, 4, 2);
            btnAnadirPregunta.Name = "btnAnadirPregunta";
            btnAnadirPregunta.Size = new Size(366, 64);
            btnAnadirPregunta.TabIndex = 1;
            btnAnadirPregunta.Text = "Añadir una pregunta";
            btnAnadirPregunta.UseVisualStyleBackColor = false;
            btnAnadirPregunta.Click += btnAnadirPregunta_Click;
            // 
            // dgvPreguntas
            // 
            dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreguntas.Location = new Point(39, 311);
            dgvPreguntas.Margin = new Padding(4, 2, 4, 2);
            dgvPreguntas.Name = "dgvPreguntas";
            dgvPreguntas.RowHeadersWidth = 82;
            dgvPreguntas.RowTemplate.Height = 41;
            dgvPreguntas.Size = new Size(1382, 973);
            dgvPreguntas.TabIndex = 2;
            dgvPreguntas.DataBindingComplete += dgvPreguntas_DataBindingComplete;
            dgvPreguntas.DoubleClick += dgvPreguntas_DoubleClick;
            // 
            // btnVerComentarios
            // 
            btnVerComentarios.BackColor = Color.Orange;
            btnVerComentarios.FlatStyle = FlatStyle.Popup;
            btnVerComentarios.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnVerComentarios.ForeColor = Color.SeaShell;
            btnVerComentarios.Location = new Point(1616, 1220);
            btnVerComentarios.Margin = new Padding(4, 2, 4, 2);
            btnVerComentarios.Name = "btnVerComentarios";
            btnVerComentarios.Size = new Size(366, 64);
            btnVerComentarios.TabIndex = 3;
            btnVerComentarios.Text = "Ver comentarios";
            btnVerComentarios.UseVisualStyleBackColor = false;
            btnVerComentarios.Click += btnVerComentarios_Click;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.BackColor = Color.Transparent;
            lblInstrucciones.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInstrucciones.ForeColor = Color.Orange;
            lblInstrucciones.Location = new Point(1519, 320);
            lblInstrucciones.Margin = new Padding(6, 0, 6, 0);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(524, 55);
            lblInstrucciones.TabIndex = 8;
            lblInstrucciones.Text = "¿Qué es el foro estudiantil?";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.ForeColor = Color.SeaShell;
            lbl1.Location = new Point(1456, 399);
            lbl1.Margin = new Padding(6, 0, 6, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(648, 140);
            lbl1.TabIndex = 9;
            lbl1.Text = "- El foro estudiantil es un sistema donde los estudiantes\r\nvan a poder realizar preguntas a otros estudiantes y esos\r\nmismos estudiantes responderán a las preguntas del otro.\r\n\r\n";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl2.ForeColor = Color.Orange;
            lbl2.Location = new Point(1456, 619);
            lbl2.Margin = new Padding(6, 0, 6, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(638, 55);
            lbl2.TabIndex = 10;
            lbl2.Text = "¿Cómo utilizo el foro estudiantil?";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.ForeColor = Color.SeaShell;
            lbl3.Location = new Point(1472, 710);
            lbl3.Margin = new Padding(6, 0, 6, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(632, 350);
            lbl3.TabIndex = 11;
            lbl3.Text = resources.GetString("lbl3.Text");
            // 
            // frmForo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2112, 1380);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblInstrucciones);
            Controls.Add(btnVerComentarios);
            Controls.Add(dgvPreguntas);
            Controls.Add(btnAnadirPregunta);
            Controls.Add(lblForo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmForo";
            Text = "Foro";
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblForo;
        private Button btnAnadirPregunta;
        private DataGridView dgvPreguntas;
        private Button btnVerComentarios;
        private Label lblInstrucciones;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
    }
}