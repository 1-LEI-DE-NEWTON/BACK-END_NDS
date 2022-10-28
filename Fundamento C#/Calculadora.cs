
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        
        static void Menu()
        {
            Console.WriteLine("Bem vindo a calculadora");
            Console.WriteLine("Escolha uma opção: ");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma();break;
                case 2:
                    Subtracao();break;
                case 3:
                    Multiplicacao();break;
                case 4:
                    Divisao();break;
                case 5:
                    Console.WriteLine("Obrigado por usar nossa calculadora!");
                    Environment.Exit(0);break;
                default:
                    Console.WriteLine("Opção inválida!");break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Informe o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = num1 + num2;

            Console.WriteLine($"A soma dos numeros é: {resultado}");
            
            Denovo();
        }

        static void Subtracao()
        {
            Console.WriteLine("Informe o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = num1 - num2;

            Console.WriteLine($"A subtração dos numeros é: {resultado}");
            
            Denovo();            
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Informe o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = num1 * num2;

            Console.WriteLine($"A multiplicação dos numeros é: {resultado}");
            
            Denovo();
        }

        static void Divisao()
        {
            Console.WriteLine("Informe o primeiro numero: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = num1 / num2;

            Console.WriteLine($"A divisão dos numeros é: {resultado}");

            Denovo();
        }

        static void Denovo()
        {
            Console.WriteLine("Deseja fazer outra operação? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta == "S" || resposta == "s")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Obrigado por usar nossa calculadora!");
                Environment.Exit(0);
            }
        }

    }
}
