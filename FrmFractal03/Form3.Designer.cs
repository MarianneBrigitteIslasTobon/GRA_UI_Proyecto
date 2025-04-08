namespace FrmFractal03
{
    partial class FrmFractal03
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
            this.PictureBoxFractal3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFractal3)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxFractal3
            // 
            this.PictureBoxFractal3.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxFractal3.Name = "PictureBoxFractal3";
            this.PictureBoxFractal3.Size = new System.Drawing.Size(786, 696);
            this.PictureBoxFractal3.TabIndex = 0;
            this.PictureBoxFractal3.TabStop = false;
            // 
            // FrmFractal03
            // 
            this.ClientSize = new System.Drawing.Size(834, 728);
            this.Controls.Add(this.PictureBoxFractal3);
            this.Name = "FrmFractal03";
            this.Load += new System.EventHandler(this.FrmFractal03_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFractal3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxFractal3;
    }
}

