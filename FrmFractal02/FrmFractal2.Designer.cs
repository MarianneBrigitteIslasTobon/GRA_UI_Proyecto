namespace FrmFractal02
{
    partial class FrmFractal2
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxFractal002 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFractal002)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxFractal002
            // 
            this.PictureBoxFractal002.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxFractal002.Name = "PictureBoxFractal002";
            this.PictureBoxFractal002.Size = new System.Drawing.Size(550, 550);
            this.PictureBoxFractal002.TabIndex = 0;
            this.PictureBoxFractal002.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(783, 563);
            this.Controls.Add(this.PictureBoxFractal002);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFractal002)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureBoxMandelbrot2;
        private System.Windows.Forms.PictureBox PictureBoxFractal2;
        private System.Windows.Forms.PictureBox PictureBoxFractal22;
        private System.Windows.Forms.PictureBox PictureBoxFractal002;
    }
}

