using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ===== EJERCICIO 1 =====
        Console.WriteLine("EJERCICIO 1");
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        foreach (string a in asignaturas)
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("\n------------------------");

        // ===== EJERCICIO 2 =====
        Console.WriteLine("EJERCICIO 2");
        foreach (string a in asignaturas)
        {
            Console.WriteLine($"Yo estudio {a}");
        }

        Console.WriteLine("\n------------------------");

        // ===== EJERCICIO 3 =====
        Console.WriteLine("EJERCICIO 3");
        Dictionary<string, double> notas = new Dictionary<string, double>();

        foreach (string a in asignaturas)
        {
            Console.Write($"Ingrese la nota de {a}: ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(a, nota);
        }

        Console.WriteLine("\nResultados:");
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}");
        }

        Console.WriteLine("\n------------------------");

        // ===== EJERCICIO 4 =====
        Console.WriteLine("EJERCICIO 4");
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingrese 6 números ganadores de la lotería:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numeros.Add(num);
        }

        numeros.Sort();

        Console.WriteLine("Números ordenados:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine("\n------------------------");

        // ===== EJERCICIO 5 =====
        Console.WriteLine("EJERCICIO 5");
        List<int> listaNumeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            listaNumeros.Add(i);
        }

        listaNumeros.Reverse();

        Console.WriteLine(string.Join(", ", listaNumeros));

        Console.WriteLine("\nPrograma finalizado.");
        Console.ReadKey();
    }
}
