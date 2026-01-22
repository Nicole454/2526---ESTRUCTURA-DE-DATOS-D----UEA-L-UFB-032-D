onsole.WriteLine("Hello, World!");


 using System;
using System.Collections.Generic;

class ParentesisBalanceados
{
    static void Main()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }

    /// <summary>
    /// Verifica si una expresión tiene paréntesis, llaves y corchetes balanceados
    /// </summary>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Si es símbolo de apertura, se apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es símbolo de cierre
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, no está balanceado
                if (pila.Count == 0)
                    return false;

                char tope = pila.Pop();

                // Verifica coincidencia
                if (!EsPar(tope, c))
                    return false;
            }
        }

        // Si la pila está vacía, está balanceado
        return pila.Count == 0;
    }

    /// <summary>
    /// Verifica si los símbolos coinciden
    /// </summary>
    static bool EsPar(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}

///Ejercicio 2

using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static void Main()
    {
        int discos = 3;

        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Inicializar torre origen
        for (int i = discos; i >= 1; i--)
            origen.Push(i);

        ResolverHanoi(discos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }

    /// <summary>
    /// Resuelve el problema de Torres de Hanoi usando pilas
    /// </summary>
    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                              string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino,
                       nombreOrigen, nombreAuxiliar, nombreDestino);

        ResolverHanoi(1, origen, destino, auxiliar,
                       nombreOrigen, nombreDestino, nombreAuxiliar);

        ResolverHanoi(n - 1, auxiliar, destino, origen,
                       nombreAuxiliar, nombreDestino, nombreOrigen);
    }
}

