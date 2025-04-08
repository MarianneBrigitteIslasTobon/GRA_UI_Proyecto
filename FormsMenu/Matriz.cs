using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMenu
{
    public partial class Matriz : Form
    {
        public Matriz()
        {
            InitializeComponent();
            this.AcceptButton = btnProcesar; // Asegurar que el Enter funcione con el botón correcto
        }
        private Button btnProcesar;


        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Validar entradas de filas y columnas
            MessageBox.Show("Botón Procesar clickeado");

            if (!int.TryParse(txtFilas.Text, out int filas) || filas <= 0 ||
                !int.TryParse(txtColumnas.Text, out int columnas) || columnas <= 0)
            {
                MessageBox.Show("Ingrese valores válidos para filas y columnas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Configurar DataGridView con el tamaño ingresado
            dgvMatriz.RowCount = filas;
            dgvMatriz.ColumnCount = columnas;

            // Inicializar la matriz con ceros para evitar valores nulos
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (dgvMatriz[j, i].Value == null)
                    {
                        dgvMatriz[j, i].Value = 0; // Aseguramos que no haya valores nulos
                    }
                }
            }

            int positivos = 0, negativos = 0, ceros = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    // Asegurarse de que el valor sea un número entero
                    if (int.TryParse(dgvMatriz[j, i].Value.ToString(), out int valor))
                    {
                        // Contar positivos, negativos y ceros
                        if (valor > 0)
                        {
                            positivos++;
                            dgvMatriz[j, i].Style.BackColor = Color.Green; // Resaltar los positivos en verde
                        }
                        else if (valor < 0)
                        {
                            negativos++;
                            dgvMatriz[j, i].Style.BackColor = Color.Red; // Resaltar los negativos en rojo
                        }
                        else
                        {
                            ceros++;
                            dgvMatriz[j, i].Style.BackColor = Color.Yellow; // Resaltar los ceros en amarillo
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese solo números en la matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Mostrar resultados en las etiquetas
            lblPositivos.Text = $"Positivos: {positivos}";
            lblNegativos.Text = $"Negativos: {negativos}";
            lblCeros.Text = $"Ceros: {ceros}";
        }
    }
}