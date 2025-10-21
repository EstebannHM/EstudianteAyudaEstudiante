namespace Proyecto
{
    partial class frmDirectorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectorio));
            dgvOficina = new DataGridView();
            lblDirectorio = new Label();
            lbl1 = new Label();
            lblInstrucciones = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOficina).BeginInit();
            SuspendLayout();
            // 
            // dgvOficina
            // 
            dgvOficina.BackgroundColor = Color.SeaShell;
            dgvOficina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOficina.Location = new Point(22, 303);
            dgvOficina.Margin = new Padding(6, 6, 6, 6);
            dgvOficina.Name = "dgvOficina";
            dgvOficina.RowHeadersWidth = 82;
            dgvOficina.RowTemplate.Height = 25;
            dgvOficina.Size = new Size(1283, 994);
            dgvOficina.TabIndex = 0;
            // 
            // lblDirectorio
            // 
            lblDirectorio.AutoSize = true;
            lblDirectorio.BackColor = Color.Transparent;
            lblDirectorio.Font = new Font("Sylfaen", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDirectorio.ForeColor = Color.DarkOrange;
            lblDirectorio.Location = new Point(366, 38);
            lblDirectorio.Margin = new Padding(6, 0, 6, 0);
            lblDirectorio.Name = "lblDirectorio";
            lblDirectorio.Size = new Size(633, 166);
            lblDirectorio.TabIndex = 1;
            lblDirectorio.Text = "Directorio";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.BorderStyle = BorderStyle.Fixed3D;
            lbl1.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.ForeColor = Color.SeaShell;
            lbl1.Location = new Point(1345, 601);
            lbl1.Margin = new Padding(6, 0, 6, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(727, 317);
            lbl1.TabIndex = 6;
            lbl1.Text = resources.GetString("lbl1.Text");
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.BackColor = Color.Transparent;
            lblInstrucciones.Font = new Font("Sylfaen", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInstrucciones.ForeColor = Color.Orange;
            lblInstrucciones.Location = new Point(1345, 459);
            lblInstrucciones.Margin = new Padding(6, 0, 6, 0);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(748, 70);
            lblInstrucciones.TabIndex = 7;
            lblInstrucciones.Text = "Funcionamiento del directorio";
            // 
            // frmDirectorio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 208, 183);
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2112, 1380);
            Controls.Add(lblInstrucciones);
            Controls.Add(lbl1);
            Controls.Add(lblDirectorio);
            Controls.Add(dgvOficina);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmDirectorio";
            Text = "frmDirectorio";
            ((System.ComponentModel.ISupportInitialize)dgvOficina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOficina;
        private Label lblDirectorio;
        private Label lbl1;
        private Label lblInstrucciones;
    }
}