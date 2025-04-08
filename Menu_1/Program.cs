using System;
using System.Threading;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Menu 1 - Programa de Introducción");
            Console.WriteLine("2. Menu 2- Programas de Localización");
            Console.WriteLine("3. Menu 3 - Localización de vectores y matrices");
            Console.WriteLine("4. Salir");

            ConsoleKeyInfo opcion = Console.ReadKey();

            if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1)
            {
                MenuIntroduccion();
            }
            else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
            {
                MenuLocalizacion();
            }
            else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
            {
                MenuVectoresYMatrices();
            }
            else if (opcion.Key == ConsoleKey.D4 || opcion.Key == ConsoleKey.NumPad4)
            {
                break;
            }
        }
    }


    private static void MenuLocalizacion()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Mostrar la tabla de senos del 0 al 90.");
            Console.WriteLine("2. Mostrar la tabla de cosenos del 0 al 90.");
            Console.WriteLine("3. Calcular la hipotenusa y los ángulos de un triángulo rectángulo.");
            Console.WriteLine("4. Calcular la pendiente, el ángulo de inclinación y el punto medio de una recta.");
            Console.WriteLine("5. Calcular y mostrar la trayectoria de un proyectil.");
            Console.WriteLine("6. Volver al menú principal");

            ConsoleKeyInfo opcion = Console.ReadKey();

            if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1)
            {
                MostrarTablaSeno(Math.Sin, "Seno");
            }
            else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
            {
                MostrarTablaCoseno(Math.Cos, "Coseno");
            }
            else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
            {
                CalcularHipotenusaYAngulos();
            }
            else if (opcion.Key == ConsoleKey.D4 || opcion.Key == ConsoleKey.NumPad4)
            {
                CalcularRecta();
            }
            else if (opcion.Key == ConsoleKey.D5 || opcion.Key == ConsoleKey.NumPad5)
            {
                CalcularTrayectoriaProyectil();
            }
            else if (opcion.Key == ConsoleKey.D6 || opcion.Key == ConsoleKey.NumPad6)
            {
                break;
            }
        }
    }


    private static void MenuIntroduccion()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Gráfica de barras");
            Console.WriteLine("2. Espiral giratoria de asteriscos");
            Console.WriteLine("3. Rectangulo de asteriscos");
            Console.WriteLine("4. Volver al menú principal");

            ConsoleKeyInfo opcion = Console.ReadKey();

            if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1)
            {
                DibujarGrafica();
            }
            else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
            {
                DibujarEspiral();
            }
            else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
            {
                DibujarRectanguloAsteriscos();
            }
            else if (opcion.Key == ConsoleKey.D4 || opcion.Key == ConsoleKey.NumPad4)
            {
                break;
            }
        }
    }


    private static void DibujarGrafica()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(55, 1);
        Console.WriteLine("Dibujando gráfica...\n");

        int baseX = Console.WindowWidth - 1;
        int baseY = (Console.WindowHeight / 2) + 5;
        int altura = 13;
        int longitudHorizontal = 6;

        while (baseX > 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int y = 0; y < altura; y++)
            {
                if (baseY - y >= 0)
                {
                    Console.SetCursorPosition(baseX, baseY - y);
                    Console.Write("*");
                    Thread.Sleep(30);
                }
            }

            Console.SetCursorPosition(baseX, baseY - altura);
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int x = 1; x <= longitudHorizontal; x++)
            {
                if (baseX - x >= 0)
                {
                    Console.SetCursorPosition(baseX - x, baseY - altura);
                    Console.Write("*");
                    Thread.Sleep(30);
                }
            }

            baseX -= longitudHorizontal;

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int y = 0; y < altura; y++)
            {
                if (baseY - altura + y < Console.WindowHeight)
                {
                    Console.SetCursorPosition(baseX, baseY - altura + y);
                    Console.Write("*");
                    Thread.Sleep(20);
                }
            }

            Console.SetCursorPosition(baseX, baseY);
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int x = 1; x <= longitudHorizontal; x++)
            {
                if (baseX - x >= 0)
                {
                    Console.SetCursorPosition(baseX - x, baseY);
                    Console.Write("*");
                    Thread.Sleep(20);
                }
            }

            baseX -= longitudHorizontal;
        }

        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(40, 26);
        Console.WriteLine("¡Listo! Presiona cualquier tecla para continuar...");
        Console.ReadKey();
    }


    private static void DibujarEspiral()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(40, 4);
        Console.WriteLine("Dibujando gráfica...\n");

        int x = 55, y = 17;
        int paso;
        int direccion = 2;
        int espacioHorizontal = 1;
        int espacioVertical = 1;

        Random random = new Random();

        var direcciones = new (int dx, int dy)[]
        {
        (1, 0),
        (0, 1),
        (-1, 0),
        (0, -1)
        };

        int[] pasosPorDireccion = { 4, 2, 9, 4, 14, 6, 19, 8, 24, 10, 29, 12, 34, 14, 39, 16, 44, 18 };
        direccion = 2;

        for (int i = 0; i < pasosPorDireccion.Length; i++)
        {
            paso = pasosPorDireccion[i];

            for (int j = 0; j < paso; j++)
            {
                Console.SetCursorPosition(x, y);
                CambiarColor(random);
                Console.Write("*");
                Thread.Sleep(100);

                x += direcciones[direccion].dx * espacioHorizontal;
                y += direcciones[direccion].dy * espacioVertical;
            }

            direccion = (direccion + 1) % 4;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(40, 4);
        Console.WriteLine($"¡Listo! presiona cualquier tecla para salir.");
        Console.ReadKey();
    }

    private static void CambiarColor(Random random)
    {
        Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
    }

    private static void MostrarTablaCoseno(Func<double, double> funcion, string nombre)
    {
        Console.Clear();

        int anchoConsola = Console.WindowWidth;

        string tituloMenu = "Menú 2 - Programas de localización";
        int posX = (anchoConsola - tituloMenu.Length) / 2;
        posX = Math.Max(0, posX);
        Console.SetCursorPosition(posX, Console.CursorTop);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(tituloMenu + "\n");


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Tabla de Cosenos\n");
        Console.ResetColor();

        Console.WriteLine("----------------------------------------------------------------------------------------");

        int columnas = 6;
        int filas = (90 / columnas) + 1;

        for (int fila = 0; fila < filas; fila++)
        {
            for (int col = 0; col < columnas; col++)
            {
                int angulo = fila + col * filas;
                if (angulo > 90) break;

                double coseno = Math.Cos(angulo * Math.PI / 180);
                Console.Write("{0,4} {1,12:F8}   ", angulo, coseno);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        string mensajeSalida = "Presiona cualquier tecla para salir...";
        posX = (anchoConsola - mensajeSalida.Length) / 2;
        posX = Math.Max(0, posX);

        int posY = Console.CursorTop;
        Console.SetCursorPosition(posX, posY);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensajeSalida);
        Console.ResetColor();

        Console.ReadKey();
    }


    private static void MostrarTablaSeno(Func<double, double> funcion, string nombre)
    {

        Console.Clear();

        int anchoConsola = Console.WindowWidth;

        string tituloMenu = "Menú 2 - Programas de localización";
        int posX = (anchoConsola - tituloMenu.Length) / 2;
        posX = Math.Max(0, posX);
        Console.SetCursorPosition(posX, Console.CursorTop);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(tituloMenu + "\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Tabla de Senos\n");
        Console.ResetColor();

        Console.WriteLine("----------------------------------------------------------------------------------------");

        int columnas = 6;
        int filas = (90 / columnas) + 1;

        for (int fila = 0; fila < filas; fila++)
        {
            for (int col = 0; col < columnas; col++)
            {
                int angulo = fila + col * filas;
                if (angulo > 90) break;

                double valor = funcion(angulo * Math.PI / 180);
                Console.Write("{0,4} {1,12:F8}   ", angulo, valor);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        string mensajeSalida = "Presiona cualquier tecla para salir...";
        posX = (anchoConsola - mensajeSalida.Length) / 2;
        posX = Math.Max(0, posX);

        int posY = Console.CursorTop;
        Console.SetCursorPosition(posX, posY);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensajeSalida);
        Console.ResetColor();

        Console.ReadKey();
    }

    private static void CalcularHipotenusaYAngulos()
    {
        Console.Clear();

        double catetoOpuesto = ObtenerValorCateto("Introduce el cateto opuesto: ");
        double catetoAdyacente = ObtenerValorCateto("Introduce el cateto adyacente: ");

        double hipotenusa = CalcularHipotenusa(catetoOpuesto, catetoAdyacente);
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}\n");

        double anguloOpuesto = CalcularAngulo(catetoOpuesto, hipotenusa);
        double anguloAdyacente = CalcularAngulo(catetoAdyacente, hipotenusa);

        Console.WriteLine($"Ángulo opuesto: {anguloOpuesto:F2} grados");
        Console.WriteLine($"Ángulo adyacente: {anguloAdyacente:F2} grados\n");

        DibujarTriangulo(catetoOpuesto, catetoAdyacente);

        MostrarMensajeFinal();
    }

    private static double ObtenerValorCateto(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }

    private static double CalcularHipotenusa(double opuesto, double adyacente)
    {
        return Math.Sqrt(Math.Pow(opuesto, 2) + Math.Pow(adyacente, 2));
    }

    private static double CalcularAngulo(double cateto, double hipotenusa)
    {
        return Math.Asin(cateto / hipotenusa) * (180 / Math.PI);
    }

    private static void DibujarTriangulo(double opuesto, double adyacente)
    {
        int anchoConsola = Console.WindowWidth;
        int centroX = (anchoConsola - (int)adyacente) / 2;
        int centroY = (Console.WindowHeight - (int)opuesto) / 2;

        for (int i = 0; i <= (int)opuesto; i++)
        {
            Console.SetCursorPosition(centroX, centroY + i);
            Console.Write('*');
            Thread.Sleep(10);
        }

        for (int i = 0; i <= (int)adyacente; i++)
        {
            Console.SetCursorPosition(centroX + i, centroY + (int)opuesto);
            Console.Write('*');
            Thread.Sleep(10);
        }

        for (int i = 0; i <= (int)adyacente; i++)
        {
            int y = (int)(opuesto * (1 - (double)i / adyacente));
            Console.SetCursorPosition(centroX + i, centroY + (int)opuesto - y);
            Console.Write('*');
            Thread.Sleep(10);
        }
    }

    private static void MostrarMensajeFinal()
    {
        string mensaje = "Listo!!! Presiona una tecla para continuar";
        int posicion = (Console.WindowWidth - mensaje.Length) / 2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(posicion, Console.CursorTop + 2);
        Console.WriteLine(mensaje);
        Console.ReadKey();
    }

    private static void CalcularRecta()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dados 2 puntos de una recta, calcule\n");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ingrese x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double pendiente = (y2 - y1) / (x2 - x1);
        double angulo = Math.Atan(pendiente) * (180 / Math.PI);
        double puntoMedioX = (x1 + x2) / 2;
        double puntoMedioY = (y1 + y2) / 2;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"\nResultados:\n");
        Console.WriteLine($"Pendiente: {pendiente:F2}");
        Console.WriteLine($"Ángulo de inclinación: {angulo:F2}°");
        Console.WriteLine($"Punto medio: ({puntoMedioX:F2}, {puntoMedioY:F2})\n");

        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();

        int altoConsola = Console.WindowHeight;
        int anchoConsola = Console.WindowWidth;

        char[,] canvas = new char[altoConsola, anchoConsola];

        for (int i = 0; i < altoConsola; i++)
        {
            for (int j = 0; j < anchoConsola; j++)
            {
                canvas[i, j] = ' ';
            }
        }

        int origenX = anchoConsola / 2;
        int origenY = altoConsola / 2;

        for (int x = -origenX; x < origenX; x++)
        {
            double y = pendiente * x + (y1 - pendiente * x1);

            int posX = origenX + x;
            int posY = origenY - (int)y;

            if (posX >= 0 && posX < anchoConsola && posY >= 0 && posY < altoConsola)
            {
                canvas[posY, posX] = '*';
            }
        }

        Console.Clear();
        for (int i = 0; i < altoConsola; i++)
        {
            for (int j = 0; j < anchoConsola; j++)
            {
                Console.Write(canvas[i, j]);
            }
            Console.WriteLine();
        }

        string mensaje = "Listo!!! Presiona una tecla para continuar";
        int posicion = (anchoConsola - mensaje.Length) / 2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(posicion, Console.CursorTop);
        Console.WriteLine(mensaje);

        Console.ReadKey();
    }

    private static void CalcularTrayectoriaProyectil()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        const double g = 9.81;

        Console.ForegroundColor = ConsoleColor.White;

        Console.Write("Ingrese la velocidad inicial (m/s): ");
        double v0 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el ángulo de lanzamiento (grados): ");
        double angulo = Convert.ToDouble(Console.ReadLine());

        double radianes = angulo * Math.PI / 180;

        double v0x = v0 * Math.Cos(radianes);
        double v0y = v0 * Math.Sin(radianes);

        double tiempoVuelo = (2 * v0y) / g;
        double alturaMax = (v0y * v0y) / (2 * g);
        double distanciaMax = v0x * tiempoVuelo;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nTiempo (s)\tX (m)\t\tY (m)\t\tVelocidad (m/s)");
        Console.WriteLine(new string('-', 50));

        double t = 0;
        while (t <= tiempoVuelo)
        {
            double x = v0x * t;
            double y = v0y * t - 0.5 * g * t * t;
            double v = Math.Sqrt(v0x * v0x + Math.Pow(v0y - g * t, 2));

            if (y < 0) break;

            Console.WriteLine("{0:F1}\t\t{1:F2}\t\t{2:F2}\t\t{3:F2}", t, x, y, v);
            t = Math.Round(t + 0.1, 1);
        }

        Console.WriteLine(new string('-', 50));
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Altura máxima: {0:F2} m", alturaMax);
        Console.WriteLine("Distancia máxima: {0:F2} m", distanciaMax);
        Console.WriteLine("Tiempo total de vuelo: {0:F2} s", tiempoVuelo);

        Console.ForegroundColor = ConsoleColor.Green;
        string mensaje = "Listo!!! Presiona una tecla para continuar";
        int posicion = (Console.WindowWidth - mensaje.Length) / 2;
        Console.SetCursorPosition(posicion, Console.CursorTop);
        Console.WriteLine(mensaje);

        Console.ReadKey();
    }


    private static void DibujarRectanguloAsteriscos()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        int anchoConsola = Console.WindowWidth;
        int altoConsola = Console.WindowHeight;

        string mensajeTitulo = "Dibujar rectángulos";

        int posX = (anchoConsola - mensajeTitulo.Length) / 2;
        int posY = altoConsola / 2 - 10;

        Console.SetCursorPosition(posX, posY);
        Console.WriteLine(mensajeTitulo + "\n");

        (ConsoleColor color, int ancho, int alto)[] rectangulos =
        {
        (ConsoleColor.Green, 3, 1),
        (ConsoleColor.Yellow, 15, 5),
        (ConsoleColor.Red, 25, 9),
        (ConsoleColor.Blue, 35, 13),
        (ConsoleColor.Cyan, 45, 17)
    };

        int centroX = anchoConsola / 2;
        int centroY = altoConsola / 2;

        foreach (var (color, ancho, alto) in rectangulos)
        {
            Console.ForegroundColor = color;

            for (int x = -ancho / 2; x <= ancho / 2; x++)
            {
                Console.SetCursorPosition(centroX + x, centroY - alto / 2);
                Console.Write("*");
                Console.SetCursorPosition(centroX + x, centroY + alto / 2);
                Console.Write("*");
                Thread.Sleep(50);

            }

            for (int y = -alto / 2; y <= alto / 2; y++)
            {
                Console.SetCursorPosition(centroX - ancho / 2, centroY + y);
                Console.Write("*");

                Console.SetCursorPosition(centroX + ancho / 2, centroY + y);
                Console.Write("*");
                Thread.Sleep(50);

            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        string mensajeFinal = "Listo!!! presiona una tecla para continuar";
        int posXFinal = (anchoConsola - mensajeFinal.Length) / 2;
        int posYFinal = centroY + 10;

        Console.SetCursorPosition(posXFinal, posYFinal);
        Console.WriteLine(mensajeFinal);

        Console.ReadKey();
    }

    private static void MenuVectoresYMatrices()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menú 3 - Localización de Vectores y Matrices");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Juego del ahorcado para cualquier palabra.");
            Console.WriteLine("2. Leer matriz mxn y contar positivos, negativos y ceros.");
            Console.WriteLine("3. Transposición de una matriz mxn.");
            Console.WriteLine("4. Encontrar mayor y menor en la matriz y marcarlos.");
            Console.WriteLine("5. Suma, conteo y promedio de pares e impares.");
            Console.WriteLine("6. Suma de filas y columnas (3x3) con vectores.");
            Console.WriteLine("7. Multiplicación de matrices A[mxn] * B[nxp].");
            Console.WriteLine("8. Calcular la desviación estándar.");
            Console.WriteLine("9. Volver al menú principal");

            ConsoleKeyInfo opcion = Console.ReadKey();

            if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1)
            {
                JuegoAhorcado();
            }
            else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
            {
                MatrizContarElementos();
            }
            else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
            {
                TransponerMatriz();
            }
            else if (opcion.Key == ConsoleKey.D4 || opcion.Key == ConsoleKey.NumPad4)
            {
                Mayormatriz();
            }
            else if (opcion.Key == ConsoleKey.D5 || opcion.Key == ConsoleKey.NumPad5)
            {
                SumaPromedioParesImpares();
            }
            else if (opcion.Key == ConsoleKey.D6 || opcion.Key == ConsoleKey.NumPad6)
            {
                SumaFilasColumnas();
            }
            else if (opcion.Key == ConsoleKey.D7 || opcion.Key == ConsoleKey.NumPad7)
            {
                MultiplicarMatrices();
            }
            else if (opcion.Key == ConsoleKey.D8 || opcion.Key == ConsoleKey.NumPad8)
            {
                CalcularDesviacionEstandar();
            }
            else if (opcion.Key == ConsoleKey.D9 || opcion.Key == ConsoleKey.NumPad9)
            {
                break;
            }
        }

    }

    private static void CalcularDesviacionEstandar()
            {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de números para calcular la desviación estándar:");

            int n = int.Parse(Console.ReadLine());
            double[] datos = new double[n];

            Console.WriteLine("\nIngrese los valores de los datos:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dato {i + 1}: ");
                datos[i] = double.Parse(Console.ReadLine());
            }

            double suma = 0;
            foreach (double dato in datos)
            {
                suma += dato;
            }
            double media = suma / n;

            double sumaDiferenciasCuadradas = 0;
            foreach (double dato in datos)
            {
                sumaDiferenciasCuadradas += Math.Pow(dato - media, 2);
            }

            double desviacionEstandar = Math.Sqrt(sumaDiferenciasCuadradas / n);

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"La media (μ) de los datos es: {media}");
            Console.WriteLine($"La desviación estándar (σ) es: {desviacionEstandar}");

            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    
    private static void MultiplicarMatrices()
    {
        Console.Clear();

        Console.Write("Ingrese el número de filas de la matriz A: ");
        int filasA = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el número de columnas de la matriz A (y filas de la matriz B): ");
        int columnasA = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas de la matriz B: ");
        int columnasB = int.Parse(Console.ReadLine());

        int[,] A = new int[filasA, columnasA];
        int[,] B = new int[columnasA, columnasB];
        int[,] C = new int[filasA, columnasB];

        Console.WriteLine("\nIngrese los elementos de la matriz A:");
        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasA; j++)
            {
                Console.Write($"Elemento A[{i},{j}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nIngrese los elementos de la matriz B:");
        for (int i = 0; i < columnasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                Console.Write($"Elemento B[{i},{j}]: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                for (int k = 0; k < columnasA; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("\nMatriz A:");
        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasA; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMatriz B:");
        for (int i = 0; i < columnasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nResultado de la multiplicación A * B (matriz C):");
        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
        Console.ReadKey();
    
}

    private static void SumaFilasColumnas()
           {
            Console.Clear();
            int[,] matriz = new int[3, 3];  
            int[] sumaFilas = new int[3];   
            int[] sumaColumnas = new int[3]; 

            Console.WriteLine("Ingrese los elementos de la matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumaFilas[i] += matriz[i, j];
                    sumaColumnas[j] += matriz[i, j];
                }
            }

            Console.WriteLine("\nMatriz 3x3 ingresada:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de las filas:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Suma de la fila {i + 1}: {sumaFilas[i]}");
            }

            Console.WriteLine("\nSuma de las columnas:");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Suma de la columna {j + 1}: {sumaColumnas[j]}");
            }

            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        
    }
    

    private static void SumaPromedioParesImpares()
    {
        Console.Clear();
        Console.WriteLine("Transposición de una matriz con estadísticas de pares e impares");

        Console.Write("Ingrese el número de filas (m): ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas (n): ");
        int columnas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[filas, columnas];

        int mayor = int.MinValue, menor = int.MaxValue;
        int filaMayor = 0, colMayor = 0;
        int filaMenor = 0, colMenor = 0;

        int sumaPares = 0, sumaImpares = 0;
        int cantPares = 0, cantImpares = 0;

        Console.WriteLine("Ingrese los elementos de la matriz:");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                int valor = int.Parse(Console.ReadLine());
                matriz[i, j] = valor;

                if (valor > mayor)
                {
                    mayor = valor;
                    filaMayor = i;
                    colMayor = j;
                }

                if (valor < menor)
                {
                    menor = valor;
                    filaMenor = i;
                    colMenor = j;
                }

                if (valor % 2 == 0)
                {
                    sumaPares += valor;
                    cantPares++;
                }
                else
                {
                    sumaImpares += valor;
                    cantImpares++;
                }
            }
        }

        Console.WriteLine("\nMatriz original:");
        MostrarMatrizConColores(matriz, filaMayor, colMayor, filaMenor, colMenor);

        int[,] transpuesta = new int[columnas, filas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }

        Console.WriteLine("\nMatriz transpuesta:");
        MostrarMatrizConColores(
            transpuesta,
            colMayor, filaMayor,
            colMenor, filaMenor
        );

        Console.WriteLine($"\n🔴 Número mayor: {mayor} en posición [{filaMayor},{colMayor}]");
        Console.WriteLine($"🟢 Número menor: {menor} en posición [{filaMenor},{colMenor}]");

        Console.WriteLine($"\n📊 Estadísticas de pares e impares:");
        Console.WriteLine($"  ➤ Suma de pares: {sumaPares}");
        Console.WriteLine($"  ➤ Suma de impares: {sumaImpares}");
        Console.WriteLine($"  ➤ Cantidad de pares: {cantPares}");
        Console.WriteLine($"  ➤ Cantidad de impares: {cantImpares}");

        double promPares = cantPares > 0 ? (double)sumaPares / cantPares : 0;
        double promImpares = cantImpares > 0 ? (double)sumaImpares / cantImpares : 0;

        Console.WriteLine($"  ➤ Promedio de pares: {promPares:F2}");
        Console.WriteLine($"  ➤ Promedio de impares: {promImpares:F2}");

        Console.ResetColor();
    }

    private static void Mayormatriz()
    {
        Console.Clear();
        Console.WriteLine("Transposición de una matriz con identificación de mayor y menor");

        Console.Write("Ingrese el número de filas (m): ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas (n): ");
        int columnas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[filas, columnas];

        int mayor = int.MinValue;
        int menor = int.MaxValue;
        int filaMayor = 0, colMayor = 0;
        int filaMenor = 0, colMenor = 0;

        Console.WriteLine("Ingrese los elementos de la matriz:");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                int valor = int.Parse(Console.ReadLine());
                matriz[i, j] = valor;

                if (valor > mayor)
                {
                    mayor = valor;
                    filaMayor = i;
                    colMayor = j;
                }

                if (valor < menor)
                {
                    menor = valor;
                    filaMenor = i;
                    colMenor = j;
                }
            }
        }

        Console.WriteLine("\nMatriz original:");
        MostrarMatrizConColores(matriz, filaMayor, colMayor, filaMenor, colMenor);

        int[,] transpuesta = new int[columnas, filas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }

        Console.WriteLine("\nMatriz transpuesta:");
        MostrarMatrizConColores(
            transpuesta,
            colMayor, filaMayor,  
            colMenor, filaMenor   
        );

        Console.WriteLine($"\nNúmero mayor: {mayor} en posición [{filaMayor},{colMayor}]");
        Console.WriteLine($"Número menor: {menor} en posición [{filaMenor},{colMenor}]");

        Console.ResetColor();
    }

    static void MostrarMatrizConColores(int[,] matriz, int filaMayor, int colMayor, int filaMenor, int colMenor)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (i == filaMayor && j == colMayor)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (i == filaMenor && j == colMenor)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write($"{matriz[i, j],4} ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }

    private static void TransponerMatriz()
    {
        Console.Clear();
        Console.WriteLine("Transposición de una matriz");

        Console.Write("Ingrese el número de filas (m): ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas (n): ");
        int columnas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[filas, columnas];

        Console.WriteLine("Ingrese los elementos de la matriz:");

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz original:");
        MostrarMatriz(matriz);

        int[,] transpuesta = new int[columnas, filas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                transpuesta[j, i] = matriz[i, j];
            }
        }

        Console.WriteLine("\nMatriz transpuesta:");
        MostrarMatriz(transpuesta);
    }

    static void MostrarMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{matriz[i, j],4} ");
            }
            Console.WriteLine();
        }


    }

    private static void JuegoAhorcado()
    {
        Console.Clear();
        Console.SetCursorPosition(5, 2);
        Console.WriteLine("╔═══════════════════════════════════════════════╗");
        Console.SetCursorPosition(5, 3);
        Console.WriteLine("║              Juego del Ahorcado              ║");
        Console.SetCursorPosition(5, 4);
        Console.WriteLine("╚═══════════════════════════════════════════════╝");

        Console.SetCursorPosition(7, 6);
        Console.Write("Ingrese una palabra secreta: ");
        string palabraSecreta = Console.ReadLine().ToUpper();

        Console.Clear();
        char[] letrasAdivinadas = new string('_', palabraSecreta.Length).ToCharArray();
        List<char> letrasFalladas = new List<char>();
        int intentosRestantes = 6;

        while (intentosRestantes > 0 && letrasAdivinadas.Contains('_'))
        {
            Console.Clear();
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Palabra: " + new string(letrasAdivinadas));
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Letras falladas: " + string.Join(", ", letrasFalladas));
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("Intentos restantes: " + intentosRestantes);

            Console.SetCursorPosition(5, 6);
            Console.Write("Ingrese una letra: ");
            char intento = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (palabraSecreta.Contains(intento))
            {
                for (int i = 0; i < palabraSecreta.Length; i++)
                {
                    if (palabraSecreta[i] == intento)
                        letrasAdivinadas[i] = intento;
                }
            }
            else
            {
                if (!letrasFalladas.Contains(intento))
                {
                    letrasFalladas.Add(intento);
                    intentosRestantes--;
                }
            }
        }

        Console.SetCursorPosition(5, 8);
        if (!letrasAdivinadas.Contains('_'))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Felicidades! Adivinaste la palabra: " + palabraSecreta);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Perdiste. La palabra era: " + palabraSecreta);
        }
        Console.ResetColor();

        Console.SetCursorPosition(5, 10);
        Console.Write("¿Desea continuar con este juego? (s/n): ");
        string opcion = Console.ReadLine();
        if (opcion.ToLower() == "s") JuegoAhorcado();
    }





    static void MatrizContarElementos()
    {
        Console.Clear();
        int m, n;

        Console.SetCursorPosition(5, 2); Console.Write("Ingrese el número de filas (m): ");
        while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
        {
            Console.SetCursorPosition(5, 3); Console.Write("Entrada inválida. Ingrese un número válido: ");
        }

        Console.SetCursorPosition(5, 4); Console.Write("Ingrese el número de columnas (n): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.SetCursorPosition(5, 5); Console.Write("Entrada inválida. Ingrese un número válido: ");
        }

        int[,] matriz = new int[m, n];
        int positivos = 0, negativos = 0, ceros = 0;

        int startY = 7;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.SetCursorPosition(5, startY + i);
                Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                int valor;
                while (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.SetCursorPosition(5, startY + i + 1);
                    Console.Write("Entrada inválida. Intente de nuevo: ");
                }
                matriz[i, j] = valor;

                if (valor > 0) positivos++;
                else if (valor < 0) negativos++;
                else ceros++;

                MostrarMatrizParcial(matriz, i, j);
            }
        }

        int resultadoY = startY + m + 3;
        Console.SetCursorPosition(5, resultadoY); Console.WriteLine($"Total de positivos: {positivos}");
        Console.SetCursorPosition(5, resultadoY + 1); Console.WriteLine($"Total de negativos: {negativos}");
        Console.SetCursorPosition(5, resultadoY + 2); Console.WriteLine($"Total de ceros:     {ceros}");

        MostrarOpcionesVolverContinuar();
    }

    static void MostrarMatrizParcial(int[,] matriz, int filaActual, int colActual)
    {
        int baseY = 10;
        for (int i = 0; i <= filaActual; i++)
        {
            Console.SetCursorPosition(40, baseY + i);
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write($"{matriz[i, j],4}");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
    }

    static void MostrarOpcionesVolverContinuar()
    {
        Console.SetCursorPosition(5, Console.CursorTop + 2); Console.WriteLine("1. Volver al menú anterior");
        Console.SetCursorPosition(5, Console.CursorTop + 1); Console.WriteLine("2. Repetir operación");
        Console.SetCursorPosition(5, Console.CursorTop + 1); Console.WriteLine("3. Salir");

        Console.SetCursorPosition(5, Console.CursorTop + 1); Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                MatrizContarElementos();
                break;
            case "2":
                MatrizContarElementos();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                MostrarOpcionesVolverContinuar();
                break;
        }
    }
}