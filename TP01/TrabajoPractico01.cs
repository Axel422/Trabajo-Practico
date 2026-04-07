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
