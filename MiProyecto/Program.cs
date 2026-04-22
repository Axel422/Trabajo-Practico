using System;
namespace SistemadeAlumnos
{
    class Alumno
    {    
    public string Nombre;
    public double Nota1;
    public double Nota2;
    
    public Alumno (string nombre, double nota1, double nota2)
        {
            Nombre = nombre;
            Nota1 = nota1;
            Nota2 = nota2;
        }
        public double calcularPromedio ()
        {
            return (Nota1 + Nota2) /2;
        }
        public bool EstaAprobado ()
        {
            return calcularPromedio () >= 6;
        }
        public void MostrarEstado ()
        {
            Console.WriteLine ("Nombre: " + Nombre);
            Console.WriteLine ("Promedio: " + calcularPromedio ());
            if (EstaAprobado ())
            {
                Console.WriteLine ("Aprobado");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }
        }
} 

class Program
{
    static void Main (string [] args)
    {
        Console.WriteLine ("=== Sistema de Alumno ===");
        Console.WriteLine ("Ingrese Nombre: ");
        string nombre = Console.ReadLine ();
        Console.WriteLine ("Ingrese nota 1: ");
        double n1 = double.Parse (Console.ReadLine ());
        Console.WriteLine ("Ingrese nota 2: ");
        double n2 = double.Parse (Console.ReadLine ());
        Alumno alumno = new Alumno (nombre,n1,n2);
        Console.WriteLine ("\n ---Resultado---");
        alumno.MostrarEstado ();
        Console.WriteLine ("\n Fin del Programa");
    }
  }
}