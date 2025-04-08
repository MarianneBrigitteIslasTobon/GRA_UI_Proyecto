
namespace FormsMenu
{
    namespace JuegoAhorcado
    {
        partial class FrmMenuPrincipal
        {
            private System.ComponentModel.IContainer components = null;
            private Label lblPalabra;
            private Label lblIntentos;
            private Label lblLetrasFalladas;
            private TextBox txtLetra;
            private Button button1;
            private Button button2;

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
                this.lblPalabra = new System.Windows.Forms.Label();
                this.lblIntentos = new System.Windows.Forms.Label();
                this.lblLetrasFalladas = new System.Windows.Forms.Label();
                this.txtLetra = new System.Windows.Forms.TextBox();
                this.button1 = new System.Windows.Forms.Button();
                this.button2 = new System.Windows.Forms.Button();
                this.SuspendLayout();

                // 
                // lblPalabra
                // 
                this.lblPalabra.AutoSize = true;
                this.lblPalabra.Location = new System.Drawing.Point(20, 20);
                this.lblPalabra.Name = "lblPalabra";
                this.lblPalabra.Size = new System.Drawing.Size(65, 13);
                this.lblPalabra.TabIndex = 0;
                this.lblPalabra.Text = "Palabra: _ _ _";

                // 
                // lblIntentos
                // 
                this.lblIntentos.AutoSize = true;
                this.lblIntentos.Location = new System.Drawing.Point(20, 60);
                this.lblIntentos.Name = "lblIntentos";
                this.lblIntentos.Size = new System.Drawing.Size(100, 13);
                this.lblIntentos.TabIndex = 1;
                this.lblIntentos.Text = "Intentos restantes: 6";

                // 
                // lblLetrasFalladas
                // 
                this.lblLetrasFalladas.AutoSize = true;
                this.lblLetrasFalladas.Location = new System.Drawing.Point(20, 100);
                this.lblLetrasFalladas.Name = "lblLetrasFalladas";
                this.lblLetrasFalladas.Size = new System.Drawing.Size(113, 13);
                this.lblLetrasFalladas.TabIndex = 2;
                this.lblLetrasFalladas.Text = "Letras falladas: ";

                // 
                // txtLetra
                // 
                this.txtLetra.Location = new System.Drawing.Point(20, 140);
                this.txtLetra.MaxLength = 1;
                this.txtLetra.Name = "txtLetra";
                this.txtLetra.Size = new System.Drawing.Size(50, 20);
                this.txtLetra.TabIndex = 3;

                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(20, 180);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(120, 40);
                this.button1.TabIndex = 4;
                this.button1.Text = "Iniciar juego";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);

                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(20, 220);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(120, 40);
                this.button2.TabIndex = 5;
                this.button2.Text = "Intentar letra";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.button2_Click);

                // 
                // FrmMenuPrincipal
                // 
                this.ClientSize = new System.Drawing.Size(284, 261);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.txtLetra);
            }
        }
    }
}