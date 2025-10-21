namespace Proyecto
{
    partial class frmTutoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutoria));
            btnMasInformacion = new Button();
            btnPublicarTutoria = new Button();
            dgvTutoria = new DataGridView();
            lbl1 = new Label();
            lblInstrucciones = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTutoria).BeginInit();
            SuspendLayout();
            // 
            // btnMasInformacion
            // 
            btnMasInformacion.BackColor = Color.Orange;
            btnMasInformacion.FlatStyle = FlatStyle.Popup;
            btnMasInformacion.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMasInformacion.ForeColor = Color.SeaShell;
            btnMasInformacion.Location = new Point(816, 443);
            btnMasInformacion.Name = "btnMasInformacion";
            btnMasInformacion.Size = new Size(208, 30);
            btnMasInformacion.TabIndex = 0;
            btnMasInformacion.Text = "Más información";
            btnMasInformacion.UseVisualStyleBackColor = false;
            btnMasInformacion.Click += btnMasInformacion_Click;
            // 
            // btnPublicarTutoria
            // 
            btnPublicarTutoria.BackColor = Color.Orange;
            btnPublicarTutoria.FlatStyle = FlatStyle.Popup;
            btnPublicarTutoria.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPublicarTutoria.ForeColor = Color.SeaShell;
            btnPublicarTutoria.Location = new Point(816, 501);
            btnPublicarTutoria.Name = "btnPublicarTutoria";
            btnPublicarTutoria.Size = new Size(208, 30);
            btnPublicarTutoria.TabIndex = 1;
            btnPublicarTutoria.Text = "Publicar nueva tutoria";
            btnPublicarTutoria.UseVisualStyleBackColor = false;
            btnPublicarTutoria.Click += btnPublicarTutoria_Click;
            // 
            // dgvTutoria
            // 
            dgvTutoria.BackgroundColor = Color.SeaShell;
            dgvTutoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutoria.Location = new Point(30, 136);
            dgvTutoria.Name = "dgvTutoria";
            dgvTutoria.RowTemplate.Height = 25;
            dgvTutoria.Size = new Size(668, 395);
            dgvTutoria.TabIndex = 2;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Sylfaen", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl1.ForeColor = Color.DarkOrange;
            lbl1.Location = new Point(136, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(857, 84);
            lbl1.TabIndex = 3;
            lbl1.Text = "Sistema de tutorias estudiantil";
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.BackColor = Color.Transparent;
            lblInstrucciones.Font = new Font("Sylfaen", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInstrucciones.ForeColor = Color.Orange;
            lblInstrucciones.Location = new Point(716, 154);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(381, 35);
            lblInstrucciones.TabIndex = 8;
            lblInstrucciones.Text = "¿Cómo funcionan las tutorias?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(739, 211);
            label1.Name = "label1";
            label1.Size = new Size(342, 190);
            label1.TabIndex = 9;
            label1.Text = resources.GetString("label1.Text");
            // 
            // frmTutoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 208, 183);
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1121, 608);
            Controls.Add(label1);
            Controls.Add(lblInstrucciones);
            Controls.Add(lbl1);
            Controls.Add(dgvTutoria);
            Controls.Add(btnPublicarTutoria);
            Controls.Add(btnMasInformacion);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTutoria";
            Text = "frmTutoria";
            ((System.ComponentModel.ISupportInitialize)dgvTutoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMasInformacion;
        private Button btnPublicarTutoria;
        private DataGridView dgvTutoria;
        private Label lbl1;
        private Label lblInstrucciones;
        private Label label1;
    }
}