namespace Proyecto
{
    partial class frmTerminosYCondiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminosYCondiciones));
            rkbTerminosYCondiciones = new RichTextBox();
            SuspendLayout();
            // 
            // rkbTerminosYCondiciones
            // 
            rkbTerminosYCondiciones.Location = new Point(-3, -2);
            rkbTerminosYCondiciones.Name = "rkbTerminosYCondiciones";
            rkbTerminosYCondiciones.ReadOnly = true;
            rkbTerminosYCondiciones.Size = new Size(367, 410);
            rkbTerminosYCondiciones.TabIndex = 1;
            rkbTerminosYCondiciones.Text = resources.GetString("rkbTerminosYCondiciones.Text");
            // 
            // frmTerminosYCondiciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 407);
            Controls.Add(rkbTerminosYCondiciones);
            Name = "frmTerminosYCondiciones";
            Text = "Terminos y Condiciones";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rkbTerminosYCondiciones;
    }
}