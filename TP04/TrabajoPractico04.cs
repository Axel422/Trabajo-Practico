namespace TP04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            string nombre = "Ana López";
            Console.WriteLine("4. TIPO TEXTO (string):");
            Console.WriteLine("   Valor guardado: " + nombre);

            char inicialNombre = 'A';
            Console.WriteLine("\n5. TIPO CARÁCTER (char):");
            Console.WriteLine("   Valor guardado: '" + inicialNombre + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}