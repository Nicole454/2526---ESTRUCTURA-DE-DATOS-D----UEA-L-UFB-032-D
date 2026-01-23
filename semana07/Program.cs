using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ================================
        // EJERCICIO 1: PARÉNTESIS BALANCEADOS
        // ================================
        Console.WriteLine("=== Verificación de Paréntesis Balanceados ===");

        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        if (ParentesisBalanceados.EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");

        // ================================
        // EJERCICIO 2: TORRES DE HANOI
        // ================================
        Console.WriteLine("\n=== Torres de Hanoi ===");
        TorresDeHanoi.Ejecutar(3);
    }
}

// ------------------------------------------------
// CLASE 1: PARÉNTESIS BALANCEADOS (USO DE PILAS)
// ------------------------------------------------
class ParentesisBalanceados
{
    public static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Símbolos de apertura
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Símbolos de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char apertura = pila.Pop();

                if (!Coinciden(apertura, c))
                    return false;
            }
        }

        // Si la pila queda vacía, está balanceado
        return pila.Count == 0;
    }

    static bool Coinciden(char a, char c)
    {
        return (a == '(' && c == ')') ||
               (a == '{' && c == '}') ||
               (a == '[' && c == ']');
    }
}

// ------------------------------------------------
// CLASE 2: TORRES DE HANOI (USO DE PILAS)
// ------------------------------------------------
class TorresDeHanoi
{
    public static void Ejecutar(int discos)
    {
        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Inicializar la torre origen
        for (int i = discos; i >= 1; i--)
        {
            origen.Push(i);
        }

        Resolver(discos, origen, destino, auxiliar,
                 "Origen", "Destino", "Auxiliar");
    }

    static void Resolver(int n,
                         Stack<int> o,
                         Stack<int> d,
                         Stack<int> a,
                         string no,
                         string nd,
                         string na)
    {
        if (n == 1)
        {
            int disco = o.Pop();
            d.Push(disco);
            Console.WriteLine("Mover disco " + disco + " de " + no + " a " + nd);
            return;
        }

        Resolver(n - 1, o, a, d, no, na, nd);
        Resolver(1, o, d, a, no, nd, na);
        Resolver(n - 1, a, d, o, na, nd, no);
    }
}
