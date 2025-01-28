using System;
using System.Threading;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            int anchoConsola = Console.WindowWidth;
            int altoConsola = Console.WindowHeight;

            int posicionVertical = altoConsola / 2 - 2; 
            int posicionHorizontal = (anchoConsola - "Seleccione una opción:".Length) / 2;

            Console.SetCursorPosition(posicionHorizontal, posicionVertical);
            Console.WriteLine("Seleccione una opción:");

            Console.SetCursorPosition(posicionHorizontal, posicionVertical + 1);
            Console.WriteLine("1. Gráfica de barras ");

            Console.SetCursorPosition(posicionHorizontal, posicionVertical + 2);
            Console.WriteLine("2. Espiral giratoria de asteriscos");

            Console.SetCursorPosition(posicionHorizontal, posicionVertical + 3);
            Console.WriteLine("3. Salir");

            Console.ResetColor();

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
        int baseY = Console.WindowHeight / 2;
        int altura = 13;
        int longitudHorizontal = 5;

        while (baseX > 0)
        {
            DibujarSegmento(baseX, baseY, altura, -1, ConsoleColor.Blue, true); 
            baseX -= DibujarSegmento(baseX, baseY - altura, longitudHorizontal, -1, ConsoleColor.Cyan, false); 
           DibujarSegmento(baseX, baseY - altura, altura, 1, ConsoleColor.Blue, true);
           baseX -= DibujarSegmento(baseX, baseY, longitudHorizontal, -1, ConsoleColor.Cyan, false); 
        }

        FinalizarDibujo();
    }

    private static int DibujarSegmento(int baseX, int baseY, int longitud, int direccion, ConsoleColor color, bool esVertical)
    {
        Console.ForegroundColor = color;

        for (int i = 0; i < longitud; i++)
        {
            int nuevaX = esVertical ? baseX : baseX + (i * direccion);
            int nuevaY = esVertical ? baseY + (i * direccion) : baseY;

            if (nuevaX >= 0 && nuevaX < Console.WindowWidth && nuevaY >= 0 && nuevaY < Console.WindowHeight)
            {
                Console.SetCursorPosition(nuevaX, nuevaY);
                Console.Write("*");
                Thread.Sleep(20);
            }
        }

        return longitud;
    }

    private static void FinalizarDibujo()
    {
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(40, 20);
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

        int[] pasosPorDireccion = { 4, 2, 9, 4, 14, 6, 19, 8, 24, 10, 29, 12, 34, 14, 39, 16, 44, 18};
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
}
