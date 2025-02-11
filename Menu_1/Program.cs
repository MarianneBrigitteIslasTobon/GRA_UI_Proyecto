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
            Console.WriteLine("1. Tabla de senos");
            Console.WriteLine("2. Tabla de cosenos");
            Console.WriteLine("3. Cuadro de asteriscos");
            Console.WriteLine("4. Volver al menú principal");

            ConsoleKeyInfo opcion = Console.ReadKey();

            if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1)
            {
                MostrarTablaTrigonometrica(Math.Sin, "Seno");
            }
            else if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2)
            {
                MostrarTablaTrigonometrica(Math.Cos, "Coseno");
            }
            else if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3)
            {
                DibujarCuadroAsteriscos();
            }
            else if (opcion.Key == ConsoleKey.D4 || opcion.Key == ConsoleKey.NumPad4)
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
            Console.WriteLine("3. Volver al menú principal");

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

    private static void MostrarTablaTrigonometrica(Func<double, double> funcion, string nombre)
    {
        Console.Clear();
        Console.WriteLine($"Tabla de {nombre}:\n");
        for (int i = 0; i <= 360; i += 10)
        {
            double valor = funcion(i * Math.PI / 180);
            Console.WriteLine($"{i}°: {valor:F4}");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    private static void DibujarCuadroAsteriscos()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dibujar rectángulos\n");

        (ConsoleColor color, int ancho, int alto)[] rectangulos =
        {
            (ConsoleColor.Green, 3, 1),
            (ConsoleColor.Yellow, 15, 5),
            (ConsoleColor.Red, 25, 7),
            (ConsoleColor.Blue, 35, 11),
            (ConsoleColor.Cyan, 45, 15)
        };

        int centroX = 40;
        int centroY = 12;

        foreach (var (color, ancho, alto) in rectangulos)
        {
            Console.ForegroundColor = color;
            for (int x = -ancho / 2; x <= ancho / 2; x++)
            {
                Console.SetCursorPosition(centroX + x, centroY - alto / 2);
                Console.Write("*");
                Console.SetCursorPosition(centroX + x, centroY + alto / 2);
                Console.Write("*");
            }
            for (int y = -alto / 2; y <= alto / 2; y++)
            {
                Console.SetCursorPosition(centroX - ancho / 2, centroY + y);
                Console.Write("*");
                Console.SetCursorPosition(centroX + ancho / 2, centroY + y);
                Console.Write("*");
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(20, centroY + 10);
        Console.WriteLine("Listo!!! presiona una tecla para continuar");
        Console.ReadKey();
    }
}
