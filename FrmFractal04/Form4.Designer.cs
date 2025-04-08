namespace FrmFractal04
{
    partial class Form4
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
            this.PictureBoxMandelbrot4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot4)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxMandelbrot4
            // 
            this.PictureBoxMandelbrot4.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxMandelbrot4.Name = "PictureBoxMandelbrot4";
            this.PictureBoxMandelbrot4.Size = new System.Drawing.Size(550, 550);
            this.PictureBoxMandelbrot4.TabIndex = 0;
            this.PictureBoxMandelbrot4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.PictureBoxMandelbrot4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMandelbrot4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxMandelbrot4;
    }
}

