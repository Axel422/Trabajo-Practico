using System;

class EjerciciodePractica1
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: SUMA DE ARREGLO ---");

        // 1. Declaración e inicialización
        int[] numeros = new int[5];

        // 2. Asignación de valores
        numeros[0] = 5;
        numeros[1] = 10;
        numeros[2] = 15;
        numeros[3] = 20;
        numeros[4] = 25;

        // 3. Recorrido y suma
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        // 4. Mostrar resultado
        Console.WriteLine("La suma es: " + suma);

        Console.ReadLine();
    }
}

 
        class EjerciciodePractica2
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: NUMEROS PARES ---");

        // 1. Declaración
        int[] numeros = new int[4];

        // 2. Asignación
        numeros[0] = 3;
        numeros[1] = 8;
        numeros[2] = 11;
        numeros[3] = 20;

        // 3. Mostrar solo pares
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                Console.WriteLine("Par: " + numeros[i]);
            }
        }

        Console.ReadLine();
    }
}

class EjerciciodePractica3
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: BUSCAR NUMERO ---");

        // 1. Declaración
        int[] numeros = new int[3];

        // 2. Asignación
        numeros[0] = 7;
        numeros[1] = 14;
        numeros[2] = 21;

        // 3. Búsqueda
        int buscado = 14;
        bool encontrado = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                encontrado = true;
            }
        }

        // 4. Resultado
        if (encontrado)
            Console.WriteLine("Numero encontrado");
        else
            Console.WriteLine("Numero no encontrado");

        Console.ReadLine();
    }
}

class EjerciciodePractica4
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: PROMEDIO ---");

        // 1. Declaración
        double[] notas = new double[4];

        // 2. Asignación
        notas[0] = 6.5;
        notas[1] = 7;
        notas[2] = 8;
        notas[3] = 9.5;

        // 3. Cálculo de promedio
        double suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        double promedio = suma / notas.Length;

        // 4. Mostrar resultado
        Console.WriteLine("Promedio: " + promedio);

        Console.ReadLine();
    }
}

class EjerciciodePractica5
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: NUMERO MAYOR ---");

        // 1. Declaración
        int[] numeros = new int[4];

        // 2. Asignación
        numeros[0] = 12;
        numeros[1] = 45;
        numeros[2] = 7;
        numeros[3] = 30;

        // 3. Buscar el mayor
        int mayor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }

        // 4. Mostrar resultado
        Console.WriteLine("El mayor es: " + mayor);

        Console.ReadLine();
    }
}