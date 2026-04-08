namespace TP01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            string edadTexto = Console.ReadLine();
            int edad = int.Parse(edadTexto); 

            Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
            double estatura = double.Parse(Console.ReadLine()); 

            
            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad el próximo año: " + (edad + 1)); 
            Console.WriteLine("Estatura: " + estatura + " metros");

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}

class Progrsm
{
    static void Main(string[] args)
    {
        Console.WriteLine("---REGISTRO DE ESTUDIANTE---");
        
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Carrera: ");
        string carrera = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("\n---DATOS---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Carrera: " + carrera);
        Console.WriteLine("Edad: " + edad);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CALCULADORA ---");

        Console.Write("Numero 1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Numero 2: ");
        int n2 = int.Parse(Console.ReadLine());

        int suma = n1 + n2;

        Console.WriteLine("Resultado: " + suma);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- DATOS DEL AUTO ---");

        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Año: ");
        int anio = int.Parse(Console.ReadLine());

        Console.WriteLine("\nAuto: " + marca + " " + modelo);
        Console.WriteLine("Año: " + anio);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CONVERSOR DE TEMPERATURA ---");

        Console.Write("Grados Celsius: ");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;

        Console.WriteLine("Fahrenheit: " + f);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- CONVERSOR DE TEMPERATURA ---");

        Console.Write("Grados Celsius: ");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;

        Console.WriteLine("Fahrenheit: " + f);

        Console.ReadLine();
    }
}
