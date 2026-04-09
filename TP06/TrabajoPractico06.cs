namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP = "GameMaster Pro";
            const string VERSION = "v1.0.2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
            
            // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            Console.WriteLine("Constante VERSION = " + VERSION);

            Console.ReadLine();

    }
}

class Program
{
    static void Main(string[] args)
    {
        const string NOMBRE_APP = "MusicPlayer";
        const string VERSION = "v2.1";
        const int DURACION_MAX = 10;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Duración máxima de canción: " + DURACION_MAX + " minutos");

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        const string TIENDA = "TechStore";
        const double IVA = 0.21;
        const int STOCK_MIN = 5;

        Console.WriteLine("Tienda: " + TIENDA);
        Console.WriteLine("IVA aplicado: " + IVA);
        Console.WriteLine("Stock mínimo: " + STOCK_MIN);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        const string ESCUELA = "Instituto Central";
        const int NOTA_APROBACION = 6;
        const int NOTA_ALUMNO = 8;

        bool aprobado = NOTA_ALUMNO >= NOTA_APROBACION;

        Console.WriteLine("Escuela: " + ESCUELA);
        Console.WriteLine("¿Alumno aprobado?: " + aprobado);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        const string JUEGO = "SpaceBattle";
        const int VIDAS_INICIALES = 3;

        Console.WriteLine("Juego: " + JUEGO);
        Console.WriteLine("Vidas iniciales: " + VIDAS_INICIALES);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        const string CINE = "CineStar";
        const int EDAD_MINIMA = 16;
        const int EDAD_CLIENTE = 20;

        bool puedeEntrar = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("Cine: " + CINE);
        Console.WriteLine("¿Puede entrar?: " + puedeEntrar);

        Console.ReadLine();
    }
}
