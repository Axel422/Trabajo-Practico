using System;

class EjerciciodePractica1
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: COLORES ---");

        // 1. Inicialización directa
        string[] colores = { "Rojo", "Azul", "Verde", "Amarillo" };

        Console.WriteLine("Lista de colores:");

        // 2. Foreach
        foreach (string color in colores)
        {
            Console.WriteLine("- " + color);
        }

        Console.ReadLine();
    }
}

class EjerciciodePractica2
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: NOMBRES ---");

        // 1. Inicialización directa
        string[] nombres = { "Juan", "Maria", "Pedro", "Lucia" };

        Console.WriteLine("Lista de nombres:");

        // 2. Foreach
        foreach (string nombre in nombres)
        {
            Console.WriteLine("- " + nombre);
        }

        Console.ReadLine();
    }
}

class EjerciciodePractica3
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: CUADRADOS ---");

        // 1. Inicialización directa
        int[] numeros = { 2, 4, 6, 8 };

        Console.WriteLine("Numeros al cuadrado:");

        // 2. Foreach
        foreach (int num in numeros)
        {
            Console.WriteLine(num + " -> " + (num * num));
        }

        Console.ReadLine();
    }
}

class EjerciciodePractica4
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: PAISES ---");

        // 1. Inicialización directa
        string[] paises = { "Argentina", "Brasil", "Chile", "Uruguay" };

        Console.WriteLine("Lista de paises:");

        // 2. Foreach
        foreach (string pais in paises)
        {
            Console.WriteLine("- " + pais);
        }

        Console.ReadLine();
    }
}

class EjerciciodePractica5
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: TEMPERATURAS ---");

        // 1. Inicialización directa
        double[] temperaturas = { 18.5, 22.3, 25.0, 19.8 };

        Console.WriteLine("Temperaturas registradas:");

        // 2. Foreach
        foreach (double temp in temperaturas)
        {
            Console.WriteLine("- " + temp + "°C");
        }

        Console.ReadLine();
    }
}
