namespace Proyecto
{
    partial class csForoRespuestas
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
            panel1 = new Panel();
            rtbRespuesta = new RichTextBox();
            lbl1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fotoBackground3;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(rtbRespuesta);
            panel1.Controls.Add(lbl1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 101);
            panel1.TabIndex = 0;
            // 
            // rtbRespuesta
            // 
            rtbRespuesta.BackColor = Color.SeaShell;
            rtbRespuesta.BorderStyle = BorderStyle.FixedSingle;
            rtbRespuesta.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rtbRespuesta.ForeColor = SystemColors.ActiveCaptionText;
            rtbRespuesta.Location = new Point(198, 22);
            rtbRespuesta.Name = "rtbRespuesta";
            rtbRespuesta.Size = new Size(513, 52);
            rtbRespuesta.TabIndex = 1;
            rtbRespuesta.Text = "";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.ForeColor = Color.SeaShell;
            lbl1.Location = new Point(26, 35);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(112, 27);
            lbl1.TabIndex = 0;
            lbl1.Text = "Respuesta: ";
            // 
            // csForoRespuestas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "csForoRespuestas";
            Size = new Size(770, 101);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox rtbRespuesta;
        private Label lbl1;
    }
}
