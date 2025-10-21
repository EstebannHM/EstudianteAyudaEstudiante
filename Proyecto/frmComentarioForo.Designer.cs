namespace Proyecto
{
    partial class frmComentarioForo
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
            btnAnadirRespuesta = new Button();
            lblRespuestas = new Label();
            flpRespuestas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnAnadirRespuesta
            // 
            btnAnadirRespuesta.BackColor = Color.Orange;
            btnAnadirRespuesta.FlatStyle = FlatStyle.Popup;
            btnAnadirRespuesta.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAnadirRespuesta.ForeColor = Color.SeaShell;
            btnAnadirRespuesta.Location = new Point(325, 427);
            btnAnadirRespuesta.Margin = new Padding(2, 1, 2, 1);
            btnAnadirRespuesta.Name = "btnAnadirRespuesta";
            btnAnadirRespuesta.Size = new Size(270, 30);
            btnAnadirRespuesta.TabIndex = 1;
            btnAnadirRespuesta.Text = "Añadir una nueva respuesta";
            btnAnadirRespuesta.UseVisualStyleBackColor = false;
            btnAnadirRespuesta.Click += btnAnadirRespuesta_Click;
            // 
            // lblRespuestas
            // 
            lblRespuestas.AutoSize = true;
            lblRespuestas.BackColor = Color.Transparent;
            lblRespuestas.Font = new Font("Sylfaen", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRespuestas.ForeColor = Color.DarkOrange;
            lblRespuestas.Location = new Point(290, 20);
            lblRespuestas.Name = "lblRespuestas";
            lblRespuestas.Size = new Size(320, 48);
            lblRespuestas.TabIndex = 2;
            lblRespuestas.Text = "Lista de respuestas";
            // 
            // flpRespuestas
            // 
            flpRespuestas.AutoScroll = true;
            flpRespuestas.BackColor = Color.SlateBlue;
            flpRespuestas.Location = new Point(56, 82);
            flpRespuestas.Name = "flpRespuestas";
            flpRespuestas.Size = new Size(795, 317);
            flpRespuestas.TabIndex = 3;
            // 
            // frmComentarioForo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fotoBackground2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(909, 478);
            Controls.Add(flpRespuestas);
            Controls.Add(lblRespuestas);
            Controls.Add(btnAnadirRespuesta);
            DoubleBuffered = true;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmComentarioForo";
            Text = "Respuestas a la pregunta seleccionada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAnadirRespuesta;
        private Label lblRespuestas;
        private FlowLayoutPanel flpRespuestas;
    }
}