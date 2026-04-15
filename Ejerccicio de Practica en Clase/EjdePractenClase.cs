using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear arreglos para guardar nombres y edades
        string[] nombres = new string[20];
        int[] edades = new int[20];

        // Ingreso de datos
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Ingrese el nombre del cliente " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();

            Console.Write("Ingrese la edad del cliente " + (i + 1) + ": ");
            edades[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nClientes que pueden ingresar al boliche (mayores de 30):");

        // Validación y salida
        for (int i = 0; i < 20; i++)
        {
            if (edades[i] > 30)
            {
                Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
            }
        }

        Console.ReadKey();
    }
}
