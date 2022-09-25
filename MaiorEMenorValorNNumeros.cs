
using System;

namespace MaiorEMenorValor;

public class MaiorEMenorValor
{
    public static void Main(string[] args)
    {
       int contador = 0;
       int maior = 0;
       int menor = 0;
       int num = 0;
       int quantidade = 0;

       Console.WriteLine("Informe quantos numeros vamos analisar: ");
       quantidade = int.Parse(Console.ReadLine());

        while (contador < quantidade)
        {
            Console.WriteLine("Informe um numero inteiro: ");
            num = int.Parse(Console.ReadLine());
            if (contador == 0)
            {
            maior = num;
            menor = num;
            }
            else
            {
                if (num > maior)
                {
                    maior = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }
            contador++;
        }
        
        Console.WriteLine($"O maior numero recebido foi {maior} e o menor foi {menor}");
        
    }
}
