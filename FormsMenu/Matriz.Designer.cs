namespace FormsMenu
{
    partial class Matriz
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

        private void InitializeComponent()

        {

            // btnProcesar

            btnProcesar = new Button();
            btnProcesar.Location = new Point(320, 20);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(100, 30);
            btnProcesar.TabIndex = 6;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += new EventHandler(btnProcesar_Click);

            //

            txtFilas = new TextBox();
            txtColumnas = new TextBox();
            dgvMatriz = new DataGridView();
            lblPositivos = new Label();
            lblNegativos = new Label();
            lblCeros = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
            SuspendLayout();
            // 
            // txtFilas
            // 
            txtFilas.Location = new Point(54, 20);
            txtFilas.Name = "txtFilas";
            txtFilas.Size = new Size(100, 23);
            txtFilas.TabIndex = 0;
            // 
            // txtColumnas
            // 
            txtColumnas.Location = new Point(180, 20);
            txtColumnas.Name = "txtColumnas";
            txtColumnas.Size = new Size(100, 23);
            txtColumnas.TabIndex = 1;
            // 
            // dgvMatriz
            // 
            dgvMatriz.Location = new Point(54, 170);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.Size = new Size(400, 200);
            dgvMatriz.TabIndex = 2;
            // 
            // lblPositivos
            // 
            lblPositivos.Location = new Point(54, 380);
            lblPositivos.Name = "lblPositivos";
            lblPositivos.Size = new Size(150, 23);
            lblPositivos.TabIndex = 3;
            lblPositivos.Text = "Positivos: 0";
            // 
            // lblNegativos
            // 
            lblNegativos.Location = new Point(220, 380);
            lblNegativos.Name = "lblNegativos";
            lblNegativos.Size = new Size(150, 23);
            lblNegativos.TabIndex = 4;
            lblNegativos.Text = "Negativos: 0";
            // 
            // lblCeros
            // 
            lblCeros.Location = new Point(380, 380);
            lblCeros.Name = "lblCeros";
            lblCeros.Size = new Size(150, 23);
            lblCeros.TabIndex = 5;
            lblCeros.Text = "Ceros: 0";
            // 
            // Form2
            // 
            ClientSize = new Size(804, 525);
            Controls.Add(txtFilas);
            Controls.Add(txtColumnas);
            Controls.Add(dgvMatriz);
            Controls.Add(lblPositivos);
            Controls.Add(lblNegativos);
            Controls.Add(lblCeros);
            Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private TextBox txtFilas;
        private TextBox txtColumnas;
        private DataGridView dgvMatriz;
        private Label lblPositivos;
        private Label lblNegativos;
        private Label lblCeros;
       

    }
}

