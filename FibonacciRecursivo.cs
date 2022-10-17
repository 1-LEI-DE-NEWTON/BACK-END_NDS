using System;

namespace FibonacciRecursivo;

public class Fibonacci
{
    public static void Main()
    {
        Console.WriteLine("Fibonacci Recursivo");
        Console.WriteLine("Digite um número: ");
        int quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine($"A sequência de Fibonacci até o número {quantidade} é: ");
        for (int i = 0; i <= quantidade; i++)
        {
            Console.Write($"{FibonacciRecursivo(i)}");
            if (i < quantidade)
            {
                Console.Write(", ");
            }
        }
    }

    public static int FibonacciRecursivo(int quantidade)
    {
        if (quantidade == 0 || quantidade == 1)
        {
            return quantidade;
        }
        else
        {
            return FibonacciRecursivo(quantidade - 1) + FibonacciRecursivo(quantidade - 2);
        }
    }
}
