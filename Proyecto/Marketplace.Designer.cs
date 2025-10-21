namespace Proyecto
{
    partial class frmMarketplace
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
            lblMarketplace = new Label();
            btnAgregarProducto = new Button();
            flpMarketplace = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblMarketplace
            // 
            lblMarketplace.AutoSize = true;
            lblMarketplace.BackColor = Color.Transparent;
            lblMarketplace.Font = new Font("Sylfaen", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMarketplace.ForeColor = Color.DarkOrange;
            lblMarketplace.Location = new Point(401, 21);
            lblMarketplace.Name = "lblMarketplace";
            lblMarketplace.Size = new Size(286, 62);
            lblMarketplace.TabIndex = 0;
            lblMarketplace.Text = "Marketplace";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.Orange;
            btnAgregarProducto.FlatStyle = FlatStyle.Popup;
            btnAgregarProducto.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = Color.SeaShell;
            btnAgregarProducto.Location = new Point(752, 593);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(241, 33);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar Nuevo Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // flpMarketplace
            // 
            flpMarketplace.AutoScroll = true;
            flpMarketplace.BackColor = Color.Transparent;
            flpMarketplace.BackgroundImageLayout = ImageLayout.None;
            flpMarketplace.Location = new Point(124, 86);
            flpMarketplace.Name = "flpMarketplace";
            flpMarketplace.Size = new Size(869, 483);
            flpMarketplace.TabIndex = 2;
            // 
            // frmMarketplace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.fotoBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1137, 647);
            Controls.Add(flpMarketplace);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblMarketplace);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMarketplace";
            Text = "Marketplace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarketplace;
        private Button btnAgregarProducto;
        private FlowLayoutPanel flpMarketplace;
    }
}