
using System;

namespace MediaAritmetica;

public class MediaAritmetica
{
    public static void Main(string[] args)
    {
        
        float soma = 0, num = 0;
        int quantidade, contador = 0;

        Console.WriteLine("Há quantos valores para a média aritmética?");
        quantidade = int.Parse(Console.ReadLine());
        
        while (contador < quantidade)
        {
            Console.WriteLine("Digite um número:");
            num = float.Parse(Console.ReadLine());
            soma = soma + num;
            contador = contador + 1;
        }
        Console.WriteLine($"A média aritmética é: {soma/quantidade}");
        Denovo();
    }

    public static void Denovo()
        {
        Console.WriteLine("Deseja fazer outra média? (S/N)");
        string resposta = Console.ReadLine();

        if (resposta == "S" || resposta == "s")
            {
                Main(null);
            }
        else
            {
            Console.WriteLine("Obrigado por usar nossa aplicação!");
            Environment.Exit(0);
            }
        }
}
