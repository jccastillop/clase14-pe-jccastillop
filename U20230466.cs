using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\nMenú de opciones:\n");
            Console.WriteLine("1. Sumar números pares hasta 75.");
            Console.WriteLine("2. Encontrar el número más grande en una lista.");
            Console.WriteLine("3. Tabla de multiplicar con suma de 2.");
            Console.WriteLine("4. Salir del programa.");
            Console.Write("\nSeleccione una opción (1-4): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        SumarNumerosParesHasta75();
                        break;
                    case 2:
                        EncontrarNumeroMasGrande();
                        break;
                    case 3:
                        TablaDeMultiplicarConSumaDe2();
                        break;
                    case 4:
                        Console.WriteLine("\nSaliendo del programa.\n");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Por favor, seleccione una opción válida.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada no válida. Por favor, ingrese un número válido.\n");
            }

        } while (opcion != 4);
    }

    static void SumarNumerosParesHasta75()
    {
        int suma = 0;
        for (int i = 2; i <= 75; i += 2)
        {
            suma += i;
        }
        Console.WriteLine("\nLa suma de los números pares hasta 75 es: " + suma);
    }

    static void EncontrarNumeroMasGrande()
    {
        List<int> numeros = new List<int> { 11, 1, 37, 2, 41, 19, 33, 14, 23, 100, 1000 };
        int maximo = int.MinValue;
        foreach (int numero in numeros)
        {
            if (numero > maximo)
            {
                maximo = numero;
            }
        }
        Console.WriteLine("\nEl número más grande en la lista es: " + maximo);
    }

    static void TablaDeMultiplicarConSumaDe2()
    {
        Console.Write("\nIngrese un número para la tabla de multiplicar: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("\nTabla de multiplicar de " + n + " con suma de 2:");
            for (int i = 1; i <= 12; i++)
            {
                int resultado = n * i + 2;
                Console.WriteLine(n + " x " + i + " = " + resultado);
            }
        }
        else
        {
            Console.WriteLine("\nEntrada no válida. Por favor, ingrese un número válido.");
        }
        
        // AUTOEVALUACION 10 U20230466
    }
}
