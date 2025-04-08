using static FormsMenu.FrmMenuPrincipal;
using System.Text;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormsMenu
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    namespace JuegoAhorcado
    {
        public partial class FrmMenuPrincipal : Form
        {
            public FrmMenuPrincipal()
            {
                InitializeComponent();
            }

            // Inicia el juego cuando se hace clic en el botón "Iniciar juego"
            private void button1_Click(object sender, EventArgs e)
            {
                Task.Run(() => JuegoAhorcado());
            }

            // Lógica del juego del ahorcado
            private void JuegoAhorcado()
            {
                // Inicializar elementos del juego
                string palabraSecreta = "CINCO"; // Puedes cambiarla o pedirla al usuario
                char[] letrasAdivinadas = new string('_', palabraSecreta.Length).ToCharArray();
                List<char> letrasFalladas = new List<char>();
                int intentosRestantes = 6;

                // Hacer el juego
                while (intentosRestantes > 0 && letrasAdivinadas.Contains('_'))
                {
                    // Actualiza las etiquetas en el formulario
                    this.Invoke(new Action(() =>
                    {
                        lblPalabra.Text = "Palabra: " + new string(letrasAdivinadas);
                        lblIntentos.Text = "Intentos restantes: " + intentosRestantes;
                        lblLetrasFalladas.Text = "Letras falladas: " + string.Join(", ", letrasFalladas);
                    }));

                    // Solicita una letra
                    string intento = string.Empty;
                    this.Invoke(new Action(() =>
                    {
                        txtLetra.Enabled = true;
                        txtLetra.Focus();
                    }));

                    while (string.IsNullOrEmpty(intento))
                    {
                        intento = txtLetra.Text.ToUpper();
                    }

                    this.Invoke(new Action(() =>
                    {
                        txtLetra.Clear();
                    }));

                    char letra = intento[0];

                    // Verifica si la letra es correcta
                    if (palabraSecreta.Contains(letra))
                    {
                        for (int i = 0; i < palabraSecreta.Length; i++)
                        {
                            if (palabraSecreta[i] == letra)
                                letrasAdivinadas[i] = letra;
                        }
                    }
                    else
                    {
                        if (!letrasFalladas.Contains(letra))
                        {
                            letrasFalladas.Add(letra);
                            intentosRestantes--;
                        }
                    }
                }

                // Mostrar el resultado del juego
                this.Invoke(new Action(() =>
                {
                    if (!letrasAdivinadas.Contains('_'))
                    {
                        MessageBox.Show("¡Ganaste! La palabra era: " + palabraSecreta);
                    }
                    else
                    {
                        MessageBox.Show("¡Perdiste! La palabra era: " + palabraSecreta);
                    }

                    // Permitir intentar de nuevo
                    button1.Enabled = true;
                    txtLetra.Enabled = false;
                }));
            }
       
    private void button2_Click(object sender, EventArgs e)
            {
                Matriz formFractal1 = new Matriz();
                formFractal1.Show();
            }

            private void button3_Click(object sender, EventArgs e)
            {

            }
        }
    }
}
    
