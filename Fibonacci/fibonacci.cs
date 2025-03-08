using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número mayor que 2: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 2)
        {
            List<int> fibonacciSequence = Fibonacci(n);
            Console.WriteLine("Secuencia de Fibonacci:");
            Console.WriteLine(string.Join(", ", fibonacciSequence));
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número mayor que 2.");
        }
    }

    static List<int> Fibonacci(int n)
    {
        if (n <= 2) return new List<int>();

        List<int> sequence = new List<int> { 1, 1 };
        for (int i = 2; i < n; i++)
        {
            sequence.Add(sequence[i - 1] + sequence[i - 2]);
        }
        return sequence;
    }
}
