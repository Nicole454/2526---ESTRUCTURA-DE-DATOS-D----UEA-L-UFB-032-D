using System;
using System.Collections.Generic;

class Program
{
    static LinkedList<int> listaPrimos = new LinkedList<int>();
    static LinkedList<int> listaArmstrong = new LinkedList<int>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            DibujarCuadro("MENÚ PRINCIPAL - EJERCICIO 1");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Ingresar número");
            Console.WriteLine("2. Mostrar resultados");
            Console.WriteLine("3. Salir");
            Console.ResetColor();
            Console.Write("\nSeleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MenuIngresarNumero();
                    break;

                case "2":
                    MenuMostrarResultados();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Opción inválida...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // ===== MENÚ INGRESAR =====
    static void MenuIngresarNumero()
    {
        Console.Clear();
        DibujarCuadro("INGRESAR NÚMERO");
        Console.Write("Ingrese un número entero: ");
        int num = int.Parse(Console.ReadLine());

        bool agregado = false;

        if (EsPrimo(num))
        {
            listaPrimos.AddLast(num);
            Console.WriteLine("Número agregado a la lista de PRIMOS.");
            agregado = true;
        }

        if (EsArmstrong(num))
        {
            listaArmstrong.AddFirst(num);
            Console.WriteLine("Número agregado a la lista de ARMSTRONG.");
            agregado = true;
        }

        if (!agregado)
        {
            Console.WriteLine("El número no es Primo ni Armstrong.");
        }

        Console.ReadKey();
    }

    // ===== MENÚ MOSTRAR =====
    static void MenuMostrarResultados()
    {
        Console.Clear();
        DibujarCuadro("RESULTADOS");

        Console.WriteLine("Cantidad de números primos: " + listaPrimos.Count);
        Console.WriteLine("Cantidad de números Armstrong: " + listaArmstrong.Count);

        if (listaPrimos.Count > listaArmstrong.Count)
            Console.WriteLine("La lista de PRIMOS tiene más elementos.");
        else if (listaArmstrong.Count > listaPrimos.Count)
            Console.WriteLine("La lista de ARMSTRONG tiene más elementos.");
        else
            Console.WriteLine("Ambas listas tienen la misma cantidad.");

        Console.WriteLine("\nLista de números primos:");
        foreach (int p in listaPrimos)
            Console.Write(p + " ");

        Console.WriteLine("\n\nLista de números Armstrong:");
        foreach (int a in listaArmstrong)
            Console.Write(a + " ");

        Console.ReadKey();
    }

    // ===== MÉTODOS AUXILIARES =====
    static bool EsPrimo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static bool EsArmstrong(int n)
    {
        int suma = 0, temp = n;
        int digitos = n.ToString().Length;

        while (temp > 0)
        {
            int d = temp % 10;
            suma += (int)Math.Pow(d, digitos);
            temp /= 10;
        }
        return suma == n;
    }

    static void DibujarCuadro(string titulo)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("==========================================");
        Console.WriteLine(titulo);
        Console.WriteLine("==========================================");
        Console.ResetColor();
    }
}

