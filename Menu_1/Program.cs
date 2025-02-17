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
            Console.WriteLine("3. Cuadro de asteriscos");
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
                DibujarCuadroAsteriscos();
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
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dados los dos catetos de un triángulo rectángulo\n");


        Console.ForegroundColor= ConsoleColor.White;
        Console.Write("Ingrese el valor del cateto 1: ");
        double cateto1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor del cateto 2: ");
        double cateto2 = double.Parse(Console.ReadLine());

        double hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);
        double angulo1 = Math.Atan(cateto1 / cateto2) * (180 / Math.PI);
        double angulo2 = 90 - angulo1;

        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}, Ángulo 1: {angulo1:F2}°, Ángulo 2: {angulo2:F2}°\n");


        string mensaje = "Listo!!! Presiona una tecla para continuar";
       int anchoConsola = Console.WindowWidth;
        int posicion = (anchoConsola - mensaje.Length) / 2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(posicion, Console.CursorTop);
        Console.WriteLine(mensaje);

        Console.ReadKey();
    }
private static void CalcularRecta()
    { 
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dados 2 puntos de un recta calcule\n");

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

        Console.WriteLine($"Pendiente: {pendiente:F2}, Ángulo: {angulo:F2}°, Punto medio: ({puntoMedioX}, {puntoMedioY})\n");
     
        
        string mensaje = "Listo!!! Presiona una tecla para continuar";
        int anchoConsola = Console.WindowWidth;
        int posicion = (anchoConsola - mensaje.Length) / 2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(posicion, Console.CursorTop);
        Console.WriteLine(mensaje);

        Console.ReadKey();
    }

    private static void CalcularTrayectoriaProyectil()
    {
        Console.Clear();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Calcular y mostrar las coordenadas (x,y)\n");



        Console.ForegroundColor= ConsoleColor.White;
        Console.Write("Ingrese la velocidad inicial (m/s): ");
        double v0 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el ángulo de lanzamiento (°): ");
        double angulo = double.Parse(Console.ReadLine());
        double g = 9.81;

        double radianes = angulo * Math.PI / 180;
        double vX = v0 * Math.Cos(radianes);
        double vY = v0 * Math.Sin(radianes);
        double tiempoVuelo = (2 * vY) / g;
        double distanciaMax = vX * tiempoVuelo;
        double alturaMax = (vY * vY) / (2 * g);

        Console.WriteLine($"Altura máxima: {alturaMax:F2}m, Distancia máxima: {distanciaMax:F2}m\n");
      
        string mensaje = "Listo!!! Presiona una tecla para continuar";
        int anchoConsola = Console.WindowWidth;
        int posicion = (anchoConsola - mensaje.Length) / 2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(posicion, Console.CursorTop);
        Console.WriteLine(mensaje);

        Console.ReadKey();
    }


private static void DibujarCuadroAsteriscos()
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
        string mensajeFinal = "Listo!!! presiona una tecla para continuar";
        int posXFinal = (anchoConsola - mensajeFinal.Length) / 2;
        int posYFinal = centroY + 10;

        Console.SetCursorPosition(posXFinal, posYFinal);
        Console.WriteLine(mensajeFinal);

        Console.ReadKey();
    }

}
