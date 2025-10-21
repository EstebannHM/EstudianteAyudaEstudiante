namespace Proyecto
{
    partial class frmAnadirPregunta
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
            btnAnadirPregunta = new Button();
            lblTitulo = new Label();
            lblPregunta = new Label();
            txtTitulo = new TextBox();
            txtPregunta = new TextBox();
            SuspendLayout();
            // 
            // btnAnadirPregunta
            // 
            btnAnadirPregunta.BackColor = Color.Orange;
            btnAnadirPregunta.FlatStyle = FlatStyle.Popup;
            btnAnadirPregunta.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAnadirPregunta.ForeColor = Color.SeaShell;
            btnAnadirPregunta.Location = new Point(151, 167);
            btnAnadirPregunta.Margin = new Padding(2, 1, 2, 1);
            btnAnadirPregunta.Name = "btnAnadirPregunta";
            btnAnadirPregunta.Size = new Size(265, 30);
            btnAnadirPregunta.TabIndex = 0;
            btnAnadirPregunta.Text = "Añadir mi nueva pregunta";
            btnAnadirPregunta.UseVisualStyleBackColor = false;
            btnAnadirPregunta.Click += btnAnadirPregunta_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.SeaShell;
            lblTitulo.Location = new Point(11, 31);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo de pregunta";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Transparent;
            lblPregunta.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPregunta.ForeColor = Color.SeaShell;
            lblPregunta.Location = new Point(11, 115);
            lblPregunta.Margin = new Padding(2, 0, 2, 0);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(103, 19);
            lblPregunta.TabIndex = 2;
            lblPregunta.Text = "Pregunta nueva";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(151, 31);
            txtTitulo.Margin = new Padding(2, 1, 2, 1);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(265, 23);
            txtTitulo.TabIndex = 3;
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(151, 111);
            txtPregunta.Margin = new Padding(2, 1, 2, 1);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(265, 23);
            txtPregunta.TabIndex = 4;
            // 
            // frmAnadirPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fotoBackground3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(431, 211);
            Controls.Add(txtPregunta);
            Controls.Add(txtTitulo);
            Controls.Add(lblPregunta);
            Controls.Add(lblTitulo);
            Controls.Add(btnAnadirPregunta);
            DoubleBuffered = true;
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmAnadirPregunta";
            Text = "Añadir una nueva pregunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnadirPregunta;
        private Label lblTitulo;
        private Label lblPregunta;
        private TextBox txtTitulo;
        private TextBox txtPregunta;
    }
}