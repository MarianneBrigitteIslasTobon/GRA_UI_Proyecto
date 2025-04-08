namespace FrmFractal01
{
    partial class Fractales
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
            this.PictureBoxMandelbrot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxMandelbrot
            // 
            this.PictureBoxMandelbrot.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxMandelbrot.Name = "PictureBoxMandelbrot";
            this.PictureBoxMandelbrot.Size = new System.Drawing.Size(550, 550);
            this.PictureBoxMandelbrot.TabIndex = 0;
            this.PictureBoxMandelbrot.TabStop = false;
            // 
            // Fractales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.PictureBoxMandelbrot);
            this.Name = "Fractales";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fractales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxMandelbrot;
    }
}

