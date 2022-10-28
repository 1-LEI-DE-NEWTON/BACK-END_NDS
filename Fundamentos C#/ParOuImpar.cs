
using System;

namespace ParOuImpar;

public class ParOuImpar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe um numero inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"O numero {num} é par");
        }
        else
        {
            Console.WriteLine($"O numero {num} é impar");
        }
    }
}
