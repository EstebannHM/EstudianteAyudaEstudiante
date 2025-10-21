namespace Proyecto
{
    partial class frmFuncionalidadesInicio
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
            pbxImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // pbxImagen
            // 
            pbxImagen.Image = Properties.Resources.fotoFondoPrincipal;
            pbxImagen.Location = new Point(0, 0);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(1137, 647);
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.TabIndex = 0;
            pbxImagen.TabStop = false;
            // 
            // frmFuncionalidadesInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1137, 647);
            Controls.Add(pbxImagen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFuncionalidadesInicio";
            Text = "Funcionalidades Inicio";
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbxImagen;
    }
}