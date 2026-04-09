namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal TASA_IVA = 0.21m; // 21% fijo
            const bool MODO_PRUEBA = false; // Control de seguridad
            const char SIMBOLO_PESO = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase = 1500.50m;
            decimal impuestoCalculado = precioBase * TASA_IVA;
            decimal total = precioBase + impuestoCalculado;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
            Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

            Console.ReadLine();

    }
}

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES ---
        const decimal IVA = 0.21m;
        const char MONEDA = '$';

        decimal precio = 1000m;
        decimal impuesto = precio * IVA;
        decimal total = precio + impuesto;

        Console.WriteLine("Sistema de facturación");
        Console.WriteLine("Precio: " + MONEDA + precio);
        Console.WriteLine("IVA: " + MONEDA + impuesto);
        Console.WriteLine("Total: " + MONEDA + total);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        const decimal DESCUENTO = 0.10m;
        const char MONEDA = '$';

        decimal precio = 500m;
        decimal descuentoAplicado = precio * DESCUENTO;
        decimal total = precio - descuentoAplicado;

        Console.WriteLine("Tienda Online");
        Console.WriteLine("Precio original: " + MONEDA + precio);
        Console.WriteLine("Descuento: " + MONEDA + descuentoAplicado);
        Console.WriteLine("Total a pagar: " + MONEDA + total);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        const decimal DOLAR = 900m;

        decimal pesos = 4500m;
        decimal dolares = pesos / DOLAR;

        Console.WriteLine("Conversor de moneda");
        Console.WriteLine("Pesos: " + pesos);
        Console.WriteLine("Dólares: " + dolares);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        const int HORAS_SEMANA = 40;
        const decimal PAGO_HORA = 10m;

        decimal salario = HORAS_SEMANA * PAGO_HORA;

        Console.WriteLine("Sistema de sueldo");
        Console.WriteLine("Horas trabajadas: " + HORAS_SEMANA);
        Console.WriteLine("Salario semanal: $" + salario);

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        const decimal IVA = 0.21m;
        const char MONEDA = '$';

        decimal precioProducto = 250m;
        decimal ivaCalculado = precioProducto * IVA;
        decimal total = precioProducto + ivaCalculado;

        Console.WriteLine("Supermercado");
        Console.WriteLine("Precio producto: " + MONEDA + precioProducto);
        Console.WriteLine("IVA: " + MONEDA + ivaCalculado);
        Console.WriteLine("Total a pagar: " + MONEDA + total);

        Console.ReadLine();
    }
}
