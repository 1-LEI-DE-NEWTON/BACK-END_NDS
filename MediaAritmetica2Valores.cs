using System;

namespace MediaAritmetica;

public class MediaAritmetica
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float num2 = float.Parse(Console.ReadLine());
        float media = (num1 + num2) / 2;
        Console.WriteLine($"A média aritmética é {media}");
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
