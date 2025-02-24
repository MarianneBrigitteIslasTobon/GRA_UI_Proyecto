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
            Console.WriteLine("1. Programa de Introducción");
            Console.WriteLine("2. Programas de Localización");
            Console.WriteLine("3. Salir");

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

}
