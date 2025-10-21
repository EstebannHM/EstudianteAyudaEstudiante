namespace Proyecto
{
    partial class frmAnadirRespuesta
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
            lblRespuesta = new Label();
            rtbRespuesta = new RichTextBox();
            SuspendLayout();
            // 
            // btnAnadirRespuesta
            // 
            btnAnadirRespuesta.BackColor = Color.Orange;
            btnAnadirRespuesta.FlatStyle = FlatStyle.Popup;
            btnAnadirRespuesta.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAnadirRespuesta.ForeColor = Color.SeaShell;
            btnAnadirRespuesta.Location = new Point(117, 157);
            btnAnadirRespuesta.Margin = new Padding(2, 1, 2, 1);
            btnAnadirRespuesta.Name = "btnAnadirRespuesta";
            btnAnadirRespuesta.Size = new Size(280, 30);
            btnAnadirRespuesta.TabIndex = 0;
            btnAnadirRespuesta.Text = "Anadir Respuesta";
            btnAnadirRespuesta.UseVisualStyleBackColor = false;
            btnAnadirRespuesta.Click += btnAnadirRespuesta_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.BackColor = Color.Transparent;
            lblRespuesta.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRespuesta.ForeColor = Color.SeaShell;
            lblRespuesta.Location = new Point(11, 32);
            lblRespuesta.Margin = new Padding(2, 0, 2, 0);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(74, 22);
            lblRespuesta.TabIndex = 2;
            lblRespuesta.Text = "Respuesta";
            // 
            // rtbRespuesta
            // 
            rtbRespuesta.Location = new Point(117, 32);
            rtbRespuesta.Name = "rtbRespuesta";
            rtbRespuesta.Size = new Size(280, 96);
            rtbRespuesta.TabIndex = 3;
            rtbRespuesta.Text = "";
            // 
            // frmAnadirRespuesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fotoBackground3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(431, 211);
            Controls.Add(rtbRespuesta);
            Controls.Add(lblRespuesta);
            Controls.Add(btnAnadirRespuesta);
            DoubleBuffered = true;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmAnadirRespuesta";
            Text = "Añadir una respuesta nueva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnadirRespuesta;
        private Label lblRespuesta;
        private RichTextBox rtbRespuesta;
    }
}