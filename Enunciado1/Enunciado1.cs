using System;
using System.Collections.Generic;

public class CuentaBancaria
{
    private decimal saldo;
    private List<string> historial;
    private string tipoCuenta;

    public decimal Saldo => saldo;
    public IReadOnlyList<string> Historial => historial.AsReadOnly();

    public CuentaBancaria(string tipoCuenta, decimal saldoInicial = 0)
    {
     if (saldoInicial < 0)
     throw new ArgumentException ("El saldo inical no puede ser negativo.");

     this.tipoCuenta = tipoCuenta.ToLower();
     saldo = saldoInicial;
     historial = new List<string>();

     historial.Add($"Cuenta creada con saldo inical: {saldo}");   
    }

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        throw new ArgumentException ("El monto debe ser mayor a cero,");

        saldo += monto;
        historial.Add($"Deposito: +{monto} |Saldo: {saldo}");
    }

    public void Retirar(decimal monto)
    {
        if (monto <= 0)
        throw new InvalidOperationException("Saldo insuficiente.");

        saldo -= monto;
        historial.Add($"Retiro: -{monto} |Saldo: {saldo}");
    }

    public void AplicarInteresMensual()
    {
        decimal interes = 0;

        if (tipoCuenta == "ahorro")
        interes = saldo*0.03m;
        else if (tipoCuenta == "corriente")
        interes = 0;

        saldo += interes;
        historial.Add($"Interes aplicado: +{interes} |Saldo: {saldo}");
    }
}

class Program
{
    static void Main()
    {
        var cuenta = new CuentaBancaria("ahorro", 1000);

        cuenta.Depositar(500);
        cuenta.Retirar(200);
        cuenta.AplicarInteresMensual();

        Console.WriteLine($"Saldo actual: {cuenta.Saldo}");

        Console.WriteLine("\nHistorial:");
        foreach (var item in cuenta.Historial)
        {
            Console.WriteLine(item);
        }
    }
}