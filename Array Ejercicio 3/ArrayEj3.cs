using System;

class EjerciciodePractica1
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: SUMAR ELEMENTOS DEL ARRAY ---");

        int[] numeros = { 5, 10, 15, 20 }; // Paso 1: declarar array
        int suma = 0; // Paso 2: acumulador

        for (int i = 0; i < numeros.Length; i++) // Paso 3: recorrer
        {
            suma += numeros[i]; // Paso 4: sumar
        }

        Console.WriteLine("Suma: " + suma); // Paso 5
    }
}

class EjerciciodePractica2
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: MAYOR DEL ARRAY ---");

        int[] numeros = { 3, 8, 2, 10, 5 }; // Array con datos a comparar
        int mayor = numeros[0]; // Se toma el primero como referencia inicial

        for (int i = 1; i < numeros.Length; i++) // Se empieza en 1 porque el 0 ya se usó
        {
            if (numeros[i] > mayor) // Se compara cada valor con el mayor actual
                mayor = numeros[i]; // Se actualiza si encontramos uno más grande
        }

        Console.WriteLine("Mayor: " + mayor); // Se muestra el mayor encontrado
    }
}

class EjerciciodePractica3
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EJERCICIO: CONTAR PARES ---"); 

        int[] numeros = { 1, 2, 3, 4, 5, 6 }; // Array de ejemplo
        int contador = 0; // Empieza en 0 porque aún no contamos nada

        for (int i = 0; i < numeros.Length; i++) // Recorre todo el array
        {
            if (numeros[i] % 2 == 0) // % 2 sirve para saber si es par
                contador++; // Suma 1 cada vez que encuentra un par
        }

        Console.WriteLine("Pares: " + contador); // Muestra cuántos hay
    }
}

class EjerciciodePractica4
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- ARRAY INVERTIDO ---"); 

        int[] numeros = { 1, 2, 3, 4, 5 }; // Se crea el array con valores

        for (int i = numeros.Length - 1; i >= 0; i--) // Se empieza desde el último índice para invertir
        {
            Console.WriteLine(numeros[i]); // Se muestra cada elemento en orden inverso
        }
    }
}

class EjerciciodePractica5
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- PROMEDIO ---"); 

        int[] notas = { 6, 7, 8, 9 }; // Array con valores
        int suma = 0; // Se usa para acumular todas las notas

        for (int i = 0; i < notas.Length; i++) // Recorre todo el array usando Length
        {
            suma += notas[i]; // Va sumando cada elemento
        }

        double promedio = (double)suma / notas.Length; // Se divide por la cantidad total para obtener promedio

        Console.WriteLine("Promedio: " + promedio); // Muestra el resultado final
    }
}
