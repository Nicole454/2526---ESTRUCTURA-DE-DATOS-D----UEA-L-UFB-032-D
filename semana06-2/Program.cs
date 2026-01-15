using System;
using System.Collections.Generic;



class Estudiante
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public double Nota { get; set; }
}

class Program
{
    static LinkedList<Estudiante> lista = new LinkedList<Estudiante>();

    static void Main()
    {
        Agregar(new Estudiante { Cedula = "123", Nombre = "Ana", Apellido = "Perez", Correo = "ana@mail.com", Nota = 8 });
        Agregar(new Estudiante { Cedula = "456", Nombre = "Luis", Apellido = "Gomez", Correo = "luis@mail.com", Nota = 6 });

        Buscar("123");
        Eliminar("456");

        MostrarTotales();
    }

    static void Agregar(Estudiante e)
    {
        if (e.Nota >= 7)
            lista.AddFirst(e);
        else
            lista.AddLast(e);
    }

    static void Buscar(string cedula)
    {
        foreach (var e in lista)
        {
            if (e.Cedula == cedula)
            {
                Console.WriteLine($"Encontrado: {e.Nombre} {e.Apellido}");
                return;
            }
        }
        Console.WriteLine("Estudiante no encontrado.");
    }

    static void Eliminar(string cedula)
    {
        var actual = lista.First;
        while (actual != null)
        {
            if (actual.Value.Cedula == cedula)
            {
                lista.Remove(actual);
                Console.WriteLine("Estudiante eliminado.");
                return;
            }
            actual = actual.Next;
        }
        Console.WriteLine("No se pudo eliminar.");
    }

    static void MostrarTotales()
    {
        int aprobados = 0, reprobados = 0;

        foreach (var e in lista)
        {
            if (e.Nota >= 7) aprobados++;
            else reprobados++;
        }

        Console.WriteLine($"Aprobados: {aprobados}");
        Console.WriteLine($"Reprobados: {reprobados}");
    }
}
