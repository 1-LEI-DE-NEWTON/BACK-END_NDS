using System;

namespace Tabuleiro;

public class Tabuleiro
{
    static void Main(String[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Qual o número de linhas do tabuleiro?");
        int n_linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o número de colunas do tabuleiro?");
        int n_colunas = int.Parse(Console.ReadLine());
        
        while (n_linhas < 1 || n_colunas < 1)
        {
            Console.WriteLine("O número de linhas e colunas deve ser maior que 0.");
            Console.WriteLine("Qual o número de linhas do tabuleiro?");
            n_linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o número de colunas do tabuleiro?");
            n_colunas = int.Parse(Console.ReadLine());
        }

        Console.Write("#");
        for (int i = 0; i < n_colunas; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine("#");

        for (int i = 0; i < n_linhas; i++)
        {
            Console.Write("#");
            
            for (int j = 0; j < n_colunas; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        } 

        Console.Write("#");
        for (int i = 0; i < n_colunas; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine("#");
    }

}
